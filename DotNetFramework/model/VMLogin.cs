using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class VMLogin
    {
        [DisplayName("帳號")]
        [Required(ErrorMessage = "帳號必填")]
        public string Account { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "密碼必填")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
