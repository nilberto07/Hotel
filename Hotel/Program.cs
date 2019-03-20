using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entities;
using Hotel.Entities.Exceptions;


class Program
{
    static void Main(string[] args)
    {
        try//Tentativa se tudo ocorrer bem no sistema, senão entra nos catch
        {
            Console.Write("Numero do quarto: ");
            int numeroQuarto = int.Parse(Console.ReadLine());
            Console.Write("Data de entrada (dd/MM/yyyy): ");
            DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de saida (dd/MM/yyyy): ");
            DateTime dataSaida = DateTime.Parse(Console.ReadLine());


            Reservar reservar = new Reservar(numeroQuarto, dataEntrada, dataSaida);
            Console.WriteLine("Reserva pro quarto " + reservar);

            Console.WriteLine();
            Console.WriteLine("Entre com data de atualização da reserva: ");
            Console.Write("Data de entrada (dd/MM/yyyy): ");
            dataEntrada = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de saida (dd/MM/yyyy): ");
            dataSaida = DateTime.Parse(Console.ReadLine());

            reservar.Atualizacao(dataEntrada, dataSaida);
            Console.WriteLine();
            Console.WriteLine("Os dados foram Atualizados!!!");
            Console.WriteLine("Reserva pro quarto " + reservar);
        }

        catch (EcessaoDominio e )//Se der erro no sistema a ecessao é capiturado nesse momento
        {
            Console.WriteLine("Erro na reserva: " + e.Message);//E é mostrado aqui o tipo de erro
        }

        catch (FormatException e)//Exception mais generico onde totos os outros erros herda dela
        {
            Console.WriteLine("Erro na formatação! " + e.Message);
        }

    }
}
