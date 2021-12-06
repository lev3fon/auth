﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PhotosApp.Controllers
{
    public class DevController : Controller
    {
        [Authorize(Roles = "RoleName")]
        public IActionResult Decode()
        {
            return View();
        }
    }
}
