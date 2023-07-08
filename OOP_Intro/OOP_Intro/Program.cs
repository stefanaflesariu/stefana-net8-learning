//Exercise 0
//Read about classes and objects and try to create your own classes. 
//For example, if you watch movies, try to create a class Movie with necessary fields and methods. 
//!!! Create at least 5 classes and use them to create objects

using OOP_Intro;
using System.Diagnostics;
using System.Xml.Linq;

//Movie movie1 = new Movie("Titanic",1997,"romantic");
//movie1.ShowMovieDetails();
//movie1.CheckCenturyMovie();
//movie1.CheckOldMovie();

//De ce afiseaza numarul de telefon fara 0 ?
//Person person1 = new Person("Andrei", 0755145698, 28);
//person1.showContactDetails();
//Console.WriteLine(person1.showYearOfBirth());

//Address address1 = new Address("Teilor","Sibiu","Romania", 500035);
//address1.getStreet();



//Exercise 1:

//Create a class Crop with the following fields:
//-name
//-currentStage(a string representing the current growth stage of the crop).
//Stages: Seed->Sprout->Plant->CanBeHarvested->Harvested

//!! When you create a set, by default currentStage should be Seed

//Add the following methods:
//-Water() - advances the crop to the next growth stage.
//-Harvest() -harvests the crop and sets the current growth stage to "Harvested".
//You can harvest only if the currentStage is CanBeHarvested

//Crop crop1 = new Crop();
//Console.WriteLine(crop1.Water());
//Console.WriteLine(crop1.Water());
//Console.WriteLine(crop1.Water());
//Console.WriteLine(crop1.Water());
//crop1.Harvest();


//Exercise 2:

//Create a class Farm with the following fields:
//-name - representing the name of the farm.
//-area - representing the total area of the farm in square meters.
//-animalCount - representing the total number of animals on the farm.

// the following methods:
//AddAnimals(count) - adds a specified number of animals to the current farm.
//CalculateDensity() -calculates the animal density on the farm by dividing the total number of animals by the farm's area.

// a usage example that creates a farm, adds animals to it, and displays the animal 
//on the farm by dividing the total number of animals by the farm's area.

//Farm farm1 = new Farm("Fram Ville",120.67);
//farm1.AddAnimals(13);
//Console.WriteLine(farm1.CalculateDensity());

//Exercise 3:

//Create a class Book with one constructor and the following fields:
//-title
//-author
// year

// the following methods:
//GetTitle() - returns the book's title.
//GetAuthor() -returns the book's author.
//-GetYear() -returns the year the book was published.
//SetTitle(string title) -sets the book's title.
//SetAuthor(string author) -sets the book's author.
//-SetYear(int year) -sets the year the book was published.

//Book book = new Book("War and Peace", "Leo Tolstoy", 1869);

//Console.WriteLine(book.GetTitle()); // Outputs "War and Peace"
//Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
//Console.WriteLine(book.GetYear()); // Outputs 1869

//book.SetTitle("Anna Karenina");
//book.SetAuthor("Leo Tolstoy");
//book.SetYear(1877);

//Console.WriteLine(book.GetTitle()); // Outputs "Anna Karenina"
//Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
//Console.WriteLine(book.GetYear()); // Outputs 1877


//Exercise 4:

// a class Product with one constructor and the following fields:
//-name
//-price
//-quantity

// the following methods:
//-GetName() - returns the product's name.
//-GetPrice() -returns the product's price.
//-GetQuantity() -returns the product's quantity.
//-SetName(string name) -sets the product's name.
//-SetPrice(double price) -sets the product's price.
//-SetQuantity(int quantity) -sets the product's quantity.

Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName()); // Outputs "Apple"
Console.WriteLine(product.GetPrice()); // Outputs 0.99
Console.WriteLine(product.GetQuantity()); // Outputs 10

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); // Outputs "Orange"
Console.WriteLine(product.GetPrice()); // Outputs 1.49
Console.WriteLine(product.GetQuantity()); // Outputs 20

