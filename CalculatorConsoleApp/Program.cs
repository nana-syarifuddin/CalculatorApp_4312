using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan Nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            var b = Convert.ToInt32(Console.ReadLine());

            // membuat objek calculator menggunakan keyword var
            var cal = new Calculator();

            Console.WriteLine(); //tambahkan garis kosong
            Console.WriteLine("Hasil Penambahan : {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, b, cal.Perkalian(a, b));
            
            // khusus method Pembagian dipanggil langsung dari class Calculator
            // karena merupakan method static            
            Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil Pangkat : {0} ^ {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil Module : {0} % {1} = {2}", a, b, Calculator.Modulo(a, b));

            Console.ReadKey();
        }   
    }
}
