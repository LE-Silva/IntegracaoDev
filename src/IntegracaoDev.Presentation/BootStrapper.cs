using Dataplace.Core.win.Views.Extensions;
using Dataplace.Core.win.Views;
using dpLibrary05.Infrastructure.ServiceLocator;

namespace IntegracaoDev.Presentation
{
    public static class BootStrapper
    {
        public static Container Container;

        public static void Bootstrap(Container container)
        {
            BootStrapper.Container = container;
        }
    }
}
