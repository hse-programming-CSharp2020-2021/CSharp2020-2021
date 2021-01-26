using System;

namespace Lib01
{
    public delegate string ConvertRule(string parametr);
    public class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr?.Invoke(str);
        }
    }
}
