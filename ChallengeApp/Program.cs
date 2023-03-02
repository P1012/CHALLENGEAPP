﻿using ChallengeApp;

var employee = new Employee("Sydney" ,"Prescot");
employee.AddGrade("5");
employee.AddGrade("Pawel");
employee.AddGrade(101);
employee.AddGrade(33.033);
employee.AddGrade(9F);
employee.AddGrade(float.MinValue);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average :{statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");