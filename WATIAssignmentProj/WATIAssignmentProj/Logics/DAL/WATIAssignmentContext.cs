using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WATIAssignmentProj.Models;

namespace WATIAssignmentProj.Logics.DAL
{
    public class WATIAssignmentContext : DbContext
    {
        public DbSet<CalculationHistory> CalculationHistories { get; set; }
    }
}