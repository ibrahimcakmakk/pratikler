
using System;

class Program
{

    static void Main(String[] args)
    {
        Console.WriteLine("");
        
        byte b = 5;
        sbyte c = 5;

        short d = 5;
        ushort e = 5;

        Int16 i16 = 2;
        int i =2;
        Int32 i32 = 2;
        Int64 i64 = 2;

        uint ui = 2;
        long l = 4;
        ulong ul = 2;

        float f = 5;
        double dou = 5;
        decimal de = 5;

        char ch = '2';
        string str = "ibrahim"; 

        bool t = true;
        bool fls = false;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        object o1 = "f";
        object o2 = 'y';
        object o4 = 4;
        object o3 = 4.3;

        String str1 = string.Empty;
        str1 = "ibrahim çakmak";
        string ad = "ibrahim";
        string soyad = "çakmak";
        string tamisim = ad + ' ' + soyad;

        int integer1 =5;
        int integer2 = 3;
        int integer3 = integer1 +integer2;


        bool bool1 = 10 < 2;

        string str20 = "20";
        int int20 = 20;
        string yenideger = str20 + int20.ToString();
        Console.WriteLine(yenideger);

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21);

        int int22 = int20 + int.Parse(str20);

        string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(dateTime);

        string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(dateTime2);

    }





}
