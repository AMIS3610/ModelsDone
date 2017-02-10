using System;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
public class HomeController : Controller

{
     [Route("Home")]
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeController");
        //return View(); 
    }
    
}