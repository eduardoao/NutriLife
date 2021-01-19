using NutriLife.Core.Domain;
using System.Threading.Tasks;

namespace NutriLife.Services
{
    public interface IPersonService
    {
        Task<PersonResult> CreatePerson(Person person);
    }
}