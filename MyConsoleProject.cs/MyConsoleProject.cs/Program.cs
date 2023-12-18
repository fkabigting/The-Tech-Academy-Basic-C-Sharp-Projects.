using System;


namespace MyConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Welcome to ACME Accounting System \nRemember we are ACCOUNTING on YOU!");
            //Console.WriteLine("What is your name????");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, \n" +  name + "!"); 
            //Console.Read();
            //Console.WriteLine("Add 2 numbers");
            /* int sagot1 = 1 + 1;
             int sagot2 = 1 - 1;
             int sagot3 = 1 * 1;
              int sagot5 = 1 / 1;
              float sagot4 = 11 % 2; //modulus

              bool truefols = 1 > 9;


           Console.WriteLine("The sum is: " + sagot1.ToString());
           Console.WriteLine("The difference is: " + sagot2);
           Console.WriteLine("The product is: " + sagot3);
           Console.WriteLine("The remainder is: " + sagot4);
           Console.WriteLine("The quotient is: " + sagot5);
           Console.Write(truefols.ToString());

            int labas = 100;
            int loob = 100;
            bool mainitsaloob = loob != labas;

            Console.WriteLine(mainitsaloob);
            Console.ReadLine();
         */
            /*
            Console.WriteLine("Please enter a number: "); //Displays the message
            string UserInput1 = Console.ReadLine(); //value from user is stored in a variable called UserInput1
            long N1 = long.Parse(UserInput1) + 50; //a variable N1 is used to strore the value of the converted UserInput1 (String) to long integer
            Console.WriteLine("Add 50 and the total is " + N1 +  "\n\nPlease press ENTER"); //Displays a message with the value of N1 being N1 was added 50. \n\n is used to move the next string to the next line
            Console.ReadLine(); //Pause for user to see then on to the next number. Same pattern goes for the codes below

            Console.WriteLine("Please enter a number: ");
            string UserInput2 = Console.ReadLine();
            long N2 = long.Parse(UserInput2) + 25;
            Console.WriteLine("Add 25 and the total is " + N2 + "\n\nPlease press ENTER");
            Console.ReadLine();


            Console.WriteLine("Please enter a number: ");
            string UserInput3 = Console.ReadLine();
            double N3 = double.Parse(UserInput3) / 12.5;
            Console.WriteLine("Divided by 12.5 and the total is " + N3 + "\n\nPlease press ENTER"); 
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            string UserInput4 = Console.ReadLine();
            int N4 = int.Parse(UserInput4);
            bool TF = N4 > 50;
            Console.WriteLine("Is the number more than 50? " + TF + "\n\nPlease press ENTER");
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            string UserInput5 = Console.ReadLine();
            double N5 = double.Parse(UserInput3) % 7;
            Console.WriteLine("The remainder is " + N5 + "\n\nPlease press ENTER");
            Console.ReadLine();

                        */

            /*The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.” */
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //Displays the message

           
           Console.WriteLine("Enter Package Weight? "); //Displays the message

            /*If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” 
            * At this point the program would end.*/
            int Wt = Convert.ToInt32(Console.ReadLine());
            
            if (Wt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();

            }
            
            else
                {
                Console.WriteLine("Enter Package Width? "); //Displays the message
                int Wd = Convert.ToInt32(Console.ReadLine()); //Converts input from user to interger and assigned the value to Wd 

                Console.WriteLine("Enter Package Height? "); //Displays the message
                int Ht = Convert.ToInt32(Console.ReadLine()); //Converts input from user to interger and assigned the value to Ht

                Console.WriteLine("Enter Package Length? "); //Displays the message
                int Lt = Convert.ToInt32(Console.ReadLine()); //Converts input from user to interger and assigned the value to Lt


                double Dimensyon = Wd * Ht * Lt;

                        if (Dimensyon > 50)
                            {
                                Console.WriteLine("Your package too big to be shipped via Package Express. Have a good day.");
                                Console.ReadLine();
                            }

                            else
                            {
                                double TotalFee = ((Wd * Ht * Lt) * Wt) / 100; // TotalFee will hold the result of the formula
                                Console.WriteLine("Thanks you, your Total Shipping Amount is: $ " + TotalFee); //Displays the message in quotes, then add the value of TotalFee
                                Console.ReadLine(); //Pause screen to view
                            }


            }







        }
    }
}
