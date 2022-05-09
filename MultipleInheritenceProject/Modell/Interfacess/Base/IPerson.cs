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

        }

        public string FullName
        {

        }

        public bool IsWooman
        {

        }

        public bool IsMan
        {
 
        }
        public int Age
        {
        }
    }
}
