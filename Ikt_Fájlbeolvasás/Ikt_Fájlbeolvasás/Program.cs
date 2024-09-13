using System.IO;
using System.Reflection.Emit;
using System.Linq;
namespace Ikt_Fájlbeolvasás
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new();
            using (StreamReader sr = new StreamReader("people.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}