namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
			string placa = Console.ReadLine();
            if (ChecarSeVeiculoExiste(placa)) {
                Console.WriteLine("Veiculo já cadastrado no estacionamento.");
                return;
            }
			veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (ChecarSeVeiculoExiste(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
				veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
				foreach (var veiculo in veiculos)
				{
					Console.WriteLine($"Placa - {veiculo}");
				}
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private bool ChecarSeVeiculoExiste(string placa) {
            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase))) {
                return true;
            }
            return false;
        }
    }
}
