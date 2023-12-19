using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    class Zrakoplov
    {
        private string naziv, snagaMotora, dosegLeta;

        public void setnaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string getNaziv()
        {
            return this.naziv;
        }
        public void setSnagaMotora(string snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public string getSnagaMotora()
        {
            return this.snagaMotora;
        }
        public void setDosegLeta(string dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
        public string getDosegLeta()
        {
            return this.dosegLeta;
        }
        public override string ToString()
        {
            string ispis = "naziv: " + this.naziv
                + "\nSnaga motora: " + this.snagaMotora
                + "\nDoseg Leta: " + this.dosegLeta;
            return ispis;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov();

            Console.WriteLine("Unesi naziv, snagu motora i doseg leta");
            string naziv = Console.ReadLine();
            string snagaMotora = Console.ReadLine();
            string dosegLeta = Console.ReadLine();

            zrakoplov.setnaziv(naziv);
            zrakoplov.setSnagaMotora(snagaMotora);
            zrakoplov.setDosegLeta(dosegLeta);
            
            Console.WriteLine(zrakoplov.ToString());


            Console.ReadKey();
        }
    }
}
