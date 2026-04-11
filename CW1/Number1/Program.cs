using CW1;


// Вызов первого задания
Factory newFactory = new Factory();
Machine machine1 = new("100", "camaz", true, 100);
Machine machine2 = new("111", "traktor", true, 45);
Machine machine3 = new("120", "traktor", true, 150);
Machine machine4 = new("123", "traktor", true, 155);
Machine machine5 = new("127", "traktor", true, 156);


newFactory.AddMachine(machine1);
newFactory.AddMachine(machine2);
newFactory.AddMachine(machine3);
newFactory.AddMachine(machine4);
newFactory.AddMachine(machine5);

foreach (var machine in newFactory.GetServiceRequired())
{
    Console.WriteLine(machine.Id);
}