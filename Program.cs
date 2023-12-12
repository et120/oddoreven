// Name: Elizabeth Trotter 

// Date Revised: 9/13/2023

// Exercise: Mini Challenge # 6 - Odd or Even

// Brief Description: Create a brand new console project that takes in an input and tells you if the number entered is odd or even.
// You are required to have Data Validation and the feature to play again.

// Peer Reviewer: Marcos Rodriguez
// Peer Comments: The code works as intended. She implimented what Jesse was teaching this morning. When it ask to play again, and the user inputs something other than yes or no it will keep looping until yes or no is typed in. Overall good job!

string title = "Mini Challenge # 6";
Console.WriteLine(title);
string breakPoint = "-----------------------------";
Console.WriteLine(breakPoint);

// Data Validation (using While Loop & TryParse)
bool replay = true;
while(replay){
    Console.Write("Please give me a number: ");
    int userNum;
    string? userInput = Console.ReadLine();
    bool success = Int32.TryParse(userInput, out userNum);

    if(success){
        Console.WriteLine("Thank you. Now let's check if your number is odd or even..");
        Console.WriteLine(breakPoint);
        replay = false; //End this while loop because CORRECT input
    }else{
        Console.WriteLine("That wasn't an acceptable input. Please try again..");
        //Continue this while loop because INCORRECT input
        //Redudant to write in code.. success = false;
    }

    // Check if Odd or Even (using Modulo %) 
    if(success == true && userNum % 2 == 0){    //This if else statement needs to be inside the While Loop (Should only run with CORRECT input)
        Console.WriteLine($"{userNum} is an even number.");
    }else if(success == true){
        Console.WriteLine($"{userNum} is an odd number.");
    }
    
    // Response Validation (using 2nd While Loop)
    bool askPlayer = true;
    while(success && askPlayer){  // && means BOTH conditions must be TRUE, don't need to write out = true..
        Console.WriteLine("Do you want to play again? (yes or no)");
        string? playAgain = Console.ReadLine()?.ToLower();
        if(playAgain == "no"){
            askPlayer = false; 
            replay = false; //1st While Loop ending
        }else if(playAgain == "yes"){
            askPlayer = false; 
            replay = true; //1st While Loop continuing
        }else{
            Console.WriteLine("That wasn't an acceptable input. Please try again.."); //2nd While Loop continuing
        }
    }

}

Console.WriteLine(breakPoint);
Console.WriteLine("Okay, sounds good. Have a good day!");
Console.WriteLine(breakPoint);
