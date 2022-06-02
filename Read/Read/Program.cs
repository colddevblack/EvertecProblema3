using System;
using System.IO;

namespace Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileToRead = @"C:\Users\Public\Entrada.txt";
            StreamWriter x;
            using (StreamReader ReaderObject = new StreamReader(FileToRead))
            {
               
                string Line;
                string saida = @"C:\Users\Public\saida.txt";
                // ReaderObject reads a single line, stores it in Line string variable and then displays it on console
                while ((Line = ReaderObject.ReadLine()) != null)
                {
                    
                    if (!File.Exists(saida))
                    {
                        x = File.CreateText(saida);
                        if (Line[0] % 3 == 0)
                        {
                           
                            x.WriteLine("M3" + Line);
                            x.Close();

                        }

                        if (Line[0] % 5 == 0)
                        {

                            x.WriteLine("M5" + Line);
                            x.Close();

                        }

                    } else
                    {
                        Console.WriteLine("Arquivo ja criado");
                        if (Line[0] % 3 == 0)
                        {
                            x = File.AppendText(saida);
                            x.WriteLine("M3" + Line);
                            x.Close();
                        }
                        if (Line[0] % 5 == 0)
                        {
                            x = File.AppendText(saida);
                            x.WriteLine("M5" + Line);
                            x.Close();
                        }

                    }
                    
                    Console.WriteLine(Line);

                    
                   
                }
            }

        }
    }
}
