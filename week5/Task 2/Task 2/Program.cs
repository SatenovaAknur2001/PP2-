using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace w5task1
{
    public class Mark
    {
        //[XmlIgnore]
        public int point;

        public Mark()
        {

        }
        public Mark(int ss)
        {
            this.point = ss;


        }
        public int num()
        {
            return point;
        }
        public string getlt()
        {
            string letter = "";
            if (point <= 100 && point >= 95)
            {
                letter = "A";
            }
            else if (point < 95 && point >= 90)
            {
                letter = "B";
            }
            else if (point <= 85 && point >= 80)
            {
                letter = "-b";
            }
            else if (point < 80 && point >= 75)
            {
                letter = "C+";
            }
            return letter;

        }
        public override string ToString()
        {
            return getlt();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ser();
            Des();

        }
        public static void Ser()
        {
            List<Mark> student1 = new List<Mark>();
            Mark pop = new Mark(92);
            pop.num();
            Mark pop1 = new Mark(85);

            student1.Add(pop);
            student1.Add(pop1);
            FileStream fs = new FileStream("student.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
            xs.Serialize(fs, student1);
            foreach (var mark in student1)
            {
                Console.WriteLine(mark);
            }



            fs.Close();

        }




        public static void Des()
        {

            FileStream fs = new FileStream("student.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));

            List<Mark> deserlisemark = xs.Deserialize(fs) as List<Mark>;
            foreach (var mark in deserlisemark)
            {
                Console.WriteLine(mark);
            }
            fs.Close();



        }
    }


}