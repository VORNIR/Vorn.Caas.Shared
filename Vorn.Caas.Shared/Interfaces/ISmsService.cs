namespace Vorn.Caas;
public interface ISmsService
{
    Task SendSms(string phoneNumber, string message);
    Task SendCode(string phoneNumber, string code);
    Task<List<Sms>> Load(int? skips = null, int? takes = null);
    Task<Sms> Reload(int id);
    Task<Sms> Load(int id);
    Task<int> Count();
}
