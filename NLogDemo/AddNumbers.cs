using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class AddNumbers
    {
        Nlog nlog = new Nlog();

        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogDebug("Debug Successfull : Sum()");
                nlog.LogError("Expecting null values");
                nlog.LogWarning("The value provided is Zero");

            }
            int c = a + b;
            nlog.LogDebug("Debug Successfull : Sum()");
            nlog.LogInformation("Sum Method passed, Results" + c);
            return c;
        }

    }
}
