using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace FindTempConsoleApp
{
    internal static class UnityConfig
    {
        public static UnityContainer Register()
        {
            var container = new UnityContainer();
            container.RegisterType<ITemperature, Temperature>();
            return container;
        }
    }
}
