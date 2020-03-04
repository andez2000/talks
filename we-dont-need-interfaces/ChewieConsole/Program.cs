using Ninject;
using ServicesLib.WithInterfaces;
using System;

namespace ChewieConsole
{
    class Program
    {
        public static IKernel Kernel { get; private set; }

        static void Main(string[] args)
        {
            Kernel = new StandardKernel();

            Kernel.Bind<IServiceA>().To<ServiceA>();
            Kernel.Bind<IServiceB>().To<ServiceB>();

            Kernel.Bind<ServiceNoInterfaceA>().To<ServiceNoInterfaceA>();
            Kernel.Bind<ServiceNoInterfaceB>().To<ServiceNoInterfaceB>();

            var serviceA = Kernel.Get<ServiceB>();
            var noInterfaceB = Kernel.Get<ServiceNoInterfaceB>();

            Console.WriteLine(serviceA.HitItChewie());
            Console.WriteLine(noInterfaceB.HelpMeObiWanKenobi());

            Console.WriteLine("Press enter to exit");

            Console.ReadLine();
        }
    }
}
