using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define a Dictionary that contains information about several members of your family.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("Wife", new Dictionary<string, string>(){ 
                {"name", "Lorie"},
                {"age", "49"}
            });
            myFamily.Add("Mother", new Dictionary<string, string>(){
                {"name", "Juanita"},
                {"age", "77"}
            });
            myFamily.Add("Father", new Dictionary<string, string>(){
                {"name", "Edgar"},
                {"age", "79"}
            });
             myFamily.Add("Sister", new Dictionary<string, string>(){
                {"name", "Liz"},
                {"age", "61"}
             });               
             myFamily.Add("Brother-in-Law", new Dictionary<string, string>(){
                {"name", "Jon"},
                {"age", "61"}
             });
             myFamily.Add("Sister2", new Dictionary<string, string>(){
                {"name", "Patricia"},
                {"age", "59"}
             });
            myFamily.Add("Nephew", new Dictionary<string, string>(){
                {"name", "Charles"},
                {"age", "35"}
             });
             myFamily.Add("his wife", new Dictionary<string, string>(){
                {"name", "Tonya"},
                {"age", "35"}
             });
             myFamily.Add("Nephew2", new Dictionary<string, string>(){
                {"name", "Joshua"},
                {"age", "32"}
             });
             myFamily.Add("his wife 2", new Dictionary<string, string>(){
                {"name", "Monica"},
                {"age", "31"}
             });                          
             foreach (var entry in myFamily)
             {
                 Console.WriteLine ($"{entry.Value["name"]} is my {entry.Key} and is {entry.Value["age"]} years old.");
             } 
            // Console.WriteLine("Hello World!");
        }
    }
}
