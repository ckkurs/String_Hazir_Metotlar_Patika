using System;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2="CSharp";

            //length;***
            //Cümle içerisinde kaç tane harf
            Console.WriteLine("Cümledeki harf sayısı: {0}",degisken.Length);
            
            //toUpper,toLower***
            Console.WriteLine("Cümledeki her harf büyük: {0}",degisken.ToUpper());
            Console.WriteLine("Cümledeki her harf küçük: {0}",degisken.ToLower());

            //Concat***
            Console.WriteLine("İki cümleyi birleştir: {0}",string.Concat(degisken," Merhaba"));

            //Compare,CompareTo***
            //Birinci degiskenle ikinci degiskene karakter sayısı eşit olursa bu bana 0 döndürür.
            //Birinci değişken ikinci değişkenden daha büyük bir karakter sayısına sahipse 1 döndürür.
            //Birinci değişken ikinci karakterden daha küçük bir karakter sayısına sahipse -1 döndürür.
            Console.WriteLine(degisken.CompareTo(degisken2));
            //bu iki değişkeni karşılaştırırken büyük küçük harf duyarsız hale gelir.Ben buna true dersem ama false dersem büyük küçük harf duyarlıdır.
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains
            //değişken birin içerisinde değişken2 var mı
            Console.WriteLine(degisken.Contains(degisken2));
            //EndsWith*** 
            //sonu bunla mı bitiyor
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            //StartsWith*** 
            //başı bunla mı başlıyor.
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf***
            //Değişken içerisinde bunu ara ilk bulduğu yerde ilk bunu bulursa C nin indexini dönücek bulamassa da -1 dönecek.
            Console.WriteLine(degisken.IndexOf("CSharp"));
            Console.WriteLine(degisken.IndexOf("Cem"));

            //Insert***
            //0.indeksten başlayarak stringin başına bunu ekler
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));

            //LastIndexof***
            //en sondaki i nin indexini getirir.
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLeft,PadRight***
            //PadLeft degisken2 nin başına 30u tamamlayacak kadar boşluk ekliyor.
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            //PadRight degisken2 nin sonuna 30u tamamlayacak kadar boşluk ekliyor.
            Console.WriteLine(degisken.PadRight(50) + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50) + degisken2.PadLeft(30,'*'));

            //Remove***
            //10.karakter sonrasını siliyor
            Console.WriteLine(degisken.Remove(10));
            //5.indexten başlayarak 3 karakter sil
            Console.WriteLine(degisken.Remove(5,3));
            //baştan
            Console.WriteLine(degisken.Remove(0,1));

            //Replace***
            //değiştirme
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split***
            //Boşluklara göre diziye at ve 1.indexi getir.
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            //4.indexten başlayarak sonuna kadar getir
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
