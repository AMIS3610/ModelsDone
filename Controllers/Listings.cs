using System;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
public class ListingsController : Controller

{
   [Route("Listings")]
    public IActionResult Index()
    {
        return Ok("This is the index of the ListingsController");
        //return View(); 
    } 
    
}