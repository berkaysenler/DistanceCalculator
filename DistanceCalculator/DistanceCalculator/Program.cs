// Berkay Senler
// Distance Calculator




bool keepRunning = true;

while (keepRunning)
{
    Console.WriteLine("1. Convertion");
    Console.WriteLine("2. Exit");
    string choice = Console.ReadLine();


    switch (choice)
    {
        case "1":
            // Prompt for distance value to convert
            double distance;
            while (true)
            {
                Console.WriteLine("Enter a distance value: ");
                if (double.TryParse(Console.ReadLine(), out distance))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            // Prompt for selecting the unit
            string input1;
            while (true)
            {
                Console.WriteLine("Select the input unit (KM/ML/M): ");
                input1 = (Console.ReadLine().ToUpper());
                if (input1 == "KM" || input1 == "ML" || input1 == "M")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select the following (KM/ML/M)");
                }
            }

            // Prompt for selecting the unit2
            string input2;
            while (true)
            {
                Console.WriteLine("Select the output unit (KM/ML/M): ");
                input2 = (Console.ReadLine().ToUpper());
                if (input2 == "KM" || input2 == "ML" || input2 == "M")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select the following (KM/ML/M)");
                }
            }

            double convertedValue = 0;

            // Calculations
            switch (input1)
            {
                case "KM":
                    if (input2 == "ML")
                    {
                        convertedValue = distance * 0.621371;
                    }
                    else if (input2 == "M")
                    {
                        convertedValue = distance * 1000;
                    }
                    else
                    {
                        convertedValue = distance;
                    }
                    break;

                case "ML":
                    if (input2 == "KM")
                    {
                        convertedValue = distance * 1.60934;
                    }
                    else if (input2 == "M")
                    {
                        convertedValue = distance * 1609.34;
                    }
                    else
                    {
                        convertedValue = distance;
                    }
                    break;

                case "M":
                    if (input2 == "KM")
                    {
                        convertedValue = distance / 1000;
                    }
                    else if (input2 == "ML")
                    {
                        convertedValue = distance / 1609.34;
                    }
                    else
                    {
                        convertedValue = distance;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }

            // Display converted distance
            Console.WriteLine("Converted distance: {0} {1}", convertedValue, input2);

            // Prompt to perform another conversion/restart
            Console.WriteLine("Do you want to perform another conversion? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                keepRunning = false;
                Console.WriteLine("Exiting the program...");
            }
            break;

        case "2":
            keepRunning = false;
            Console.WriteLine("Exiting the program...");
            break;

        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}

Console.ReadKey();