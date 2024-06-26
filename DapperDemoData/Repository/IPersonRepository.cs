using DapperDemoData.Models;

namespace DapperDemoData.Repository;

public interface IPersonRepository
{
    Task<bool> AddPerson(Person person);

    Task<bool> UpdatePerson(Person person);
    Task<Person> GetPersonById(int id);
    Task<bool> DeletePerson(int id);
    Task<IEnumerable<Person>> GetPeople();

}