//Exercise 1
/*
Input:
33 11 25
Output:
Minimum number is 11
Maximum number is 33

*/
int[] numbers = new int[3];
//Se citesc numerele de la tastatura
for (int i = 0; i <= 2; i++)
{
    Console.WriteLine("Elementul {0} este: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
// Presupun ca atat maximul cat si minimul este egal cu primul element
int max = numbers[0];
int min = numbers[0];

/*
for (int i = 0; i <= 2; i++)
{
    //daca elementul curent este mai mare sau egal decat max atunci el devine max
        if (numbers[i] >= max)
        {
            max = numbers[i];
        }
    //daca elementul curent este mai mic  decat min atunci el devine minumul
    if (numbers[i] < min)
        {
            min = numbers[i]; 
        }
    
}
Console.WriteLine("Minimum number is: " + min);
Console.WriteLine("Maximum number is: " + max);*/

/*
[Exercise 2]  

Input:
13 99 -441
Output:
Minimum number is -441
Maximum number is 99
 
*/
for (int i = 0; i <= 2; i++)
{
    numbers[i] >= max ? numbers[i] = max : ;
    numbers[i] < min ? numbers[i] = min : ;
}