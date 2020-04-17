using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    public static class MyExtensionMethods
    {
        public static bool IsDividableByThree(this int number) => 0 == number % 3;
    }
}