using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace LING {
    public class ProgramLogic {
        static void Main(string[] args) {
            PeopleData[] people;
            var fileContent = File.ReadAllText("people.json");
            people = JsonSerializer.Deserialize<PeopleData[]>(fileContent);
            //foreach (var item in people) {
            //    Console.WriteLine(item.last_name);  //lastname..job..language.. etc.. etc..
            //}

            //var orderedByLastName = people.OrderBy(person => person.last_name).ToList();
            //foreach (var person in orderedByLastName) { Console.WriteLine(person.first_name + " " + person.last_name); }

            //Console.WriteLine();

            //var orderedByLanguageDesc = people.OrderByDescending(person => person.language).ToList();
            //foreach (var person in orderedByLanguageDesc)
            //    Console.WriteLine(person.last_name + " " + person.language);

            //Console.WriteLine();

            //var ages = people.Select(person => new { person.last_name, person.date_of_birth }).Select(person => $"{person.last_name} {(DateTime.Today - Convert.ToDateTime(person.date_of_birth)).Days / 365}").ToList();
            //foreach (var person in ages) {
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine();

            //var ages2 = people.Select(person => new { person.last_name, Age = (DateTime.Today - Convert.ToDateTime(person.date_of_birth)).Days / 365 }).Select(personWithDate => $"{personWithDate.last_name} {personWithDate.Age}").ToList();
            //foreach(var item in ages2) {
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            

            //var startsWithBe = people.Where(person => person.last_name.StartsWith("Be")).ToList();
            //foreach (var person in startsWithBe) {
            //    Console.WriteLine(person.last_name);
            //}+6

            //Console.WriteLine();

            //LastNameContains(people,"th");

        }

        public static List<PeopleData> GetPeopleOfSpecialLanguage(PeopleData[] people, string language) {
            return people.Where(person => person.language == language).ToList();    
         
        }

        public static string[] GetLanguages(PeopleData[] people) {
            return people.Select(person => person.language).Distinct().OrderBy(lang => lang).ToArray();
        }

        public static List<PeopleData> LastNameContains(PeopleData[] people, string myString) {
            return people.Where(person => person.last_name.Contains(myString)).OrderBy(person => person.last_name).ToList();
            
            //foreach (var person in containsTh) {
            //    Console.WriteLine(person.last_name);
            //}

        }
    }
}
