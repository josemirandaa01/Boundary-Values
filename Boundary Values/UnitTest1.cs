using NUnit.Framework;
using ClassLibrary1;

namespace Boundary_Values
{
    public class Tests
    {

        [Test]
        public void name()
        {
            string value = "Jose";
            string result = Class1.nombre(value);
            string expected = "Jose";

            Assert.AreEqual(result, expected);
        }

        public void lastName()
        {
            string value = "Miranda";
            string result = Class1.Apellido(value);
            string expected = "Miranda";

            Assert.AreEqual(result, expected);

        }

        public void age()
        {

            int value = 20;
            int result = Class1.Edad(value);
            int expected = 20;

            Assert.AreEqual(result, expected);

        }
    }
}