using Microsoft.AspNetCore.Mvc;

namespace Encryptor.Controllers;

[ApiController]
[Route("[controller]")]
public class RS256Controller : ControllerBase
{

    [HttpPost]
    [Produces("application/json")]
    public RS256 post([FromBody] RS256 JsonData)
    {
        RS256 RS256Class = new RS256();

        RS256Class = RS256Class.SignAndHash(JsonData.dataToSign, JsonData.PrivateKey);
        return RS256Class;

    }

}

