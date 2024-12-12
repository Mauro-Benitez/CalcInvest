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

        public double CalcularJurosSimples()
        {

            if(TaxaDeJuros.Tipo == "Mensal" || TaxaDeJuros.Tipo == "mensal")
            {
                double taxaDeJuros = TaxaDeJuros.Porcentagem/100;


                ValorFinal = CapitalInicial * taxaDeJuros * TempoMeses;


                return ValorFinal;
            }

            double taxaDeJurosMensal = TaxaDeJuros.Porcentagem / 12;

            double taxaDeJursoFinal = taxaDeJurosMensal/100;

            ValorFinal = CapitalInicial * taxaDeJursoFinal * TempoMeses;

            return ValorFinal;
        }
    }
}
