// string [] flaudulentOrderIDs = new string[3];
// flaudulentOrderIDs[0] = "A123";
// flaudulentOrderIDs[1] = "B456";
// flaudulentOrderIDs[2] = "C789";
// //flauduleOrderIDs[3] = "D000";

string [] flaudulentOrderIDs = {"A123" ,"B456","C789" };
Console.WriteLine($"First  :  {flaudulentOrderIDs[0]}");
Console.WriteLine($"Second :  {flaudulentOrderIDs[1]}");
Console.WriteLine($"Third  :  {flaudulentOrderIDs[2]}");
flaudulentOrderIDs[0] ="F000";
Console.WriteLine($"Reassign First: {flaudulentOrderIDs[0]}");
Console.WriteLine($"There are {flaudulentOrderIDs.Length} flaudulent orders to process.");

int[]inventory = {200,450,700,175,250};
int sum = 0;
int bin = 0;
foreach(int items in inventory){
    sum+=items;
    bin++;
     Console.WriteLine($" Bin {bin} = {items } items (Running total : { sum } )");
}
 Console.WriteLine($" We have  {sum } items in inventory. )");

