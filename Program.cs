double tempo, distancia, velocidade = 340.29, horasExtras;

Console.Clear();
Console.WriteLine("---Raio e Trovão---\n");

tempo = SolicitarValor("Informe o atraso entre raio e o trovão: ");

distancia = Calculartempo(velocidade, tempo);

Console.WriteLine($"a distancia entre você e o raio é: {distancia:N2}KM");

double Calculartempo(double velocidade
                      , double tempo)
{
    double distancia = (tempo * velocidade) / 1000;
    return distancia;
}

double SolicitarValor(string mensagem)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{mensagem} ");
    Console.ResetColor();
    return Convert.ToDouble(Console.ReadLine());
}