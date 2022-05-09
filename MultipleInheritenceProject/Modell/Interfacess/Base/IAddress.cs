using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces.Base
{
    interface IAddress
    {
        public string City { get; set; }
        public string StreetAndNumber { get; set; }

        public int PostCode { get; set; }

        public string WritingAddresses
        {
            get
            {
                return City + "\n" + StreetAndNumber + "\n" + PostCode;
            }
        }
    }
}
