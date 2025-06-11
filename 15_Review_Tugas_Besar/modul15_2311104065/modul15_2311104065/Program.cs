class Program
{
    static void Main()
    {
        AuthService auth = new AuthService();

        while (true)
        {
            Console.WriteLine("1. Registrasi");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Username: ");
                    string regUser = Console.ReadLine();
                    Console.Write("Password: ");
                    string regPass = Console.ReadLine();
                    if (auth.Register(regUser, regPass))
                        Console.WriteLine("Registrasi berhasil!");
                    break;

                case "2":
                    Console.Write("Username: ");
                    string logUser = Console.ReadLine();
                    Console.Write("Password: ");
                    string logPass = Console.ReadLine();
                    if (auth.Login(logUser, logPass))
                        Console.WriteLine("Login berhasil!");
                    else
                        Console.WriteLine("Login gagal!");
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
