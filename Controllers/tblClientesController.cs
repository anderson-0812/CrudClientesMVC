using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CrudClientesMVC;

namespace CrudClientesMVC.Controllers
{
    public class tblClientesController : Controller
    {
        private CRUDEntities1 db = new CRUDEntities1();

        // GET: tblClientes
        public async Task<ActionResult> Index()
        {
            return View(await db.tblClientes.ToListAsync());
        }

        // GET: tblClientes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClientes tblClientes = await db.tblClientes.FindAsync(id);
            if (tblClientes == null)
            {
                return HttpNotFound();
            }
            return View(tblClientes);
        }

        // GET: tblClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblClientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Nombres,Apellidos,Correo,Ci,ID")] tblClientes tblClientes)
        {
            if (ModelState.IsValid)
            {
                db.tblClientes.Add(tblClientes);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblClientes);
        }

        // GET: tblClientes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClientes tblClientes = await db.tblClientes.FindAsync(id);
            if (tblClientes == null)
            {
                return HttpNotFound();
            }
            return View(tblClientes);
        }

        // POST: tblClientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Nombres,Apellidos,Correo,Ci,ID")] tblClientes tblClientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblClientes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblClientes);
        }

        // GET: tblClientes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblClientes tblClientes = await db.tblClientes.FindAsync(id);
            if (tblClientes == null)
            {
                return HttpNotFound();
            }
            return View(tblClientes);
        }

        // POST: tblClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblClientes tblClientes = await db.tblClientes.FindAsync(id);
            db.tblClientes.Remove(tblClientes);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
