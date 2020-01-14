using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using B2B.Repository.Repositories;
using B2B.Repository.ViewModels;

namespace B2B.WebMVC.Controllers
{

    //public class VmTestPerson2
    //{
    //    public int Id { get; set; }
    //    public string Description { get; set; }
    
    //    public int DescriptionMLId { get; set; }
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int TestSexId { get; set; }
    //}

    public class MultiLangTestController : Controller
    {
        private RepoTestPerson _repo;

        public MultiLangTestController()
        {
            _repo = new RepoTestPerson();
        }

        // GET: MultiLangTest
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewTestPartial()
        {
            return PartialView("_GridViewTestPartial", _repo.List());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewTestPartialAddNew(VmTestPerson item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Add(item);
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewTestPartial", _repo.List());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewTestPartialUpdate(VmTestPerson item)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Update(item);
                }
                catch (Exception e)
                {



                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewTestPartial", _repo.List());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewTestPartialDelete(System.Int32 Id)
        {
            if (Id >= 0)
            {
                try
                {
                    _repo.Delete(Id);
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewTestPartial", _repo.List());
        }
    }
}