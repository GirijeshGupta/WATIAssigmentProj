using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WATIAssignmentProj.Models
{
    [Table("CalculationHistories")]
    public class CalculationHistory
    {
        public int ID { get; set; }
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }
        public decimal Result { get; set; }
        public string Type { get; set; }
    }
}