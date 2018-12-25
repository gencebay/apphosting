using AppHosting;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using NetCoreStack.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppHosting.Controllers
{
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly LookupContext _lookupContext;

        public AlbumController(LookupContext lookupContext)
        {
            _lookupContext = lookupContext;
        }

        [HttpGet(nameof(GetArtistListAsync))]
        public async Task<List<IdTextPair>> GetArtistListAsync()
        {
            await Task.CompletedTask;

            var query = _lookupContext.ArtistCollection.AsQueryable()
                .Select(x => new IdTextPair
                {
                    Id = x.Id,
                    Text = x.Name
                });

            return query.ToList();
        }

        [HttpGet(nameof(GetAlbums))]
        public async Task<IActionResult> GetAlbums()
        {
            await Task.CompletedTask;

            var query = _lookupContext.AlbumCollection.AsQueryable().ToList();

            return new JsonResult(query.ToList());
        }
    }
}
