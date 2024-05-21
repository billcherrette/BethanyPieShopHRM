

using BethanyPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.PerformWork(25);

string name = "bethany";
string anotherName = name;
name += " smith";

Console.WriteLine("Name: " + name);
Console.WriteLine("Another name: " + anotherName);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

Employee testEmployee = bethany;
testEmployee.firstName = "Gill";
testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails();


bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

bethany.firstName = "John";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

string fn = bethany.firstName;

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);