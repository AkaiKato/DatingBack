using Domain;
using Domain.Interfaces.UoW;
using Grpc.Core;

namespace DatingBack.gRPC.Server
{
    public class GrpcUserService : GrpcUser.GrpcUserBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public GrpcUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override async Task<GrpcBoolAnswer> HaveThisPhoneNumberRequest(HaveThisPhoneNumber request, ServerCallContext context)
        {
            var responce = new GrpcBoolAnswer();
            var answer = await _unitOfWork.UserRepository.HaveThisPhoneNumberAsync(request.TelephoneNumber);
            responce.Answer = answer;
            return responce;
        }

    }
}
