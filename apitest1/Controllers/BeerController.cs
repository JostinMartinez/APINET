using apitest1.DTO;
using apitest1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apitest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private StoreContext _Context;

        public BeerController(StoreContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BeerDTO>> Get() =>
         await _Context.Beers.Select(b => new BeerDTO
            {
                Id = b.BeerID,
                Name = b.Name,
                Alcohol = b.Alchohol,
                BrandID = b.BrandID,
            }).ToListAsync();

        [HttpGet("{id}")]

        public async Task<ActionResult<BeerDTO>> GetById(int id )

        {
            var beer = await _Context.Beers.FindAsync(id);
            if (beer == null) 
            {
                return NotFound();
                    
            }

            var beerDto = new BeerDTO
            {
                Id = beer.BeerID,
                Name = beer.Name,
                Alcohol = beer.Alchohol,
                BrandID = beer.BrandID,


            };

            return Ok(beerDto);
        }



    }
}
