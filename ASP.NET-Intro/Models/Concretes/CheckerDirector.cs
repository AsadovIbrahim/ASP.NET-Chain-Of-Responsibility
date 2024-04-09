using ASP.NET_Intro.Models.Abstracts;
using ASP.NET_Intro.Models.Concretes.Checkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Intro.Models
{
    public class CheckerDirector
    {
        public ICheckerBuilder? CheckerBuilder { get; set; }
        public void MakePerson(Person person)
        {
            UsernameChecker usernameChecker = new();
            EmailChecker emailChecker = new();
            PasswordChecker passwordChecker = new();

            usernameChecker.Next = emailChecker;
            emailChecker.Next = passwordChecker;

            usernameChecker.Check(person);

        }
    }
}
