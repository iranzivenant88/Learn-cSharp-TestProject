
string secretWord = "Gift";
string guess = "";
int count = 0;
do{
     Console.WriteLine("Enter guess : ");
    guess=Console.ReadLine();
    count++;
}


while(secretWord!=guess&&count<=3);

if(guess==secretWord){
    Console.WriteLine("you win!");
}else
{
    Console.WriteLine("Sorry,but you lost!Try again");
}





