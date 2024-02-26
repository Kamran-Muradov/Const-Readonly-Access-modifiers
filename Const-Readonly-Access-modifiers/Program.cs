using Const_Readonly_Access_modifiers;
using Const_Readonly_Access_modifiers.Controllers;
using Const_Readonly_Access_modifiers.Models;
using Const_Readonly_Access_modifiers.Services;

CustomMath calculate = new();

//var result = calculate.GetSumOfArrayItems(new int[] { 1, 3, 4, 5, 6, 7 });

//Console.WriteLine(result);

//var result = calculate.CheckNumber(5);

//Console.WriteLine(result);

//Console.WriteLine(calculate.SquareOfEvenNumbers(new int[] { 1, 3, 4, 5, 6, 7 }));

//var result = calculate.MultipleOfNumbers(5);

//Console.WriteLine(result);


//EmployeeService employeeService = new EmployeeService();

//var result = employeeService.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item.name);
//}

EmployeeController employeeController = new();

//employeeController.GetAll();

//employeeController.GetAllByAge();

//employeeController.GetCountByAge();

//employeeController.GetAllByCheckedEmail();

//string email = "reshad@gmail.com";

////Console.WriteLine(email.Contains("g"));

//int index = email.IndexOf("@");

//string result = email.Substring(0, index);

//Console.WriteLine(result.Contains("g"));

//Console.WriteLine(Book.title);

//Book book = new();
//Console.WriteLine(book.author);


//Car car = new Car();


Test test = new();

//Car car = new Car(100);

Console.WriteLine(test.bestSpeed);

