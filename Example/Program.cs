using Example2;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument musicalInstrument = new MusicalInstrument();


            musicalInstrument.InstrumentName("Piano");
            musicalInstrument.PlayAnInstrument("Piano");
            musicalInstrument.YearOfManufacture("1992");
            musicalInstrument.Special("Is a type of stringed keyboard instrument, the strings are struck with wooden hammers");

            Console.WriteLine("");

            musicalInstrument.InstrumentName("Guitar");
            musicalInstrument.PlayAnInstrument("Guitar");
            musicalInstrument.YearOfManufacture("1994");
            musicalInstrument.YearOfManufacture("Is a musical instrument with keys and strings, widely used in all types of music, and can accompany singing, ensembles or solos");
        }
    }
}
