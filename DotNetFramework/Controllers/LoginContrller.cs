using BacksideWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace BacksideWebsite.Controllers
{
    public class LoginController : Controller
    {
        GameEntities gameDb = new GameEntities();
        GetData getData = new GetData();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(VMLogin vMLogin)
        {
            string sql = "select * from Manager where M_Account=@id and M_Password=@pw";
            List<SqlParameter> list = new List<SqlParameter>()
            {
                new SqlParameter("id",vMLogin.Account),
                new SqlParameter("pw",vMLogin.Password) 
            };
            var reader = getData.LoginQuery(sql,list);
            Debug.WriteLine(sql);

            if(reader.HasRows && reader!=null)
            {
                Session["emp"] = reader;
                reader.Close();

                return RedirectToAction("Index", "Home");
            }
            ViewBag.Message = "帳號密碼有誤";
            reader.Close();
            return View();
        }
    }
}
