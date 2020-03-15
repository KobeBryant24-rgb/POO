uusing System;

using System.Collections.Generic;

namespace Lista_Peliculas

{

    class Lista_Peliculas{

        public string nombre;

        public void imprime(){

            Console.WriteLine(nombre);

        }
         public string año;

        public void imprime(){

            Console.WriteLine(año);

        }



        public Lista_Peliculas(string n, int q){

        nombre = n;
        año = q;

    }

    

    }




    class Program
    {
        static void Main(string[] args)
        {
           

           List <Lista_Actores> Lista_Actores = new List<Lista_Actores>();
           Lista_Actores.Add(new Lista_Actores("Emma ", 16));
           Lista_Actores.Add(new Lista_Actores("Stone", 20 ));
           Lista_Actores.Add(new Lista_Actores("Col of dury",21));
           Lista_Actores.Add(new Lista_Actores("Fornais", 2012));
           Lista_Actores.Add(new Lista_Actores("Girs of guars"));
           foreach(Lista_Actores a in Lista_Actores)
           a.imprime();
        }
    }
 }