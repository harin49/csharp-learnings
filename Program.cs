// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// using Microsoft.VisualBasic;

// Random r = new Random();
// int daysUntilExpiry = r.Next(12);
// int discount = 0;
// string renewalMsg = "";

// if (daysUntilExpiry == 0)
// {
//     renewalMsg = "Your subscription has expired.";
// }
// else if (daysUntilExpiry == 1)
// {
//     discount = 20;
//     renewalMsg = $"Your subscription expires within a day! \nRenew now and save {discount}%!";
// }
// else if (daysUntilExpiry <= 5)
// {
//     discount = 10;
//     renewalMsg = $"Your subscription expires in {daysUntilExpiry} days.\nRenew now and save {discount}%!";
// }
// else if (daysUntilExpiry <= 10)
// {
//     renewalMsg = "Your subscription will expire soon. Renew now!";
// }

// Console.WriteLine(renewalMsg);

// string[] orderIDs = new string[] { "B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179", };

// List<string> fraudIDs = new List<string> { };

// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         fraudIDs.Add(orderID);
//         Console.WriteLine(orderID);
//     }
// }


// foreach (string fraudID in fraudIDs)
// {
//     Console.WriteLine(fraudID);
// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// int numberOfExams = 5;

// string[] students = ["hari", "chola", "sri", "nari", "sai"];

// int[] hariScores = [80, 90, 87, 98, 100, 55, 70, 80];
// int[] cholaScores = [70, 60, 82, 91, 80, 89, 56, 45];
// int[] sriScores = [70, 50, 57, 68, 90, 56, 78, 34];
// int[] nariScores = [83, 85, 97, 78, 40, 33];
// int[] saiScores = new int[] { 84, 30, 57, 68, 70, 99 };

// int[] studentScores = new int[10];

// foreach (string student in students)
// {
//     string currentName = student;
//     int examTotalScores = 0;
//     int assingmentScore = 0;
//     int overallScores = 0;
//     decimal overallAverage = 0;
//     decimal examAverage = 0;
//     string currentStudentLetterGrade = "";
//     int examCount = 0;


//     if (currentName == "hari")
//     {
//         studentScores = hariScores;
//     }

//     if (currentName == "chola")
//     {
//         studentScores = cholaScores;
//     }

//     if (currentName == "sri")
//     {
//         studentScores = sriScores;
//     }

//     if (currentName == "nari")
//     {
//         studentScores = nariScores;
//     }

//     if (currentName == "sai")
//     {
//         studentScores = saiScores;
//     }

//     foreach (int score in studentScores)
//     {
//         examCount++;

//         if (examCount <= numberOfExams)
//         {
//             examTotalScores += score;

//         }
//         else
//         {
//             assingmentScore += score / 10;
//         }
//     }

//     overallScores = examTotalScores + assingmentScore;

//     overallAverage = (decimal)overallScores / numberOfExams;
//     examAverage = (decimal)examTotalScores / numberOfExams;

//     if (overallAverage >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (overallAverage >= 93)
//         currentStudentLetterGrade = "A";

//     else if (overallAverage >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (overallAverage >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (overallAverage >= 83)
//         currentStudentLetterGrade = "B";

//     else if (overallAverage >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (overallAverage >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (overallAverage >= 73)
//         currentStudentLetterGrade = "C";

//     else if (overallAverage >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (overallAverage >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (overallAverage >= 63)
//         currentStudentLetterGrade = "D";

//     else if (overallAverage >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";


//     Console.WriteLine($"{currentName}:\t {examAverage}\t{overallAverage}\t{currentStudentLetterGrade}\t{assingmentScore} ({overallAverage - examAverage} pts)");


// }

// ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// string role = "admin";
// int roleLevel = 55;


// if (role == "admin")
// {
//     Console.WriteLine((roleLevel > 55) ? "Welcome Super Admin" : "Welcome Admin");
// }
// else if (role == "manager")
// {
//     Console.WriteLine((roleLevel > 20) ? "Contact an Admin for access." : "You do not have privileges");
// }
// else
// {
//     Console.WriteLine("You do not have privileges");
// }

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// int? x = null;




// x ??= 10;

// Console.WriteLine(x);

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// for (int i = 1; i <= 100; i++)
// {
//     string keyWord = "";

//     if (i % 3 == 0)
//     {
//         keyWord += "Fizz";
//     }

//     if (i % 5 == 0)
//     {
//         keyWord += "Buzz";
//     }

//     Console.WriteLine($@"{i} - {keyWord}");
// }

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Random r = new Random();
// int current;

// do
// {
//     current = r.Next(1, 7);
//     Console.WriteLine(current);
// } while (current != 2);

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// int heroHealth = 10;
// int monsterHealth = 10;

