namespace BankTreKonton
{
    public class Personkonto
    {
        public string kontohavarensNamn;
        public int kontonummer;
        public int saldo;

        public Personkonto(string kontohavaernsNamn)
        {
            this.kontohavarensNamn = kontohavaernsNamn;
            this.kontonummer = 333;
            this.saldo = 300;
        }

        public int checkSaldo()
        {
            return this.saldo;
        }

        public void draw(int money)
        {
            this.saldo = this.saldo - money;
        }

        public void deposit(int money)
        {
            this.saldo = this.saldo + money;
        }

    }
}
