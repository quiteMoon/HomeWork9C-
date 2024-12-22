using System.Text;

namespace HomeWork9C_
{
    internal class Program
    {
        delegate void MessageDelegate(string message);
        delegate double ArithmeticOperation(double a, double b);

        static void Main(string[] args)
        {
            Console.InputEncoding = UTF8Encoding.UTF8;
            Console.OutputEncoding = UTF8Encoding.UTF8;

            //Завдання 1
            //MessageDelegate messageHandler;

            //messageHandler = ShowMessage;
            //messageHandler("Cтандартне повідомлення");

            //messageHandler = ShowMessageInUpperCase;
            //messageHandler("Повідомлення у верхньому регістрі");

            //messageHandler = ShowMessageWithDate;
            //messageHandler("Повідомлення з додаванням дати");

            //Завдання 2
            //ArithmeticOperation add = Add;
            //ArithmeticOperation subtract = Subtract;
            //ArithmeticOperation multiply = Multiply;

            //Console.WriteLine("Виберіть операцію: \n1. Додавання \n2. Віднімання \n3. Множення \nВаш вибір: ");
            //int choice = int.Parse(Console.ReadLine());

            //Console.Write("Введіть перше число: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Введіть друге число: ");
            //double num2 = double.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine($"Результат додавання: {add(num1, num2)}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Результат віднімання: {subtract(num1, num2)}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Результат множення: {multiply(num1, num2)}");
            //        break;
            //    default:
            //        Console.WriteLine("Невірний вибір операції");
            //        break;
            //}

            //Завдання 3
            //Predicate<int> isEven = IsEven;
            //Predicate<int> isOdd = IsOdd;
            //Predicate<int> isPrime = IsPrime;
            //Predicate<int> isFibonacci = IsFibonacci;

            //Console.WriteLine("Оберіть перевірку: \n1. Перевірка на парність \n2. Перевірка на непарність \n3. Перевірка на просте число \n4. Перевірка на число Фібоначчі \nВаш вибір: ");
            //int choice = int.Parse(Console.ReadLine());

            //Console.Write("Введіть число: ");
            //int number = int.Parse(Console.ReadLine());

            //bool result = choice switch
            //{
            //    1 => isEven(number),
            //    2 => isOdd(number),
            //    3 => isPrime(number),
            //    4 => isFibonacci(number),
            //    _ => throw new InvalidOperationException("Невірний вибір.")
            //};

            //Console.WriteLine(result ? "Число відповідає умові" : "Число не відповідає умові");

            //Завдання 4
            //ArithmeticOperation add = Add;
            //ArithmeticOperation subtract = Subtract;
            //ArithmeticOperation multiply = Multiply;

            //Console.WriteLine("Виберіть операцію: \n1. Додавання \n2. Віднімання \n3. Множення \nВаш вибір: ");
            //int choice = int.Parse(Console.ReadLine());

            //Console.Write("Введіть перше число: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Введіть друге число: ");
            //double num2 = double.Parse(Console.ReadLine());

            //ArithmeticOperation operation = null;

            //switch (choice)
            //{
            //    case 1:
            //        operation = add;
            //        break;
            //    case 2:
            //        operation = subtract;
            //        break;
            //    case 3:
            //        operation = multiply;
            //        break;
            //    default:
            //        Console.WriteLine("Невірний вибір операції.");
            //        return;
            //}

            //if (operation != null)
            //{
            //    double result = operation.Invoke(num1, num2);
            //    Console.WriteLine($"Результат: {result}");
            //}

        }

        static void ShowMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
        static void ShowMessageInUpperCase(string message)
        {
            Console.WriteLine($"{message.ToUpper()}");
        }
        static void ShowMessageWithDate(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }



        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }



        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static bool IsFibonacci(int number)
        {
            bool IsPerfectSquare(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }
    }
}
