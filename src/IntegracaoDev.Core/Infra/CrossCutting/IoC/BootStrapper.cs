using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoDev.Core.Infra.CrossCutting.IoC
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
