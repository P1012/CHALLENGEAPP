using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            float f = (float)valueInInt;
            if (grade >= 0 && grade >= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float ");
            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }


        public Statistics GetStatisticsWithFor()
        {
            var statisticsFor = new Statistics();
            statisticsFor.Average = 0;
            statisticsFor.Max = float.MinValue;
            statisticsFor.Min = float.MaxValue;
            for (var index = 0; index < this.grades.Count; index++)
            {
                statisticsFor.Max = Math.Max(statisticsFor.Max, this.grades[index]);
                statisticsFor.Min = Math.Min(statisticsFor.Min, this.grades[index]);
                statisticsFor.Average += this.grades[index];
            }
            statisticsFor.Average /= this.grades.Count;
            return statisticsFor;
        }
        public Statistics GetStatisticsDoWhile()
        {
            var statisticsDoWhile = new Statistics();
            statisticsDoWhile.Average = 0;
            statisticsDoWhile.Max = float.MinValue;
            statisticsDoWhile.Min = float.MaxValue;
            var index = 0;
            do
            {
                statisticsDoWhile.Max = Math.Max(statisticsDoWhile.Max, this.grades[index]);
                statisticsDoWhile.Min = Math.Min(statisticsDoWhile.Min, this.grades[index]);
                statisticsDoWhile.Average += this.grades[index];
                index++;

            } while (index < this.grades.Count);
            statisticsDoWhile.Average /= this.grades.Count;
            return statisticsDoWhile;
        }
        public Statistics GetStatisticsWhile()
        {
            var statisticsWhile = new Statistics();
            statisticsWhile.Average = 0;
            statisticsWhile.Max = float.MinValue;
            statisticsWhile.Min = float.MaxValue;
            var index = 0;
            while (index < this.grades.Count)
            {
                statisticsWhile.Max = Math.Max(statisticsWhile.Max, this.grades[index]);
                statisticsWhile.Min = Math.Min(statisticsWhile.Min, this.grades[index]);
                statisticsWhile.Average += this.grades[index];
            }
            statisticsWhile.Average /= (float)this.grades.Count;
            return GetStatisticsWhile();
        }
    }
}


      
     
    


  
        
        
        
	  

	   

	    

	    
        
        
            
            
            
            
        
            
        

         
		

			
			

			
    

			

			
        
        
            
        
        
        
         
			

		
       

			
  


             
            
            
    
    



