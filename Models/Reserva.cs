using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite { get; set; }
        public int DiasReservados { get; set;}

        public Reserva() {}

        public Reserva(int diasReservados) 
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(Suite?.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else 
            {
                throw new Exception("A quantidade de hospedes nao pode exceder a capacidade maxima");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal? CalcularValorDiaria()
        {
            decimal? valor = DiasReservados * Suite.ValorDiaria; 

            if(DiasReservados >= 30)
            {
                valor *= 0.90m;
            } 
            return valor; 
        }

        class Excecao : Exception
        {
            public Excecao(string mensagem) : base(mensagem)
            {
                
            }
        }


    }
}