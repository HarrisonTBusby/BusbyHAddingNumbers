//Harrison Busby
//10/17/2022
//Mini Challenge 2: Adding numbers
//Create a program that takes two user-inputted numbers and adds them together. Also data validation and a while loop if you want to play again. 

string numbOne;
string numbTwo;
string playAgain = "yes";
bool actualNumber = true;
bool actualNumber2 = true;
int numberOne = 0;
int numberTwo = 0;
int sum = 0;
while(playAgain == "yes"){


Console.WriteLine("Let's add some numbers");

Console.WriteLine("Write your first number");

numbOne = Console.ReadLine();
actualNumber = Int32.TryParse(numbOne, out numberOne);

Console.WriteLine("Enter your second number");

numbTwo = Console.ReadLine();
actualNumber2 = Int32.TryParse(numbTwo, out numberTwo);

if(actualNumber == true && actualNumber2 == true){
    
Console.WriteLine("Your sum is:" + (numberOne + numberTwo));
}else{
    Console.WriteLine("Those are not numbers. Please input a valid response");
}

Console.WriteLine("Would you like to play again?");
string againPlay = playAgain.ToLower();
playAgain = Console.ReadLine();


if(playAgain == "yes"){
    Console.WriteLine("Lets play again.");
}else{
    Console.WriteLine("Go away.");
}
}