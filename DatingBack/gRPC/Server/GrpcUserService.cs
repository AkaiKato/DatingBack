using Domain;
using Domain.DTO;
using Domain.Interfaces.UoW;
using Domain.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static Domain.Enums.DomainEnums;

namespace DatingBack.gRPC.Server
{
    public class GrpcUserService : GrpcUser.GrpcUserBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GrpcUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override async Task<UserInfoForAuth> GetUserWithIdRequest(GetUserWithId request, ServerCallContext context)
        {
            var responce = new UserInfoForAuth();
            var user = await _unitOfWork.UserRepository.GetAsync(Guid.Parse(request.Id), new CancellationToken());

            if (user == null)
            {
                responce.Id = Guid.Empty.ToString();
                responce.TelephoneNumber = "";
                responce.Role = "";
                responce.RefreshToken = "";
                responce.TokenCreated = DateTime.UtcNow.ToTimestamp();
                responce.TokenExpires = DateTime.UtcNow.ToTimestamp();
                return responce;
            }

            responce.Id = user.Id.ToString();
            responce.TelephoneNumber = user.TelephoneNumber;
            responce.Role = user.Role.ToString();
            responce.RefreshToken = user.RefreshToken;
            responce.TokenCreated = user.TokenCreated.ToUniversalTime().ToTimestamp();
            responce.TokenExpires = user.TokenExpires.ToUniversalTime().ToTimestamp();

            return responce;
        }

        public override async Task<UserInfoForAuth> GetUserWithPhoneNumberRequest(GetUserWithPhoneNumber request, ServerCallContext context)
        {
            var responce = new UserInfoForAuth();
            var user = await _unitOfWork.UserRepository.GetAsync(x => x.TelephoneNumber == request.TelephoneNumber, new CancellationToken());

            if (user == null)
            {
                responce.Id = Guid.Empty.ToString();
                responce.TelephoneNumber = "";
                responce.Role = "";
                responce.RefreshToken = "";
                responce.TokenCreated = DateTime.UtcNow.ToTimestamp();
                responce.TokenExpires = DateTime.UtcNow.ToTimestamp();
                return responce;
            }

            responce.Id = user.Id.ToString();
            responce.TelephoneNumber = user.TelephoneNumber;
            responce.Role = user.Role.ToString();
            responce.RefreshToken = user.RefreshToken;
            responce.TokenCreated = user.TokenCreated.ToUniversalTime().ToTimestamp();
            responce.TokenExpires = user.TokenExpires.ToUniversalTime().ToTimestamp();
          
            return responce;
        }

        public override async Task<VoidMessage> SaveUserLoginRequest(UserInfoForAuth request, ServerCallContext context)
        {
            var responce = new VoidMessage();
            var updatedUser = await _unitOfWork.UserRepository.GetAsync(Guid.Parse(request.Id), new CancellationToken());

            if (updatedUser == null)
            {
                return responce;
            }

            updatedUser.RefreshToken = request.RefreshToken;
            updatedUser.TokenCreated = request.TokenCreated.ToDateTime();
            updatedUser.TokenExpires = request.TokenExpires.ToDateTime();

            _unitOfWork.UserRepository.Update(updatedUser);
            await _unitOfWork.SaveAsync(new CancellationToken());

            return responce;
        }

        public override async Task<GrpcBoolAnswer> HaveThisPhoneNumberRequest(HaveThisPhoneNumber request, ServerCallContext context)
        {
            var responce = new GrpcBoolAnswer();
            var answer = await _unitOfWork.UserRepository.HaveThisPhoneNumberAsync(request.TelephoneNumber);
            responce.Answer = answer;
            return responce;
        }

        public override async Task<GrpcGuidAnswer> CreateUserRequest(CreateUser request, ServerCallContext context)
        {
            var responce = new GrpcGuidAnswer();

            var newId = Guid.NewGuid();

            var newUser = new User()
            {
                Id = newId,
                Name = request.Name,
                Surname = request.Surname,
                TelephoneNumber = request.TelephoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Sex = (Sex)request.Sex,
                Role = Roles.User,
                RegisterDate = DateOnly.FromDateTime(DateTime.UtcNow),
            };

            _unitOfWork.UserRepository.Add(newUser);
            await _unitOfWork.SaveAsync(CancellationToken.None);

            responce.Answer = newId.ToString();
            return responce;
        }

        public override async Task<GrpcBoolAnswer> VerifyPassRequest(VerifyPass request, ServerCallContext context)
        {
            var responce = new GrpcBoolAnswer();
            var user = await _unitOfWork.UserRepository.GetAsync(Guid.Parse(request.Id), new CancellationToken());
            if (user == null)
            {
                responce.Answer = false;
                return responce;
            }
            var answer = ValidatePassword(request.LoginPass, user.Password);
            responce.Answer = answer;
            return responce;
        }

        private bool ValidatePassword(string loginPassword, string userPassword)
        {
            return BCrypt.Net.BCrypt.Verify(loginPassword, userPassword);
        }
    }
}
