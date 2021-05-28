using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ParentObjectsController : Controller
  {
    private readonly ProjectNameContext _db;

    public ParentObjectsController(ProjectNameContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<ParentObject> model = _db.ParentObjects.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(ParentObject parentObject)
    {
      _db.ParentObjects.Add(parentObject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      ParentObject thisParentObject = _db.ParentObjects.FirstOrDefault(parentObject => parentObject.ParentObjectId == id);
      ViewBag.ChildObjects = thisParentObject.ChildObjects;
      return View(thisParentObject);
    }
    public ActionResult Edit(int id)
    {
      var thisParentObject = _db.ParentObjects.FirstOrDefault(parentObject => parentObject.ParentObjectId == id);
      return View(thisParentObject);
    }
    [HttpPost]
    public ActionResult Edit(ParentObject parentObject)
    {
      _db.Entry(parentObject).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisParentObject = _db.ParentObjects.FirstOrDefault(parentObject => parentObject.ParentObjectId == id);
      return View(thisParentObject);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisParentObject = _db.ParentObjects.FirstOrDefault(parentObject => parentObject.ParentObjectId == id);
      _db.ParentObjects.Remove(thisParentObject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}