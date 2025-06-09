namespace MusicalInstrument;

internal class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Bowed string", "Violin", 0.5, 4, "Viu-viu-viu", 
            "appeared in the 16th century in Italy, and its modern form was shaped by master luthiers Amati, Stradivari, and Guarneri. " +
            "became a key instrument in classical music and later spread to jazz, folk, and rock music",
            "a brass wind instrument with a sliding trombone, allowing for smooth pitch changes. It is used in orchestras, jazz, and marching music.");
        Trombone trombone = new Trombone("Wind instrumentg", "Trombone", 3.5, 3, "Vuooom",
            "appeared in the 15th century and was initially used in church music. " +
            "In the 17th century, it became an important instrument in classical music, and since the 20th century, it has been an integral part of jazz.",
            "bowed string musical instrument with four strings tuned in perfect fifths.");
        Cello cello = new Cello("Bowed string", "Cello", 3.5, 3, "Muuuuuu-Vau",
           "originated in the 16th century in Italy and became the primary bass instrument in classical music." +
           " Due to its expressive sound, the cello is used in film scores, rock music, and experimental genres.",
           "a string instrument with a warm and rich tone. It is used in both classical music and contemporary genres.");
        Ukulele ukulele = new Ukulele("Plucked string", "Ukulele", 2.5, 0.8, "Plim-plam",
           "appeared in the 19th century in Hawaii, inspired by Portuguese instruments. " +
           "It became a symbol of Hawaiian culture and gained recognition in modern music.",
           "a small guitar from Hawaii with a soft and bright sound. Its ease of learning has made it popular worldwide.");
        violin.Show();
        trombone.Show();
        cello.Show();
        ukulele.Show();
        Console.WriteLine();
        violin.Desc();
        trombone.Desc();
        cello.Desc();
        ukulele.Desc();
        Console.WriteLine();
        violin.Sound();
        trombone.Sound();
        cello.Sound();
        ukulele.Sound();
        Console.WriteLine();
        violin.History();
        trombone.History();
        cello.History();
        ukulele.History();
    }
}
