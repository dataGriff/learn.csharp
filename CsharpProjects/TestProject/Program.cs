// Random random = new Random();
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

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = System.Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// remove stacking bonus

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// challenge

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if(daysUntilExpiration < 10)
// {
//     if(daysUntilExpiration ==0)
//     {
//         Console.WriteLine("Your subscription has expired.");
//     }
//     else if (daysUntilExpiration ==1)
//     {
//         Console.WriteLine("Your subscription expires in a day!");
//         Console.WriteLine("Renew now and save 20%!");
//         discountPercentage = 20;
//     }
//     else if (daysUntilExpiration <= 5)
//     {
//         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//         Console.WriteLine("Renew now and save 10%!");
//         discountPercentage = 10;
//     }
//     else {
//         Console.WriteLine("Your subscription will expire soon. Renew now!"); 
//     }
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// challenge

// string [] orders = {"B123","C234","A345","C15","B177","G3003","C35","B179" };

// foreach (string order in orders)
// {
//     if (order.StartsWith("B"))
//     {
//          Console.WriteLine(order);
//     }
// }

// good variable names

char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// good whitespace

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// challenge

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

// string message = "The quick brown fox jumps over the lazy dog.";

// char[] characterMessage = message.ToCharArray();
// Array.Reverse(characterMessage);

// int letterCount = 0;

// foreach (char letter in characterMessage) 
// { 
//     if (letter == 'o') 
//     { 
//         letterCount++; 
//     } 
// }

// string newMessage = new String(characterMessage);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3];
