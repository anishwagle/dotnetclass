namespace Learning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, My name is Stella and I am X years old.");
            Console.WriteLine("If You can guess my age correctly, you will win a dinner date with me.");
            Console.WriteLine("So, are you ready to play? (Y/N): ");


            var response = Console.ReadLine();

            if (response == null || response== "N" || response== "n")
            {
                Console.WriteLine("No problem. Thank you for checking me out.");
            }


            while (response == "Y" || response == "y")
            {
                Console.WriteLine("Alright. I am excited. Let's get started.");
                Console.WriteLine("Please guess my age in numbers: ");
                var userInput = Convert.ToInt16(Console.ReadLine());
                Random rnd = new Random();
                var myAge = rnd.Next(18, 40);

                if (userInput > 40)
                {
                    Console.WriteLine("You are rude. I am not that old.");
                    Console.WriteLine("If you behave, I will let you try again.");
                    Console.WriteLine("Would you like to try again?(Y/N): ");
                    response = Console.ReadLine();
                    if (response == "N" || response == "n")
                    {
                        Console.WriteLine("No problem. Thank you for checking me out.");
                    }
                    if (response == "Y" || response == "y")
                    {
                        continue;
                    }
                }

                if (userInput < 18)
                {
                    Console.WriteLine("You are disgusting. I am not a child.");
                    Console.WriteLine("You just lost your chance to try again.");
                    break;
                }

                if (myAge == userInput)
                {
                    Console.WriteLine("Congratulations! You have guessed my age correctly.");
                    Console.WriteLine("As promised, you have won a dinner date with me at the Ritz.");
                    Console.WriteLine("I will contact you personally to get your information.");
                }

                if (myAge != userInput && userInput <40 && userInput >= 18)
                {
                    Console.WriteLine("Oops. You got it wrong.");
                    Console.WriteLine("The correct answer is " + myAge);
                    Console.WriteLine("Would you like to try again?(Y/N): ");
                    response = Console.ReadLine();
                    if (response == "N" || response == "n")
                    {
                        Console.WriteLine("No problem. Thank you for checking me out.");
                    }
                    if (response == "Y" || response == "y")
                    {
                        continue;
                    }
                   
                }

            }
            

        }
    }
}