double money = 0;
Console.WriteLine("Vuvedi sumata, koqto shte izprashtate: ");
double pari = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the country you want to ship to: ");
string country = Console.ReadLine();

if (country == "EU")
{

    money = 10.50 + pari;
    Console.WriteLine($"The charge is {money}  euro");

}

else if (country == "GB")
{

    money = 23.00 + pari;
    Console.WriteLine($"The charge is {money} euro");
}
else
{
    money = 20.00 + pari;
    Console.WriteLine($"The charge is {money} euro");

}