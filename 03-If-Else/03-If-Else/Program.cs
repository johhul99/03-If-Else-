// See https://aka.ms/new-console-template for more information

//1 Even or Odd:
/*Console.WriteLine("Type a number.");
int nummer = Convert.ToInt32(Console.ReadLine());

if (nummer % 2 == 0)
{
    Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is odd.");
}*/


//2 Age Bracket:
/*Console.WriteLine("How old are you?");
int ålder = Convert.ToInt32(Console.ReadLine());   
if (ålder < 13)
{
    Console.WriteLine("You are a child.");
}
else if (ålder > 12 && ålder < 20)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}*/


//3 Grade System:
/*Console.WriteLine("Type in your test score, between 0 and 100.");
int TestScore = Convert.ToInt32(Console.ReadLine());
if (TestScore < 101 && TestScore > 89)
{
    Console.WriteLine("Your grade is A.");
}
else if (TestScore < 90 && TestScore > 79)
{
    Console.WriteLine("Your grade is B.");
}
else if (TestScore < 80 && TestScore > 69)
{
    Console.WriteLine("Your grade is C.");
}
else if (TestScore < 70 && TestScore > 59)
{
    Console.WriteLine("Your grade is D.");
}
else if (TestScore < 60)
{
    Console.WriteLine("Your grade is F.");
}*/


//4 Leap Year Checker:
/*Console.WriteLine("Write an AD year.");
int year = Convert.ToInt32(Console.ReadLine());
if ( year % 4 == 0 && year % 100 != 0 )
{
    Console.WriteLine("Your year is a leap year.");
}
else if ( year % 100 == 0 && year % 400 == 0 )
{
    Console.WriteLine("Your year is a leap year.");
}
else
{
    Console.WriteLine("Your year is not a leap year.");
}*/


//5 Maximum of Three:
/* Console.WriteLine("Write a number.");
int firstNumber= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write another number.");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write another number.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine("The first number you wrote is the maximum.");
}
else if (firstNumber < secondNumber && secondNumber > thirdNumber)
{
    Console.WriteLine("The second number you wrote is the maximum.");
}
else if (firstNumber < thirdNumber && secondNumber < thirdNumber)
{
    Console.WriteLine("The third number you wrote is the maximum.");
}*/


//6 Positive, Negative or Zero:
/*Console.WriteLine("Type a number.");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("Your number is zero.");
}
else if  (number % 2 == 0)
{
    Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is odd.");
}*/


//7 Discount system:
/*Console.WriteLine("What is the total amount of your purchase in $?");
int price = Convert.ToInt32(Console.ReadLine());
double discountedPrice = price * 0.9;
if (price > 1000)
{
    Console.WriteLine("Your purchase is above 1000$ therefore you will recieve a 10% discount leaving your total amount to pay at " + discountedPrice +"$");
}
else
{
    Console.WriteLine("Your total amount is " + price + "$");
}*/


//8 Weekdays:
/*Console.WriteLine("Type a number.");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("The first day of the week is Monday.");
}
else if (number == 2)
{
    Console.WriteLine("The second day of the week is Tuesday.");
}
else if (number == 3)
{
    Console.WriteLine("The third day of the week is Wednesday.");
}
else if (number == 4)
{
    Console.WriteLine("The fourth day of the week is Thursday.");
}
else if (number == 5)
{
    Console.WriteLine("The fifth day of the week is Friday.");
}
else if (number == 6)
{
    Console.WriteLine("The sixth day of the week is Saturday.");
}
else if (number == 7)
{
    Console.WriteLine("The seventh day of the week is Sunday.");
}
else 
{
    Console.WriteLine("ERROR");
}*/

//9 Password checker:
/*string password = "gooberfloober";
Console.WriteLine("Type in the password.");
string enteredPassword = Console.ReadLine();
if ( password == enteredPassword)
{
    Console.WriteLine("Access granted.");
}
else
{
    Console.WriteLine("Access denied.");
}*/


//10 Temperature Converter:
/*Console.WriteLine("Would you like to convert the temperature from Farenheit or Celsius?");
string temperatureScale = Console.ReadLine();
Console.WriteLine("What is the temperature?");
int temperature = Convert.ToInt32(Console.ReadLine());
double farenheitToCelsius = (temperature - 32) / 1.8;
double celsiusToFarenheit = (temperature *1.8) + 32;
if (temperatureScale == "Farenheit" || temperatureScale == "farenheit")

{
    Console.WriteLine("The temperature in Celsius is " + farenheitToCelsius);
}
else if (temperatureScale == "Celsius" || temperatureScale == "celsius")
{
    Console.WriteLine("The temperature in Farenheit is " + celsiusToFarenheit);
}*/