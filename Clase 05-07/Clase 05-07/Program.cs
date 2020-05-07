using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clase_05_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> lastnames = new List<string>();
            List<int> ages = new List<int>();
            Console.WriteLine("1:Crear una persona");
            Console.WriteLine("2:Ver personas");
            Console.WriteLine("3:Cargar personas");
            Console.WriteLine("4:Guardar personas");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Escriba el nombre de la persona");
                    string n = Console.ReadLine();
                    Console.WriteLine("Escriba el apellido de la persona");
                    string ln = Console.ReadLine();
                    Console.WriteLine("Escriba la edad de la persona");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Person nperson = new Person(n, ln, a);
                    names.Add(n);
                    lastnames.Add(ln);
                    ages.Add(a);

                    break;
                case 2:
                    int i = 0;
                    int l = names.Count;
                    while (i != l)
                    {
                        Console.WriteLine(names[i],"", lastnames[i],"", ages[i]);
                        i = i + 1;
                    }
                    break;
                case 3:
                    int x = 0;
                    int d = names.Count;
                    while (x != d)
                    {

                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("Archivopersonas.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                        Person newperson = (Person)formatter.Deserialize(stream);
                        stream.Close();
                        x = x + 1;
                    }
                    break;
                case 4:
                    int k = 0;
                    int s = names.Count;
                    while (k != s)
                    {
                        Person newperson = new Person(names[k], lastnames[k], ages[k]);
                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream("Archivopersonas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                        formatter.Serialize(stream, newperson);
                        stream.Close();
                        k = k + 1;
                    }
                    break;

            }
        }
    }
}
