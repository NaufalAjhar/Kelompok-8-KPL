using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa1302220098
    {
        public Nama nama
        {
            get;
            set;
        }
        public int nim
        {
            get;
            set;
        }
        public String fakultas
        {
            get;
            set;
        }
        public class Nama
        {
            public String depan
            {
                get; 
                set;
            }
            public String belakang
            {
                get;
                set;
            }
        }
        public void ReadJSON()
        {
            String json = File.ReadAllText("C:\\Users\\Haikal\\OneDrive\\Documents\\Konstruksi Perangkat Lunak\\tp7_1_1302220098.json");
            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220098>(json);
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
    }
}
