using ChallengeApp;

Console.WriteLine("Welcome to program work hard until You die for nothing");
Console.WriteLine("-------------------------------------------------------"); 
Console.WriteLine();
var employee = new EmployeeInFile("Sydney", "Prescot", "Women","33");



Console.WriteLine("New Grades");
Console.WriteLine("-------------------");
employee.AddGrade(1.5f);
employee.AddGrade('c');
employee.AddGrade('B');
employee.AddGrade(20);
employee.AddGrade("15");
employee.AddGrade("20");




















//while (true)
//{
//    Console.WriteLine("Show next Worker grade: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//	try
//	{
//        employee.AddGrade(input);
//	}
//	catch (Exception exception)
//	{

//        Console.WriteLine($"Exception catched : {exception.Message}");
//	}
//}
//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");







