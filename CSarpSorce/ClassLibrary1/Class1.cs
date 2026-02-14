using System.Security.Cryptography;
using System.Text;

 namespace ClassLibrary1
{
    public class Class1
    {
       public static byte[] aesencrypt(string input)
        {
            var f = Aes.Create();
            f.GenerateKey();f.GenerateIV();
           byte[] en=f.EncryptCbc(Encoding.UTF8.GetBytes(input), f.IV);
            return en;
        } 
    }
}
