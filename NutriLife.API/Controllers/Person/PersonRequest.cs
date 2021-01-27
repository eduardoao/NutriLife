using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriLife.API.Controllers.Person
{
    public class PersonRequest
    {
        public string FirtName { get;  set; }
        public string LastName { get;  set; }
        public int Age { get;  set; }
        public double Weight { get;  set; }  
    }
}
