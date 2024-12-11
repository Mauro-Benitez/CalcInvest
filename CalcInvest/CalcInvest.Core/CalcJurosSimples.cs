namespace CalcInvest.Core
{
    public class CalcJurosSimples
    {
        public double CapitalInicial { get; set; }

        public TaxaDeJuros TaxaDeJuros { get; set; }

        public int TempoMeses { get; set; }

        public double ValorFinal { get; set; }

        public CalcJurosSimples(double valorInicial, TaxaDeJuros taxaDeJuros,  int meses)
        {
            CapitalInicial = valorInicial;
            TaxaDeJuros = taxaDeJuros;
            TempoMeses = meses;
        }

        double CalcularJurosSimples()
        {

            double taxaDeJuros = TaxaDeJuros.Porcentagem;


            ValorFinal = CapitalInicial * taxaDeJuros * TempoMeses;


            return ValorFinal;
        }
    }
}
