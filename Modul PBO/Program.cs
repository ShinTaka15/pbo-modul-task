// See https://aka.ms/new-console-template for more information

namespace Modul
{
    class Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Corei3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Corei5";
        }
    }

    class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Corei7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "Athlon";
        }
    }



    class VGA
    {
        public string merk;
    }

    class Nvidia : VGA
    {
       public Nvidia()
       {
            base.merk = "Nvidia";
       } 
    }

    class Amd : VGA
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }



    class Laptop
    {
        public string merk;
        public string tipe;
        public VGA vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "Acer";
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new Amd();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new Amd();
            predator.processor = new Corei7();

            // No 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine();

            // No 2
            // laptop1.Ngoding();
            // Terjadi error

            // No 3
            Console.WriteLine($"Merk Vga laptop1       : {laptop1.vga.merk}");
            Console.WriteLine($"Merk processor laptop1 : {laptop1.processor.merk}");
            Console.WriteLine($"Tipe processor laptop1 : {laptop1.processor.tipe}");
            Console.WriteLine();

            // No 4
            predator.BermainGame();
            Console.WriteLine();

            // No 5
            ACER acer = new ACER();
            acer.vga = new Amd();
            acer.processor = new Corei7();
            // acer.BermainGame();
            // Terjadi error

        }
    }
}