//1.Accept 10 passenger names in an array
using System;
using System.Linq;

int n = 10;
string?[] passengerName = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the passenger Name");
    passengerName[i] = Console.ReadLine();
}

Console.WriteLine();

//Print alphabetic order
Array.Sort(passengerName);
Console.WriteLine("Names in Alphabetic Order");
foreach (var name in passengerName)
{
    Console.WriteLine(name);
}

Console.WriteLine();

//Print reverse order
Array.Sort(passengerName);
Array.Reverse(passengerName);
Console.WriteLine("Names in Reverse Order");
foreach (var name in passengerName)
{
    Console.WriteLine(name + " ");
}

Console.WriteLine();

//Input a name and search in array and display
Console.Write("Search: ");
String? searchName = Console.ReadLine();
String found = "Not Found";
string?[] searchResult = new string[n];
int resCount = 0;
int index = 0;
if (searchName != null)
{
    foreach (var name in passengerName)
    {
        if (name != null)
        {
            if (name.Contains(searchName, StringComparison.InvariantCultureIgnoreCase))
            {
                searchResult[index] = name;
                found = "Found";
                index++;
                resCount++;
            }
        }
    }
    if (found == "Not Found")
    {
        Console.WriteLine(found);
    }
    else
    {
        Console.WriteLine(resCount + " results");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(searchResult[i]);
        }
    }
}

Console.WriteLine();

//Print the length of names in each element
foreach (var name in passengerName)
{
    if (name != null)
    {
        Console.Write("length of " + name + " is ");
        Console.WriteLine(name.Length);
    }

}

Console.WriteLine();

//Split the names at space and print for each element
foreach (var name in passengerName)
{
    if (name != null)
    {
        Console.WriteLine("Full Name: " + name);
        var splits = name.Split(' ');
        Array.ForEach(splits, s => Console.WriteLine(s));
        Console.WriteLine();
    }
}
        
Console.WriteLine();

//Print duplicate entries
int count = 0;
string duplicate = "No duplicates found";
List<string?> duplicates = new List<string?>();
for (int i = 0; i < passengerName.Length; i++)
{
    for (int k = i + 1; k < passengerName.Length; k++)
    {
        if (passengerName[i] == passengerName[k])
        {
            count++;
            duplicates.Add(passengerName[i]);
            duplicate = "Found Duplicates";
        }
    }
}
if (duplicate == "Found Duplicates")
{
    Console.WriteLine(duplicate);
    foreach (var item in duplicates)
    {
        Console.WriteLine(item);
    }
}
else
    Console.WriteLine(duplicate);






