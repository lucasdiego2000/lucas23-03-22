using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine(" Por Favor informe seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine(" Por Favor Informe sua data" + " de nascimentono formato dd/mm/yyyy: ");



                //Passando por referencia
                //DateTime.TryParse(Console.ReadLine(),out DateTime datanascimento
                var datadenascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(ObterMensagemFaixaEtaria(nome, datadenascimento));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
        private static string ObterMensagemFaixaEtaria(string nome,DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;

            if(idade>=60)
                return $"olá(nome),esta na faixa etaria idoso!";
            else if(idade>=20 && idade <=59)
                return $"olá(nome),esta na faixa etaria adulto!";

            return $"olá(nome),esta na faixa etaria Jovem!";
        }
    }
}
