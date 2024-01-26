using System;
using System.IO;
using System.Text;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello dear user, I am your assistant, what do u do want today? \n");
            Console.WriteLine("1- save and a text file. \n2- load the saved text file.(comming soon)");

            Console.Write("Enter The Number: ");
            int UserSelection = Convert.ToInt32(Console.ReadLine());

            if (UserSelection == 1)
            {
                ReadSavedText();
            }
            else
            {
                Console.WriteLine("ERROR!!! U HAVE 2 SELECT BETWEEN DEFINDED NUMBERS! >:(");
            }

            Console.ReadKey();
        }
        static void ReadSavedText()
        {
            Console.Write("Enter your name of title: ");
            string NameFile = Console.ReadLine();
            string FileLocation = NameFile + ".txt";

            Console.Write("Enter your name of Text: ");
            string FileContent = Console.ReadLine();

            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(FileLocation, FileMode.OpenOrCreate);
                using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.Write(FileContent);
                }
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
        }
    }
}