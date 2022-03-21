using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_PsuedoCode_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Pseudo Code(Sözde Kod); algoritma kurarken kullandığımız, günlük konuşma diline yakın ve belli bir programlama diline ait özelliklere sahip olmayan bir algoritma tanımlama biçimidir. Algoritmanın yapısını tüm detayları ile ve günlük dil sadeliğinde, bir akış içerisinde anlatmak için kullanılır. Sözde kodu okuyan kişi zorlanmadan algoritmayı tamamen anlamalı ve çalışma mantığını kavrayabilmelidir.
            
            Pseudo Code yazarken dikkat edilmesi gereken bir syntax yani söz dizimi yoktur. Önemli olan anlaşılabilir ve programlanabilir olmasıdır. Amaç, temel olarak tasarlanan algoritmanın çalışma mantığını anlatmak olduğu için derlemeye(compiling) veya hata ayıklamaya(debugging) uygun bir yapısı yoktur.
                       
             */


            // ÖRNEK : Kullanıcıdan önce ismini isteyip o değeri aldığınız, sonra soy ismini isteyip o değeri aldığınız ve en sonunda Hoşgeldin İsim Soyİsim ile selamlayabileceğiniz bir Console programı yazınız...

            /*
             * C# Console için Algoritma:
             
            1.Başlat
            2.Ekrana isim girmek istediğini yazdır
            3.Kullanıcıdan isim girebilmesi için bekle
            4.Kullanıncın girdiği bilgiyi bir hafıza alanında sakla(alanın ismi : 'isim')
            5.Ekrana soyisim girmek istediğini yazdır
            6.Kullanıcıdan soyisim girebilmesi için bilgi bekle 
            7.Kullanıcının girdiği bilgiyi bir hafıza alanında sakla(alanın ismi : 'soyIsim')
            8.Saklamış olduğun verileri, aralarında birer boşluk olacak şekilde Hoşgeldin kelimesi ile birlikte ekrana yazdır
            9.Konsolun beklemesini sağla
            10.Bitir.
                        
             */


            Console.WriteLine("Lütfen isim giriniz"); // Ekrana, verdiğimiz string ifadeyi yazdırdık

            string isim = Console.ReadLine(); // burada Console.ReadLine() ifadesi sayesinde satıra yazılan veriyi aldık, okuduk ve 'isim' ismindeki string tipindeki oluşturduğumuz hafıza alanımıza(değişkenimize), yani veri tutan depomuza attık

            Console.WriteLine("Lütfen soyIsim giriniz"); // Ekrana, verdiğimiz string ifadeyi yazdırdık

            string soyIsim = Console.ReadLine(); // burada Console.ReadLine() ifadesi sayesinde satıra yazılan veriyi aldık, okuduk ve 'soyIsim' ismindeki string tipindeki oluşturduğumuz hafıza alanımıza(değişkenimize), yani veri tutan depomuza attık

            Console.WriteLine("Hoşgeldin " + isim + " " + soyIsim); // RAM'imizde sakladığımız değişkenlerimizi 'Hoşgeldin' kelimesi ile birleştirip, her kelimeden sonra bir karakter boşluk bıraktk

            Console.ReadLine(); // Programın açık kalmasını sağlamak adına Console.ReadLine() ifadesini kullandık



        }
    }
}
