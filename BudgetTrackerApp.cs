// In some areas unnecessary code has been added to showcase my learning progression in C#. 

// 1. User inputs total monthly income
Console.WriteLine("Please input your total monthly income:");
double monthlyIncome;
while (!double.TryParse(Console.ReadLine(), out monthlyIncome))
{
    Console.WriteLine("Invalid input. Please write a number:");
}
    Console.WriteLine("Monthly income: £" + monthlyIncome);

// 2.a Groceries budget
Console.WriteLine("Please input your monthly budgets for the below:");
Console.WriteLine("Groceries budget:");
double groceryBudget;
while (!double.TryParse(Console.ReadLine(), out groceryBudget))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Grocery budget: £" + groceryBudget);

// 2.b Entertainment budget
Console.WriteLine("Entertainment budget:");
double entertainmentBudget;
while (!double.TryParse(Console.ReadLine(), out entertainmentBudget))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Entertainment budget: £" + entertainmentBudget);

// 2.c Rent budget
Console.WriteLine("Rent budget:");
double rentBudget;
while (!double.TryParse(Console.ReadLine(), out rentBudget))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Rent budget: £" + rentBudget);

// 2.d Electricity budget
Console.WriteLine("Electricity budget:");
double electricityBudget;
while (!double.TryParse(Console.ReadLine(), out electricityBudget))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Electricity budget: £" + electricityBudget);

// 2.e Water budget
Console.WriteLine("Water budget:");
double waterBudget;
while (!double.TryParse(Console.ReadLine(), out waterBudget))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Water budget: £" + waterBudget);

//3.a. Compare monthly income to budget total 
double totalBudget = groceryBudget + entertainmentBudget + rentBudget + electricityBudget + waterBudget;
Console.WriteLine("Total budget is: £" + totalBudget);

double remainingAllowance = monthlyIncome - totalBudget;

if (totalBudget <= monthlyIncome)
{
    Console.WriteLine("The budget is affordable with this monthly income. Remaining is: £" + remainingAllowance);
}
else
{
    Console.WriteLine("The budget exceeds the monthly income" + remainingAllowance);
}

// 4.a. Groceries spent
Console.WriteLine("Please input your money spent on groceries this month:");
double grocerySpent;
while (!double.TryParse(Console.ReadLine(), out grocerySpent))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Your groceries outgoings are: £" + grocerySpent);

// 4.b. Entertainment spent
Console.WriteLine("Please input your money spent on entertainment this month:");
double entertainmentSpent;
while (!double.TryParse(Console.ReadLine(), out entertainmentSpent))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Your entertainment outgoings are: £" + entertainmentSpent);

// 4.c. Electricity spent
Console.WriteLine("Please input your money spent on electricity this month:");
double electricitySpent;
while (!double.TryParse(Console.ReadLine(), out electricitySpent))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Your electricity outgoings are: £" + electricitySpent);

// 4.d. Water spent
Console.WriteLine("Please input your money spent on water this month:");
double waterSpent;
while (!double.TryParse(Console.ReadLine(), out waterSpent))
{
    Console.WriteLine("Invalid input. Please enter a number:");
}
Console.WriteLine("Your water outgoings are: £" + waterSpent);

//5.a. if statement for whether groceries outgoings have exeeded budget
double groceryDifference = grocerySpent - groceryBudget;

if (groceryDifference > 30)
{
    Console.WriteLine("Groceries: You are very over budget!");
}
else if (groceryDifference > 0)
{
    Console.WriteLine("Groceries: You are over budget");
}
else if (groceryDifference >= -10)
{
    Console.WriteLine("Groceries: You are within the budget");
}
else
{
    Console.WriteLine("Groceries: You are very under budget!");
}

//5.b. if statement for whether entertainment outgoings have exeeded budget
double entertainmentDifference = entertainmentSpent - entertainmentBudget;

if (entertainmentDifference > 30)
{
    Console.WriteLine("Entertainment: You are very over budget!");
}
else if (entertainmentDifference > 0)
{
    Console.WriteLine("Entertainment: You are over budget");
}
else if (entertainmentDifference >= -10)
{
    Console.WriteLine("Entertainment: You are within the budget");
}
else
{
    Console.WriteLine("Entertainment: You are very under budget!");
}

//5.c. if statement for whether electricity outgoings have exeeded budget
    double electricityDifference = electricitySpent - electricityBudget;

if (electricityDifference > 30)
{
    Console.WriteLine("Electricity: You are very over budget!");
}
else if (electricityDifference > 0)
{
    Console.WriteLine("Electricity: You are over budget");
}
else if (electricityDifference >= -10)
{
    Console.WriteLine("Electricity: You are within the budget");
}
else
{
    Console.WriteLine("Electricity: You are very under budget!");
}

//5.d. if statement for whether water outgoings have exeeded budget
    double waterDifference = waterSpent - waterBudget;

if (waterDifference > 30)
{
    Console.WriteLine("Water: You are very over budget!");
}
else if (waterDifference > 0)
{
    Console.WriteLine("Water: You are over budget");
}
else if (waterDifference >= -10)
{
    Console.WriteLine("Water: You are within the budget");
}
else
{
    Console.WriteLine("Water: You are very under budget!");
}

//Combine fixed expenses into a list (to edit)
// List<double> fixedExpenses = new List<double> { 250.00, 75.00, 40.00 };
// Console.WriteLine("Fixed expenses: ");
// Console.WriteLine("Rent = £" + fixedExpenses[0]);
// Console.WriteLine("Electricity = £" + fixedExpenses[1]);
// Console.WriteLine("Water = £" + fixedExpenses[2]);

//Add expenses to list
// fixedExpenses.Add(1000.00);
// fixedExpenses.Add(35.00);
// Console.WriteLine("House refurbishments = £" + fixedExpenses[3]);
// Console.WriteLine("Internet = £" + fixedExpenses[4]);



    