
using System.Text;
using DesafioHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new ("Hóspede 1", "Teste1");
Pessoa p2 = new ("Hóspede 2", "Teste2"); 
Pessoa p3 = new ("Hóspede 3", "Teste3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new ("Premium", 10, 90);
Suite suite2 = new ("Luxo", 3, 70);
Suite suite3 = new ("Stantard", 4, 50);

Reserva reserva = new (5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("Suite: {0} - Valor diária: {1}", suite.TipoSuite, suite.ValorDiaria);
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

