namespace Abstraction.Entities
{
    //Abstraindo Classe
    abstract class Contributors
    {

        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //Construtor.
        public Contributors(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //Metodo abstrato.
        public abstract double Tax();

        //Sobreescrevendo o metodo ToString para que seja exibido os dados com uma formatação personalizada.
        public override string ToString()
        {
            return $"{Name}: ${Tax().ToString("F2")}";
        }
    }
}
