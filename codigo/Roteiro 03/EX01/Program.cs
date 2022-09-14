
int []A = new int {10, 20, 30, 40, 50};
Console.WriteLine("Informe o valor que deseja procurar");
int pesq = int.Parse(Console.ReadLine());
int inicio=0;
int meio=A.Length/2;
int fim=A.Length-1;
int resultado =pesquisa(A, inicio, meio, fim, pesq);
if(resultado==-1)
    Console.WriteLine("O número desejado não existe no vetor");
else
    Console.WriteLine("A posição do número desejado é: {0}", resultado);

int pesquisa (int vet, int inicio, int meio, int fim, int pesq){
    if(inicio>fim)
        return meio;
    if(vet[meio]==pesq)
        return meio;
    else{ 
        if(pesq>vet[meio])
            return pesquisa(meio+1);
        if(pesq>vet[meio])
            return pesquisa(meio-1);
    }
}
