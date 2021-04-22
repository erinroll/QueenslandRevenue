using System;

using static System.Console;

namespace QueenslandRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erin Rollestone - Student No -
            //create constants and variables for the program
            const char SINGING = 'S', DANCING = 'D', MUSIC = 'M', EXIT = '!';
            int contestants2019, contestants2020, count, contestantNo = 1, singingNo, dancingNo, musicNo;

            string[] contestantName = new string [30];
            char[] contestantTalent = new char [30];

            char userInput;

            //Get user to input 2019 and 2020 contestants
            //only 0 - 30 contestants is a valid number, re-enter if invalid
            WriteLine("Please enter the number of contestants from 2019:");
            contestants2019 = Convert.ToInt32(ReadLine());

            while (contestants2019 < 0 || contestants2019 > 30)
            {
                WriteLine("\nYou have entered an invalid number, please try again");
                WriteLine("\nEnter the number of contestants from 2019:");
                contestants2019 = Convert.ToInt32(ReadLine());
            }

            WriteLine("\nPlease enter the number of contestants in 2020:");
            contestants2020 = Convert.ToInt32(ReadLine());

            while (contestants2020 < 0 || contestants2020 > 30)
            {
                WriteLine("\nYou have entered an invalid number, please try again");
                WriteLine("\nEnter the number of contestants in 2020:");
                contestants2020 = Convert.ToInt32(ReadLine());
            }

            //Display all input data
            WriteLine("\nYou entered \n2019: {0} contestants \n2020: {1} contestants", contestants2019, contestants2020);

            //Determine and display message depending on cases
            if (contestants2020 >= (contestants2019 * 2))
                WriteLine("\nThe competition is more than twice as big this year!");

            if ((contestants2020 >= contestants2019) && (contestants2020 < (contestants2019 * 2)))
                WriteLine("\nThe competition is bigger than ever!");

            if (contestants2020 < contestants2019)
                WriteLine("\nA tighter race this year! Come out and cast your vote!");

           //users input contestants and talent for 2020
           //only S, D, M can be character for talent, allow for re-entry if incorrect
            WriteLine("\nLet's get more information the {0} 2020  entrants",contestants2020);
            
            for (count = 0; count < contestants2020; ++count)
            {
                WriteLine("\nEnter Contestant No:{0}'s name:", contestantNo);
                contestantName[count] = ReadLine();

                WriteLine("Enter contestant No.{0}'s talent - S (singing), D (dancing), M (musical instrument):", contestantNo);
                contestantTalent[count] = Char.ToUpper(Convert.ToChar(ReadLine()));

                while (!(contestantTalent[count] == SINGING || contestantTalent[count] == DANCING || contestantTalent[count] == MUSIC))
                {
                    WriteLine("Invalid talent input. Please enter again");
                    contestantTalent[count] = Char.ToUpper(Convert.ToChar(ReadLine()));
                }
                ++contestantNo;
            }

            //Determine and display count of each type of talent
            singingNo = 0;
            dancingNo = 0;
            musicNo = 0;

            for (count = 0; count < contestantTalent.Length; ++count)
            {
                if (contestantTalent[count] == SINGING)
                {
                    singingNo += 1;
                }
                if (contestantTalent[count] == DANCING )
                {
                    dancingNo += 1;
                }
                if (contestantTalent[count] == MUSIC)
                {
                    musicNo += 1;
                }
            }

            //Display count of each talent
            WriteLine("\nThere are: \n{0} singers (talent code S) \n{1} dancers (talent code D) \n{2} musicians (talent code M)", singingNo, dancingNo, musicNo);

            //Display contestants names for talent - continual prompt until ! is pressed
            WriteLine("\nPlease enter S, D or M to view contests. Press ! to exit.");
            userInput = Char.ToUpper(Convert.ToChar(ReadLine()));

            while (userInput != EXIT)
            {
                if (!(userInput == SINGING || userInput == DANCING || userInput == MUSIC))
                {
                    WriteLine("\nInvalid talent input. Enter S, D or M to view contests. Press ! to exit.");
                    userInput = Char.ToUpper(Convert.ToChar(ReadLine()));
                }

                else
                {
                    //if statements to create headings for display
                    if (userInput == SINGING)
                        WriteLine("\nThe {0} singers are:", singingNo);
                        
                    if (userInput == DANCING)
                        WriteLine("\nThe {0} dancers are:", dancingNo);

                    if (userInput == MUSIC)
                        WriteLine("\nThe {0} musicians are:", musicNo);

                    //for loop to get contestants names
                    for (count = 0; count < contestantTalent.Length; ++count)
                    {
                        if (userInput == SINGING && contestantTalent[count] == SINGING)
                        {
                            WriteLine(contestantName[count]);
                        }

                        if (userInput == DANCING && contestantTalent[count] == DANCING)
                        {
                            WriteLine(contestantName[count]);
                        }

                        if (userInput == MUSIC && contestantTalent[count] == MUSIC)
                        {
                            WriteLine(contestantName[count]);
                        }
                    }
                    WriteLine("\nPlease enter S, D or M to view contests. Press ! to exit.");
                    userInput = Convert.ToChar(ReadLine());
                    userInput = Char.ToUpper(userInput);
                }
            }
        }
    }
}