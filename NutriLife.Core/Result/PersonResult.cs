using NutriLife.Core.Domain;
using NutriLife.Result;

namespace NutriLife.Core.Result
{
    public class PersonResult: AResultBase
    {
        public PersonResult(Person person)
        {
            Person = person;
        }
        
        public Person Person { get; private set; }      
    }
}