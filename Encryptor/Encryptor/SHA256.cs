using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace Encryptor;

public class SHA256
{
    public string RawData { get; set; }
    public string ResultValue { get; set; }


    public SHA256 ComputeSha256Hash(string rawData)
    {
        var crypt = new System.Security.Cryptography.SHA256Managed();
        var hash = new System.Text.StringBuilder();
        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        foreach (byte theByte in crypto)
        {
            hash.Append(theByte.ToString("x2"));
        }
        string HashString = hash.ToString();

        SHA256 ReturnValue = new SHA256 { RawData = rawData, ResultValue = HashString };
        return ReturnValue;
    }

}

