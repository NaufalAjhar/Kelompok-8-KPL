namespace tpmodul7_kelompok_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mahasiswa = new DataMahasiswa1302223040 { };

            var courses = new KuliahMahasiswa1302223040 { };

            mahasiswa.ReadJSON();
            courses.ReadJSON();
            
        }
    }
}
