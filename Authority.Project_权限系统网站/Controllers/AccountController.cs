using Authority.Common.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authority.Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        [HttpGet]//返回一个页面：这个页面是用来展示登录页面的
        public ActionResult Login()
        {


            return View();
        }

        [HttpPost]//提交登录--开始登录的时候，需要去处理的业务逻辑
        public ActionResult Login(LoginUser user)
        {
            {
                //去调用数据库判断，如果用户名+密码验证通过了，--跳转到指定的页面

            }


            return View();
        }
    }
}