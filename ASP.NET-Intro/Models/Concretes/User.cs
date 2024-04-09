using ASP.NET_Intro.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_Intro.Models
{
    public class User:Person
    {
        public User(string username,string email,string password):base(username,email,password){ }
    }
}
