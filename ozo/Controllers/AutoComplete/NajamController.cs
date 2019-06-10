using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ozo.Models;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace ozo.Controllers.AutoComplete
{
    [Route("autocomplete/[controller]")]
    public class NajamController : Controller
    {
        private readonly PI01Context ctx;
        private readonly AppSettings appData;

        public NajamController(PI01Context ctx, IOptions<AppSettings> options)
        {
            this.ctx = ctx;
            appData = options.Value;
        }

        [HttpGet]
        public IEnumerable<IdLabel> Get(string term)
        {
            var query = ctx.Registar
                .FromSql("Select * From dbo.Registar where TipRegistraId=2")
                            .Select(v => new IdLabel
                            {
                                Id = v.RegistarId,
                                Label = v.Naziv
                            })
                            .Where(l => l.Label.Contains(term));

            var list = query.OrderBy(l => l.Label)
                            .ThenBy(l => l.Id)
                            .ToList();
            return list;
        }
    }
}
