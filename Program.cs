using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        class student
        {
            public string ФИО;
            public int оценка1;
            public int оценка2;
            public void Show()
            {
                Console.WriteLine($"ФИО: {ФИО}, Оценка 1: {оценка1}, Оценка 2: {оценка2}");
            }

            public float СредняяОценка ()
            {
                return (float)(оценка1 + оценка2) / 2;
            }
        }
        static void Main(string[] args)
        {
            student st = new student();
            st.ФИО = "Иванов";
            st.оценка1 = 3;
            st.оценка2 = 5;

            st.Show();

            float average = st.СредняяОценка();
            Console.WriteLine($"Средняя оценка студента: {average}");           
            Console.ReadKey();


        }
    }
}
