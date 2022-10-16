﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_PROJECT.Controllers
{
  public class BlogController : Controller
  {
    BlogManager bm = new BlogManager(new EfBlogRepository());
    public IActionResult Index()
    {
      var values = bm.GetBlogListWithCategory(); // Burada iki table include edip view e gönderdik :)
      return View(values);
    }
    public IActionResult BlogReadAll(int id)
    {
      var values = bm.GetBlogById(id);
      return View(values);
    }
  }
}