using System;


namespace Herencia
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected double cedula;
        protected int edad;
        

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        
        public string Apellido
        {
            set
            {
                apellido = value;
            }
            get
            {
                return apellido;
            }
        }
        
        public double  Cedula 
        {
            set
            {
                cedula = value;
            }
            get
            {
                return cedula; 
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: "   + Nombre);
            Console.WriteLine("Apellido: "  + Apellido);
            Console.WriteLine("Cedula: "   + Cedula);
            Console.WriteLine("Edad: "  + Edad);
        } 
    }

    public class Profesor : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }

    class ejercicio1
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Victor";
            persona1.Edad = 19;
            persona1.Apellido = "Perez";
            persona1.Cedula = 40202199286;
            Console.WriteLine("Datos de la persona:  ");
            Console.WriteLine("----------------------");
            persona1.Imprimir();
            
            Console.WriteLine();

            Profesor profesor1 = new Profesor();
            profesor1.Nombre = "Ramon";
            profesor1.Edad= 25;
            profesor1.Apellido = "Morillo";
            profesor1.Cedula = 40201735667;
            profesor1.Sueldo = 45000;
            Console.WriteLine("Datos del profesor:");
            Console.WriteLine("-------------------");
            profesor1.Imprimir();

            Console.ReadKey();
        }
    }
}