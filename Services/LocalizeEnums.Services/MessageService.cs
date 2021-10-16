using LocalizeEnums.Services.Interfaces;

namespace LocalizeEnums.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
