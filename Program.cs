using System;

Main();

void Main() 
{
    FullGame();
}


void Question()
{
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    
}

void FullGame()
{
        int userThrowNum;
        int userPoints = 0;
        int robotPoints = 0;

        while(userPoints != 3 && robotPoints != 3){
            Console.WriteLine("------------------------------------");
            Console.WriteLine($" | Player: {userPoints} | Computer: {robotPoints} | ");
            Console.WriteLine("------------------------------------");
            Question();
            userThrowNum = Convert.ToInt32(Console.ReadLine());
            string outputString = RoundPlayer(userThrowNum);
            
            if (outputString == "YOU WIN")
            {
                userPoints++;
            }
            else if (outputString == "YOU LOSE")
            {
                robotPoints++;
            }
        }

}

string RoundPlayer(int inputNum)
{
    Random r = new Random();
      int genRand= r.Next(1,3);
    
    string myString ="";

    if (inputNum == 1)
    {
        if (genRand == 1)
        {
            myString = "DRAW";
            Console.WriteLine(myString);
            Console.WriteLine(@"
        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)

    VS

        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)

            ");
            return myString;
        }
        else if (genRand == 2)
        {
            myString = "YOU LOSE";
            Console.WriteLine(myString);
            Console.WriteLine(@"
        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)

    VS

        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)

            ");
            return myString;
        }
        else if (genRand == 3)
        {
            myString = "YOU WIN";

            Console.WriteLine(myString);
            Console.WriteLine(@"
        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)

    VS

        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

            ");
            return myString;
        }
    }
    else if (inputNum == 2)
    {
        if (genRand == 2)
        {
            myString = "DRAW";
            Console.WriteLine(myString);

            Console.WriteLine(@"
        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)

    VS

        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)
            ");
            return myString;
        }
        else if (genRand == 3)
        {
            myString = "YOU LOSE";
            Console.WriteLine(myString);

            Console.WriteLine(@"
        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)

    VS

        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

            ");
            return myString; 
        }
        else if (genRand == 1)
        {
            myString = "YOU WIN";

            Console.WriteLine(myString);
            Console.WriteLine(@"
        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)

    VS

        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)


            ");
            return myString;
        }
    }
    else if (inputNum == 3)
    {
        if (genRand == 3)
        {
            myString = "DRAW";
            Console.WriteLine(myString);

            Console.WriteLine(@"
        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

    VS

        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

            ");
            return myString;
            
        }
        else if (genRand == 1)
        {
            myString = "YOU LOSE";
            Console.WriteLine(myString);

            Console.WriteLine(@"
        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

    VS

        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)


            ");
            return myString;
        }
        else if (genRand == 2)
        {
            myString = "YOU WIN";
            Console.WriteLine(myString);
                        
            Console.WriteLine(@"
        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)

    VS

        _______
    ---'    ____)____
                ______)
                _______)
                _______)
    ---.__________)

            ");
            return myString;
        }
    }
    return myString;
}


