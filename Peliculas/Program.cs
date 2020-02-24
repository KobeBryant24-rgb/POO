using System;

namespace Peliculas
{
    class pelicula
    {
        private string title;
        private Int16 year;
        private string country;
        private string main;

        public pelicula(string title, Int16 year)
        {
            this.title=title;
            this.year=year;
        }
        public void print()
        {
            Console.WriteLine("{0} {1}  ",title,year);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula("Gravity",2013);
            p1.print();

            pelicula p2 = new pelicula("Joker",2019);
            p2.print();
            
            pelicula p3 = new pelicula("Toy Story 4",2019);
            p3.print();

            pelicula p4 = new pelicula("Bohemian Rapsody",2018);
            p4.print();
            
            pelicula p5 = new pelicula("Roma",2018);
            p5.print();
            
            
                
        }
            
    }
}