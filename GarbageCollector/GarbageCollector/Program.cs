namespace GarbageCollector;

internal class Program
{
    static void Main(string[] args)
    {
        Play play = new Play("Natalka Poltavka", "Ivan Kotlyarevsky", Enum.Genre.Vaudeville, 1819);
        play.ShowInfo();
        play.Dispose();
        Store store = new Store("Busy", "Vygovskogo 55", Enum.TypeOfStore.Household);
        store.InfoAboutStore();
        store.Dispose();
    }
}
