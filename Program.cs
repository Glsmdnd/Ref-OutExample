using System;

namespace Ref_OutExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number1 = 5;
            int number2 = 2;
            Console.WriteLine("number1 Değeri:"+number1);
            Console.WriteLine("number2 Değeri:" + number2);
            var result4 = Add4(5, 2);
            Console.WriteLine("sonuç:" + result4+"  number1'in Main Metodu Değeri:" + number1);

            int result5 = Add5(ref number1,number2);
            Console.WriteLine("sonuç:" + result5+ "  number1'in Ref Keywordu İle Metod Değeri:" + number1);

            int num1;
            int num2=20;
            int result6 = Add6(out num1, num2);
            Console.WriteLine("sonuç:" + result6 + "  number1'in Out Keywordu İle Metod Değeri:" + num1);
        }
        static int Add4(int number1, int number2)
        {
            //5 ve 2 değeri yukarıda tanımlanmış ve aşağıdaki metoda parametreyle gönderilmiştir.
            //Asağıdaki metodda number1 değeri değişir,yeni değeri 30 olur yukarıda ekrana 30+2 =32 olarak return edilir.Normalde bu deger main alanındaki
            //number1 bağlamaz, ve tekrar number1 mainde yazildiğinda 5 değeri ekrana yazılacaktır.
            number1 = 30;
            return number1 + number2;
            
        }
         static int Add5(ref int number1, int number2)
        {   //5 ve 2 değeri yukarıda tanımlanmış ve aşağıdaki metoda parametreyle gönderilmiştir.
            //Asağıdaki metodda number1 değeri değişir,yeni değeri 30 olur yukarıda ekrana 30+2 =32 olarak return edilir.Normalde bu deger main alanındaki
            //number1 bağlamaz,fakat ref kelimesi number1 i değer tip gibi değil referans tip olarak hizmet vermesini sağlayacaktır.
            //dolayısı ile number1 5 değerini değil metodda referans edilen 30 değerinin adresini tutar.
            //yeni değeri 30 olur number1 yazılmaya çalışılıdğında 30 değeri alınır.
            number1 = 30;
            return number1 + number2;
        }
        static int Add6(out int num1, int num2)
        {
            //out ve ref mantık olarak aynıdır. adresi referans eder.outun reften farkı ref de en başta değerin set edilmesi gereklidir.Main içinde int num1=20 gibi
            //outda ise buna gerek yoktur,Fakat ilgili metodda bir kere set edilmelidir.
            num1 = 30;
            num2 = 70;
            return num1 + num2;
        }
    }
}
