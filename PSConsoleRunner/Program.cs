using System.Management.Automation;

Console.WriteLine("Test PowerShell Runner!");

var psInstance = PowerShell.Create();

psInstance.AddScript("Get-Host");
//psInstance.AddCommand("Get-Host");

Console.WriteLine("Before Invoke.");
var returnObj = psInstance.Invoke();
Console.WriteLine("After Invoke.");

Console.WriteLine("Name: " + returnObj.First().Members.First().Value);

psInstance.Runspace?.Close();

Console.WriteLine("Was successful run");

