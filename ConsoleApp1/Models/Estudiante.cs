using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Estudiante
    {
        private string _apellido;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get { return _apellido; }
            set { _apellido = " | " + value; }
        }
        public DateTime FechaNacimiento { get; set; }
    }
}
