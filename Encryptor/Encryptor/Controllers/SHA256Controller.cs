using Microsoft.AspNetCore.Mvc;

namespace Encryptor.Controllers;

[ApiController]
[Route("[controller]")]
public class SHA256Controller : ControllerBase
{
    [HttpPost]
    [Produces("application/json")]
    public SHA256 post([FromBody] SHA256 JsonData)
    {
        SHA256 SHA256Class = new SHA256();
        SHA256Class = SHA256Class.ComputeSha256Hash(JsonData.RawData);
        return SHA256Class;
        
    }
}

