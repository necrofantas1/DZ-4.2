{
    bool continueProgram = true;

    while (continueProgram)
    {

        Console.WriteLine("Hello, enter the first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter the operation (+, -, *, /):");
        string operation = Console.ReadLine();


        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: {a + b}");

                break;
            case "-":
                Console.WriteLine($"Result: {a - b}");

                break;
            case "*":
                Console.WriteLine($"Result: {a * b}");

                break;
            case "/":
                if (b != 0)
                {
                    Console.WriteLine($"Result: {a / b}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Error: Invalid operation.");

                break;
        }

                // запитуємо користувача, чи хоче він продовжити          
                { Console.WriteLine("\nDo you want to continue? (Y/N):"); }

                var answer = Console.ReadKey(intercept: true);

                // перевіряємо, чи користувач хоче продовжити
                if (answer.KeyChar != 'Y' && answer.KeyChar != 'y' && answer.KeyChar != 'н' && answer.KeyChar != 'Н')

                {
                    continueProgram = false;

                    Console.WriteLine("\nThank you for using the program. Goodbye!");
                }
                else
                {
                    continueProgram = true;
                }

               

        }
    }


