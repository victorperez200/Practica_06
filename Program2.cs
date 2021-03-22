using System;

namespace ejercicio2
{
    public class Contacto
    {
        protected string nombre;
        protected string apellido;
        protected double telefono;
        protected string direccion;
        

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
        
        public double  Telefono 
        {
            set
            {
                telefono = value;
                
                
            }
            get
            {
                return telefono; 
            }
        }

        public string Direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
            }
        }

        public void SetContacto(string N)
        {
            nombre = N;
            apellido = N;
            //telefono = N;
            direccion = N;
        } 
    

      public void Saludar()
    {
        Console.Write ("Hola, Soy: " + Nombre);
        Console.WriteLine(" "+ Apellido);
        Console.WriteLine("Telefono: " + Telefono);
        Console.WriteLine("Direccion: " + Direccion);
        
    }
    
    }

    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Randy";
            contacto1.Apellido = "Perez";
            contacto1.Telefono= 8092893745;
            
            contacto1.Direccion = " Calle Francisco del Rosario Sanchez";
            Console.WriteLine("Buenas  ");
            Console.WriteLine("------");
            contacto1.Saludar();
            
            Console.WriteLine();
            
            Contacto contacto2 = new Contacto();
            contacto2.Nombre = "John";
            contacto2.Apellido = "Cena";
            contacto2.Telefono = 8092768815;
            contacto2.Direccion = "AV. ROMULO Betancourt";
            Console.WriteLine("Saludos  ");
            Console.WriteLine("-------");
            contacto2.Saludar();

            Console.ReadKey();
        }
    }
    
}    
    
