using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//igor060178@gmail.com Суслов Игорь

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}


namespace HW_1CS
{
    internal class Program
    {     

        static void Main(string[] args)
        {
            //Задача 1. Дан код, что выведет в консоль скомпилированная программа? Выберите правильный ответ.
            /* int a = 4;
             string b = "5";
             string c = a + b;
             Console.WriteLine(c); //Ответ 45*/

            //Задача 2. Дан код, что выведет в консоль скомпилированная программа?
            /*int a = 4;
            string b = "5";
            string c = a + b;
            Console.WriteLine("c * 2"); //Ответ с * 2 */

            //Задача 3. Приведите пример кода ToCelsius.cs, позволяющего запустить ваше приложение в консоли следующим образом "ToCelsius.exe 212" и получить вывод "212 F = 100 C".

            /*if (args.Length <= 0)
            {
                Console.WriteLine("Use: ToCelsius.exe <temperature in F>");
                return;
            }            
            double degreeFahrenheit;
            if (!double.TryParse(args[0], out degreeFahrenheit))
            {
                Console.WriteLine("Invalid input: {0}", args[0]);
                return;
            }

            double degreeCelsius = (degreeFahrenheit - 32.0) * 5.0 / 9.0;

            Console.WriteLine("{0} F = {1} C", degreeFahrenheit, degreeCelsius);*/

            //Задача 4. Перепишите, используя цикл while, следующий код.  for (int i = 0; i < 10; i++)  {Console.WriteLine(i);}
            /*int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }*/

            //Задача 5. Приведите пример кода, который спрашивает у 5 пользователей имя и возраст и по завершению выводит список пользователей по старшинству: от старших к младшим.

            /* List<Person> people = new List<Person>();
             Console.WriteLine("Enter five people: ");
             for (int i = 0; i < 5; i++)
             //Console.WriteLine("Enter a number of people: ");
             //int number = int.Parse(Console.ReadLine());
             //for (int i = 0; i < number; i++)
             {
                 Console.WriteLine("Enter name:");
                 string name = Console.ReadLine();
                 Console.WriteLine("Enter age:");
                 int age = int.Parse(Console.ReadLine());
                 Person person = new Person(name, age);
                 people.Add(person);
             }
             people.Sort((age1, age2) => age2.Age.CompareTo(age1.Age));
             Console.WriteLine("List of people:");
             foreach (Person person in people)
             {
                 Console.WriteLine($"{person.Name} - {person.Age}");
             }*/

            //Задача 6. Приведите пример кода позволяющего получить из функции 2 разных числовых значения.

            /*for (int i = (int)'0'; i <= (int)'9'; i++) 
            {
                Console.WriteLine(((char)i).ToString()+" имеет код " + i);
            }*/

            //Задача 7. Приведите пример кода спрашивающего у пользователя имя, возраст и любимое время года из списка.
            //Скомпилированная по вашему коду программа должна корректно реагировать на некорректный ввод со стороны пользователя и просить его повторить ввод,
            //если он ввёл, например, не число, когда ожидается число.

            List<Person> people = new List<Person>();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            int age=0;
            do
            {
                try
                {
                    Console.WriteLine("Enter age");
                    age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Age entered incorrectly!");                    
                }
            } while ((age <= 0) && (age > 120));
                      
            Person person = new Person(name, age);
            people.Add(person);            
            Console.WriteLine($"{person.Name} - {person.Age}");
            
            Console.WriteLine("Season:");
            List<string> season = new List<string>() { "Winter", "Spring", "Summer", "Autumn" };
            for (int i = 0; i < season.Count; i++)
            {
                Console.WriteLine(season[i]);
            }
            string mySeason;
            Console.WriteLine("Enter your favorite season:");
            mySeason = Console.ReadLine();
            Console.WriteLine($"Name {person.Name}, " + $" Age {person.Age}, " + $"Favorite season {mySeason}");
           
        }
    }
}
