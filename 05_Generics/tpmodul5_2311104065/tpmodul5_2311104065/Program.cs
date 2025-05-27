class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Dian");

        DataGeneric<string> data = new DataGeneric<string>("2311104065");
        data.PrintData();
    }
}
