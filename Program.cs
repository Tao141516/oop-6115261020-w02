using System;

namespace oop_6115261020_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r434 = new Room("434", "434", 4, 4, "Computer");
            Console.WriteLine(r434);
            Building b4 = new Building("4 ", " Computer ", " 5.335 ", " 532.321 ");
            Console.WriteLine(b4);
            Subject th = new Subject("34511 ", " thai ", " 2 ", " 2 ", " 2 ");
            Console.WriteLine(th);
            Lecturer tc = new Lecturer("Nantida ", " Rodaumpan ", " Teacher ");
            Console.WriteLine(tc);
            Section tt = new Section("322 ", " 01 ", " Computer ", " T.tao ", " 01 Oct ", " 09.30 ", " 12.00 ");
            Console.WriteLine(tt);
            Programm aa = new Programm("Com ", " Bachelor degree ");
            Console.WriteLine(aa);
        }
    }
}
