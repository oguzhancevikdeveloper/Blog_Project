﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_PROJECT.Controllers
{
  public class ErrorPageController : Controller
  {
    public IActionResult Error1(int code)
    {
      return View();
    }
  }
}