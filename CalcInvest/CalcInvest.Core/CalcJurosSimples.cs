namespace CalcInvest.Core
{
    public class CalcJurosSimples
    {
        public decimal CapitalInicial { get; set; }

        public TaxaDeJuros TaxaDeJuros { get; set; }

        public int TempoMeses { get; set; }

        public decimal ValorFinal { get; set; }

        public CalcJurosSimples(decimal valorInicial, TaxaDeJuros taxaDeJuros,  int meses)
        {
            CapitalInicial = valorInicial;
            TaxaDeJuros = taxaDeJuros;
            TempoMeses = meses;
        }

        public decimal CalcularJurosSimples()
        {

            if(TaxaDeJuros.Tipo == "Mensal" || TaxaDeJuros.Tipo == "mensal")
            {
                decimal taxaDeJuros = TaxaDeJuros.Porcentagem/100;


                ValorFinal = CapitalInicial * taxaDeJuros * TempoMeses;


                return ValorFinal;
            }

            decimal taxaDeJurosMensal = TaxaDeJuros.Porcentagem / 12;

            decimal taxaDeJursoFinal = taxaDeJurosMensal/100;

            ValorFinal = CapitalInicial * taxaDeJursoFinal * TempoMeses;

            return ValorFinal;
        }




























    }
}
