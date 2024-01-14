using Microsoft.AspNetCore.Mvc;

namespace DotnetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    DataContextDapper _dapper;

    public UserController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }

    [HttpGet("TestConnection")]
    public DateTime TestConnection(){
        return _dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
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