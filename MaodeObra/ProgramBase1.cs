namespace MaodeObra
{
    internal class ProgramBase1
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); //CRIA UMA LISTA DE FUNCIONARIOS

            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine()); //ARMAZENA O QUE O USUARIO DIGITAR NA VARIAVEL n

            for (int i = 1; i <= n; i++) //for do valor digitado pelo usuario para saber quantas passagens
            //pelo for funcionario ira ocorrer
            {
                Console.WriteLine($"Employee #{i} data: "); //PERGUNTA USANDO O FOR COMO INDICE
                Console.Write("OutSource (y/n)?");
                char outs = char.Parse(Console.ReadLine());//ARMAZENA A RESPOSTA DO USUARIO EM outs

                Console.Write("Name: ");
                string name = Console.ReadLine();//ARMAZENA A RESPOSTA DO USUARIO EM name
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());//ARMAZENA A RESPOSTA DO USUARIO EM hours
                Console.Write("Value per Hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//ARMAZENA A RESPOSTA DO USUARIO EM ValuePerHours

                if (outs == 'y') //TESTE SE O FUNCIONARIO É TERCERIZADO------SE SIM.....ADICIONA O CUSTO EXTRA
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            //IMPRESSÃO NA TELA
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}