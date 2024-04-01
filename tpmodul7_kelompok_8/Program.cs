using tpmodul7_Kelompok8;

namespace TPModul7_Kelompok8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mahasiswa = new DataMahasiswa1302223040 { };

            var courses = new KuliahMahasiswa1302223040 { };
      
            mahasiswa.ReadJSON();
            courses.ReadJSON();
            

            var mahasiswa = new DataMahasiswa_1302220024 { };
            var courses = new KuliahMahasiswa_1302220024 { };

            mahasiswa.ReadJSON();
            courses.ReadJSON();
          
            var mahasiswa = new DataMahasiswa1302223015 { };
            var courses = new KuliahMahasiswa1302223015 { };


            mahasiswa.ReadJSON();
            courses.ReadJSON();

        }
    }
}
