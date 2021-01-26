using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public delegate double delegateConvertTemperature
        (double sourceTemp);
    class TemperatureConverterImp
    {
        public double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }
        public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverterImp obj = new TemperatureConverterImp();
            delegateConvertTemperature delConvertToFahrenheit =
                              new delegateConvertTemperature
                              (obj.ConvertToFahrenheit);

            delegateConvertTemperature delConvertToCelsius =
                                 new delegateConvertTemperature
                                 (obj.ConvertToCelsius);
            
            double celsius = 0.0;
            double fahrenheit = delConvertToFahrenheit(celsius);
            string msg1 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                         celsius, fahrenheit);
            Console.WriteLine(msg1);

            fahrenheit = 212.0;
            celsius = delConvertToCelsius(fahrenheit);
            string msg2 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                         celsius, fahrenheit);
            Console.WriteLine(msg2);
            Console.WriteLine(delConvertToCelsius.Target);
            Console.ReadKey();
        }
    }
}
