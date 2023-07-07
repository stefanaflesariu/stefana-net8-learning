//Exercise 0
//Read about classes and objects and try to create your own classes. 
//For example, if you watch movies, try to create a class Movie with necessary fields and methods. 
//!!! Create at least 5 classes and use them to create objects

using OOP_Intro;

Movie movie1 = new Movie("Titanic",1997,"romantic");
movie1.ShowMovieDetails();
movie1.CheckCenturyMovie();
movie1.CheckOldMovie();

Person person1 = new Person("Andrei", 0755145698, 28);
person1.showContactDetails();
Console.WriteLine(person1.showYearOfBirth());

Address address1 = new Address("Teilor","Sibiu","Romania", 500035);
address1.getStreet();