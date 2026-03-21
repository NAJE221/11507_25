LQ1<int> lq1 = new(new int[] {1,2,3,4,5}, 3);
Console.WriteLine("Первый номер");
foreach (var item in lq1.result)
{
    Console.Write(item + " ");
}
Lq3 lq3 = new();
List<string> listString = new()
{
    "123",
    "112233",
    "adcs",
    "popopo",
    "pqio"
};
Console.WriteLine("\nТретий номер");
foreach (var result in lq3.GetValidString(listString))
{
    Console.WriteLine(result);
}