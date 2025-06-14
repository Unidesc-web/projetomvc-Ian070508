public class ConcessionariaView
    {
        public void ExibirCarros(List<Carro> carros)
        {
            Console.WriteLine("=== Lista de Carros Disponíveis ===");
            foreach (var carro in carros)
            {
                Console.WriteLine($"ID: {carro.Id}, Marca: {carro.Marca}, Modelo: {carro.Modelo}, Preço: R${carro.Preco:F2}");
            }
            Console.WriteLine("===================================");
        }
    }