using ChallengeApp;



Employee employee1 = new Employee("Ziutka", "Berbelucha", "33");
Employee employee2 = new Employee("Henio", "Wyrwizabek" , "43");
Employee employee3 = new Employee("Czesio", "WlaTcyMoch", "8");


employee1.AddScore(5); 
employee1.AddScore(4); 
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(1);

employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(6); 
employee2.AddScore(8); 
employee2.AddScore(10);

employee3.AddScore(8);
employee3.AddScore(1); 
employee3.AddScore(3); 
employee3.AddScore(9);
employee3.AddScore(7); 
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{

    employee1 , employee2, employee3 ,

};




int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult= employee.Result;
        employeeWithMaxResult = employee;

    }
}

Console.WriteLine("Pracownik z najwiekszym wynikiem to :");
Console.WriteLine(employeeWithMaxResult.Name + "");
Console.WriteLine(employeeWithMaxResult.Surname + "");
Console.WriteLine(employeeWithMaxResult.Age + "lat ,");
Console.WriteLine($"Wynik: {employeeWithMaxResult.Result}punktow");
Console.WriteLine();

