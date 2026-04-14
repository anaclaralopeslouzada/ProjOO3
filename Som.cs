namespace HomeTheater
{
    public class Som {
        public void Ligar() => Console.WriteLine("Som: Sistema de áudio ligado.");
        public void DefinirVolume(int vol) => Console.WriteLine($"Som: Volume definido em {vol}.");
        public void Desligar() => Console.WriteLine("Som: Áudio desligado.");
    }
}
