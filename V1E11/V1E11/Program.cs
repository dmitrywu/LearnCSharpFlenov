using TestProject;

//IMoneyManagement o = new Wife();
IMoneyManagement  o = new Bmw320d(10, 10, 10, 10);
o.Add(10);
o.Spend(5);


IDisposable d = new Bmw320d(10,10,10,10);
d.Dispose();