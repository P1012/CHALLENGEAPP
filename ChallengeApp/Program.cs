
string sex1 = "Kobieta";
int age1 = 28;

string name1 = "Ewa";
int age2 = 33;

string sex2 = "Mezczyzna";
int age3 = 16;

string name2 = "Pawel";
int age4 = 40; 


if (sex1 == "Kobieta" && age1 < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
if (name1 == "Ewa" && age2 == 33)
{
    Console.WriteLine("Ewa lat 33");

}
if (sex2 == "Mezczyzna" && age3 < 18 )
{
    Console.WriteLine("Niepelnoletni Mezczyzna");

}
if (name2 == "Pawel" && age4 == 40)
{
    Console.WriteLine("Cos o mnie");
}