

using System;
using modul7_kelompol7;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== Deserialisasi Data Mahasiswa ==========");
        var dataMahasiswa = new DataMahasiswa2311104065();
        dataMahasiswa.ReadJSON();

        Console.WriteLine("\n========== Deserialisasi Team Members ==========");
        var teamMembers = new TeamMembers2311104065();
        teamMembers.ReadJSON();

        Console.WriteLine("\n========== Deserialisasi Glossary Item ==========");
        var glossaryItem = new GlossaryItem2311104065();
        glossaryItem.ReadJSON();
        Console.ReadLine();
    }
}
