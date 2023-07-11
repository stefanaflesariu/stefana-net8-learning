using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Movie
    {   //Fields
        public string name;
        public int year;
        public string genre;
        public double duration = 3.50; 

        //Constructor cu 3 fields required
        public Movie(string name, int year, string genre) {
            
            this.name = name;
            this.year = year;
            this.genre = genre;
        }

        //METODE

        //Afiseaza datele filmului
        public void ShowMovieDetails()
        {
            Console.WriteLine($"Name: {this.name}, Year of appearance: {this.year}, Genre: {this.genre}, Duration: {this.duration}");
        }

        //Verifica din ce secol face parte filmul
        public void CheckCenturyMovie()
        {
            if ( year == 0 ) {
                throw new Exception("The year of the film is not specified");
            }else if( this.year < 2000)
            {
                Console.WriteLine("The film is from the 20th century");
            }
            else
            {
                Console.WriteLine("Filmul apartine secolului XXI");
            }
        }

        // Verifica cat de vechi este filmul
        public void CheckOldMovie() {

            this.year = 2023 - year;

            if( this.year ==1 ) 
            {
                Console.WriteLine($"The film has an age of: " + this.year + " year");
            }
            else
            {
                Console.WriteLine("The film has an age of: " + this.year + " years");
            }
        }

    }
}
