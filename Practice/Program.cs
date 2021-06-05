using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;



namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            try { 
                    while (true)
                    {
                        Console.WriteLine("Для заселення нового мешканця введiть \"Y\", для завершення роботи програми \"N\" ");
                    XmlSerializer formatter = new XmlSerializer(typeof(Hotel));
                        string ch = Console.ReadLine();
                        switch (ch)
                        {
                            case "Y":
                                Console.WriteLine("Введiть iм`я мешканця");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введiть прiзвище мешканця");
                            string sname = Console.ReadLine();
                            Person person = new Person(name + " " + sname);
                            Hotel hotel = new Hotel();
                            try { using (FileStream fs = new FileStream("hotel.xml", FileMode.Open)) { } } catch (FileNotFoundException e){
                                using (FileStream fs = new FileStream("hotel.xml", FileMode.OpenOrCreate))
                                { formatter.Serialize(fs, hotel); }
                                }
                            using (FileStream fs = new FileStream("hotel.xml", FileMode.Open))
                            {
                                Hotel newhotel = (Hotel)formatter.Deserialize(fs);

                                hotel = newhotel;
                            }
                                Console.WriteLine("Список вiльних номерiв:");
                            for (int i = 0; i < 15; i++) {
                                if (hotel.rooms[i].is_Empty)
                                    Console.WriteLine(i+1);
                            }
                            Console.WriteLine("Оберiть вiльний номер:");
                            int n = 0;
                            n= Convert.ToInt32(Console.ReadLine());
                            hotel.sell_Room(person, n-1);
                           
                            using (FileStream fs = new FileStream("hotel.xml", FileMode.OpenOrCreate))
                            {
                                formatter.Serialize(fs, hotel);

                                Console.WriteLine("Объект сериализован");
                            }
                            break;
                            case "N": return;
                        default:
                            Console.WriteLine("Незадовiльнi вхiднi даннi");
                            break;
                    
                    }
                    }
                

            }catch(FormatException e){ Console.WriteLine("Незадовiльнi вхiднi даннi"); } }
    }
}
