namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
         public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Nokia Instalado aplicativo {nomeApp}");
        }
    }
}