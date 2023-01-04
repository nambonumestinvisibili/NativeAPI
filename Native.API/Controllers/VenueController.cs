using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Native.Domain.Models;
using Native.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VenueController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public VenueController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Venue>> GetAll() =>
            await _repositoryManager.Venue.GetAll();
    }
}
