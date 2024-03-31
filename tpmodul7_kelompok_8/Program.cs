using TPModul7_Kelompok_8;

namespace TPModul7_Kelompok8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mahasiswa = new DataMahasiswa_1302220024 { };

            var courses = new KuliahMahasiswa_1302220024 { };

            mahasiswa.ReadJSON();
            courses.ReadJSON();

        }
    }
}
