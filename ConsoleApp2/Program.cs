using System.Globalization;



Console.WriteLine("Hello, what is your name?: ");
string username = Console.ReadLine();
Console.WriteLine($"Nice to meet you {username}");

void perimeter(int num1, int num2)
{
    int rectangle = num1 * num2;
    int perimeter = (num1 + num2) * 2;
    Console.WriteLine($"The rectangle area is {rectangle} and its perimeter is {perimeter}");
}

Console.WriteLine("please put the first number: ");
int usernum1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second number: ");
int usernum2 = int.Parse(Console.ReadLine());
perimeter(usernum1, usernum2);

void pricecalc(int prcforone, int percent, int quantity)
{
    int finalprcforone = prcforone - (percent / 100);
    int finalquantity = finalprcforone * quantity;
    Console.WriteLine($"The new price for one umbrella is: {finalprcforone} and the total price is: {finalquantity}");
}

Console.WriteLine("Please put the price for one umbrella: ");
int oneumbrella_price = int.Parse(Console.ReadLine());
Console.WriteLine("Please put the discount percentage: ");
int percentage = int.Parse(Console.ReadLine());
Console.WriteLine("Please put the quantity: ");
int userquantity = int.Parse(Console.ReadLine());
pricecalc(oneumbrella_price, percentage, userquantity);


int a = 4;
int b = 5;
int add = a + b;
double sub = a - b;
int mul = a * b;
float div = a / b;
Console.WriteLine($"{add}  {sub} {mul}  {div}");