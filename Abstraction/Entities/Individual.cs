namespace Abstraction.Entities
{
    //Herdando Contributors
    //Selando Subclasse
    sealed class Individual: Contributors
    {
        public double HealthExpenditures { get; set; }

        //Construtor
        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        //Sobreescrevendo o metodo
        public override double Tax()
        {
            double tax = 0;

            //Caso seja menor que 20.000 então a taxa de calculo será de 15%
            if(AnualIncome < 20000)
            {
                //Caso healthExpenditures tenha um valor maior que 0 então calcula quanto seria 50% de healthExpenditures e remove do resultado da conta de (AnualIncome * 0.15)
                tax = HealthExpenditures > 0 ? ((AnualIncome * 0.15) - (HealthExpenditures * 0.5)) : (AnualIncome * 0.15);
            }
            //Caso seja maior ou igual a 20.000 então a taxa de calculo será de 25%
            else if (AnualIncome >= 20000)
            {
                //Caso healthExpenditures tenha um valor maior que 0 então calcula quanto seria 50% de healthExpenditures e remove do resultado da conta de (AnualIncome * 0.25)
                tax = HealthExpenditures > 0 ? ((AnualIncome *0.25) - (HealthExpenditures * 0.5)) : (AnualIncome * 0.25);
            }

            return tax;
        }
    }
}
