using Microsoft.AspNetCore.Mvc;
//super basic level of our controller

namespace WebApplication1.Controllers {
    public class HomeController : Controller {//is HomeController a built-in class?

        //when you return a ViewResult we're asking MVC to render a view
        public ViewResult Index() {
            return View("MyView");
        }   
    }
}
//also like in JS, curly brace same line as declaration
//(it wasn't in the initial stuff I was reading)

//getting error: unable to connect to web server 'iss express'