# Контрольная работа №9  
**Дисциплина:** Программирование (C#)  
**Время выполнения:** 60 минут  

---

## Задание 1. Мониторинг цеха (Iterators + Yield)

Реализуйте эффективный перебор оборудования, требующего технического обслуживания.

```csharp
public class Machine
{
    public string Id { get; set; }
    public string Category { get; set; }
    public bool IsBroken { get; set; }
    public int DaysSinceLastService { get; set; }
}

public class Factory
{
    private List<Machine> _machines = new List<Machine>();

    public void AddMachine(Machine m) { ... }

    public IEnumerable<Machine> GetServiceRequired()
    {
        // Использовать yield return для возврата нужных машин
    }

    public IEnumerable<Machine> GetMachinesByCategory(string category)
    {
        // Итератор для фильтрации по категории
    }
}
```

### Требования:

1. Метод `GetServiceRequired` должен возвращать только те машины, у которых либо `IsBroken == true`, либо `DaysSinceLastService > 30`.
2. Обязательно использовать ключевое слово `yield return`.
3. Добавьте метод `GetMachinesByCategory(string category)`, который также является итератором.

В Main:
1. Создайте фабрику и добавьте 5 разных машин.
2. С помощью цикла `foreach` выведите ID всех машин, возвращаемых методом `GetServiceRequired`.
3. Убедитесь, что итератор работает лениво (элементы выбираются по одному).

---

## Задание 2. Датчик климат-контроля (Events + EventHandler)

Реализуйте систему оповещения о резких температурных скачках.

```csharp
public class TemperatureEventArgs : EventArgs
{
    public int OldTemp { get; set; }
    public int NewTemp { get; set; }
    public int Difference { get; set; }
}

public class Thermostat
{
    private int _lastTemp = 20;
    public event EventHandler<TemperatureEventArgs> SharpChangeDetected;

    public void UpdateTemperature(int newTemp) { ... }
}
```

### Требования:

1. Метод `UpdateTemperature` сравнивает текущую температуру с предыдущей.
2. Если разница (по модулю `Math.Abs`) составляет **5 градусов и более**, вызвать событие `SharpChangeDetected`.
3. В аргументах события передать старую температуру, новую и вычисленную разницу.
4. После вызова события (или если скачка нет) обновить `_lastTemp`.

В Main:
1. Создайте термостат.
2. Подпишитесь на событие.
3. В обработчике выведите: "ВНИМАНИЕ! Резкий скачок: с [Old] на [New] (разница: [Diff] град.)".
4. Имитируйте изменение температуры: 20 -> 22 -> 28.

---

## Задание 3. Парсинг конфигурации (IO + LINQ)

Дан файл настроек `settings.ini` в формате: `Key=Value`.

```ini
Volume=80
Brightness=50
Resolution=1080
Language=RU
Theme=Dark
```

### Требования:

1. Считать файл в `Dictionary<string, string>`.
2. С помощью LINQ выполнить фильтрацию:
    - Выбрать только те записи, где `Value` является числом (использовать `int.TryParse`).
    - Отсортировать по значению (от меньшего к большему).
3. Результат сохранить в `numeric_settings.txt` в формате `Key: Value`.

---

## Общие требования

- Код должен компилироваться.
- В задании 3 использовать LINQ-выражения для фильтрации словаря.
- Обрабатывать возможные ошибки доступа к файлам.

---