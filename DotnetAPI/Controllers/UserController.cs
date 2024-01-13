using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {

    }

    [HttpGet("test/{testValue}", Name = "GetUser")]
    public string[] Test(string testValue = "caralhudo")
    {
        string[] responseArray = new string[]{
            testValue,
            testValue,
            testValue,
            testValue,
            testValue,
            testValue,
            testValue,
            testValue,
            testValue
        };
        return responseArray;
    }


}