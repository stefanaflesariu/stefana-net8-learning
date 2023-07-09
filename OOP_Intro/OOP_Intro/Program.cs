//Exercise 0
//Read about classes and objects and try to create your own classes. 
//For example, if you watch movies, try to create a class Movie with necessary fields and methods. 
//!!! Create at least 5 classes and use them to create objects

//using OOP_Intro;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

//Product product = new Product("Apple", 0.99, 10);

//Console.WriteLine(product.GetName()); // Outputs "Apple"
//Console.WriteLine(product.GetPrice()); // Outputs 0.99
//Console.WriteLine(product.GetQuantity()); // Outputs 10

//product.SetName("Orange");
//product.SetPrice(1.49);
//product.SetQuantity(20);

//Console.WriteLine(product.GetName()); // Outputs "Orange"
//Console.WriteLine(product.GetPrice()); // Outputs 1.49
//Console.WriteLine(product.GetQuantity()); // Outputs 20




//Exercise 5:
//Create a class Animal with one constructor and the following fields:
//-name
//- species
//-breed
//-age
//-color
//-weight
//-isSpayedOrNeutered

//Add the following methods:
//-GetName() - returns the animal's name.
//-GetSpecies() -returns the animal's species.
//-GetBreed() -returns the animal's breed.
//-GetAge() -returns the animal's age.
//-GetColor() -returns the animal's color.
//-GetWeight() -returns the animal's weight.
//-IsSpayedOrNeutered() -returns a boolean value indicating whether the animal has been spayed or neutered.
//-SetName(string name) -sets the animal's name.
//-SetSpecies(string species) -sets the animal's species.
//-SetBreed(string breed) -sets the animal's breed.
//-SetAge(int age) -sets the animal's age.
//-SetColor(string color) -sets the animal's color.
//-SetWeight(double weight) -sets the animal's weight.
//-SetIsSpayedOrNeutered(bool isSpayedOrNeutered)-
//sets a boolean value indicating whether the animal has been spayed or neutered.

//Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);
//Console.WriteLine(animal.GetName()); // Outputs "Max"
//onsole.WriteLine(animal.GetSpecies()); // Outputs "Dog"
//Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
//Console.WriteLine(animal.GetAge()); // Outputs 2
//Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
//Console.WriteLine(animal.GetWeight()); // Outputs 75
//Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs true

//animal.SetName("Buddy");
//animal.SetSpecies("Cat");
//animal.SetBreed("Siamese");
//animal.SetAge(5);
//animal.SetColor("Gray");
//animal.SetWeight(12);
//animal.SetIsSpayedOrNeutered(false);

//Console.WriteLine(animal.GetName()); // Outputs "Buddy"
//Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
//Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
//Console.WriteLine(animal.GetAge()); // Outputs 5
//Console.WriteLine(animal.GetColor()); // Outputs "Gray"
//Console.WriteLine(animal.GetWeight()); // Outputs 12
//Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs false



//Exercise 6:

//Create a class Calculator with the following methods:

//-Add(int x, int y) - returns the sum of x and y.
//-Subtract(int x, int y) -returns the difference between x and y.
//-Multiply(int x, int y) -returns the product of x and y.
//-Divide(int x, int y) -returns the quotient of x and y.
//-Power(double x, double y) -returns x raised to the power of y.
//-SquareRoot(double x) -returns the square root of x.

//Calculator calculator = new Calculator();


//Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
//Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
//Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
//Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
//Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
//Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3



//Exercise 7:

//Create a Student class that has the following fields: 
//-firstName
//-lastName
//-studentId
//-gpa

//The Student class should have the following methods:

//GetFullName(): returns the student's full name (i.e. first name followed by last name).
//HasHonors(): returns a boolean value indicating whether the student has a GPA of 3.5 or higher.

//Finally, create a Faculty class that has the following fields:
//-firstName
//-lastName
//-employeeId
//-subjectsTaught

//The Faculty class should have the following methods:

//GetFullName(): returns the faculty member's full name (i.e. first name followed by last name).
//GetSubjectsTaught(): returns a list of strings representing the subjects the faculty member teaches.

//Create a University class that has the following fields: 
//-name
//-students
//-faculties

//The students property should be a list of Student objects, and the faculties property should be a list of Faculty objects.

//The University class should have the following methods:

//-AddStudent(student): adds the specified Student object to the students list.
//-AddFaculty(faculty): adds the specified Faculty object to the faculties list.
//-GetStudentCount(): returns the number of students at the university.
//-GetFacultyCount(): returns the number of faculties at the university.

//University myUniversity = new University("My University");

//Student john = new Student("John", "Doe", 123456, 3.8);
//Student jane = new Student("Jane", "Smith", 654321, 3.6);

//myUniversity.AddStudent(john);
//myUniversity.AddStudent(jane);

//List<string> list = new List<string>() {"Math", "Physics"};
//List<string> list1= new List<string>() {"English", "History" };
//Faculty mary = new Faculty("Mary", "Jones", 111111, list);
//Faculty bob = new Faculty("Bob", "Smith", 222222, list1);

//myUniversity.AddFaculty(mary);
//myUniversity.AddFaculty(bob);

//Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
//Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2




//Exercise 8:

//Create a class College with the following fields. Use default constructor to assign default values:
//-name(Default: "Unknown")
//-foundedYear(Default: 0)
//-city(Default: "Unknown)

//Create a class Student with one constructor to initialize the following values:
//-name
//-startDate(Date when the student started College)
//-endDate
//-college
//-birthDate

//-IsStillStudent method - return True or False if the person is still a student
//-GetAge method that return the current age of the Student
//-Print() Method(to show all details)

//Create a class Professor with multiple constructors to initiliaze the following values:
//-name
//-faculity
//-specialization
//-studentsWhoGiveTheirDegree - List of students who give their degree

//We will have two constructors:
//-name, faculity, specialization
//-name, faculity, specialization, studentsWhoGiveTheirDegree

using OOP_Intro.Ex8;

Student student = new Student("Mihai", new DateTime(2018,12,12), new DateTime(2020, 12, 12), "College1", new DateTime(1999,12,20));
student.IsStillStudent();
Console.WriteLine(student.GetAge()); 
student.Print();