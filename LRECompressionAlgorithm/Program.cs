using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRECompressionAlgorithm
{
    class Program
    {
        public string LRECompression(string text)
        {
            int say=0;
            List<char> textinchars = text.ToList();
            string returntext = "";
                for (int i = 0; i <= text.Count(); i++)
                {
                    if (i+1==text.Count())//Son Karakter
                    {
                    returntext = returntext + (say+1).ToString() + textinchars[i];
                    return returntext;
                   
                    }
                    else if (textinchars[i]==textinchars[i+1])
                    {
                        say++;
                    }
                    else
                    {
                        say++;
                        returntext =returntext+say.ToString()+ textinchars[i];
                        say = 0;
                    }
                }
            return returntext;
        }
        static void Main(string[] args)
        {
            Console.Write("Sıkıştırılmak İstenen Metni Giriniz :");
            string text = Console.ReadLine();
            LRECompressionAlgorithm.Program p = new Program();
            Console.WriteLine( p.LRECompression(text));
            Console.ReadKey();
        }
       
    }
}
