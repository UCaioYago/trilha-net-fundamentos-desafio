namespace DesafioFundamento.Models
{
    public class Estacionamento
    {
        // precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
        // precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        // veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorhora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora= precoPorhora;
        }
        // AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacinar: ");

            var veiculo = Console.ReadLine();

            Veiculos.Add(veiculo);
        }
        // RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");

            var placa = Console.ReadLine();

            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permanceu estacinado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal preco = horas * PrecoPorHora;
                decimal valorTotal = preco + PrecoInicial;

                Veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

            }
        }
        // ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".
        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                Veiculos.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
