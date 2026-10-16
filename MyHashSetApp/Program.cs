namespace MyHashSetApp;

class Program
{
    static void Main(string[] args)
    {
        MyHashSet<Lehrperson> set = new MyHashSet<Lehrperson>();
        MyHashSet<int> set2 = new MyHashSet<int>();

        // TODO 1) Datei-Einlesen: lehrpersonen.txt mit using und StreamReader einlesen.
        // Kopfzeile, Kommentarzeilen (#), falsche Zeilen und leere Zeilen überspringen.
        // Jede eingelesene Lehrperson mit Add in das Set einfügen (siehe Angabe: File I/O).
        // Vorerst 3 fixe Lehrpersonen zum Testen der Grundfunktionen:
        Lehrperson anna = new Lehrperson("Anna", "Huber", new DateTime(1980, 3, 12), Unterrichtsfach.Informatik, 18);
        Lehrperson anna2 = new Lehrperson("Anna", "Petrovic", new DateTime(1977, 5, 4), Unterrichtsfach.Informatik, 18);
        Lehrperson jose = new Lehrperson("José", "Rojas", new DateTime(1975, 11, 5), Unterrichtsfach.Mathematik, 20);
        Lehrperson shirin = new Lehrperson("Shirin", "Karimi", new DateTime(1990, 7, 23), Unterrichtsfach.Deutsch, 22);

        set.Add(anna);
        set.Add(anna2);
        set.Add(jose);
        set.Add(shirin);

        set2.Add(2);
        set2.Add(4);
        set2.Add(9)

        Console.WriteLine($"\nCount: {set.Count}, Capacity: {set.Capacity}");
        Console.WriteLine(set); // ToString: alle Slots, Index 0 zuerst
        
    }
}
