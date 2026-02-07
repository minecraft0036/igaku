using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace File_String_Encrypt
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var df = AesString("sdsdaf");
            
            Console.WriteLine();
        }
        static dynamic AesString(string s)
        {
            var d = System.Security.Cryptography.Aes.Create();
            d.GenerateIV();d.GenerateKey();

            var bytes=d.EncryptCbc(Encoding.UTF8.GetBytes("afafsafas"), d.IV);
            
           var df=new  {IV=d.IV,String=Convert.ToBase64String( bytes),Key=d.Key};
            return df;
        }
    }
    class Ex
    {
        public string StringToSHA256(string s)
        {
            return Convert.ToBase64String(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(s)));
        }
    }
}
