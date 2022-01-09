

namespace MaodeObra.Entities
{       //subCLASSE
    class OutsourceEmployee : Employee
    {   //ATRIBUTO DA subCLASSE
        public double AdditionalCharge { get; set; }

        //CONSTRUTOR INICIAL DA subCLASSE
        public OutsourceEmployee()
        {

        }
        //CONSTRUTOR PADRÃO DA subCLASSE
        public OutsourceEmployee(string name, int hours, double valueperHour,double additionalCharge) 
            : base (name, hours, valueperHour)
        {
            AdditionalCharge = additionalCharge;
        }

        // METODO DA SUBCLASSE
        public override double Payment()
        {
          return base.Payment() + 1.1 * AdditionalCharge;
        }



    }
}
