using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT_rezolvareSub_Ionita2020
{
    class ComparatorMedie : IComparer
    {
        public int Compare(object x, object y)
        {
            Student sx = (Student)x;
            Student sy = (Student)y;
            if (sx.Medie < sy.Medie)
            {
                return -1;
            }
            else if (sx.Medie > sy.Medie)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
