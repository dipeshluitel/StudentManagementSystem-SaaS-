using Microsoft.AspNetCore.Mvc;
using BasicForm.Models;
namespace BasicForm.Controllers;

public class UserController:Controller
{
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(MyForm myForm)
    {
        if (ModelState.IsValid)
        {
            return View("Success", myForm);
        }
        return View(myForm);
    }
}