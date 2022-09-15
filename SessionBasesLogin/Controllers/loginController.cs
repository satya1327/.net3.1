
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Web;
using SessionBasesLogin.Models;



namespace SessionBasesLogin.Controllers
{
    
    public class loginController : Controller
    {
        private readonly loginContext _loginContext;
        public loginController(loginContext loginContext)
        {
            _loginContext = loginContext;
        }
        [Route("login")]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Index()
        //{

        //}
        
        [HttpPost]
        public IActionResult Indexlogin(Login l)
        {
            if (ModelState.IsValid == true)
            {
                if (l.rememberMe == true)
                {
                    HttpCookie cookie = new HttpCookie("login");

                }

                

            }
            return View();
           

        }
    }
}

