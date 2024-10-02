namespace BankTreKonton
{
    public class Investeringskonto
    {
        public string kontohavarensNamn;
        public int kontonummer;
        public int saldo;


        public Investeringskonto(string kontohavaernsNamn)
        {
            this.kontohavarensNamn = kontohavaernsNamn;
            this.kontonummer = 111;
            this.saldo = 100; 
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

        public void internalMoneyTransfer(int money, int kontonummer, Sparkonto isakSparkonto, Personkonto isakPersonkonto, Investeringskonto isakInvesteringskonto)
        {
            this.kontonummer = kontonummer;
            isakSparkonto.draw(money);
            isakSparkonto.deposit(money);

            isakPersonkonto.draw(money);
            isakPersonkonto.deposit(money);

            isakInvesteringskonto.draw(money);
            isakInvesteringskonto.deposit(money);
        }




    }
}
