using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TPModul7_Kelompok_8
{
    internal class DataMahasiswa_1302220024
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public void ReadJSON()
        {
            string json = File.ReadAllText("D:\\KPL\\TPModul7_Kelompok8\\tp7_1_1302220024.json");
            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302220024>(json);
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }


}
