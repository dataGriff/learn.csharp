﻿// Random random = new Random();
// int coinFlip = random.Next(0,2);
// string coinSide = coinFlip == 1 ? "Heads" : "Tails";
// Console.WriteLine(coinSide);

// string permission = "jim";
// int level = 56;
// string message = "You do not have sufficient privileges.";

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         message = "Welcome, Super Admin user.";
//     }
//     else
//     {
//         message = "Welcome, Admin user.";
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level > 20)
//     {
//         message = "Welcome, Super Manager user.";
//     }

// }

// Console.WriteLine(message);

// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine($"Outside of code block: {value}");

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");


// Challenge

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found) 
// {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// challenge

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     case "WH":
//         color = "White";
//         break;
//     default:
//         color = "Other";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

// challenge

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine(i);
// }

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Random random = new Random();
// int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// /*
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
// */



// int heroHealth = 10;
// int monsterHealth = 10;
// Random dice = new Random();

// do {
//     int heroAttack = dice.Next(1, 11);
//     monsterHealth -= heroAttack;
//     Console.WriteLine($"Monster waa damaged and lost {heroAttack} health and now has {monsterHealth} health.");

//     if(monsterHealth <= 0) 
//     {
//         Console.WriteLine("Hero Wins!");
//         break;
//     }

//     int monsterAttack = dice.Next(1, 11);
//     heroHealth -= monsterAttack;
//     Console.WriteLine($"Hero waa damaged and lost {monsterAttack} health and now has {heroHealth} health.");

//     if(heroHealth <= 0) 
//     {
//         Console.WriteLine("Monster Wins!");
//         break;
//     }
// }
// while(heroHealth > 0 || monsterHealth > 0);

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

// int numericValue = 0;
// bool validNumber = false;
// bool validEntry = false;
// Console.WriteLine("Enter a valid integer between 5 and 10:");
// do
// {
//     var readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         validNumber = int.TryParse(readResult, out numericValue);
//         if (validNumber && numericValue >= 5 &&  numericValue <= 10)
//         {
//             validEntry = true;
//             Console.WriteLine($"Your value of ({readResult}) has been accepted.");
//         }
//         else
//         {
//             Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
//         }
//     }
// } while (validEntry == false);

// int numericValue = 0;
// bool validNumber = false;
// bool validEntry = false;
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do
// {
//     var readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Trim().ToLower() == "administrator" || readResult.Trim().ToLower() == "manager" || readResult.Trim().ToLower() == "user")
//         {
//             validEntry = true;
//             Console.WriteLine($"Your value of ({readResult}) has been accepted.");
//         }
//         else
//         {
//             Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//         }
//     }
// } while (validEntry == false);

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


// for (int i = 0; i < myStrings.Length; i++)
// {
//     string myString = myStrings[i];
//     int periodLocation = myString.IndexOf('.');
//     while (periodLocation != -1)
//     {
//             Console.WriteLine(myString.Substring(0, periodLocation));
//             myString = myString.Remove(0, periodLocation + 1).Trim();
//             periodLocation = myString.IndexOf('.');    
//     }
//     Console.WriteLine(myString);
// }

// Random dice = new Random(); // stateful so requires a new instance (stores seed of random)
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll); // staleless because just returns a value

// // overload examples

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// Random dice2 = new Random();
// int roll1 = dice2.Next();
// int roll2 = dice2.Next(101);
// int roll3 = dice2.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice2.Next(1, 7);

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);