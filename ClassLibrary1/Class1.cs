using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string nombre(string name)
        {

            char[] charName = name.ToCharArray();

            if (charName[0] == null || charName[1] == null)
            {
                return "error";
            }

            if (charName[63] == null)
            {
                return "error";
            }

            return name;
        }

        public static string Apellido(string lastName)
        {

            char[] charLastName = lastName.ToCharArray();

            if (charLastName[0] == null || charLastName[1] == null)
            {
                return "error";
            }

            if (charLastName[63] == null)
            {
                return "error";
            }

            return lastName;
        }

        public static int Edad(int age)
        {
            if (age < 18 || age > 120)
            {
                return 0;
            }

            return age;

        }
    }
}
