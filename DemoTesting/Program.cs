using DemoTesting.BLL.Services;

// Application client (Interface graphique)
string today = new DemoService().GetTodayDate();
Console.WriteLine(today);