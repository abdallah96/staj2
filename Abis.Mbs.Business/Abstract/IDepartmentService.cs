﻿using Abis.Mbs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abis.Mbs.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();

        void Add(Department department);
        void Update(Department department);
        void Delete(int depId);
        Department GetById(int depId);




    }
}
