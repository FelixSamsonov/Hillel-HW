
namespace Interfaces;
internal class Program
{
    static void Main(string[] args)
    {
        MyArray array = new MyArray(356, 15, 23, 53, 75, 26, 16);
        array.Show();
        array.Show("This is my array");
        Console.WriteLine(array.Max());
        Console.WriteLine(array.Min());
        Console.WriteLine(array.Avg());
        Console.WriteLine(array.Search(56));
        array.SortAsc();
        array.SortDesc();
        array.SortByParam(true);
        array.SortByParam(false);
    }
}