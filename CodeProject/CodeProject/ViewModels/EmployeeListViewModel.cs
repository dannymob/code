﻿using CodeProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeProject.ViewModel
{
    public class EmployeeListViewModel
    {
        public List <EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}