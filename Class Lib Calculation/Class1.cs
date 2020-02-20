using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Lib_Calculation
{
    public class Calculation
    {
        public int No1 { get; set; }
        public int No2 { get; set; }

        public string Add()
        {
            return string.Format("Sum = {0}",No1+No2);
        }

        public string Sub()
        {
            return string.Format("Difference = {0}", No1 - No2);
        }

        public string Mul()
        {
            return string.Format("Product = {0}", No1 * No2);
        }

        public string Div()
        {
            return string.Format("Division = {0}", No1 / No2);
        }

    }
}
