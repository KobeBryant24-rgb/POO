using System;
using System.Collections.Generic;
namespace Lista_Peliculas
{
    class Lista_Peliculas{
        public string nombre;
        public void imprime(){
            Console.WriteLine(nombre);
        }
        public int16 año;
        public void imprime(){
            Console.WriteLine(año);
        }
         public Lista_Actores(string n, string m){
         nombre = n;
         año = m;

         }
          public void print()
        {
            Console.WriteLine("{0} {1}  ",title,year);
        }

         
          

         
    }
      

     
    }



    class Program
    {
        static void Main(string[] args)
        {
           

           List <Lista_Actores> Lista_Actores = new List<Lista_Actores>();
           Lista_Actores.Add(new Lista_Actores("Termineitor", 16));
           Lista_Actores.Add(new Lista_Actores("Jeilo", 20 ));
           Lista_Actores.Add(new Lista_Actores("Col of dury",21));
           Lista_Actores.Add(new Lista_Actores("Fornais", 2012));
           Lista_Actores.Add(new Lista_Actores("Girs of guars"));
           foreach(Lista_Actores a in Lista_Actores)
           a.imprime();
        }
    }
 }