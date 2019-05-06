using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.类型转换
{
    public class DecimalChange
    {
        public void DecimalToString()
        {
            decimal value = 16325.62m;
            string specifier;
            CultureInfo culture;

            // Use standard numeric format specifiers. specifier = "G";
            specifier = "G";
            culture = CultureInfo.CreateSpecificCulture("eu-ES");

            Console.WriteLine(value.ToString(specifier, culture));

            decimal? aa = 12312312312312.0000000000m;
            decimal bb = Convert.ToDecimal(aa);
            Console.WriteLine(bb.ToString("N5"));

        }
    }
}
