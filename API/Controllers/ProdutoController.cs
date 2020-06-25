using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var ctx = new Context();
            var teste = ctx.Set<Produto>().ToList();
            return null;
        }
    }
}
