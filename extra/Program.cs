
/* 
 
Maak een klasse aan dat heet TypeData en maak daarin een constructor die alle properties initialiseert.
Maak properties voor de volgende data types:
 
    string
    int
    float
    double
    decimal
    bool
    char
    byte
    long
    short
    DateTime


Maak properties voor alle bovenstaande tijdsformaten en de afghandeling daar van in datatypen. 
Maak een override van de ToString() methode die alle data netjes afdrukt.
maak in de Main() methode een object aan van TypeData en druk deze af met de ToString() methode.
    
 */
namespace extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TypeData data = new TypeData(
                "Example Text",
                42,
                3.14f,
                2.71828,
                19.99m,
                true,
                'A',
                255,
                12345678901234,
                32000,
                DateTime.Now
            );  
        }
    }
    public class TypeData
    {
        public string Text { get; set; }
        public int Number { get; set; }
        public float FloatNumber { get; set; }
        public double DoubleNumber { get; set; }
        public decimal DecimalNumber { get; set; }
        public bool IsTrue { get; set; }
        public char Character { get; set; }
        public byte ByteValue { get; set; }
        public long LongNumber { get; set; }
        public short ShortNumber { get; set; }
        public DateTime Date { get; set; }
        public TypeData(string text, int number, float floatNumber, double doubleNumber, decimal decimalNumber,
                        bool isTrue, char character, byte byteValue, long longNumber, short shortNumber, DateTime date)
        {
            Text = text;
            Number = number;
            FloatNumber = floatNumber;
            DoubleNumber = doubleNumber;
            DecimalNumber = decimalNumber;
            IsTrue = isTrue;
            Character = character;
            ByteValue = byteValue;
            LongNumber = longNumber;
            ShortNumber = shortNumber;
            Date = date;
        }
        public override string ToString()
        {
            return $"String: {Text}\n" +
                   $"Int: {Number}\n" +
                   $"Float: {FloatNumber}\n" +
                   $"Double: {DoubleNumber}\n" +
                   $"Decimal: {DecimalNumber}\n" +
                   $"Bool: {IsTrue}\n" +
                   $"Char: {Character}\n" +
                   $"Byte: {ByteValue}\n" +
                   $"Long: {LongNumber}\n" +
                   $"Short: {ShortNumber}\n" +
                   $"DateTime: {Date}";
        }
    }
}
