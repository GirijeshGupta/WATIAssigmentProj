using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WATIAssignmentProj.Logics.BLL;

namespace WATIAssignmentProj.Controllers
{
    public class CalculationController : Controller
    {

        [Route("Add")]
        public JsonResult Add(decimal num1, decimal num2)
        {

            var _objBLL = new CalculationHistoryBLL();

            decimal sum = num1 + num2;

            int res = _objBLL.Add(new Models.CalculationHistory() { Num1 = num1, Num2 = num2, Result = sum, Type = "Sum" });

            if (res > 0)
            {
                return Json(new { IsSuccess = true, Result = sum }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { IsSuccess = false, Result = sum }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}