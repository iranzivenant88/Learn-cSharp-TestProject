using System.Text;
using System.Threading.Tasks;
namespace Giraffe{
    class Program
    {
        static void Main(string[]args){
            Console.WriteLine(GetDay(12));

            Console.ReadLine();
        }
        static string GetDay(int dayNum){
            string dayName;
            switch(dayNum){
                case 0: 
                     dayName = "Sunday";
                     break;
                case 1: 
                     dayName = "Monday";
                     break;
            
              
                case 2: 
                     dayName = "Tuesday";
                     break;
            
             
                case 3: 
                     dayName = "Wednesday";
                     break;
            
             
                case 4: 
                     dayName = "Thursay";
                     break;
                case 5: 
                     dayName = "Friday";
                     break;
                case 6: 
                     dayName = "Saturaday";
                     break;
                default:
                     dayName= "Invalid day number";
              break;
            }
             


            return dayName;
            
        }
        

    }
}
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50,101);
// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"First roll: {roll2}");
// Console.WriteLine($"First roll: {roll3}");



// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// //int roll1 = 6;
// //int roll2 = 6;
// //int roll3 = 6;
// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice rolls: {roll1 } + {roll2 } + { roll3} ={total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to tatal!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled double! +2 bonus to tatal!");
//         total += 2;
//     }
// }



// if (total >= 16)
// {
//     Console.WriteLine("you win a car !");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("you win a laptop ");
// }
// else if (total == 7)
// {
//     Console.WriteLine("you win a trip for two!");

// }
// else
// {
//     Console.WriteLine("You win a Kitten");
// }



        //  Case 1: 
        //      dayName = "Sunday";
        //      break;
        //  Case 2: 
        //      dayName = "Sunday";
        //      break;
        //  Case 3: 
        //      dayName = "Sunday";
        //      break;

        //  Case 0: 
        //      dayName = "Sunday";
        //      break;
             
        //  Case 0: 
        //      dayName = "Sunday";
        //      break;
        //  Case 0: 
        //      dayName = "Sunday";
        //      break;
   // }

 



// Console.Write("Enter a number: ");
// double num1 =Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter Operator: ");
// string op = Console.ReadLine();

// Console.Write("Enter a number: ");
// double num2 =Convert.ToDouble(Console.ReadLine());

// if(op=="+"){
//     Console.WriteLine(num1+num2);

// }else if(op =="-"){
//      Console.WriteLine(num1-num2);

// }else if(op=="*"){
//     Console.WriteLine(num1 * num2);

// }else if(op =="/"){
//      Console.WriteLine(num1 / num2);

// }else{
//     Console.WriteLine("Invalid Operator");
// }