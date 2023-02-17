﻿using ChallengeApp;

var employee = new Employee("Sydney" ,"Prescot");
employee.AddGrade(5);
employee.AddGrade(7);
employee.AddGrade(9);
var statistics = employee.GetStatistics(); 

Console.WriteLine($"Average :{statistics.Average:N2}");     
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");