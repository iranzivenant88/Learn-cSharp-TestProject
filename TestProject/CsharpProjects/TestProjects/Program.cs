
string secretWord = "Gift";
string guess = "";
int count = 0;


while(secretWord!=guess&&count<=3){
    Console.WriteLine("Enter guess : ");
    guess=Console.ReadLine();
    count++;
}
if(guess==secretWord){
    Console.WriteLine("you win!");
}else
{
    Console.WriteLine("Sorry,but you lost!Try again");
}





