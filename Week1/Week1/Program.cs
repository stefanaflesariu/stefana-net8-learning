// C# Intro - Homework 

//Exercise 1
/*Console.Write("Introdu primul numar: ");
float a = float.Parse(Console.ReadLine());

Console.Write("Introdu al 2 lea  numar: ");
float b = float.Parse(Console.ReadLine());

//Addition
float add = (a + b);
Console.WriteLine("Addition : " + add);

//Subtraction 
float sub = a - b;
Console.WriteLine("Subtraction : " + sub);
    
//Division
float div = a /b;
Console.WriteLine("Division : " + div);

//Multiplication
float mul = a * b;
Console.WriteLine("Multiplication : " + mul);

//Modulo
float mod = a % b;
Console.WriteLine("Modulo : " + mod);


//Exercise 2
int i = 15;
int j = 10;
int k = 20;
int calcul = i+j-k/2;

Console.WriteLine("Rezultatul este:" + calcul);

int a = 17;
int b = 18;
a++;
b--;
Console.WriteLine("Numarul a este: "+a);
Console.WriteLine("Numarul b este: " + b);
a += 5;
b -= 5;
Console.WriteLine("Numarul a dupa incrementare este: " + a);
Console.WriteLine("Numarul b dupa decrementare este: " + b);
*/

//Exercise 3

Console.Write("Introdu primul numar: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Introdu al 2 lea  numar: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Cele doua numere sunt egale");
}
if (a != b)
{
    Console.WriteLine("Cele doua numere nu sunt egale");
}
//Operatorul &&
Console.WriteLine(false && false);
Console.WriteLine(false && true);
Console.WriteLine(true && false);
Console.WriteLine(true && true);

// Operatorul ||
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);
Console.WriteLine(true || true);

bool n=true;
Console.WriteLine(!n);