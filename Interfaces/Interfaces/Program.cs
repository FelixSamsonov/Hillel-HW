
namespace Interfaces;
internal class Program
{
    static void Main(string[] args)
    {
        MyArray array = new MyArray(356, 15, 23);
        array.Show();
        array.Show("My first array");
    }
}