namespace FINAL_FINAL__unless_
{
    
            /*
 * author: joseph sandoval
 * purpose: Dating app for final project.
 */

           
namespace final_project_dating_app
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Visual Studio dating pool, Please fill out the info below");


                string[] names = GetNames();

                Console.WriteLine("First Name: " + names[0]);
                Console.WriteLine("Last Name: " + names[1]);

               
                // TODO: while (true) creates an infinite loop. what makes the loop stop?

                int age = GetAgeFromBirthYear();


                string gender;
                // TODO: move this gender section in a method for code reusability
                // TODO: while (true) creates an infinite loop. what makes the loop stop?
                do
                {
                    Console.WriteLine("Please enter your gender (M/F/O): ");
                    gender = Console.ReadLine()?.ToUpper();

                    if (gender != "M" && gender != "F" && gender != "O")
                    {
                        Console.WriteLine("Invalid gender. TRY AGAIN.");
                    }
                } while (gender != "M" && gender != "F" && gender !="O");




               

                List<string> questions = new List<string>()
            {
                "Whats your favotire color?:",
                "Whats your favorite food?:",
                "Whats your favorite tvshow?:",
                "Whats your favorite candy?:",
                "Whats your origin of birth?:",
                "Whats your dream?: ",
                "What kind of animals do you have, write none if none:",
                "Do you partake in the devils lechuga?:,",
                "Do you prefer indoors or outdoors?:",
                "playstation or xbox? (warning: answer is susceptible to deal breakers:)",

            };

                List<string> responses = new List<string>();

                foreach (string question in questions) // allows the user to cycle through the questions as they answer each one until the end. 
                {
                    Console.WriteLine(question);

                    string response;
                    do
                    {
                        Console.WriteLine("Please respond quickly");
                        response = Console.ReadLine();

                        if (string.IsNullOrEmpty(response))
                        {
                            Console.WriteLine("Invalid response you");
                        }
                    } while (string.IsNullOrEmpty(response));
                    responses.Add(response);
                }


                static string[] GetNames()
                {
                    //this will collect both first and last name with validation
                    string[] names = new string[2];
                    do
                    {
                        Console.WriteLine("Enter your first name:");
                        names[0] =
                            Console.ReadLine().Trim();
                    } while (string.IsNullOrEmpty(names[0]));

                    do
                    {
                        Console.WriteLine("Enter your last name:");
                        names[1] =
                            Console.ReadLine().Trim();
                    } while (string.IsNullOrEmpty(names[1]));
                    return names;

                }

                static int GetAgeFromBirthYear()
                {
                    int currentYear = DateTime.Now.Year;
                    int birthYear;

                    while (true)
                    {
                        Console.WriteLine("Please enter the year you were born (between 1900 and " + currentYear + "):");
                        string input = Console.ReadLine();
                        if (!int.TryParse(input, out birthYear))// useful to convert user input
                        {
                            Console.WriteLine("Please ensure that the information entered meets guidlines");
                            continue; //tells the user to try again until they get it right. 

                        }

                        if (birthYear < 1900 || birthYear > currentYear)
                        {
                            Console.WriteLine("Please enter a year between 1900 and " + currentYear + ".");
                            continue;
                        }
                        break; //breaks the loop if correct 


                    }
                    return currentYear - birthYear;
                }

                Console.WriteLine("Thanks For entering in this years dating pool. (press any key to continue)");
                Console.ReadKey();

                Console.WriteLine($"Thank you, {names[0]}! Heres your information:");
                // TODO: add a space between the firstName and lastName
                Console.WriteLine($"First and last name:{names[0]}  {names[1]}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {gender}");
               
                


            }
        }
    }
}
