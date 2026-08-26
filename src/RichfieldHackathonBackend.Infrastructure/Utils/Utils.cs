using System.Security.Cryptography;

public static class Utils
{
    public static string GenerateCertCode()
    {
        return RandomNumberGenerator.GetInt32(1000, 10000).ToString();
    }
    public static string GenerateSixDiginPin()
    {
        return RandomNumberGenerator.GetInt32(100000, 1000000).ToString();

    }

}