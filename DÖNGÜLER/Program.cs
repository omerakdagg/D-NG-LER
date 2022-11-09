//for (int i = 0; i <= 20; i=i+2)
//{
//    Console.WriteLine(1);
//}
//Console.ReadLine();    

//string str = "Ayşe eve ekmek al.";
//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(i + ". Elaman " + str[i]);
//    if (str[i] == '.')
//    {
//        break;
//    }
//}

//string[] ogrenciDizisi = { "Yasemin Eryılmaz", "Büşra Arslan", "Merve Erdem", "Emre Ersoy", "Resul Binici", "Furkan Hüseyin Karaboga", "Emre Turan" };

//for (int i = 0; i < ogrenciDizisi.Length; i++)
//{
//    Console.WriteLine(i + "=Eleman" + ogrenciDizisi[i]);

//}



//string[] ogrenciDizisi = { "Yasemin Eryılmaz", "Büşra Arslan", "Merve Erdem", "Emre Ersoy", "Resul Binici", "Furkan Hüseyin Karaboga", "Emre Turan" };
//foreach (string ogrenci in ogrenciDizisi)
//{
//    Console.WriteLine(ogrenci);

//}



//int[] sayiDizi = { 1, 3, 5, 7, 3, 8, 0, 4, 6, 8, 0, 3, 1, 23, 45, 76, 456, 34556 };


//for (int i = 0; i < sayiDizi.Length; i++)
//{
//    Console.WriteLine( sayiDizi[i]);

//}

//int[] sayiDizi = { 1, 3, 5, 7, 3, 8, 0, 4, 6, 8, 0, 3, 1, 23, 45, 76, 456, 34556 };
//foreach (int k in sayiDizi)
//{
//    Console.WriteLine(k);
//}

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//string[] a = { "Ali","ahmet" };
//foreach (string K in a)
//{
//	if (K=="Ali")
//	{
//		Console.WriteLine(222);
//	}
//}

//int[] DiziElaman = new int[3];
//DiziElaman[0] = 12;
//DiziElaman[1] = 13;
//DiziElaman[2] = 14;

//Console.WriteLine(DiziElaman.Length);

//foreach (int i in DiziElaman)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("**********");
//for (int i = 0; i < DiziElaman.Length; i++)
//{
//    Console.WriteLine(DiziElaman[i]);
//}

char[] chardizi = { 'A', 'L', 'İ' };
for (int i = 0; i < chardizi.Length; i++)
{
    Console.Write(chardizi[i]);
}
Console.WriteLine("");
Console.WriteLine("");
foreach (Char A in chardizi)
{
    Console.Write(A);
}