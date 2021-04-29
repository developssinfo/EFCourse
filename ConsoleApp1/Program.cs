using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Karen, bienvenida");

            var estudiante = new Estudiante
            {
                Apellido = "Perez",
                FechaNacimiento = DateTime.Now,
                Name = "Juan"
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Add(estudiante);
                ctx.SaveChanges();
            }

        }
    }
}
