namespace tpmodul7_kelompok_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mahasiswa = new DataMahasiswa1302220098 { };

            var courses = new KuliahMahasiswa1302220098 { };

            mahasiswa.ReadJSON();
            courses.ReadJSON();

        }
    }
}
