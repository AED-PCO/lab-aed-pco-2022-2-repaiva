
int []A = new int []{10, 20, 30, 80, 100, 120};
Console.WriteLine("Informe o valor que deseja procurar");
int pesq = int.Parse(Console.ReadLine());
int resultado =pesquisa(A, pesq);
if(resultado==-1)
    Console.WriteLine("O número desejado não existe no vetor");
else
    Console.WriteLine("O número desejado existe no vetor");

int pesquisa (int []vet, int pesq){
    int fim = vet.Length-1; int inicio = 0; int meio=(inicio+fim)/2;
    int []B = new int [meio+1];
    if(vet[meio]== pesq)
        return meio;
    else if(meio==0)
            return -1;
    else{ 
        if(pesq>vet[meio]){
            inicio=meio;
            for(int i=inicio+1; i<=fim; i++)
                B[i-meio-1]=vet[i];
            return pesquisa(B, pesq);
            }
        fim = meio;
        for(int i=inicio; i<fim; i++)
                B[i]=vet[i];
        return pesquisa(B, pesq);   
    }
}