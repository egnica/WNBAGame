using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            int teamOne;
            int scoreOne;
            int teamTwo;
            int scoreTwo;
            string EXIT = "EXIT";
            string primer;
            WNBAGame [] scores = new WNBAGame[12];
            string [] teams = {"1. Atlanta_Dream", "2. Chicago_Sky", "3. Connecticut_Sun", "4. Indiana_Fever", "5. New_York_Liberty", "6. Washington_Mystics", "7. Dallas_Wings", "8. Las_Vegas_Aces", "9. Los_Angeles_Sparks", "10. Minnesota_Lynx", "11. Phoenix_Mercury", "12. Seattle_Storm"};


            primer = houseKeeping();

            while(primer != EXIT){
                for(var i = 0; i < teams.Length; i++){

                    //Define 1st team
                    System.Console.WriteLine($"Please enter your first team number:");
                    System.Console.WriteLine("The number must be 1 - 12");
                    System.Console.WriteLine($"{teams[i]}");
                    teamOne = Convert.ToInt32(Console.ReadLine());


                    //Defencive program for teamOne
                    while(teamOne < 1 && teamOne > 12){
                        System.Console.WriteLine("You entered an invallad number. Enter a number between 1- 12");
                        teamOne = Convert.ToInt32(Console.ReadLine());
                    }

                    //Define 2nd team
                    System.Console.WriteLine("Please enter your second team number");
                    teamTwo = Convert.ToInt32(Console.ReadLine());

                    //Defencive program for teamTwo
                    while (teamTwo < 1 && teamTwo > 12){
                        System.Console.WriteLine("You enterend an invallad number. Please enter a number between 1 - 12");
                        teamTwo = Convert.ToInt32(Console.ReadLine());
                    }

                    //reset teams
                    teamOne = teamOne - 1;
                    teamTwo = teamTwo - 1;

                    scores[i] = new WNBAGame();

                    System.Console.WriteLine($"Please enter the score for {teams[teamOne]}");
                    scoreOne = Convert.ToInt32(Console.ReadLine());
                    scores[i].scoreOne = scoreOne;

                    System.Console.WriteLine($"Please enter the score of {teams[teamTwo]}");
                    scoreTwo = Convert.ToInt32(Console.ReadLine());
                    scores[i].scoreTwo = scoreTwo;


                    System.Console.WriteLine($"{teams[teamOne]}: {scoreOne} vs. {teamTwo}: {scoreTwo}");
                    if(scoreOne > scoreTwo){
                        System.Console.WriteLine($"{teams[teamOne]} wins!");
                    }else if (scoreTwo > scoreOne){
                        System.Console.WriteLine($"{teams[teamTwo]} wins!");
                    }else{
                        System.Console.WriteLine($"{teams[teamOne]} tied {teams[teamTwo]}");
                    }

                    primer = rerun();

                
                }// for loop


            }// while loop



        }// end main

        static string houseKeeping(){
        string primer;
        System.Console.WriteLine("Welcome to the WNBA site. Please type 'ENTER' to enter");
        primer = Console.ReadLine();

        return primer;
    }
    static string rerun(){
        string primer;
        System.Console.WriteLine("If you wouls like to rerun the program, type 'ENTER'. To exit please type 'EXIT'. ");
        primer = Console.ReadLine();

        return primer;
    }

    }//end class program



    class WNBAGame
    {
        public int teamOne{get; set;}
        public int teamTwo{get; set;}
        public int scoreOne{get; set;}
        public int scoreTwo{get; set;}
    }
}
