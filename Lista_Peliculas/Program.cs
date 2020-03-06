using System;
using System.Collections.Generic;
namespace Lista_Peliculas
{
    class Lista_Peliculas{
        public string nombre;
        public void imprime(){
            Console.WriteLine(nombre);
        }
        public Lista_Peliculas(string n){
        nombre = n;
    }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
           

           List <Lista_Peliculas> Lista_Peliculas = new List<Lista_Peliculas>();
           Lista_Peliculas.Add(new Lista_Peliculas("Termineitor"));
           Lista_Peliculas.Add(new Lista_Peliculas("Jeilo"));
           Lista_Peliculas.Add(new Lista_Peliculas("Col of dury"));
           Lista_Peliculas.Add(new Lista_Peliculas("Fornais"));
           Lista_Peliculas.Add(new Lista_Peliculas("Girs of guars"));
           for(int i = 0; i<Lista_Peliculas.Count; i++){
               Lista_Peliculas[i].imprime();
           }
        }
    }
}
