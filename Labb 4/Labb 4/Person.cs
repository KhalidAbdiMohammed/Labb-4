using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4
{
    public class Person
    {
        //Properties där vi lägger in olika egenskaper
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }  
        public DateTime Birthday { get; private set; }  
        public string Eyecolor { get; private set; }

        //Konstruktor används för att skapa en person med detaljerade beskrivningar
        public Person(String name, Gender gender, Hair hair, DateTime birthday, string eyeColors)

        {
            Name = name;
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            Eyecolor = eyeColors;
        }
        public string ToString() 
        {
            return $"Name: {Name}" +
            $"\nGender: {Gender}" +
            $"\nBirthday: {Birthday: yyyy/MM/dd}" +
            $"\nHair: {Hair.hairColor} and {Hair.hairLenght}" +
            $"\nEyecolor: {Eyecolor}";
        }
    }
}
