using System;
using System.Text;
using System.Threading.Tasks;
 
namespace kalkulator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Masukkan angka pertama:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Pilih dari pilihan perhitungan di bawah ini:");
                 Console.WriteLine("\t+ - Pertambahan");
                 Console.WriteLine("\t- - Pengurangan");
                 Console.WriteLine("\t* - Perkalian");
                 Console.WriteLine("\t/ - Pembagian");
    
                switch (Console.ReadLine())
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Hasil Dari penjumlahan adalah :" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Hasil Dari pengurangan adalah:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Hasil Dari perkalian adalah:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Hasil Dari pembagian adalah:" + res);
                        break;
                    default:
                        Console.WriteLine("Salah input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Mau menghitung kembali?(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");
        }
    }
 
}