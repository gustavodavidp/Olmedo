using LetrasBlog.Client.Repositories;
using LetrasBlog.Infraestructure.Entities;
using LetrasBlog.Infraestructure;
using LetrasBlog.Infraestructure.Interfaces;
using LetrasBlog.Server.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LetrasBlog.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatsController : Controller
    {
        private readonly IRepository _RepositoryValidation;
        private readonly SqlConfigurationContext _dbContext;
        protected readonly ILogger<CatsController> _logger;

        public CatsController(IRepository Repository, [NotNull] ILogger<CatsController> logger)
        {
            _RepositoryValidation = Repository;
            _logger=logger;
            
        }

        [Route("GetCatsFacts")]
        [HttpGet]
        public async Task<IActionResult> GetCatsFacts()
        {
            var post = await _RepositoryValidation.GetCatsFacts();

            if (post == null)
            {
                throw new BusinessExceptions("Error en obtención");
            }
            return Ok(post);
        }
    }
}