// Random dice = new Random();

// do
// {
//     int heroAttack = dice.Next(1, 10);
//     monsterHealth -= heroAttack;

//     Console.WriteLine($"hero attacked with {heroAttack} points, monster has {monsterHealth} remaining");

//     if (monsterHealth <= 0) continue;

//     int monsterAttack = dice.Next(1, 10);
//     heroHealth -= monsterAttack;

//     Console.WriteLine($"monster attacked with {monsterAttack} points, monster has {heroHealth} remaining");

// } while (heroHealth > 0 && monsterHealth > 0);

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Console.WriteLine("Enter an integer between 5 and 10 : ");
// string? userInput;
// bool isValid;
// int value;
// do
// {
//     bool isValidInteger;
//     userInput = Console.ReadLine();
//     isValidInteger = int.TryParse(userInput, out value);

//     isValid = isValidInteger && value >= 5 && value <= 10;
// } while (!isValid);

// Console.WriteLine($"Your input {value} has been accepted");

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// string? userInput;
// bool isValid;
// string[] rolesArray = ["administrator", "manager", "user"];
// do
// {
//     userInput = Console.ReadLine();
//     string? tranformedInput = userInput?.Trim()?.ToLower();
//     isValid = rolesArray.Contains(tranformedInput);

//     if (!isValid)
//     {
//         Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
//     }

// } while (!isValid);

// Console.WriteLine($"Your input value ({userInput}) has been accepted.)");

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three. of the menu choices"];

// for (int i = 0; i < myStrings.Length; i++)
// {
//     string myString = myStrings[i];
//     int periodIndex = myString.IndexOf(".");
//     string mySentence;

//     while (periodIndex != -1)
//     {

//         mySentence = myString.Remove(periodIndex);
//         myString = myString.Substring(periodIndex + 1);
//         myString = myString.TrimStart();

//         periodIndex = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     Console.WriteLine(myString);
// }

// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// int[] intArr = { 2, 4, 1, 0, 5, 8 };
// string[] strArr = { "a", "b", "c" };

// Array.Sort(intArr);

// foreach (int i in intArr)
// {
//     Console.WriteLine($"===> {i}");
// }

// foreach (string i in strArr)
// {
//     Console.WriteLine($"===> {i}");
// }

// Array.Clear(intArr, 0, 2);
// Array.Clear(strArr, 0, 2);

// foreach (int i in intArr)
// {
//     Console.WriteLine($"===> after {i}");
// }

// foreach (string i in strArr)
// {
//     Console.WriteLine($"===> after {i}");
// }

// Console.WriteLine($"===> after {intArr[0].ToString()}");
// Console.WriteLine($"===> after {strArr[0].ToLower()}");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] pArray = pangram.Split();
// string[] reveresedPArray = new string[pArray.Length];
// int i = 0;

// foreach (string s in pArray)
// {
//     char[] currentWordArr = s.ToCharArray();
//     Array.Reverse(currentWordArr);
//     reveresedPArray[i++] = string.Join("", currentWordArr);
// }
// string x = string.Join(" ", reveresedPArray);

// Console.WriteLine($"{x}");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// foreach (string s in orderStream.Split(","))
// {

//     if (s.Length != 4)
//     {
//         Console.WriteLine($"{s} - error");
//     }
//     else
//     {
//         Console.WriteLine($"{s}");
//     }
// }

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"Product Shares: {productShares:N3}");
// Console.WriteLine($"total: {total:C0}");


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine($"Dear Ms. Barros,\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:N2}.");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = $"{currentProduct}\t{currentReturn:P2}\t{currentProfit:C2}\n{newProduct}\t{newReturn:P2}\t{newProfit:C2}";

// // Your logic here

// Console.WriteLine(comparisonMessage);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// string s = "Find what is (inside the parentheses)";

// int oI = s.IndexOf('(');
// int cI = s.IndexOf(')');
// int length = cI - oI;

// Console.WriteLine($"{oI}");
// Console.WriteLine($"{cI}");
// Console.WriteLine(s.Substring(oI + 1, length));


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string message = "(What if) there are (more than) one (set of parentheses)?";
// bool c = true;

// while (c)
// {
//     int oI = message.IndexOf('(');
//     int cI = message.IndexOf(')');
//     oI += 1;
//     int length = cI - oI;

//     Console.WriteLine(message.Substring(oI, length));
//     message = message.Substring(cI + 1);
//     c = message.Contains('(');
// }

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = ['(', '{', '['];

// while (true)
// {

//     int openPosition = message.IndexOfAny(openSymbols);

//     if (openPosition == -1)
//     {
//         return;
//     }

