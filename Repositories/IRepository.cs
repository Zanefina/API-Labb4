using API_Labb4_ClassLibrary.Models;

namespace API_Labb4.Repositories
{
    public interface IRepository
    {
        Task<List<Person>> ListAllPersons();
        Task<List<Interest>> ListInterestsByPerson(int personId);
        Task<List<Link>> ListLinksByPerson(int personId);
        Task<PersonInterest> AddNewInterestPerson(int interestId, int personId, int linkId);
        Task<Link> AddNewLink(string url, int personId, string interestName);


    }
}
