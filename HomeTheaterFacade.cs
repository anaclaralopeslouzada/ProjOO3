namespace HomeTheater
{
    public class HomeTheaterFacade {
        private Luzes _luzes;
        private Som _som;
        private Streaming _streaming;

        public HomeTheaterFacade(Luzes luzes, Som som, Streaming streaming) {
            _luzes = luzes;
            _som = som;
            _streaming = streaming;
        }

        public void AssistirFilme(string filme) {
            Console.WriteLine("\nPreparando para o filme");
            _luzes.Escurecer();
            _som.Ligar();
            _som.DefinirVolume(10);
            _streaming.Play(filme);
            Console.WriteLine("Bom filme!\n");
        }

        public void EncerrarFilme() {
            Console.WriteLine("\nEncerrando o sistema");
            _streaming.Parar();
            _som.Desligar();
            _luzes.Acender();
            Console.WriteLine("Sistema desligado\n");
        }
    }
}
