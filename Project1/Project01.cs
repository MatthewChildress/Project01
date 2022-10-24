///
namespace Project01
{ 
/// <summary>
/// 
/// </summary>
    internal class Project01
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char menuChoice;

            do
            {
                PrintLargeWelcomeMessage();
                menuChoice = ShowMenu();
                if (menuChoice == '1')
                {
                    OnePlayerMode();
                    break;
                }
                else if (menuChoice == '2')
                {
                    TwoPlayerMode();
                    break;
                }
                else if (menuChoice == '3')
                {
                    RulesMode();
                }
                else if (menuChoice == '4')
                {
                    ExitOption();
                }

            } while (menuChoice != '4');
        }
        // Utility Methods
        /// <summary>
        /// A method that given a message prompt will, print the message, allow th euser to enter a value,
        /// and without pressing enter, return to the char value to the user.
        /// </summary>
        /// <param name="messagePrompt"></param>
        /// <returns></returns>
        static char PromptForChar(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Convert.ToChar(Console.ReadLine());
        }
        /// <summary>
        /// A method that given a message prompt will, print th emessage, allow the user to enter a value,
        /// and without pressing enter, return the char value to the user. THe value entered by the user shall
        /// not be shown on the screen.
        /// </summary>
        /// <param name="messagePrompt"></param>
        /// <returns></returns>
        static char PromptForCharHidden(string messagePrompt)
        {
            Console.WriteLine("--- Choose a value ---");
            Console.WriteLine("Press 1 for a Rock Bottom");
            Console.WriteLine("Press 2 for some Flying Leg Scissors");
            Console.WriteLine("Press 3 for Whatever Paper Is");
            Console.Write(messagePrompt);
            return Convert.ToChar(Console.ReadKey(true));
        }
        /// <summary>
        /// A method that given a message prompt will print the message, allow the user to enter a value, 
        /// and without pressing enter, return the char value to the user. The value entered by the user shall
        /// not be shown on the screen.
        /// </summary>
        /// <param name="messagePrompt">user input</param>
        /// <returns>input converted to a string</returns>
        static string PromptForString(string messagePrompt)
        {
            Console.Write(messagePrompt);
            return Convert.ToString(Console.ReadLine());
        }
        /// <summary>
        /// Preints a message to 'press any key to continue' and waits for the user to press enter
        /// </summary>
        static void PressAnyKey()
        {
            Console.WriteLine("- - - PRESS ANY KEY TO CONTINUE - - -");
            Console.ReadLine();

        }
        // game logic
        /// <summary>
        /// given two player choices [1,2,3], the method will reutrn a byte value, 1 for player one
        /// 2 for playertwo, or a 0 for a tie
        /// </summary>
        /// <param name="playerOneChoice"></param>
        /// <param name="playerTwoChoice"></param>
        /// <returns></returns>
        static byte CalculateWinner(char playerOneChoice, char playerTwoChoice)
        {
            byte result;
            if ((playerOneChoice == 1 && playerTwoChoice == 3) || (playerOneChoice == 2 && playerTwoChoice == 1) || (playerOneChoice == 3 && playerTwoChoice == 2))
            {
                result = 1;
            }
            else if ((playerOneChoice == 1 && playerTwoChoice == 2) || (playerOneChoice == 2 && playerTwoChoice == 3) || (playerOneChoice == 3 && playerTwoChoice == 1))
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
        /// <summary>
        /// Given two player names and their choices. This method will print the results of a match.
        /// </summary>
        /// <param name="playerOneName"></param>
        /// <param name="playerOneChoice"></param>
        /// <param name="playerTwoName"></param>
        /// <param name="playerTwoChoice"></param>
        static void PrintResults(string playerOneName, char playerOneChoice, string playerTwoName, char playerTwoChoice)
        {
        }
        /// <summary>
        /// a method that takes a character choice ['1','2','3'] and return 
        /// corresponding character choice [1 = rock, 2 = paper, 3 = scissors]
        /// </summary>
        /// <param name="playerChoice"></param>
        /// <returns></returns>
        static string ConvertChoiceToName(char playerChoice)
        {
            string choice;
            if (playerChoice == 1)
            {
                choice = "Rock Bottom";
            }
            else if (playerChoice == 2)
            {
                choice = "Flying Leg Scissors";
            }
            else
            {
                choice = "Whatever Paper Is";
            }
            return choice;
        }
        // ui method
        /// <summary>
        /// A method that prints the main game banner, with the name of your game.
        /// </summary>
        static void PrintLargeWelcomeMessage()
        {
            Console.WriteLine("- - - - - - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("          Mega         ");
            Console.WriteLine("        Rasslin'      ");
            Console.WriteLine("        Maniacs!       ");
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - -");

        }
        /// <summary>
        /// A method that prints the name of your game, all on one line.
        /// This will be used at the top of more than one game screen.
        /// </summary>
        static void PrintSmallHeader()
        {
            Console.WriteLine("- - - - Wrestle Something Placeholder - - - -");

        }
        /// <summary>
        /// This method will show the menu options, prompt the user for a char key (visible). 
        /// Once it receives input, it should clear the console and return the char value entered by the user. 
        /// The char value will correlate to the menu choice.
        /// </summary>
        /// <returns></returns>
        static char ShowMenu()
        {
            char choice;
            Console.WriteLine();
            Console.WriteLine("     1. One Player Game");
            Console.WriteLine("     2. Two Player Game");
            Console.WriteLine("     3. Game Rules");
            Console.WriteLine("     4. Exit the Game");
            Console.WriteLine();
            choice = PromptForChar("Choose [1-4]");
            Console.Clear();
            return choice;
        }
        /// <summary>
        /// A method that prints the rules of the game, indicating which hands win or lose
        /// </summary>
        static void PrintRules()
        {
            Console.WriteLine();
            Console.WriteLine("- - - - - - - Game Rules - - - - - - -");
            Console.WriteLine();
            Console.WriteLine("Make A Choice To See If It Beats Your Opponent");
            Console.WriteLine();
            Console.WriteLine("Rock Bottom beats Flying Leg Scissors");
            Console.WriteLine("Flying Leg Scissors beats Whatever Paper Is");
            Console.WriteLine("Whatever Paper Is beats the Rock Bottom");
            Console.WriteLine();
        }
        // ui screens
        static void OnePlayerMode()
        {
            PrintSmallHeader();
            Console.WriteLine("- - - - -One Player Coming Soon- - - - -");
            Console.WriteLine("Look Out For It in the MEGA Rasslin' DLC");
            PressAnyKey();
            ShowMenu();
        }
        static void TwoPlayerMode()
        {
            string playerOneName, playerTwoName;
            char playerOneChoice, playerTwoChoice;

            PrintSmallHeader();

            playerOneName = PromptForString("What is Player One's Name? : ");
            Console.WriteLine();
            playerTwoName = PromptForString("What is Player Two's Name? : ");
            Console.WriteLine();
            Console.Clear();
            PrintSmallHeader();
            Console.WriteLine($"{playerOneName} VERSUS {playerTwoName}");
            PrintRules();
            do
            {
                playerOneChoice = PromptForChar($"{playerOneName} - > : ");
            } while ((playerOneChoice < 0) && (playerOneChoice > 3));
            do
            {
                playerTwoChoice = PromptForChar($"{playerTwoName} - > : ");
            } while ((playerTwoChoice < 0) && (playerTwoChoice > 3));
            Console.Clear();
            PrintSmallHeader();
            PrintResults(playerOneName, playerOneChoice, playerTwoName, playerTwoChoice);
            PressAnyKey();
            Console.Clear();

        }
        static void RulesMode()
        {
            PrintSmallHeader();
            PrintRules();
            PressAnyKey();
            Console.Clear();
            ShowMenu();
        }
        static void ExitOption()
        {
            PrintLargeWelcomeMessage();
            Console.WriteLine();
            Console.WriteLine("Thanks for playing");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}