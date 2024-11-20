namespace SorterLiczb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SorterLiczb sorter = new SorterLiczb();

            sorter.ReadData();
            sorter.ProcessData();
            sorter.ShowResults();

            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
