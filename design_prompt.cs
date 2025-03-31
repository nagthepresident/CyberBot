using System;
using System.Collections;

namespace CyberBot
{
    public class design_prompt
    {

        private string user_name = string.Empty;
        private string user_asking = string.Empty;


        private ArrayList answers = new ArrayList();
        private ArrayList ignore_not_needed = new ArrayList();

        public design_prompt()
        {






            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("||   Welcome to all things Cyber Security.   ||");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tony: ");
            Console.ResetColor();
            Console.WriteLine("Please enter your name ");
            


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("You : ");
            Console.ResetColor();
            string user_name = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tony: ");
            Console.ResetColor();
            Console.WriteLine("Hi " + user_name + " welcome, I am Tony and you can ask me anything regarding CYBER SECURITY.");


            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(user_name + ": ");
            //Console.ResetColor();

            //prompt the user
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("Tony: ");
            //Console.ResetColor();
            //Console.WriteLine(" You can start by asking what is cyber security?");
            //string ask = Console.ReadLine();



            do
            {


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(user_name + ": ");
                //colour reset
                Console.ForegroundColor = ConsoleColor.White;
                //then prompt the question
                user_asking = Console.ReadLine();



                answer(user_asking);

            } while (user_asking != "exit");




        }
        private void answer(string asked)
        {



            if (asked != "exit")
            {


                ArrayList answers = new ArrayList();
                ArrayList ignore_not_needed = new ArrayList();

                //answers to questions
                answers.Add("Tony: password need to be very protected.");
                answers.Add("Tony: You know sql injection is on a high rate now.");
                answers.Add("Tony: They attack you using tactics like phising and more...");
                answers.Add("Tony: When safe browsing, do not accept all website cookies.");
                answers.Add("Tony: Cyber security is the practice of protecting confidential information, systems, networks and programs from digital attacks.");
                answers.Add("Tony: Phishing is an attack that uses fraudulent emails, text messages, phone calls or websites to trick people in to sharing sensitive data.");
                answers.Add("Tony: Safe browsing...");

                //words to be ignored in a question
                ignore_not_needed.Add("tell");
                ignore_not_needed.Add("me");
                ignore_not_needed.Add("about");
                ignore_not_needed.Add("what");
                ignore_not_needed.Add("is");
                ignore_not_needed.Add("so");
                ignore_not_needed.Add(",");
                ignore_not_needed.Add(".");



                                                //////////////// HERE IS MY SPLIT_FILTER_FUNCTION //////////////////////
                
                
                


                //store all words the user enter by split function into one, one
                string[] store_words = asked.Split(' ');
                ArrayList final_words = new ArrayList();

                Boolean found = false;

                //for loop to display all stored from split
                for (int count = 0; count < store_words.Length; count++)
                {


                    if (!ignore_not_needed.Contains(store_words[count]))
                    {

                        found = true;


                        final_words.Add(store_words[count]);



                    }

                }

                Boolean found_final = false;
                string message = string.Empty;


                if (found)
                {

                
                //for loop to test final word array
                for (int index = 0; index < final_words.Count; index++)
                {
                    //for loop for the replies
                    for (int counting = 0; counting < answers.Count; counting++)
                    {

                        //check for final answer
                        if (answers[counting].ToString().Contains(final_words[index].ToString()))
                        {
                            found_final = true;
                            message += answers[counting].ToString() + "\n";

                        }

                    }



                }


            }
                if (found_final)
                {
                    Console.WriteLine(message);

                }
                else
                {

                    Console.WriteLine("Please search something related to cyber security");
                }

                                                     /////////////// HERE ENDS MY SPLIT_FILTER_ FUNCTION /////////////////////






            }
            else
            {
                Console.WriteLine("Thank you, BYE!");
                System.Environment.Exit(0);
            }




        }

    }    
}