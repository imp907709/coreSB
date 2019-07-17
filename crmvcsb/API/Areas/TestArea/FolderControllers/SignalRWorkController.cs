﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using crmvcsb.Domain.Interfaces;

using crmvcsb.Domain.TestModels;

using Newtonsoft.Json;


namespace mvccoresb.TestArea.Controllers
{
    /** while mapping in startup.completionlist exists no custom attribute needed */
    [Area("TestArea")]
    public class SignalRWorkcontroller : Controller
    {
        public IActionResult Work()
        {
            return View("../SignalRWork/work");
        }

    }
}