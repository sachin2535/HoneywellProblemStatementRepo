using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace FindTempConsoleApp
{
    class Program
    {
        //variable to hold constructor instances
        private static ITemperature _temperatureRepository;
        public static void Main(String[] args)
        {
            GetDependentInstances();
            // Given temperatures 
            int[] arr = { 73, 74, 75, 71, 69, 72, 76, 73 };
            var output = _temperatureRepository.CalculateDaysForNextTemperatureRise(arr);
        }

        /// <summary>
        /// Resolved unity dependencies
        /// </summary>
        static void GetDependentInstances()
        {
            var container = UnityConfig.Register();
            _temperatureRepository = container.Resolve<ITemperature>();
        }
    }
}

