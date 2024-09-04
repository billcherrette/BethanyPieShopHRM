

using BethanyPieShopHRM;
using BethanyPieShopHRM.HR;
using BethanysPieShopHRM.Accounting;
using System.Text;

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

Console.WriteLine("How many hours do we need to register for Bethany?");
int numberOfHours = 0;
string input = Console.ReadLine();
numberOfHours = int.Parse(input);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(numberOfHours);

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");
/*
IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);



List<IEmployee> employees = new List<IEmployee>();   
employees.Add(bethany);
employees.Add(bobJunior);
employees.Add(mary);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    employee.GiveCompliment();
}
/*
bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();

mary.DisplayEmployeeDetails();
mary.PerformWork(20);
mary.PerformWork();
mary.PerformWork();
mary.ReceiveWage();
mary.AttendManagementMeeting();

bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);*/

//bethany.FirstName = "John";
//string fn = bethany.FirstName;

//var wage = bethany.Wage;

//int[] sampleArray1 = new int[5];

//int[] sampleArray2 = new int[] {1, 2, 3, 4, 5 };
////int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5 };

//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[length];

//var testId = employeeIds[0];
////var errorId = employeeIds[length];

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());//let's assume here that the user will always enter an int value
//    employeeIds[i] = id;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Array.Sort(employeeIds);

//Console.WriteLine("After sorting");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//int[] employeeIdsCopy = new int[length];

//employeeIds.CopyTo(employeeIdsCopy, 0);

//Console.WriteLine("After copying");
//for (int i = 0; i < employeeIdsCopy.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");
//}

//Array.Reverse(employeeIds);
//Console.WriteLine("After reversing");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}


//List<int> employeeIds = new List<int>();

//employeeIds.Add(55);
//employeeIds.Add(1);
//employeeIds.Add(946);
//employeeIds.Add(78);
//employeeIds.Add(79);

//if(employeeIds.Contains(78))
//{
//    Console.WriteLine("78 is found!");
//}

//int currentAmountOfEmployees = employeeIds.Count;

//var employeeIdsArray = employeeIds.ToArray();

//employeeIds.Clear();

//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());//let's assume here that the user will always enter an int value
//    employeeIds.Add(id);
//}

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
//Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

//List<Employee> employees = new List<Employee>();
//employees.Add(george);
//employees.Insert(0, bethany);
//employees.Add(mary);
//employees.Add(bobJunior);
//employees.Add(kevin);
//employees.Add(kate);
//employees.Add(kim); 

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//}

//Employee[] employees = new Employee[7];
//employees[0] = bethany;
//employees[1] = george;
//employees[2] = mary;
//employees[3] = bobJunior;
//employees[4] = kevin;  
//employees[5] = kate;
//employees[6] = kim;

//foreach(Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}



//bethany.CalculateWage();

//Account account = new Account("12345");


//List<Employee> employees = new List<Employee>();
//for (int i = 0; i < 10000000; i++)
//{
//    Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), null, EmployeeType.StoreManager);
//    employees.Add(randomEmployee);
//}

//employees.Clear();
//employees = null;

//GC.Collect();

//Console.ReadLine();

//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();

//#region First run Bethany
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.ReceiveWage();
//bethany.DisplayEmployeeDetails();
//#endregion

//#region First run George
//george.PerformWork(10);
//george.PerformWork();
//george.PerformWork();
//george.PerformWork();
//george.ReceiveWage();
//george.DisplayEmployeeDetails();
//#endregion

//Employee.taxRate = 0.02;

//#region Second run Bethany
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.ReceiveWage();
//bethany.DisplayEmployeeDetails();
//#endregion

//#region Second run George
//george.PerformWork(10);
//george.PerformWork();
//george.PerformWork();
//george.PerformWork();
//george.ReceiveWage();
//george.DisplayEmployeeDetails();
//#endregion

//Employee.DisplayTaxRate();

//bethany.firstName = "john";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//string fn = bethany.firstName;

//double receivedwagebethany = bethany.ReceiveWage(true);
//Console.WriteLine($"wage paid (message from program): {receivedwagebethany}");

//Console.WriteLine("creating an employee");
//Console.WriteLine("--------------------\n");

//Employee george = new("george", "jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork(8);

//var receivedwagegeorge = george.ReceiveWage(true);

//BethanysPieShopHRM.Accounting.Customer customer = new BethanysPieShopHRM.Accounting.Customer();

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3;
//task.PerformWorkTask();

//string bethanyAsJson = bethany.ConvertToJson();
//Console.WriteLine(bethanyAsJson);

//bethany.PerformWork(25);

//string name = "bethany";
//string anotherName = name;
//name += " smith";

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Another name: " + anotherName);

//string upperCaseName = name.ToUpper();

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Uppercase name: " + upperCaseName);

//string firstName = "Bethany";
//string lastName = "Smith";

//StringBuilder builder = new StringBuilder();

//builder.Append("Last name: ");
//builder.Append(lastName);
//builder.Append("First name: ");
//builder.Append(firstName);
//string result = builder.ToString();

//StringBuilder builder2 = new StringBuilder();

//for (int i = 0; i < 2500; i++)
//{
//    builder2.Append(i);
//    builder2.Append(" ");
//}
//string list = builder2.ToString();

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus = 100;
//int bonusTax;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

//Employee testEmployee = bethany;
//testEmployee.firstName = "Gill";
//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();


