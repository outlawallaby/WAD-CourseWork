﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace USMALL.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        public string Invoke() {
            return "Hello from the Nav view Component"
        }
    }
}
