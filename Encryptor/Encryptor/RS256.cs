using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Encryptor;

public class RS256
{
    public string dataToSign { get; set; }
    public string PrivateKey { get; set; }
    public string ResultValue { get; set; }

    public RS256 SignAndHash(string dataToSign, string privatekey)
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider();
        var encoder = new UTF8Encoding();
        byte[] plaintext = encoder.GetBytes(dataToSign);
        RSAProvider.FromXmlString(privatekey);
        RSAParameters priKey = RSAProvider.ExportParameters(true);
        RSAProvider.ImportParameters(priKey);

        byte[] sign = RSAProvider.SignData(plaintext, CryptoConfig.MapNameToOID("SHA256"));

        string HexString = ToHexString(sign);
        RS256 RS256Class = new RS256 { dataToSign = dataToSign, PrivateKey = "", ResultValue = HexString };
        return RS256Class;
    }

    private string ToHexString(byte[] data)
    {
        var sb = new StringBuilder();
        foreach (var b in data)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }

}

