using CW2;

var inventar = new InventoryManager(10);

var weapon = new Weapon("Ядерка", 2.0, 10);
inventar.TryAddItem(weapon);
inventar.UseItem(0, null);

var armor = new Armor("Броня 2", 3, 5, 10, 8);
inventar.TryAddItem(armor);
inventar.UseItem(1, 9);

var potion = new Potion("Зелье здоровья", 5, 10);
inventar.TryAddItem(potion);
inventar.UseItem(2, null);