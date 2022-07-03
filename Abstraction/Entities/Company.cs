namespace Abstraction.Entities
{
    //Herdando Contributors
    //Selando Subclasse
    sealed class Company: Contributors
    {
        public int NumberEmployees { get; set; }

        //Construtor
        public Company(string name, double anualIncome, int numberEmployees)
            :base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        //Sobreescrevendo o metodo
        public override double Tax()
        {

            double tax;

            //Se NumberEmployees for maior que 10 então o calculo será feito com 14%, senão o calculo será feito com 16%
            tax = NumberEmployees > 10 ? (AnualIncome * 0.14) : (AnualIncome * 0.16);

            return tax;
        }
    }
}
