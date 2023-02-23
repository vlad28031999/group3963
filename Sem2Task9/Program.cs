System.Random numSintezator = new System.Random();

// Вариант 1
//int rndNumber = numSintezator.Next(10,100);
//Console.WriteLine(rndNumber);
//int firstNumber = rndNumber/10;
//int secondNum = rndNumber%10;

//if(firstNumber>secondNum)
//{
    Console.WriteLine(firstNumber);
//}
//else
//{
//   Console.WriteLine("Второее число больше первого " +secondNum);
//}

//Вариант 2

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[0])-48;

int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
