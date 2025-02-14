﻿using ABC.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.DataAccess
{
    public class AbcDB : DbContext
    {
        public AbcDB(DbContextOptions<AbcDB> option) : base(option)
        {

        }

        #region DatabaseTables
        public DbSet<CashCenter> CashCenters { get; set; }
        public DbSet<CashCenterGroup> CashCenterGroups { get; set; }

        #endregion
    }
}
