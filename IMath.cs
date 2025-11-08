using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Homework3_1
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int value);
    }
}
