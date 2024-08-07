using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static Deneme.Program;

namespace Deneme
{
    internal class Program
    {
        public class player1 {
            public int hitLimit = 10;
            public int counter;
            public int score = 0;

            public void Throw()
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 100);
                if (x <= 50)
                {
                    Console.WriteLine("sorry,you miss the board.");
                }
                else if (x > 50)
                {
                    int y = rnd.Next(1,100) ;
                    if (y > 50)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 5 points");
                        score = score + 5;
                    }
                    if (y > 15 & y <= 50)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 10 points");
                        score = score + 10;
                    }
                    if (y <= 15)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 10 points");
                        score = score + 20;
                    }

                }
            }  
            public void playTheGame()
                {
                    for (int i = 0; i < hitLimit; i++)
                    {
                        Throw();
                        counter = score;
                        Console.WriteLine(counter);
                    }
                }      
        }
        public class player2
        {
            public int hitLimit = 10;
            public int counter;
            public int score = 0;

            public void Throw()
            {
                Random rnd = new Random();
                int x = rnd.Next(1,100);
                if (x <= 50)
                {
                    Console.WriteLine("sorry,you miss the board.");
                }
                else if (x > 50)
                {
                    int y = rnd.Next(1,100);
                    if (y > 50)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 5 points");
                        score = score + 5;
                    }
                    if (y > 15 & y <= 50)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 10 points");
                        score = score + 10;
                    }
                    if (y <= 15)
                    {
                        Console.WriteLine("You hit the dart!");
                        Console.WriteLine("You collect 10 points");
                        score = score + 20;
                    }

                }
            }
            public void playTheGame()
            {
                for (int i = 0; i < hitLimit; i++)
                {
                    Throw();
                    counter = score;
                    Console.WriteLine(counter);
                }
            }
        }
        public class jar
        {
            private int capacity;
            private bool jarLid;
            private int currentFullness;

            public void setCapacity(int capacity) { this.capacity = capacity; }

            public double getCapacity() { return this.capacity; }

            public double getCF() {
                Console.WriteLine(capacity);
                return capacity;
            }
            public bool openLid() { 
                jarLid = true;
                return true;
            }

            public bool closeLid() {
                jarLid = false;
                return true;
            }

            public bool Empty() {
                currentFullness = 0;
                return true;
            }

            public bool addMarble(int marble)
            {
                if (jarLid == true)
                {
                    if (capacity - currentFullness >= marble)
                    {
                        currentFullness = currentFullness + marble;
                        Console.WriteLine(currentFullness);
                        return true;
                    }
                    else { 
                    Console.WriteLine("Sorry, your jar full capacity now.");
                    Console.WriteLine("Error Code: Full");
                    Console.WriteLine("İf you need more capacity you look our brand new jars!");
                    return false;
                    }
                }
                else {
                    Console.WriteLine("please first open the jar");
                    return false;
                }
            }
            public bool takeMarble(int marble)
            {
                if(jarLid == true) {
                if(currentFullness - marble >=  0)
                    {
                        currentFullness = currentFullness - marble;
                        Console.WriteLine(currentFullness);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry,you can't take more than you add.");
                        Console.WriteLine("Error Code:NotEnough");
                        Console.WriteLine("İf you need more marble you can buy our website!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("please first open the jar");
                    return false;
                }
            }
        }
        public class ogrenci
        {
            public string OgrenciNo { get; set; }
            public string AdSoyad { get; set; }
            public string bolum { get; set; }
            public bool mezun { get; set; }
        }
            
        static int Gelirler(ref int KZ, params int[] tutar)
        {
            int tutarSum = tutar.Sum(x => Math.Abs(x));
            KZ += tutarSum;
            return tutarSum;
        }
        static int Giderler(ref int KarZarars, params int[] tutar)
        {
            int tutarSum = -1 * tutar.Sum(x => Math.Abs(x));
            KarZarars += tutarSum;
            return tutarSum;
        }
        static int Tutarlar(ref int karZarar, bool gelirmi, params int[] tutar) 
        {
            int carpan = gelirmi ? 1 : -1;
            int tutarsum = carpan*tutar.Sum(x => Math.Abs(x));
            karZarar += tutarsum;
            return tutarsum;
        }
        static void Main(string[] args)
        {
            try
            {
                string[] birkimseler = new string[3] { "ENgin", "Necla", "Salih" };
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            } catch (Exception exceptiion)
            {
                Console.WriteLine(exceptiion.Message);
            }
            jar jar = new jar();
            jar.setCapacity(213);
            jar.getCapacity();
            jar.openLid();
            jar.addMarble(100);
            jar.closeLid();
            jar.addMarble(200);
            jar.takeMarble(143);
            jar.openLid();
            jar.addMarble(200);
            jar.takeMarble(143);
            jar.Empty();
            jar.getCF();
            jar.openLid();
            ogrenci ogr = new ogrenci();
            ogr.AdSoyad = "Muratti John";
            ogr.OgrenciNo = "230133103";
            ogr.bolum = "Komputer Muh.";
            ogr.mezun = false;
            ogrenci ogr2 = new ogrenci();
            ogr2.AdSoyad = "Arnavut Hüsnü";
            ogr2.OgrenciNo = "220532804";
            ogr2.bolum = "Komputer Muh.";
            ogr2.mezun = false;

            List<ogrenci> ogrencilistesi = new List<ogrenci>();
            ogrencilistesi.Add(ogr);
            ogrencilistesi.Add(ogr2);

            player1 p1 = new player1();
            player2 p2 = new player2();
            p1.playTheGame();
            p2.playTheGame();
            if (p1.counter > p2.counter) {
                Console.WriteLine("Winner is the player 1" + " Player 1 last score: " + p1.counter + " Player 2 last score:" + p2.counter);
            } else if (p1.counter < p2.counter) {
                Console.WriteLine("Winner is the player 2" + " Player 1 last score: " + p1.counter + " Player 2 last score:" + p2.counter);
            }
            else { 
                Console.WriteLine("draw" + " Player 1 last score: " + p1.counter + " Player 2 last score:" + p2.counter);
            }
        



            foreach ( var item in ogrencilistesi)
            {
                Console.WriteLine(item.AdSoyad);
            }
            Queue Kuyruk = new Queue();
            Kuyruk.Enqueue("Mamut");
            Kuyruk.Enqueue("Fil");
            Kuyruk.Enqueue("Kaplan");
            Kuyruk.Enqueue("Aslan");
            Object ilk = Kuyruk.Peek();
            object cik = Kuyruk.Dequeue();
            Console.WriteLine(ilk.ToString());
            Console.WriteLine(cik.ToString());
            Kuyruk.Dequeue();
            Object iki = Kuyruk.Peek();
            Console.WriteLine(iki.ToString());
            int KZDurumu = 0;
            int buYİL = DateTime.Today.Year;
            int oncYİL = buYİL - 1;
            Console.WriteLine($"{oncYİL} durumu");
            int Gelir = Gelirler(ref KZDurumu, 1_000, 200, 3_000, 400, 10_000);
            int Gider = Giderler(ref KZDurumu, 1_000, 200, 3_000, 400, 500);
            Console.WriteLine($"Geliriniz : {Gelir:0,0} Gideriniz : {Gider:0,0}");
            Console.WriteLine($"{(KZDurumu > 0 ? "Kar ettiniz" : "Zarar ettiniz")}");
            Console.WriteLine("K/Z Durumu");
            Console.WriteLine($"+ {Gelir:0,0} {Gider:0,0} = {KZDurumu:0,0}");
            int oncekiYil = KZDurumu;
            string[] students = new string[3]; 
            students[0] = "Memet";
            students[1] = "Dalgın";
            students[2] = "Algın";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            var number = 10;
            var number2 = 8;
            Console.WriteLine(number2 == 10 ? "Number is 10" : "yooo"); 
            if(number == 10)
            {
                Console.WriteLine("Number is 10 uiyyy");
            }
            else
            {
                Console.WriteLine("Numbeah is not 10");
            }switch (number)
            {
                case 10:
                    Console.WriteLine("Evet");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("hicbiri");
                    break;
              
            }
            

            Console.ReadLine();
        }

    }
}