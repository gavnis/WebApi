using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EjercicioClases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

    }

    public class Person
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public void SetAge(int n)
        {
            this.Edad = n;
        }
        public void Hello()
        {
            Console.WriteLine("Hola");
        }
    }

    public class Student : Person
    {
        public double Promedio { get; set; }
        public Student(string NewNombre, double NewPromedio, int NewEdad)
        {
            this.Nombre = NewNombre;
            this.Promedio = NewPromedio;
            this.Edad = NewEdad;
        }
        public void ShowAge()
        {
            Console.WriteLine("La edad es: " + this.Edad);
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Explanation Begins");
        }
        private string subject { get; set; }
    }
}
