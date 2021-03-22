using System;

namespace Contacto
{
    public class Contacto
    {
        public string Nombre;
        public string Apellido;
        public double Telefono;
        public string Direccion;
        
        public void SetContacto(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetContacto1(String Apellido)
        {
            this.Apellido = Apellido;
        }
        public void SetContacto2(double Telefono)
        {
            this.Telefono = Telefono;
        }
        public void SetContacto3(string Direccion)
        {
            this.Direccion = Direccion;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy "  + Nombre +  " "  + Apellido +  ", vivo en  "  + Direccion +  ", y mi telefono es "  + Telefono +  "");
        }
        public class ProbarContacto
        {
            public static void Main()
            {
                Contacto cont1 = new Contacto();
                
                cont1.SetContacto("John");
                cont1.SetContacto1("Cena");
                cont1.SetContacto2( 8091278040);
                cont1.SetContacto3("AV. Romulo Betancourt");
                Console.WriteLine("Buenas:");
                cont1.Saludar();
                
                Console.WriteLine();
                
                Contacto cont2 = new Contacto();
                cont2.SetContacto("Randy ");
                cont2.SetContacto1("Orton");
                cont2.SetContacto2(8097158040);
                cont2.SetContacto3("San Isidro");
                Console.WriteLine("Saludos:");
                cont2.Saludar();
            }
        }
    }
}