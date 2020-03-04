namespace service_lib
{
    public class ServiceA : IServiceA
    {
        public string HitItChewie()
        {
            return "Wooooooooooo hoooooooooooooooo!!!!";
        }
    }

    public interface IServiceA
    {
        string HitItChewie();
    }

}
