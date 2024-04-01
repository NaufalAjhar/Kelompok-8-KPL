using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TPModul7_Kelompok8
{
    internal class KuliahMahasiswa_1302220024
    {
        public List<Courses> courses { get; set; }

        public class Courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }
        public void ReadJSON()
        {
            string json = File.ReadAllText("D:\\KPL\\TPModul7_Kelompok8\\tp7_2_1302220024.json");
            var coursesJson = JsonSerializer.Deserialize<KuliahMahasiswa_1302220024>(json);
            int i = 1;
            foreach (var course in coursesJson.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
