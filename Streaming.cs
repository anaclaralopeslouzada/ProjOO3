namespace HomeTheater
{
    public class Streaming {
        public void Play(string filme) => Console.WriteLine($"Streaming: Iniciando o filme '{filme}'...");
        public void Parar() => Console.WriteLine("Streaming: Parando reprodução.");
    }
}
