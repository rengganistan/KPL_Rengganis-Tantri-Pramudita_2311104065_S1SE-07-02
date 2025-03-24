class Program
{
    static void Main()
    {
        string NIM = "2311104065";

        string angka1 = NIM.Substring(0, 2); // "12"
        string angka2 = NIM.Substring(2, 2); // "34"
        string angka3 = NIM.Substring(4, 2); // "56"

        char lastDigit = NIM[NIM.Length - 1];

        switch (lastDigit)
        {
            case '1':
            case '2':
                SimpleDataBase<float> databaseFloat = new SimpleDataBase<float>();
                databaseFloat.AddNewData(float.Parse(angka1));
                databaseFloat.AddNewData(float.Parse(angka2));
                databaseFloat.AddNewData(float.Parse(angka3));
                databaseFloat.PrintAllData();
                break;

            case '3':
            case '4':
            case '5':
                SimpleDataBase<double> databaseDouble = new SimpleDataBase<double>();
                databaseDouble.AddNewData(double.Parse(angka1));
                databaseDouble.AddNewData(double.Parse(angka2));
                databaseDouble.AddNewData(double.Parse(angka3));
                databaseDouble.PrintAllData();
                break;

            case '6':
            case '7':
            case '8':
                SimpleDataBase<int> databaseInt = new SimpleDataBase<int>();
                databaseInt.AddNewData(int.Parse(angka1));
                databaseInt.AddNewData(int.Parse(angka2));
                databaseInt.AddNewData(int.Parse(angka3));
                databaseInt.PrintAllData();
                break;

            case '9':
            case '0':
                SimpleDataBase<long> databaseLong = new SimpleDataBase<long>();
                databaseLong.AddNewData(long.Parse(angka1));
                databaseLong.AddNewData(long.Parse(angka2));
                databaseLong.AddNewData(long.Parse(angka3));
                databaseLong.PrintAllData();
                break;

            default:
                Console.WriteLine("NIM tidak valid.");
                break;
        }
    }
}
