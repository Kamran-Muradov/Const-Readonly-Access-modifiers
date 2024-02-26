using Const_Readonly_Access_modifiers.Models;

namespace Const_Readonly_Access_modifiers.Services
{
    internal class EmployeeService : Employee
    {
        public Employee[] GetAll()
        {
            Employee employe1 = new()
            {
                id = 1,
                name = "Employe1",
                surname = "Employev1",
                address = "Baki1",
                email = "employe1@gmail.com",
                age = 18
            };
            Employee employe2 = new()
            {
                id = 2,
                name = "Employe2",
                surname = "Employev2",
                address = "Baki2",
                email = "employe2@gmail.com",
                age = 19
            };
            Employee employe3 = new()
            {
                id = 3,
                name = "Employe3",
                surname = "Employev3",
                address = "Baki3",
                email = "employe3@gmail.com",
                age = 54
            };
            Employee employe4 = new()
            {
                id = 4,
                name = "Employe4",
                surname = "Employev4",
                address = "Baki4",
                email = "employe4@gmail.com",
                age = 67
            };
            Employee employe5 = new()
            {
                id = 5,
                name = "Employe5",
                surname = "Employev5",
                address = "Baki5",
                email = "tploye5@gmail.com",
                age = 23
            };
            Employee employe6 = new()
            {
                id = 6,
                name = "Employe6",
                surname = "Employev6",
                address = "Baki6",
                email = "employe6@gmail.com",
                age = 13
            };
            Employee employe7 = new()
            {
                id = 7,
                name = "Employe7",
                surname = "Employev7",
                address = "Baki7",
                email = "ttmploye7@gmail.com",
                age = 42
            };

            Employee[] employers = { employe1, employe2, employe3, employe4, employe5, employe6, employe7 };
            return employers;
        }

        public Employee[] GetAllByAge(Employee[] employees, int age)
        {
            //var result = GetAll();
            return employees.Where(m => m.age > age).ToArray();
        }

        public int GetCountByAge(Employee[] employees, int firstAge, int lastAge)
        {
            return employees.Where(m => m.age > firstAge && m.age < lastAge).Count();
        }

        public int SumOfAges(Employee[] employees)
        {
            return employees.Sum(m => m.age);
        }

        public Employee[] GetAllByCheckedEmail(Employee[] employees, string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();
        }
    }
}
