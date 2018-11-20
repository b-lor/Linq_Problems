using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems

{
    class Program
    {

        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            //var wordsWithTHFromList = words.Where(w => w.Contains("th")).ToList();
            //foreach (var searchIndexForTH in wordsWithTHFromList)
            //{
            //    Console.WriteLine(searchIndexForTH);
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var noDuplicateName = names.ToList();
            //foreach (string n in noDuplicateName.Distinct())
            //    Console.WriteLine(n);
            //Console.ReadLine();

            //List<string> classGrades = new List<string>()
            //{
            //"80,100,92,89,65",
            //"93,81,78,84,69",
            //"73,88,83,99,64",
            //"98,100,66,74,55"
            //};

            //var gradeAverage = classGrades.ToList();
            //List<int> studentGrade = new List<int>();
            //double studentGradeAverage = 0;
            //foreach (var result in gradeAverage)
            //{
            //    studentGrade = result.Split(',').Select(m => int.Parse(m)).ToList();
            //    //Console.WriteLine(result);
            //    var studentAverage = studentGrade.Where(x => x != studentGrade.Min()).Average();
            //    studentGradeAverage += studentAverage;
            //}
            //Console.WriteLine("Class Average is: " + studentGradeAverage / 4);
            //Console.ReadLine();


            var frequency = from f in "terrill"
                            group f by f into letterfrequency
                            orderby letterfrequency.Key
                            select new
                            {
                                Letter = letterfrequency.Key,
                                Frequency = letterfrequency.Count()
                            };

            foreach (var f in frequency)
            {
                Console.WriteLine($"{f.Letter}{f.Frequency}");
            }

            Console.ReadLine();

        }
    }
}
