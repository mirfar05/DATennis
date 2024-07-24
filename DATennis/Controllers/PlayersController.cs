using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DATennis.Models;

namespace DATennis.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Players
        public async Task<ActionResult> Index()
        {
            return View(await db.Players.ToListAsync());
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = await db.Players.FindAsync(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }
    
        public async Task<ActionResult> Tournament()
        {
            var tournament = await db.Tournaments.FirstOrDefaultAsync();
            if (tournament == null)
            {
                return HttpNotFound();
            }

            return View(tournament);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
