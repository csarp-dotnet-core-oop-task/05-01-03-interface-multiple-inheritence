using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Interfaces.Base
{
    interface IAccount
    {
        public string LoginName { get; set; }

        public string Password { get; set; }

        public bool IsLoginNameCorrect(string givenLoginName);
        public bool IsPasswordCorrect(string givenPassword);

        public bool VerifyLoginName(string givenLoginName);
        public bool VerifyPassword(string givenPassword);

        public bool IsSuccessfulLogin(string givenLoginName,string givenPassword)
        {

        }

    }
}
