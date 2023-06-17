namespace Fiorello_backend.Services.Interfaces
{
    public interface IEmailService
    {
        public void Send(string to, string subject, string html,string from=null);
    }
}
