using API_Labb4.Data;
using API_Labb4.Dto;
using API_Labb4_ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace API_Labb4.Repositories
{
    public class Repository : IRepository
    {
        private Context _context;
        public Repository(Context context)
        {
            _context = context;
        }
        // Retrieve a list of all persons
        public async Task<List<Person>> ListAllPersons()
        {
            var persons = await _context.Person.ToListAsync();
            return persons;
        }
        // Retrieve a list of interests for a specific person
        public async Task<List<Interest>> ListInterestsByPerson(int personId)
        {
            var interests = await _context.PersonInterest
            .Where(pi => pi.PersonID == personId)
            .Select(pi => pi.Interest)
           .ToListAsync();

            return interests;
           
        }
        // Retrieve a list of links for a specific person

        public async Task<List<Link>> ListLinksByPerson(int personId)
        {
            var links = await _context.PersonInterest
            .Where(pi => pi.PersonID == personId)
            .Select(pi => pi.Link)
            .ToListAsync();

            return links;
        }
        // Add a new link for a specific person and interest
        public async Task<Link> AddNewLink(string url, int personId, string interestName)
        {
            var result = await _context.PersonInterest.FirstOrDefaultAsync(p =>
            p.Person.PersonID == personId &&
            p.Interest.Title.ToLower() == interestName.ToLower());
            if (result == null)
            {
                return null;
            }
            var link = new Link()
            {
                LinkURL = url,
                PersonInterest = result
            };
            await _context.Link.AddAsync(link);
            await _context.SaveChangesAsync();
            return link;

        }
        // Add a new interest for a specific person with a link
        public async Task<PersonInterest> AddNewInterestPerson(int interestId, int personId, int linkId)
        {
            var person = await _context.Person.FindAsync(personId);
            var interest = await _context.Interest.FindAsync(interestId);
            var link = await _context.Link.FindAsync(linkId);
            if (person == null || interest == null || link == null)
            {
                return null;
            }
            var toAdd = new PersonInterest()
            {
                InterestID = interestId,
                PersonID = personId,
                LinkID = linkId
            };
            await _context.PersonInterest.AddAsync(toAdd);
            await _context.SaveChangesAsync();
            return toAdd;

        }

        
    }
}
