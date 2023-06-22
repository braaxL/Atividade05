using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade05
{
    class Program
    {
        static void Main(string[] args)
        {

           


            string nome;
            string snome;
            string end;
            string bairro;
            string cidade;
            string estado;
            int viagem;
            int viagens;
            string promo;
            string promo2;


            Console.WriteLine("Bem-Vindo ao Sistema de Viagens e Turismo Tindo \n");
            Console.WriteLine("Digite Seu Primeiro Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite Seu SobreNome: ");
            snome = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine($"Olá, Sr(a).{nome} {snome}, Vamos Continuar Seu Cadastro...");

            Console.WriteLine("- Qual é o Seu Endereço? ");
            end = Console.ReadLine();
            Console.WriteLine("- Bairro?");
            bairro = Console.ReadLine();
            Console.WriteLine("- Cidade?");
            cidade = Console.ReadLine();
            Console.WriteLine("- Estado?");
            estado = Console.ReadLine();

            Console.WriteLine($"O Sr(a).{snome} Mora Na Cidade De {cidade} - {estado}, No Endereço {end}, Localizado No Bairro {bairro}. \n");
            Console.WriteLine("Quantas Viagens Você Fez Ano Passado?");
            viagem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas Viagens Você Planejou Esse Ano? ");
            viagens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine($"Você Viajou No Total: {viagem + viagens}");




            if (viagem + viagens >= 10)
            {
                Console.WriteLine($"Você Viajou Mais que 10 Vezes ao Todo!");

            }
            else
            {
                Console.WriteLine($"Faltam {10 - viagem + viagens} Viajens Para 10 \n\n");
            }

            Console.WriteLine($"Obrigado {nome} {snome}, O Seu Cadastro Foi Finalizado Com Sucesso! \n");

            Console.WriteLine("◉ Digite Seu Cupom De Desconto: ");
            if (promo == "Tindo10")
            {
                Console.WriteLine("Parabéns, Você Recebeu 10% De Desconto Na Sua Próxima Viagem");
            }
            else
            {
                Console.WriteLine("◉ Este Cupom Não Existe \n");
            }
            Console.WriteLine("◉ Você Gostaria De Receber Promoções No Seu E-mail?");
            if (promo2 == "Sim")
            {
                Console.WriteLine($"◉ Obrigado {nome} Por Se Registrar, Você Receberá Novos E-mails Em Breve.");
            }
            else
            {
                Console.WriteLine("◉ Ok, Você Não Receberá E-mails De Promoções.\n\n");
            }
            Console.WriteLine("◉ Obrigado, E Volte Sempre!");


            Console.ReadKey();


        }
    }
}
