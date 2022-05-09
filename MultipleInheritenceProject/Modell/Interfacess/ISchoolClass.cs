using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces
{
    interface ISchoolClass
    {
        public int Id { get ; set ; }
        public int Grade { get; set; }
        public char GradeType { get ; set ; }
        public int TeacherId { get; set ; }

        public string GradeGradeType
        {
            get
            {
                string result = Grade + ". " + GradeType;
                return result;
            }
        }

        public bool SchoolLeaver
        {
            get
            {
                if (Grade == 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
