
using System;

using System.Collections.Generic;



namespace Lista_actor

{

    class actor

    {

        private string acto;

        private Int16 yeara;

        public actor(string a, Int16 b)

        {

            acto = a;

            yeara = b;

        }

        public string getActor()

        {

            return acto;

        }

        public Int16 getYeara()

        {

            return yeara;

        }

    }

    class Movies

    {

       private string Movie_name;

       private Int16 Movie_year;

       private List<actor> actors;

       public Movies(string Movie_name, Int16 Movie_year)

       {

           this.Movie_name=Movie_name;

           this.Movie_year=Movie_year;

           actors = new List <actor>();

       }



       public string getMovies()

       {

           return Movie_name;

       }

       public int getYeara()

       {

           return Movie_year;

       }

       public void AddActor(actor a)

       {

           actors.Add(a);

       }

       public void PrintActors()

       {

           Console.WriteLine("The movie called " + "{0}" + " was on cinemas in " + "{1}", Movie_name,Movie_year);

           foreach (actor a in actors){

               Console.WriteLine("The main character was interpretated by " + "{0}" + " he/She was born in " + "{1}", a.getActor(), a.getYeara());

           }

           Console.WriteLine();

       }

    }
    class AnimatedActor

    {

        private string ani;

        private Int16 aniy;

        public AnimatedActor(string x, Int16 y)

        {

            ani = x;

            aniy = y;

        }

        public string getAnimatedActor()

        {

            return ani;

        }

        public Int16 getAnimatedActor_year()

        {

            return aniy;

        }

    }

    class Animated_Movies

    {

       private string name;

       private Int16 year;

       private List<AnimatedActor> Lista_actor;

       public Animated_Movies(string name, Int16 year)

       {

           this.name=name;

           this.year=year;

           Lista_actor = new List <AnimatedActor>();

       }



       public string getName()

       {

           return name;

       }

       public int getYear()

       {

           return year;

       }

       public void AddAnimatedActor(AnimatedActor x)

       {

           Lista_actor.Add(x);

       }

       public void PrintAnimatedActors()

       {

           Console.WriteLine("The animated movie called " + "{0}" + " was on cinemas in " + "{1}", name,year);

           foreach (AnimatedActor x in Lista_actor){

               Console.WriteLine("The main character's voice actor was " + "{0}" + " he/she was born in" + "{1}", x.getAnimatedActor(), x.getAnimatedActor_year());

           }

           Console.WriteLine();

       }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Animated_Movies p1 = new Animated_Movies ("Nightmare before christmas", 1993);

            p1.AddAnimatedActor(new AnimatedActor ("Chris Sarandon", 1942));

            p1.PrintAnimatedActors();

            Movies p2 = new Movies ("The invisible man", 2020);

            p2.AddActor(new actor ("Elisabeth Moss", 1982));

            p2.PrintActors();

            Animated_Movies p3 = new Animated_Movies ("Treasure planet", 2002);

            p3.AddAnimatedActor(new AnimatedActor (" Joseph Gordon-Levitt ", 1981));

            p3.PrintAnimatedActors();

            Movies p4 = new Movies ("Godzilla ", 2014);

            p4.AddActor(new actor (" Aaron Taylor-Johnson,", 1979));

            p4.PrintActors();

            Movies p5 = new Movies ("Venom", 2018);

            p5.AddActor(new actor ("Tom Hardy", 1977));

            p5.PrintActors();



        }

    }

}