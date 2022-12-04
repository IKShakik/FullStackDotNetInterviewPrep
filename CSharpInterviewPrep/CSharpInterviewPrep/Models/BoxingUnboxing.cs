using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrep.Models
{
    internal class BoxingUnboxing
    {
        private static int i = 10;
        private static object obj = i; // boxing
        private int j = (int)obj; // unboxing
    }
}
