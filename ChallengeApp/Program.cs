using ChallengeApp;
Console.WriteLine("Welcome to program work hard until You die for nothing");
Console.WriteLine("-------------------------------------------------------"); 
Console.WriteLine();


var employee = new Employee("Sydney", "Prescot", 33, "Woman");

while (true)
{
    Console.WriteLine("Show next Worker grade: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
	try
	{
        employee.AddGrade(input);
	}
	catch (Exception exception)
	{

        Console.WriteLine($"Exception catched : {exception.Message}");
	}
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");







