Console.WriteLine("Digite a palavra para remover todas as vogais: ");
string palavra = Console.ReadLine();
string resultado = VogDelet(palavra);
Console.WriteLine("A palavra {0} sem vogais fica {1}", palavra, resultado);

static string VogDelet(string texto)
{
    int pos= texto.Length-1;
    if (texto == "") 
        return "";
    if (texto[pos] == 'a' || texto[pos] == 'e' || texto[pos] == 'i' || texto[pos] == 'o' || texto[pos] == 'u') 
        return VogDelet(texto.Substring(0, pos));
    return VogDelet(texto.Substring(0, pos))+texto[pos];
}