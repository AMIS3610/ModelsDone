using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
public class LoginController : Controller

{
   public IActionResult Index()
    {
            return Ok("This is the index of the LoginController");         
            //return View(); 
    }

     [Route("Login/Register")] 
    public IActionResult Register() 
    {
        return Ok("This is Login/Register");
    }
}