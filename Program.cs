namespace HomeTheater
{
    class Program {
        static void Main(string[] args) {
            // Criando os aparelhos
            Luzes luzes = new Luzes();
            Som som = new Som();
            Streaming streaming = new Streaming();

            // Criando a Fachada
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(luzes, som, streaming);

            // Chama um método
            homeTheater.AssistirFilme("Vingadores: Ultimato");

            // Para desligar tudo
            homeTheater.EncerrarFilme();
        }
    }
}
