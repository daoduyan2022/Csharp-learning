using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            
            // KHoi tao 1 doi tuong tu 1 class
            information an = new information();
            //gan gia tri cua thuoc tinh cho object
            an.name = "Dao Duy An";
            an.yearborn = 1998;
            an.numberPhone = "0398279900";
            // su dung phuong thuc cua object
            an.print_information();



            // xau khi tu, thu hien tinh toan trong chuoi string.
            int a = 123;
            int b = 456;
            string solution = $"a = {a}, b = {b},    c = {a - b}";
            bool z = false;

            //phep toan dieu kien
            z = (a > b) ? true : false;


            Console.WriteLine(solution);

            // ep kieu trong C#
            
            float _float = 1234;

            var _double = (double)_float;
            //kiem tra kieu 
            if (_double is double)
            {
                // lay thong tin kieu du lieu
                Console.WriteLine(_double.GetType());
            }

            //ep kieu voi as

            object ob1 = "Hello world";

            string str1 = ob1 as string;
            // tra ve gia tri null khi ep kieu khong thanh cong
            object ob2 = 1234;

            string str2 = ob2 as string;
            Console.WriteLine();
            // String

            string _str = "Hello the world";
            string _toUpper = _str.ToUpper();
            Console.WriteLine(_toUpper.ToLower());

            string greeting = string.Concat("Hello", "world", "from", "C#");
            Console.WriteLine(greeting);

            string a11 = "AAAHello the world from C,# 2022";
            
            string a22 = a11;

            Console.WriteLine("CHUOI GO BAN DAU LA:    " + a11+ "\n\n");
            //a11 = "delete";
            //Console.WriteLine(a22);
            // xoa phan khoang trang hoac ki tu chi dinh o dau va cuoi 1 chuoi
            
            Console.WriteLine("XOA KHOANG TRANG HOAC KI TU DUOC CHI DINH O DAU HOAC CUOI 1 STRING :");
            Console.WriteLine(a11.Trim(new[] { 'A', '2'}) + "\n\n");

            // XAC DINH VI TRI CUA XAU CON VALUE. TRA VE VI TRI DAU TIEN BAT GAP. IndexOf()
            Console.WriteLine("XAC DINH VI TRI CUA XAU CON VALUE :");
            Console.WriteLine(a11.IndexOf("C#") + "\n\n");
            //LastIndexOf() : tra ve vi tri bat gap cuoi cung.


            //INSERT : TAO BAN SAO CUA 1 CHUOI VOI 1 XAU CON VALUE CHEN VAO VI TRI START_INDEX

            var _insertString = a11.Insert(9, "INSERT VALUE ");
            Console.WriteLine("CHEN 1 XAU VAO VI TRI START_INDEX: ");
            Console.WriteLine(_insertString + "\n\n");

            // REPLACE : TAO BAN SAO CUA 1 CHUOI VA THAY THE MOT CHUOI CON BANG CHUOI CON KHAC

            var _replaceString = a11.Replace("world", "REPLACE_WORLD BY VIETNAM");
            Console.WriteLine("THAY THE CHUOI CU BANG CHUOI MOI : ");
            Console.WriteLine(_replaceString+ "\n\n");


            // SPLIT: TACH 1 STRING THANH 1 MANG CAC STRING NHO BOI DAU PHAN TACH DO NGUOI DUNG CHI DINH
            string[] sub_string = a11.Split(' ',',');
            Console.WriteLine("MANG CAC STRING NHO SAU KHI TACH TU STRING LON BOI DAU CACH LA: ");
            foreach (string substring in sub_string)
            {
                Console.WriteLine(substring);
            }

            // TO CHAR ARRAY : CHUYEN TOAN BO MANG THANH 1 MANG CHAR:

            char[] arrayOfChar = a11.ToCharArray();
            Console.WriteLine("CHUYEN 1 STRING THANH ARRAY CUA CAC KI TU: ");
            foreach(char _char in arrayOfChar)
            {
                Console.Write(_char + "\t");
            }
            Console.WriteLine();

            // CHECK IS NULL OR EMPTY:
            string _empty = " ";
            Console.WriteLine(string.IsNullOrEmpty(_empty));
            
            public enum Gender
            {
                a,b,c,d
            }

           



















        }
    }

}
