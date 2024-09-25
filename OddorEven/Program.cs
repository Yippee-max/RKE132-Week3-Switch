
Console.WriteLine("Enter a number");
int userNum = Convert.ToInt32(Console.ReadLine());

// kontrollida kas kasutaja arv on paaris voi paaritu

int result = userNum % 2;
if (result != 0) // != ei ole vordne
{
    Console.WriteLine($"Usernumber {userNum} is odd");
}
else
{
    Console.WriteLine($"Usernumber {userNum} is even");
}
Console.WriteLine(result);