//     string currentSymbol = message.Substring(openPosition, 1);
//     char closeSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "(":
//             closeSymbol = ')';
//             break;
//         case "{":
//             closeSymbol = '}';
//             break;

//         case "[":
//             closeSymbol = ']';
//             break;
//         default:
//             break;
//     }

//     openPosition += 1;
//     int closePosition = message.IndexOf(closeSymbol);

//     int length = closePosition - openPosition;

//     Console.WriteLine(message.Substring(openPosition, length));

//     message = message.Substring(closePosition + 1);
// }


//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string openSpan = "<span>";
// string closeSpan = "</span>";
// string openDiv = "<div>";
// string closeDiv = "</div>";

// string x = input;

// int openSpanLength = openSpan.Length;
// int openSpanPos = input.IndexOf(openSpan);
// int closeSpanPos = input.IndexOf(closeSpan);

// int openDivLength = openDiv.Length;

// x = x.Remove(0, openDivLength);
// x = x.Remove(x.Length - closeDiv.Length);


// int quantityLength = closeSpanPos - (openSpanPos + openSpanLength);
// string quantity = input.Substring(openSpanPos + openSpanLength, quantityLength);
// string output = x;

// Console.WriteLine(quantity);
// Console.WriteLine(output);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// string s = "healthy";

// s[0] = i;

// Console.WriteLine(s);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// string[,] corporate =
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external =
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//     // display internal email addresses
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//     // display external email addresses
// }

// void DisplayEmail(string[,] names, bool isCorporate)
// {
//     for (int i = 0; i < names.GetLength(0); i++)
//     {
//         string emailName = names[i, 0].Substring(0, 2) + names[i, 1];
//         string domain = isCorporate ? "contosso.com" : externalDomain;
//         Console.WriteLine($"===> {emailName}@{domain}");
//     }
// }

// DisplayEmail(external, false);
// DisplayEmail(corporate, true);

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// void foo()
// {
//     double x = 33.33;
//     double y = 0.0;

//     int xInt = 33;
//     int yInt = 0;

//     Console.WriteLine(x / y);
//     Console.WriteLine(xInt / yInt);
// }

// void bar()
// {
//     try
//     {

//         foo();

//     }
//     finally
//     {
//         Console.WriteLine("Something seems to be wrong");
//     }
// }

// try
// {
//     bar();
// }
// catch
// {
//     Console.WriteLine("Exception Caught");
// }

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();

//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.Write($"Caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte small;

//     Console.WriteLine(float1 / float2);
//     // Console.WriteLine(number1 / number2);

//     checked
//     {
//         try
//         {
//             small = (byte)number1;
//         }
//         catch
//         {
//             Console.WriteLine("There has been an exception");
//         }
//     }
// }

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


// try
// {
//     int num1 = int.MaxValue;
//     int num2 = int.MaxValue;
//     int result = num1 + num2;
//     Console.WriteLine("Result: " + result);

//     string str = null;
//     int length = str.Length;
//     Console.WriteLine("String Length: " + length);

//     int[] numbers = new int[5];
//     numbers[5] = 10;
//     Console.WriteLine("Number at index 5: " + numbers[5]);

//     int num3 = 10;
//     int num4 = 0;
//     int result2 = num3 / num4;
//     Console.WriteLine("Result: " + result2);
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
// }
// catch (NullReferenceException ex)
// {
//     Console.WriteLine("Error: The reference is null." + ex.Message);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Error: Index out of range." + ex.Message);
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
// }

// Console.WriteLine("Exiting program.");

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());

// decimal averageValue = 0;
// bool exit = false;

// do
// {
//     try
//     {
//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//         // Display the value returned by AverageOfEvenNumbers in the console
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
//         exit = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine(ex.Message);
//         Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//         string? read = Console.ReadLine();

//         if (read.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             exit = false;
//             try
//             {
//                 upperBound = int.Parse(read);
//             }
//             catch (FormatException e)
//             {
//                 Console.WriteLine(e.Message);
//                 exit = true;
//             }
//         }
//     }
// } while (!exit);

// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {

//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("Lower bound is greater than or equal to upper bound. invalid");
//     }

//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }

//     average = (decimal)sum / count;

//     return average;
// }
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException zeroEx)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine($"{zeroEx.Message}");
}



static void Workflow1(string[][] userEnteredValues)
{

    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException FormatEX)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine($"{FormatEX.Message}");
        }
    }
}

static void Process1(String[] userEntries)
{
    foreach (string userValue in userEntries)
    {
        try
        {
            int valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (DivideByZeroException zeroEx)
        {
            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.", zeroEx);
        }
        catch (FormatException formatEx)
        {
            throw new FormatException("Invalid data. User input values must be valid integers.", formatEx);
        }
    }
};