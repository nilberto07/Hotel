using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entities.Exceptions;

namespace Hotel.Entities
{
    class Reservar
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reservar()
        {
        }

        public Reservar(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataSaida <= dataEntrada)
            {
                throw new EcessaoDominio("As datas deve ser posteriores da data de entrada");
                //Cláusula throw serve para lançar a exceção / "corta" ou finaliza o metado
            }

            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int Duracao()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada);
            return (int)duracao.TotalDays;
        }

        public void Atualizacao(DateTime dataEntrada, DateTime dataSaida)
        {
            DateTime now = DateTime.Now;
            if (dataEntrada < now || dataSaida < now)
            {
                throw new EcessaoDominio ("As datas deve ser futuras");
            }
            if (dataSaida <= dataEntrada)
            {
                throw new EcessaoDominio ("As datas deve ser posteriores da data de entrada");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Numero: "
                + NumeroQuarto
                + ", Data de entrada: "
                + DataEntrada.ToString("dd/MM/yyyy")
                + ", Data de Saida: "
                + DataSaida.ToString("dd/MM/yyyy, ")
                + Duracao()
                + " Noites.";                
        }
    }
}
