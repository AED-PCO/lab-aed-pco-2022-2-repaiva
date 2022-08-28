Console.WriteLine("Escreva a frase desejada");
string frase= Console.ReadLine();
Console.WriteLine("Escreva a letra desejada");
char caracter= char.Parse(Console.ReadLine());
int resultado = ContLetra(frase, caracter);
Console.WriteLine("O caracter {0} foi encontrado {1} vezes na frase", caracter, resultado);

int ContLetra(string texto, char letra){
    if(texto=="")
        return 0;
    if(texto.Length-1==letra)
        return (ContLetra(frase.Substring(-1), caracter)+1);
    return (ContLetra(frase.Substring(-1), caracter));
}