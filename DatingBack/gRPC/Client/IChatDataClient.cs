namespace DatingBack.gRPC.Client
{
    public interface IChatDataClient
    {
        Task<bool> CreateChat(Guid user1, Guid user2);
    }
}
