using DapperDemoData.Data;
using DapperDemoData.Models;

namespace DapperDemoData.Repository;

public class PersonRepository:IPersonRepository
{
    private readonly IDataAccess _db;

    public PersonRepository(IDataAccess db)
    {
        _db = db;
    }
    public async Task<bool> AddPerson(Person person)
    {
        try
        {
            string query = "INSERT INTO dbo.Person(Name,Email) VALUES (@Name,@Email)";

            await _db.SaveData(query, new { Name = person.Name, Email = person.Email });
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public Task<bool> UpdatePerson(Person person)
    {
        throw new NotImplementedException();
    }

    public Task<Person> GetPersonById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletePerson(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Person>> GetPeople()
    {
        throw new NotImplementedException();
    }
}