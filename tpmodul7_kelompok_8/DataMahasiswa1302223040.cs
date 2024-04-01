using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa1302223040
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
            string json = File.ReadAllText("D:\\1.Programming\\tpmodul7_kelompok_8\\tpmodul7_kelompok_8\\tp7_1_1302223040.json");
            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223040>(json);
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }


}
