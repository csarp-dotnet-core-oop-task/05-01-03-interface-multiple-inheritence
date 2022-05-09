using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces.Base
{
    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Wooman { get; set; }

        public DateTime DataOfBirth { get; set; }

        public string HungarianFullName { 
            get
            {
                return LastName + " " + FirstName;
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public bool IsWooman
        {
            get
            {
                return Wooman;
            }
        }

        public bool IsMan
        {
            get
            {
                return !Wooman;
            }
        }
        public int Age
        {
            get
            {
                int age = 0;
                age = DateTime.Now.Year - DataOfBirth.Year;
                if (DateTime.Now.DayOfYear < DataOfBirth.DayOfYear)
                    age = age - 1;
                return age;
            }
        }
    }
}
