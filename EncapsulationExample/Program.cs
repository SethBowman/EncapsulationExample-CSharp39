using EncapsulationExample;


var seth = new Person();

var myWallet = seth.CheckWallet();

Console.WriteLine("Money in wallet:");
Console.WriteLine(myWallet);

Console.WriteLine("Adding money..");
seth.AddMoney(1000.00);

var newWallet = seth.CheckWallet();
Console.WriteLine(newWallet);

