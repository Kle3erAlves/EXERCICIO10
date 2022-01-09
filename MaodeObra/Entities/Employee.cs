using System;

namespace MaodeObra.Entities
{   //SUPERCLASSE
    class Employee
    {
        // ATRIBUTOS DA CLASSE
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValueperHour { get; set; }

        //CONSTRUTOR INICIAL DA CLASSE
        public Employee()
        {

        }
        //CONSTRUTOR PADRÃO DA CLASSE
        public Employee(string name, int hours, double valueperHour)
        {
            Name = name;
            Hours = hours;
            ValueperHour = valueperHour;
        }
        //METODO PAGAMENTO
        public virtual double Payment() //NÃO FOI PASSADO NENHUM PARAMETRO, POIS OS CALCULOS SERÃO FEITO COM OS
        //ATRIBUTOS DA PROPRIA CLASSE - HOURS E VALUEPERHOURS
        {
            return Hours * ValueperHour;
        }


    }
}
