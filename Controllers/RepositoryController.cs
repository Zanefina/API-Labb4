using API_Labb4.Repositories;
using API_Labb4_ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_Labb4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : ControllerBase
    {
        private readonly IRepository _Repository;

        public RepositoryController(IRepository Repository)
        {
            _Repository = Repository;
        }

        [HttpGet("ListAllPersons")]
        public async Task<IActionResult> ListAllPersons()
        {

            try
            {
                var persons = await _Repository.ListAllPersons();
                return Ok(persons);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        [HttpGet("ListInterestsByPerson")]
        public async Task<IActionResult> ListInterestsByPerson(int personId)
        {
            try
            {
                var interests = await _Repository.ListInterestsByPerson(personId);
                return Ok(interests);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        [HttpGet("ListLinksByPerson")]
        public async Task<IActionResult> ListLinksByPerson(int personId)
        {
            try
            {
                var links = await _Repository.ListLinksByPerson(personId);
                return Ok(links);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        [HttpPost("AddNewInterestPerson")]
        public async Task<IActionResult> AddNewInterestPerson(int interestId, int personId, int linkId)
        {
            try
            {
                var toAdd = await _Repository.AddNewInterestPerson(interestId, personId, linkId);
                return Ok("The new interest has been added to a person!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest();
            }
        }

        [HttpPost("AddNewLink")]
        public async Task<IActionResult> AddNewLink(string url, int personId, string interestName)
        {
            try
            {
                var result = await _Repository.AddNewLink(url, personId,interestName);
                return Ok("New link has been added!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }
    }
}

