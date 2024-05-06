
using System.Net.Security;
using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class car : Controller
{
    [HttpGet]

    public string prnit(string name)

    {
        return "hello " + name;

    }

}