using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class MyValidationAttribute : DataTypeAttribute
    {
        public MyValidationAttribute()
            : base("MyValidation")
        {
            ErrorMessage = "此欄位必須為偶數";
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            int num;
            if (!int.TryParse(value.ToString(), out num)) return false;
            return num%2 == 0;
        }
    }
}