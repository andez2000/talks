namespace ServicesLib.WithInterfaces
{
    public class ServiceNoInterfaceB
    {
        private readonly ServiceNoInterfaceA serviceA;

        public ServiceNoInterfaceB(ServiceNoInterfaceA serviceA)
        {
            this.serviceA = serviceA;
        }

        public string HelpMeObiWanKenobi()
        {
            return serviceA.HelpMeObiWanKenobi();
        }
    }
}
