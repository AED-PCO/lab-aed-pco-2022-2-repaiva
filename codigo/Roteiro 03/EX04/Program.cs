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
int aux=0;
int resultado = pesquisa(A, pesq);
if(resultado==-1)
    Console.WriteLine("O número desejado não existe no vetor");
else
    Console.WriteLine("O número desejado existe no vetor na posição {0}", resultado);

int pesquisa (int []vet, int pesq){
    int fim = vet.Length-1;
    int inicio = 0;
    int meio=(inicio+fim)/2;
    int []B = new int [meio+1];
    if(vet[meio]== pesq){
        for(int i=0; i<A.Length; i++)
            if(vet[meio]==A[i])
                aux=i;
        return aux;
    }
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