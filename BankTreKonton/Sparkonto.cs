namespace BankTreKonton
{
    public class Sparkonto
    {
        public string kontohavarensNamn;
        public int kontonummer;
        public int saldo;

        public Sparkonto(string kontohavaernsNamn)
        {
            this.kontohavarensNamn = kontohavaernsNamn;
            this.kontonummer = 222;
            this.saldo = 200;
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
