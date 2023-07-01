//[Exercise 1]
//Given an array of integer numbers,
//print the total of all the values that are even numbers.
//[1, 2, 3, 4, 5] -> total = 6

/*int[] arr = new int[5] {1, 2, 3, 4, 5};
int suma = 0;
for (int i = 0; i < 5; i++)
{
    
    if (arr[i]%2==0)
    {
        suma += arr[i];
    }
}
Console.WriteLine(suma)/
*/

//[Exercise 2]
//Find if an array of integer numbers contains duplicates and display them if so.
//[1, 2, 3, 3, 4] -> 3
/*
int[] arr = new int[] { 1, 2, 3, 3, 4};
for(int i=0; i<arr.Length; i++) 
{
    for(int j=i+1; j<arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine(arr[i]);
        }
    }
} */

//[Exercise 3]
//Check if there are duplicates in a list of strings. If yes, remove the them.
//{"a", "b", "b", "c", "c", "d"} -> { "a", "b", "c", "d"}

/*
List<string> strings = new List<string> { "a", "b", "b", "c", "c", "d" };
for (int i = 0; i < strings.Count; i++)
{
    for (int j = i + 1; j < strings.Count; j++)
    {
        if (strings[i] == strings[j])
        {
           strings.RemoveAt(i);
        }
    }
}
// Uneste stringurile intr-o linie CSV
// (comma separated values - valori separate prin virgula).
string newString = string.Join(",", strings.ToArray());
Console.WriteLine(newString);*/

//[Exercise 4]
//Write a program to count the frequency of each element in an array.
//[1, 4, 5, 2, 1, 4, 3, 1, 2] -> 1 - 3 times, 4 - 2 times, 5 - one time, 2 - 2 times, 3 - one time

/*
int count=1;
int[] array = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            count++;
            
        }
    }
   Console.WriteLine(array[i]+" - "+count+"times"); 
}
*/
//Exercise 5]
//Read an array from the console and separate odd and even values into 2 arrays. 
//[3, 4, 5, 6, 7, 8] -> Odd array: [3, 5, 7], Even array: [4, 6, 8]
/*
int[] array = new int[5] ; 
List<int> list = new List<int>();
List<int> list1 = new List<int>();
Console.WriteLine("Scrie un array cu 6 elemente");
for (int j = 0; j <= 5; j++)
{
    Console.WriteLine("Elementul {0} este: ");
    array[j] = int.Parse(Console.ReadLine());
}
for(int i=0; i<array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
       list.Add(array[i]);
    }
    else
    {
        list1.Add(array[i]);
    }
}
string oddArray = string.Join(",", list.ToArray());
string evenArray = string.Join(",", list1.ToArray());
Console.WriteLine("Odd array ["+ oddArray + " ]");
Console.WriteLine("Even array [" + evenArray + " ]");
*/

//[Exercise 6]
//Read two numbers, a and b, from the user and create a collection with all the numbers between a and b.
//Be sure to have the collection in ascending order (a to b if a < b, b to a if b < a).
//Print the collection elements. Print all numbers that divide by 3 starting from a to b.
//Use both for and foreach loops.
//a = 3, b = 15 => collection = 3, 4, 5, ..., 14, 15 & output => 3, 6, 9, 12, 15

Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
List<int> list1 = new List<int>();
if (a < b)
{
    for(int i = a; i <= b; i++)
    {
        list.Add(i);
    }
    int[] newArray = list.ToArray(); ;
    Console.WriteLine("Colection : " + newArray);
    foreach(int i in newArray)
    {  //Am exceptie la linia 129 (System.IndexOutOfRangeException: 'Index was outside the bounds of the array.')
        if (newArray[i] % 3 == 0)
        {
            Console.WriteLine("Output : "+newArray[i]);
        }
    }
    
}
else
{
    for (int i = b; i <= a; i++)
    {
        list1.Add(i);
    }
    string newArray = string.Join(",", list1.ToArray());
    Console.WriteLine("Elementele multimii sunt : " + newArray);
}

