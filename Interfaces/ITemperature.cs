using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTempConsoleApp
{
    interface ITemperature
    {
        // Interface method to determine how many days 
        // required to wait for the next 
        // warmer temperature 
        int[] CalculateDaysForNextTemperatureRise(int[] tempArray);
    }
}
