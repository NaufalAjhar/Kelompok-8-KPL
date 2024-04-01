using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_8
{
    internal class KuliahMahasiswa1302223015
    {
        public List<Courses> courses { get; set; }

        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            try
            {
                string json = File.ReadAllText("D:\\Telkom University\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TUGAS\\WEEK 7\\Kelompok-8-KPL\\tpmodul7_kelompok_8\\tp7_2_1302223015.json");
                var coursesJson = JsonSerializer.Deserialize<KuliahMahasiswa1302223015>(json);
                int i = 1;
                foreach (var course in coursesJson.courses)
                {
                    Console.WriteLine($"MK {i} {course.code} - {course.name}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
