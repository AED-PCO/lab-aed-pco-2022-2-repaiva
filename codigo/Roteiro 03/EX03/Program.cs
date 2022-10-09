Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []A = new int[tam];
prencherVet(A);
Array.Sort(A);
Console.WriteLine("Vetor Gerado:");
imprimeVet(A);
Console.WriteLine();
Console.WriteLine("Informe o valor que deseja procurar");
int pesq = int.Parse(Console.ReadLine());
int posicao = tam/2;
int resultado = pesquisa(A, pesq, posicao);
if(resultado==-1)
    Console.WriteLine("O número desejado não existe no vetor");
else
    Console.WriteLine("O número desejado existe no vetor na posição {0}", resultado);

int pesquisa (int[] vet, int pesq, int pos){
    if(pesq==vet[pos])
        return pos;
    if(pos == vet.Length-1 || pos == 0)
        return -1;
    else if(pesq<vet[pos])
            return pesquisa(vet, pesq, (pos/2));
    else if(pesq>vet[pos])
            return pesquisa(vet, pesq, (pos+((vet.Length-pos)/2)));
    return -1;
}

void imprimeVet (int []vet){
    for (int  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t"); 
}

int []prencherVet (int []vet){
    Random aux = new Random();
    for(int i = 0; i<vet.Length; i++)
        vet[i] = aux.Next(100);
    return vet;
}