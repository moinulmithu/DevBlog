using DevsCraft.Core;
using DevsCraft.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevsCraft.Web.Controllers
{
    public class BlogController : Controller
    {
        public IBlogRepository _iblogRepo;
        // GET: Blog
        public BlogController(IBlogRepository iblogRepo)
        {
            _iblogRepo = iblogRepo;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Posts(int p = 1)
        {
            var viewModel = new ListViewModel(_iblogRepo,p);
            ViewBag.Title = "Latest Posts";
            return View("List", viewModel);
            //var posts = _iblogRepo.Posts(p - 1, 10);
            //var totalPosts = _iblogRepo.TotalPosts();
            //var listViewModel = new ListViewModel
            //{
            //    Posts = posts,
            //    TotalPosts = totalPosts
            //};
            //ViewBag.Title = "Latest Posts";
            //return View("List", listViewModel);
        }
        
    }
}