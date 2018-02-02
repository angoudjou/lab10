using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        public static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
            //Movie m = new Movie();
            fillMovies();
            Displaymovies();
            bool continue_run = true;
            try
            {

                while (continue_run)
                {

                    Console.WriteLine();
                    Console.WriteLine();

                    //Console.Write("Enter a category : ");
                    //string cat = Console.ReadLine();
               int _cat=     displayMenu();
                    string catToDisplay="";

                    if(_cat> 0)
                    {
                        
                        switch (_cat)
                        {
                            case 1:
                                catToDisplay = "drama";
                                break;
                            case 2:
                                catToDisplay = "scfi";
                                break;
                            case 3:
                                catToDisplay = "horror";
                                break;
                            case 4:
                                catToDisplay = "animated";
                                break;
                            default:
                                break;
                        }
                        //end switch
                        Displaymovies(catToDisplay);

                    }
                    //if (cat.Length> 0)
                    //Displaymovies(cat);
                    //else
                    //    Console.WriteLine("You did not enter any category to look up ");

                    Console.WriteLine();
                    Console.Write("Continue? (y/n) : ");
                    continue_run = Console.ReadKey().Key == ConsoleKey.Y;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input Erro");
             //   throw;
            }

            Console.ReadLine();
            
        }

        //fill the movie sample
     static   public void fillMovies()
        {
            Movie m = new Movie("Titanic", "Drama");
            movies.Add(m);
            movies.Add(new Movie("Lion King", "Animated"));
            movies.Add(new Movie("Scream", "horror"));
            movies.Add(new Movie("Star War", "scfi"));
            movies.Add(new Movie("Aladin", "Animated"));
            movies.Add(new Movie("Rio 1", "Animated"));
            movies.Add(new Movie("Shrek", "Animated"));
            movies.Add(new Movie("Lion KIng", "Animated"));
            movies.Add(new Movie("China Town", "Drama"));
            movies.Add(new Movie("The Wrestler", "Drama"));
            movies.Add(new Movie("City of God", "Drama"));
            movies.Add(new Movie("The God Father 1", "drama"));
            movies.Add(new Movie("It", "horror"));
            movies.Add(new Movie("The Shinning", "horror"));
            movies.Add(new Movie("Psycho", "horror"));
            movies.Add(new Movie("Blade Runner", "scfi"));
            movies.Add(new Movie("Alien", "scfi"));
            movies.Add(new Movie("District 9", "scfi"));
            movies.Add(new Movie("Matrix Revolution", "scfi"));

        }
        //display categories
        static public int displayMenu() {

            try
            {
                Console.WriteLine("Select a Category number");
                Console.WriteLine("1 - Drama");
                Console.WriteLine("2 - Scfi");
                Console.WriteLine("3 - horror");
                Console.WriteLine("4 - animated");
                Console.Write("Your choice :");
                int selection = int.Parse(Console.ReadLine());
                return selection;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Make a valid selection");
                return 0;
               // throw;
            }
             
        }
        // display the list of movies
         static public void Displaymovies()
        {
            Console.WriteLine("List of Movies");
            Console.WriteLine("Title                          Categorie");
            Console.WriteLine("----------------------------------------");
            foreach (var item in movies)
            {

                Console.WriteLine(string.Format("{0,-30} {1,-10}", item.getTitle(), item.getCategory()));

            }
            Console.WriteLine();
            Console.WriteLine(movies.Count + " movies found");
            Console.WriteLine();
        }
        //overloading displaymovie method
        static public void Displaymovies( string _category)
        {
            int count = 0;
            Console.WriteLine("List of Movies of the category " + _category);
            Console.WriteLine("Title                          Categorie");
            Console.WriteLine("----------------------------------------");
            foreach (var item in movies)
            {
                if (item.getCategory().ToLower().Equals(_category.ToLower()))
                {
                    Console.WriteLine(string.Format("{0,-30} {1,-10}", item.getTitle(), item.getCategory()));
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count +" movies found");
            Console.WriteLine();
        }
    }
}
