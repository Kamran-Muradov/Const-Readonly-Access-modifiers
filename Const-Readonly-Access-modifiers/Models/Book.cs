
namespace Const_Readonly_Access_modifiers.Models
{
    internal class Book : BaseEntity
    {
        public const string title = "Bashliq";
        //public readonly string author = "salam";
        public readonly string author;

        public Book()
        {
            author = "sagol";
        }
    }
}
