using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WATIAssignmentProj.Logics.DAL;
using WATIAssignmentProj.Models;

namespace WATIAssignmentProj.Logics.BLL
{
    public class CalculationHistoryBLL
    {
        public int Add(CalculationHistory obj)
        {
            var _db = new WATIAssignmentContext();

            _db.CalculationHistories.Add(obj);
            return _db.SaveChanges();
        }

        public List<CalculationHistory> Histories()
        {
            var _db = new WATIAssignmentContext();
            return _db.CalculationHistories.ToList();
        }
    }
}