using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class RegViewModels
    {
        public string UserID { get; set; }
        public string UserPW { get; set; }
        [UIHint("Enum-radio")]
        public MemberLevel mLevel { get; set; }
    }

    public enum MemberLevel
    {
        User,
        Admin
    }
}