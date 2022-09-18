
int []A = new int []{10, 20, 30, 80, 100, 120};
Console.WriteLine("Informe o valor que deseja procurar");
int pesq = int.Parse(Console.ReadLine());
int inicio = 0;
int fim = A.Length-1;
int resultado = pesquisa(A, pesq, inicio, fim);
if(resultado==-1)
    Console.WriteLine("O número desejado não existe no vetor");
else
    Console.WriteLine("O número desejado existe no vetor");

int pesquisa (int []vet, int pesq, int inicio, int fim){
    int pos=(inicio+fim)/2;
    int []B = new int [pos+1];
    if(vet[pos]== pesq)
        return pos;
    else if(pos==0)
            return -1;
    else{ 
        if(pesq>vet[pos]){
            inicio=pos;
            for(int i=inicio+1; i<=fim; i++)
                B[i-pos-1]=vet[i];
            return pesquisa(B, pesq, 0, fim);
            }
        fim = pos;
        for(int i=inicio; i<fim; i++)
                B[i]=vet[i];
        return pesquisa(B, pesq, 0, fim);   
    }
    
}