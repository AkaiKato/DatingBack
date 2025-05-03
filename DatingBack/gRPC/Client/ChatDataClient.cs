using Domain.Chat;
using Grpc.Net.Client;

namespace DatingBack.gRPC.Client
{
    public class ChatDataClient : IChatDataClient
    {
        private readonly IConfiguration _configuration;

        public ChatDataClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> CreateChat(Guid user1, Guid user2)
        {
            var channel = GrpcChannel.ForAddress(_configuration["GrpcChat"]!);
            var client = new GrpcChat.GrpcChatClient(channel);
            var request = new CreateChatForThisUsers()
            {
                User1 = user1.ToString(),
                User2 = user2.ToString()
            };

            try
            {
                var reply = await client.CreateChatAsync(request);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Couldn't call gRPC Server {ex.Message}");
                return false;
            }
        }
    }
}
