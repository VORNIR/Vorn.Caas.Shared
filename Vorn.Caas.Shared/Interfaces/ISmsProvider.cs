namespace Vorn.Caas.Shared;
public interface ISmsProvider
{
    Task<Sms> SendSms(string phoneNumber, string message);
    Task<Sms> SendCode(string phoneNumber, string code);
    Task<Sms> GetSms(long messageId);
    Task<List<Sms>> ReceiveLatestSms();
}