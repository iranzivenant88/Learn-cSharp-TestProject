Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration==0){
    Console.WriteLine("Your subscription has expired");
}
else if(daysUntilExpiration<=10)
{
    Console.WriteLine("Your subscription will expire soon.Renew now!");
    
}
else if(daysUntilExpiration<=5)
{
    ConsoleWriteLine("Your subscription expires in "+daysUntilExpiration + " days. \nRenew now and save 10%!");
    discountPercentage+=discountPercentage*10/100;
} 
else if(daysUntilExpiration==1)
{
    Console.WriteLine("Your subscription expires within a day!\n Renew now and save 20%!");
    discountPercentage+=discountPercentage*20/100;
}