﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccess.Abstract;
using Villa.DataAccess.Context;
using Villa.DataAccess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccess.EntityFramework
{
    public class EfFeautreDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeautreDal(VillaContext context) : base(context)
        {
        }
    }
}
