namespace Labb_4
{
    internal class Program
    {
        // En lista för att lagra personobjekt
        public static List<Person> listPerson = new List<Person> ();
        static void Main(string[] args)
        {
            bool exitIt = true;
            int userSelector = 0;
            // Huvudloopen för programmet
            while (exitIt == true) 
            {
                try
                {

                    // Visa användaren olika alternativ
                    Console.WriteLine(
                        "Choose one of the options: " +
                        "\n1.) Add a person" +
                        "\n2.) Show all the people" +
                        "\n3.) Exit");

                    // Läsa användarens val
                    userSelector = int.Parse (Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }

                // Hantera användarens val
                switch (userSelector)
                {
                    case 1:
                        addPerson();
                        break;

                    case 2:
                        if (listPerson == null || listPerson.Count == 0) 
                        {
                            Console.WriteLine("unfortunately, there are no registered people. Please try again");
                        }
                        else 
                        {
                            ListPersons();
                        }

                        break;
                    case 3:
                        exitIt = false;
                        break;

                    default:
                        Console.WriteLine("You need to type a number between 1-3\n");
                        break;
                
                }
            }
        }
        static void addPerson() 
        {
            Hair hair = new Hair { };
            DateTime userDate = DateTime.Today;
            bool wrongInput = true;
            int hairChoice = 0;
            string eyeColors = " ";

            int userChoice = 1;
            Console.WriteLine("What is the person's name?");
            String name = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("What is the person's gender, Type one of the existing numbers \n1.woman \n2.Man \n3.Nonbinary \n4.Other");
                    bool parse;
                    parse = int.TryParse(Console.ReadLine(), out userChoice);

                    if (parse == false || userChoice == 0 || userChoice < 0 || userChoice > 4)
                    {
                        Console.WriteLine("Please, write a number between 1-4");
                        wrongInput = false;
                    }
                    else
                    {
                        wrongInput = true;
                    }
                }
                catch
                {
                    wrongInput = true;
                }
            }

            while (wrongInput == false);

            //Använd en do/while-loop för att säkerställa att användaren skriver in ett giltigt datumformat
            bool wrongDate = false;
            do 
            {
                //kod där undantaget kan inträffar
                try 
                {
                    Console.WriteLine("When is the persons birthday, write in YYYY-MM-DD format");
                    userDate = DateTime.Parse(Console.ReadLine());
                    wrongDate = false;   
                }

                //hanterar undantaget
                catch
                {
                    Console.WriteLine("Note! Write with numbers only and don't forget hyphens in between.");
                    wrongDate = true;

                }
            }  
            while (wrongDate == true);
            Gender userGender = Gender.Woman;
            switch (userChoice)
            {
                case 1:
                    userGender = Gender.Woman;
                    break;
                case 2:
                    userGender = Gender.Man;
                    break;
                case 3:
                    userGender = Gender.Nonbinary;
                    break;
                case 4:
                    userGender = Gender.Other;
                    break;
            
            }

            // Använd do/while-loopar för att hantera felaktig inmatning för hårfärg, hårlängd och ögonfärg
            bool wrongHair = false;
            do
            {
                try
                {
                    Console.WriteLine("what is the person's haircolor?");
                    hair.hairColor = Console.ReadLine();
                    wrongHair = false;  
                    if (hair.hairColor.All(Char.IsDigit))
                    {
                        throw new Exception();                    
                    }
                }
                catch
                {
                    Console.WriteLine("Note! Please write a color instead");
                    wrongHair = true;   
                }
            }

            while(wrongHair == true);

            bool userhairWrong;
            do
            {


                Console.WriteLine("what is the person's hair lenght?");
                hair.hairLenght = Console.ReadLine();
                userhairWrong = false;
       
            
            }
            while (userhairWrong == true);

            bool wrongeyes;
            do
            {
                try
                {
                    Console.WriteLine("what is the person's eye colors");
                    eyeColors = Console.ReadLine();
                    wrongeyes = false;
                    if (eyeColors.All(char.IsDigit))

                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Note! Please write in letters instead");
                    wrongeyes = true;
                }
            }
            while (wrongeyes == true);

            Person person = new Person(name,userGender,hair,userDate,eyeColors);
            listPerson.Add (person);
        }

        // // Används för att visa data om personerna som vi har i listan på konsolen
        static void ListPersons()
        {
            foreach (Person person in listPerson)
            {
                Console.WriteLine(person.ToString() + "\n");
            }
        }
    }
}