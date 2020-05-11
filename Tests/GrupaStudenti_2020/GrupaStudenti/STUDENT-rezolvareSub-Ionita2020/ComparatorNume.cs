using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_rezolvareSub_Ionita2020
{
    class ComparatorNume : IComparer
    {
       
        public int Compare(object x, object y)
        {
            Student s1 = (Student)x;
            Student s2 = (Student)y;

            if(s1 !=null && s2 != null)
            {
                return String.Compare(s1.Nume, s2.Nume);
            }
            else
            {
                throw new NotImplementedException();
            }

        }

    }
}
