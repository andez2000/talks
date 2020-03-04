namespace service_lib
{
    public class ServiceB : IServiceB
    {
        private readonly IServiceA serviceA;

        public ServiceB(IServiceA serviceA)
        {
            this.serviceA = serviceA;
        }

        public string HitItChewie()
        {
            return serviceA.HitItChewie();
        }
    }

    public interface IServiceB
    {
        string HitItChewie();
    }

}
