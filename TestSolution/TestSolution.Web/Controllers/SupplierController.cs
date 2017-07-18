using System.Linq;
using System.Net;
using System.Web.Mvc;
using TestSolution.Model;
using TestSolution.Web.SupplierServiceReference;

namespace TestSolution.Web.Controllers
{
    //[Authorize]
    public class SupplierController : Controller
    {
        private readonly Service1Client _service1Client;

        public SupplierController()
        {
            _service1Client = new Service1Client();
        }

        public ActionResult Index()
        {
            return View(_service1Client.GetSuppliers().ToList());            
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Supplier sup = _service1Client.GetSupplier(id);
            if (sup == null)
            {
                return HttpNotFound();
            }
            return View(sup);
        }

        [HttpPost]
        public ActionResult Create(Supplier sObj)
        {
            _service1Client.InsertSupplier(sObj);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Supplier sup = _service1Client.GetSupplier(id);
            if (sup == null)
            {
                return HttpNotFound();
            }
            return View(sup);
        }

        [HttpPost]
        public ActionResult Edit(Supplier sObj)
        {
            if (sObj != null)
            {
                _service1Client.UpdateSupplier(sObj);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Supplier sup = _service1Client.GetSupplier(id);
            if (sup == null)
            {
                return HttpNotFound();
            }
            return View(sup);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _service1Client.DeleteSupplier(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {              
            }
            base.Dispose(disposing);
        }
    }
}