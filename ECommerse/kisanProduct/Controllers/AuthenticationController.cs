using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kisanProduct.Models;
using Admin;
using kisranCart;

namespace kisanProduct.Controllers;

public class AuthenticationController:Controller{

    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(ILogger<AuthenticationController> logger)
    {
        Console.WriteLine("Auth Controller instance initialized......");
        _logger = logger;
    }
[HttpGet]
     public IActionResult Login()
    {
        return View();
    }
     public IActionResult Welcome()
    {
        return View();
    }

      public IActionResult Validate(string email, string password)
    {

        List<KisanRegister> kisans=DataManagemant.GetAllRegisterData();
        if(kisans.Exists(list=>list.Email.Equals(email))){
            KisanRegister newRegister=kisans.Find(obj=>obj.Email.Equals(email));
            Console.WriteLine(newRegister);
            if(newRegister.Password.Equals(password)){
                return Redirect("/Authentication/Welcome");
            }
        }
        return View();
    }
     public IActionResult Register()
    {
        Console.WriteLine("inside register");
        return View();
    }
     public IActionResult KisanRegistration(string FirstName,string LastName,string address,string Password,string Email,string ContactNo)
    {

        List<KisanRegister> list=DataManagemant.GetAllRegisterData();
        //  List<KisanRegister> list=new List<KisanRegister>();
        KisanRegister kisan=new KisanRegister(FirstName,LastName,address,Password,Email,ContactNo);
        list.Add(kisan);
        DataManagemant.serializationFile(list);
        return Redirect("/Home/Index");
    }




}