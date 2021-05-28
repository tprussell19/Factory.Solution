using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ChildObjectsController : Controller
  {
    private readonly ProjectNameContext _db;
    public ChildObjectsController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ChildObject> model = _db.ChildObjects.Include(childObject => childObject.ParentObject).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.ParentObjectId = new SelectList(_db.ParentObjects, "ParentObjectId", "Name", new { @class = "custom-select" });
      return View();
    }

    [HttpPost]
    public ActionResult Create(ChildObject childObject)
    {
      _db.ChildObjects.Add(childObject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ChildObject thisChildObject = _db.ChildObjects.FirstOrDefault(childObject => childObject.ChildObjectId == id);
      return View(thisChildObject);
    }

    public ActionResult Edit(int id)
    {
      var thisChildObject = _db.ChildObjects.FirstOrDefault(childObject => childObject.ChildObjectId == id);
      ViewBag.ParentObjectId = new SelectList(_db.ParentObjects, "ParentObjectId", "Name");
      return View(thisChildObject);
    }

    [HttpPost]
    public ActionResult Edit(ChildObject childObject)
    {
      _db.Entry(childObject).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisChildObject = _db.ChildObjects.FirstOrDefault(childObject => childObject.ChildObjectId == id);
      return View(thisChildObject);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisChildObject = _db.ChildObjects.FirstOrDefault(childObject => childObject.ChildObjectId == id);
      _db.ChildObjects.Remove(thisChildObject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}