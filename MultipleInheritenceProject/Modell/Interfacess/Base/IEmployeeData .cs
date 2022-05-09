using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces.Base
{
    interface IEmployeeData
    {
        public int GrossSalary { get; set; }

        public int NumberOfChildren { get; set; }

        public bool HasChild
        {
            get
            {
                if (NumberOfChildren > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
