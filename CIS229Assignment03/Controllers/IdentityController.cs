using CIS229Assignment03.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace CIS229Assignment03.Controllers;

public class IdentityController : Controller
{    
    // Example groups
    private static Group raiderGaming = new Group(1, "Raider Gaming");
    private static Group codeRaiders = new Group(2, "Code Raiders");
    
    // Example roles
    private static Role student = new Role(1, "Student");
    private static Role studentEmployee = new Role(2, "Student Employee");
    private static Role admin = new Role(999, "Admin");

    // Example system identities
    private Identity identity1 = new Identity(123456, true, "Winter 2025", [
        raiderGaming, codeRaiders
    ], student);
    private Identity identity2 = new Identity(987654, false, "Winter 2022", [], student);
    private Identity identity3 = new Identity(654321, true, "Winter 2025", [raiderGaming], studentEmployee);
    private Identity identity4 = new Identity(1, false, "~", [], admin);
    
    private static List<Identity> identities = new List<Identity>();
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    // GET /GetIdentities
    public JsonResult GetIdentities()
    {
        return Json(identities);
    }
    
    // GET /PopulateIdentities
    public JsonResult PopulateIdentities()
    {
        identities.Add(identity1);
        identities.Add(identity2);
        identities.Add(identity3);
        identities.Add(identity4);

        return Json(identities);
    }
    
    // POST /AddIdentity
    public JsonResult AddIdentity([FromBody] Identity identity)
    {
        if (identity == null) return Json(new { message = "Invalid identity" });
        
        identities.Add(identity);

        return Json(identity);
    }
}