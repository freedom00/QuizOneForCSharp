﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    internal class RegisterStudentOperation
    {
        public static void Graduated(object sender, EventArgs e) => Console.WriteLine($"Student {((Student)sender).Name} Graduated");
    }
}