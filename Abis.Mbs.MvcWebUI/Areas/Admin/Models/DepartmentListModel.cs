﻿using Abis.Mbs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abis.Mbs.MvcWebUI.Areas.Admin.Models
{
    public class DepartmentListModel
    {
        public List<Department> Departments { get; internal set; }

    }
}
