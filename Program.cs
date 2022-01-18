using System;

namespace Jgoodman_BinaryNumbersInCSha
{
    class Program
    {
        static void Main(string[] args)
        {
           string filePath = args[0];
           Console.WriteLine($"loading...{filePath}");

           string message;
           message = System.IO.File.ReadAllText(filePath);
           Console.WriteLine($" The encrypted message is: '{message}'. ");


           
           Cipher cipher;
           cipher = new Cipher(3);

           string decrypt;
           decrypt = cipher.Decrypt(message);
           Console.WriteLine(decrypt);
           
           int shift = (1);
           while(shift <= 10)
           {
               cipher = new Cipher (shift);
               decrypt = cipher.Decrypt(message);
               Console.WriteLine($" The Decrypted message is: {decrypt}");
               shift = (shift +1);

           }



           
        

        
     

        }
    }
}
