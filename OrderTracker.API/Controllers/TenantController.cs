using Microsoft.AspNetCore.Mvc;
using OrderTracker.API.Data;
using System.Linq;
using System.Threading.Tasks;
using OrderTracker.API.Models;

namespace OrderTracker.API.Controllers
{
    public class TenantController : ControllerBase
    {
        private readonly DataContext _context;

        public TenantController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetTenant")]
        public ActionResult GetTenant(string token, int id){
            var tenants = _context.Tenants.Where(x=>x.Id==id && x.Token == token);
            if(tenants.Any()){
                return Ok(tenants);
            }else{
                return Ok("pipa");
            }
        }

        public async Task<ActionResult> CreateTentant(OT_Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            await _context.SaveChangesAsync();
            return Ok(tenant);
        }
    }
}