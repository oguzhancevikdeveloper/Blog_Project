﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_PROJECT.Controllers
{
  [AllowAnonymous]
  public class NotificationController : Controller
  {
    NotificationManager nm = new NotificationManager(new EfNotificationRepository());
    public IActionResult Index()
    {
      return View();
    }
    
    public IActionResult AllNotification()
    {
      var values = nm.GetList();
      return View(values);
    }
  }
}
