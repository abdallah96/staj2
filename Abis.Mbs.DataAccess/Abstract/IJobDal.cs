﻿using Abis.Core.DataAccess;
using Abis.Mbs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abis.Mbs.DataAccess.Abstract
{
    public interface IJobDal : IEntityRepository<Job>
    {
        //List<Job> GetMany(Expression<Func<Job, bool>> where, string[] include);
    }
}
