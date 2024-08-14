using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using libreriaClase;

namespace libreria
{

    class Pricipal{
        static void Main(){

            List<Persona> listaPersona = new List<Persona>();

            string opcion = mostrarMenu();

            while ( opcion != "9") {
        switch (opcion)
                  {
                    case "1":
                     listaPersona.Add(crearPersona());
                     break;
                    case "2":
                     mostrarPersona(listaPersona);
                     break;

                     case "3":
                     buscarPersona(listaPersona);
                     break;

                    default:
                     Console.WriteLine("Opcion incorrecta...");
                     Console.ReadKey();
                     break;
                   }
        opcion = mostrarMenu();

        }
    }

         public static Persona crearPersona(){

            Console.Clear();
            Persona p1 = new Persona();
            Console.WriteLine("");

            Console.Write("Ingrese Apellido: ");
            p1.Apellido = Console.ReadLine();

            Console.Write("Ingrese Nombre: ");
            p1.Nombre = Console.ReadLine();

            Console.Write("Ingrese DNI: ");
            p1.DNI = Convert.ToInt32(Console.ReadLine());            
            

            Console.Write("Ingrese Fecha Nacimiento: ");
            p1.FechaNacimiento = Console.ReadLine();

            return p1;

        }

        public static void mostrarPersona(List<Persona> personas){
            Console.Clear();
            foreach(var elem in personas){
                Console.Write("Apellido: ");
                Console.WriteLine(elem.Apellido);
                Console.Write("Nombre: ");
                Console.WriteLine(elem.Nombre);
                Console.Write("DNI: ");
                Console.WriteLine(elem.DNI);
                Console.Write("Fecha Nacimiento: ");
                Console.WriteLine(elem.FechaNacimiento);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-----------");
        
            }
                Console.ReadKey();
        }

        public static void buscarPersona(List<Persona> personas){
            int dni;
            int flag=0;
            Console.Clear();
            Console.WriteLine("Ingrese DNI persona a buscar:");
            dni = Convert.ToInt32(Console.ReadLine());

            foreach(var elem in personas){

                if(elem.DNI == dni )
                {
                Console.Write("Apellido: ");
                Console.WriteLine(elem.Apellido);
                Console.Write("Nombre: ");
                Console.WriteLine(elem.Nombre);
                Console.Write("DNI: ");
                Console.WriteLine(elem.DNI);
                Console.Write("Fecha Nacimiento: ");
                Console.WriteLine(elem.FechaNacimiento);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-----------");

                Console.ReadKey();   
                flag = 1; 
                }
            }
            if (flag == 0){
                Console.WriteLine("Usuario no encontrado");
                Console.ReadKey();
            }


        }


        public static string mostrarMenu(){

            string opcion;

            Console.Clear();

            Console.WriteLine("Menú");
            Console.WriteLine("-----");

            Console.WriteLine("");
            Console.WriteLine("1.- Crear Alumno");
            Console.WriteLine("2.- Mostrar Alumno");
            Console.WriteLine("3.- Buscar alumno");
            
            Console.WriteLine("");
            Console.Write("Elija una opción: ");

            opcion = Console.ReadLine();

            return opcion;


        }
    }


    
}