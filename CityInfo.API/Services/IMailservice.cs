namespace CityInfo.API.Services
{
    public interface IMailservice
    {
        void Send(string subject, string message);
    }
}