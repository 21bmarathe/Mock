class Program
{
  
  Console.WriteLine("Choose Option 1 or 2");
  choice = Convert.ToInt32(Console.ReadLine());
  if (choice == 1)
  {
    Console.WriteLine("a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("b = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Result: " + (a + b));
  }
  else if (choice == 2)
  {
    Console.WriteLine("a = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("b = ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Result: " + (a - b));
  }


  Console.WriteLine("Enter a number: ");
  int digit = Convert.ToInt32(Console.ReadLine());
  int sumdigits = 0;
  while (sumdigits > 20)
  {
    sumdigits += digit;
    digit = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("Digit sum: " + sumDigits);
}


