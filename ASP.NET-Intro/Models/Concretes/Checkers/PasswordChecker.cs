using ASP.NET_Intro.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Intro.Models.Concretes.Checkers
{
    public class PasswordChecker : BaseChecker
    {
        public override void Check(object? request)
        {
            if (request is Person person)
            {
                if (!string.IsNullOrEmpty(person.Password) && person.Password.Length>6)
                {
                    Console.WriteLine("Password is Correct...");
                    Next?.Check(request);
                }
                else
                {
                    Console.WriteLine("Wrong Password!");
                }
            }
        }
    }
}
