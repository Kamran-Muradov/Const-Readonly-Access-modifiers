
namespace Const_Readonly_Access_modifiers.Models
{
    internal class Car
    {
        private string name;
        public string color;
        protected int speed = 900;

        private Car()
        {
            Console.WriteLine("Reshad bey bu da sizin ucun private constructor");
        }

        public Car(int a) : this()
        {

        }
    }
}
