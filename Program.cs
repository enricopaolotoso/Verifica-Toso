using System;

namespace verifica
{
    public class Treni
    {
        public string codtreno { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public int costo = 100000;
        public int km;

        public virtual double CostoMezzo()
        {
            return costo;
        }
        public virtual int CostoUtilizzo()
        {
            return km;
        }
    }


    public class Passeggeri : Treni
    {
        public Passeggeri(string codtreno, string tipo, string nome, int numvagoni, string alimentazione, int km)
        {
            this.codtreno = codtreno;
            this.tipo = tipo;
            this.nome = nome;
            this.numvagone = numvagoni;
            this.alimentazione = alimentazione;
            this.km = km;
        }

        public int numvagone;
        public string alimentazione;

        public override double CostoMezzo()
        {
            return (costo* 1.25);
        }
        public override int CostoUtilizzo()
        {
            return (km * 100);
        }

        public override string ToString()
        {
            return $"Codice Treno: {codtreno}\nTipo: {tipo}\nNome: {nome}\nCosto: {this.CostoMezzo()}\nNumero Di Vagoni: {numvagone}\nAlimentazione: {alimentazione}\nCosto Utilizzo Del Mezzo Per {km}km: {this.CostoUtilizzo()} euro";
        }
    }


    public class Merci : Treni
    {
        public Merci(string codtreno, string tipo, string nome, int numvagoni, string alimentazione, int km)
        {
            this.codtreno = codtreno;
            this.tipo = tipo;
            this.nome = nome;
            this.numvagone = numvagoni;
            this.alimentazione = alimentazione;
            this.km = km;
        }

        public int numvagone;
        public string alimentazione;

        public override double CostoMezzo()
        {
            return (costo * 1.35);
        }
        public override int CostoUtilizzo()
        {
            return (km * 150);
        }

        public override string ToString()
        {
            return $"Codice Treno: {codtreno}\nTipo: {tipo}\nNome: {nome}\nCosto: {this.CostoMezzo()}\nNumero Di Vagoni: {numvagone}\nAlimentazione: {alimentazione}\nCosto Utilizzo Del Mezzo Per {km}km: {this.CostoUtilizzo()} euro";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            string codtreno = "", tipo = "", nome = "", alimentazione = "";
            int numvagoni = 0, km = 0;


            Console.WriteLine("codice treno:");
            codtreno = Console.ReadLine();

            do
            {
                Console.WriteLine("tipo treno:");
                tipo = Console.ReadLine();
            } while (tipo != "regionale" && tipo != "nazionale" && tipo != "internazionale");
            

            Console.WriteLine("nome treno:");
            nome = Console.ReadLine();

            Console.WriteLine("numero dei vagoni:");
            numvagoni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("alimentazione treno:");
            alimentazione = Console.ReadLine();

            Console.WriteLine("Lunghezza percorso in km:");
            km = Convert.ToInt32(Console.ReadLine());

            Passeggeri p = new Passeggeri(codtreno, tipo, nome, numvagoni, alimentazione, km);
            Console.WriteLine("codice treno:");
            codtreno = Console.ReadLine();

            do
            {
                Console.WriteLine("tipo treno:");
                tipo = Console.ReadLine();
            } while (tipo != "regionale" && tipo != "nazionale" && tipo != "internazionale");


            Console.WriteLine("nome treno:");
            nome = Console.ReadLine();

            Console.WriteLine("numero dei vagoni:");
            numvagoni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("alimentazione treno:");
            alimentazione = Console.ReadLine();

            Console.WriteLine("Lunghezza percorso in km:");
            km = Convert.ToInt32(Console.ReadLine());

            Merci m = new Merci(codtreno, tipo, nome, numvagoni, alimentazione, km);
            Console.WriteLine(p.ToString());
            Console.WriteLine(m.ToString());

        }
    }
}
