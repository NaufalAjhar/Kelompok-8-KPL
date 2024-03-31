using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_8
{
    internal class KuliahMahasiswa1302223040
    {
        public List<Courses> courses { get; set; }

        public class Courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }
        public void ReadJSON()
        {
            string json = File.ReadAllText("D:\\1.Programming\\tpmodul7_kelompok_8\\tpmodul7_kelompok_8\\tp7_2_1302223040.json");
            var coursesJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223040>(json);
            int i = 1;
            foreach ( var course in coursesJson.courses )
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
