using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== TUGAS PEMROGRAMAN C# X RPL ===");
            Console.WriteLine("1. For\n2. While\n3. Do While\n4. Foreach\n5. Array\n6. List\n0. Keluar");
            Console.Write("Pilih jenis program: ");
            string pilih = Console.ReadLine();

            if (pilih == "0") break;

            Console.Clear();
            switch (pilih)
            {
                case "1": MenuFor(); break;
                case "2": MenuWhile(); break;
                case "3": MenuDoWhile(); break;
                case "4": MenuForeach(); break;
                case "5": MenuArray(); break;
                case "6": MenuList(); break;
                default: Console.WriteLine("Pilihan tidak tersedia."); break;
            }

            Console.WriteLine("\nTekan Enter untuk kembali ke menu utama...");
            Console.ReadLine();
        }
        Console.WriteLine("Program selesai. Terima kasih!");
    }

    static void MenuFor()
    {
        Console.WriteLine("=== FOR ===");
        Console.WriteLine("1. Angka 1-10\n2. Angka genap\n3. Perkalian 5\n4. Total angka 1-10\n5. Hitung mundur");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                for (int i = 1; i <= 10; i++) Console.WriteLine(i);
                break;
            case "2":
                for (int i = 2; i <= 20; i += 2) Console.WriteLine(i);
                break;
            case "3":
                for (int i = 1; i <= 10; i++) Console.WriteLine("5 x " + i + " = " + (5 * i));
                break;
            case "4":
                int total = 0;
                for (int i = 1; i <= 10; i++) total += i;
                Console.WriteLine("Total = " + total);
                break;
            case "5":
                for (int i = 10; i >= 1; i--) Console.WriteLine(i);
                Console.WriteLine("Mulai!");
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }

    static void MenuWhile()
    {
        Console.WriteLine("=== WHILE ===");
        Console.WriteLine("1. Angka 1-5\n2. Tabungan\n3. Energi game\n4. Angka ganjil\n5. Nyawa game");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                int i = 1;
                while (i <= 5) { Console.WriteLine(i); i++; }
                break;
            case "2":
                int uang = 0;
                while (uang < 50000) { uang += 10000; Console.WriteLine("Tabungan: " + uang); }
                break;
            case "3":
                int energi = 0;
                while (energi < 100) { energi += 20; Console.WriteLine("Energi: " + energi); }
                break;
            case "4":
                int angka = 1;
                while (angka <= 15) { Console.WriteLine(angka); angka += 2; }
                break;
            case "5":
                int nyawa = 5;
                while (nyawa > 0) { Console.WriteLine("Nyawa: " + nyawa); nyawa--; }
                Console.WriteLine("Game Over!");
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }

    static void MenuDoWhile()
    {
        Console.WriteLine("=== DO WHILE ===");
        Console.WriteLine("1. Angka 1-5\n2. Angka genap\n3. Uang jajan\n4. Level game\n5. Hitung mundur");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                int i = 1;
                do { Console.WriteLine(i); i++; } while (i <= 5);
                break;
            case "2":
                int angka = 2;
                do { Console.WriteLine(angka); angka += 2; } while (angka <= 20);
                break;
            case "3":
                int uang = 0;
                do { uang += 5000; Console.WriteLine("Uang: " + uang); } while (uang < 25000);
                break;
            case "4":
                int level = 1;
                do { Console.WriteLine("Level " + level); level++; } while (level <= 5);
                break;
            case "5":
                int waktu = 5;
                do { Console.WriteLine(waktu); waktu--; } while (waktu >= 1);
                Console.WriteLine("Selesai!");
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }

    static void MenuForeach()
    {
        Console.WriteLine("=== FOREACH ===");
        Console.WriteLine("1. Nama teman\n2. Makanan\n3. Skor game\n4. Karakter game\n5. Pelajaran");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                string[] teman = { "Andi", "Budi", "Citra", "Doni" };
                foreach (string nama in teman) Console.WriteLine(nama);
                break;
            case "2":
                string[] makanan = { "Bakso", "Sate", "Mie Ayam" };
                foreach (string menu in makanan) Console.WriteLine(menu);
                break;
            case "3":
                int[] skor = { 100, 200, 300, 400 };
                foreach (int nilai in skor) Console.WriteLine("Skor: " + nilai);
                break;
            case "4":
                string[] karakter = { "Hero", "Mage", "Assassin" };
                foreach (string hero in karakter) Console.WriteLine("Karakter: " + hero);
                break;
            case "5":
                string[] pelajaran = { "Matematika", "Bahasa Inggris", "Pemrograman", "IPA" };
                foreach (string mapel in pelajaran) Console.WriteLine(mapel);
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }

    static void MenuArray()
    {
        Console.WriteLine("=== ARRAY ===");
        Console.WriteLine("1. Daftar nama\n2. Daftar nilai\n3. Total belanja\n4. Senjata game\n5. Nilai tertinggi");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                string[] nama = { "Andi", "Budi", "Citra", "Doni" };
                for (int i = 0; i < nama.Length; i++) Console.WriteLine(nama[i]);
                break;
            case "2":
                int[] nilai = { 80, 90, 75, 85, 95 };
                for (int i = 0; i < nilai.Length; i++) Console.WriteLine("Nilai: " + nilai[i]);
                break;
            case "3":
                int[] harga = { 5000, 10000, 15000 };
                int total = 0;
                for (int i = 0; i < harga.Length; i++) total += harga[i];
                Console.WriteLine("Total belanja: " + total);
                break;
            case "4":
                string[] senjata = { "Pedang", "Busur", "Perisai" };
                for (int i = 0; i < senjata.Length; i++) Console.WriteLine("Senjata: " + senjata[i]);
                break;
            case "5":
                int[] daftarNilai = { 70, 85, 90, 65, 95 };
                int tertinggi = daftarNilai[0];
                for (int i = 1; i < daftarNilai.Length; i++)
                    if (daftarNilai[i] > tertinggi) tertinggi = daftarNilai[i];
                Console.WriteLine("Nilai tertinggi: " + tertinggi);
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }

    static void MenuList()
    {
        Console.WriteLine("=== LIST ===");
        Console.WriteLine("1. Nama teman\n2. Makanan\n3. Hapus barang\n4. Skor game\n5. Karakter game");
        Console.Write("Pilih contoh: ");
        switch (Console.ReadLine())
        {
            case "1":
                List<string> teman = new List<string> { "Andi", "Budi", "Citra" };
                foreach (string nama in teman) Console.WriteLine(nama);
                break;
            case "2":
                List<string> makanan = new List<string> { "Bakso", "Sate", "Nasi Goreng" };
                foreach (string menu in makanan) Console.WriteLine(menu);
                break;
            case "3":
                List<string> barang = new List<string> { "Buku", "Pensil", "Penghapus" };
                barang.Remove("Pensil");
                foreach (string benda in barang) Console.WriteLine(benda);
                break;
            case "4":
                List<int> skor = new List<int> { 100, 200, 300 };
                foreach (int nilai in skor) Console.WriteLine("Skor: " + nilai);
                break;
            case "5":
                List<string> karakter = new List<string> { "Hero", "Mage", "Assassin" };
                karakter.Add("Tank");
                foreach (string hero in karakter) Console.WriteLine("Karakter: " + hero);
                break;
            default: Console.WriteLine("Pilihan tidak tersedia."); break;
        }
    }
}