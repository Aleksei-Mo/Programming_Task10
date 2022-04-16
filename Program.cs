// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Please enter your three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberOfDigit=DigitNumber(number);// Entered number should be thee-digit number. Let's check it.
if (numberOfDigit ==3)
   {
    int result = number / 10 % 10; // Find the second digit of the number
    Console.WriteLine("The second digit of "+ number+ " is " + result);
   }
else
   {
    Console.WriteLine("Attention! "+ number + " is not a three-digit number!" );
   }


int DigitNumber (int number)// Function to find number of digit
{
int NumberOfDigit=0;
double Buffer = number;
while (Buffer>=1)
   {
    Buffer=Buffer/10;
    NumberOfDigit++;
   }
return NumberOfDigit;
}