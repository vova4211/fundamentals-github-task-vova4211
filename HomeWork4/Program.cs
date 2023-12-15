namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Person person = new Person();
            person.Output();

            Person[] people = new Person[6];

            for(int i = 0; i < people.Length; i++)
            {
                people[i] = Person.Input(i);
            }

            for (int i = 0;i < people.Length; i++)
            {
                people[i].Output();
            }

            for (int i = 0; i < people.Length; i++)
            {

                Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age()}");
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            for(int i = 0; i < people.Length; i++)
            {
                people[i].Output();
            }

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"{people[i]} and {people[j]}  same name");
                    }
                   
                }
            }









        }
    }
}