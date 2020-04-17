using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    internal class Student
    {
        public event EventHandler StudentGraduated;

        public string Name { get; set; }
        public bool Isgraduated { get; set; }

        private bool isGraduated;

        public bool IsGraduated
        {
            get { return isGraduated; }
            set
            {
                if (value)
                {
                    OnStudentGraduated(EventArgs.Empty);
                }
                isGraduated = value;
            }
        }

        protected virtual void OnStudentGraduated(EventArgs e)
        {
            EventHandler handler = StudentGraduated;
            handler?.Invoke(this, e);
        }
    }
}