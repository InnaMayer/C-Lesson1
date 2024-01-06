// напишите программу, которая принимает на вход трехзначное целое
// число и на выходе показывает сумму первой и последней цифры этого числа.

int num = 424;
if (num>=100 && num<=999){
  int num1 = num / 100;
  int num2 = num % 10;
  int sum = num1 + num2;
  Console.Write($"Sum of first and Last digit in numb {num} is {sum}");
}
else{
    Console.Write($"Your numb is not 3 digit");
}

