int []A = new int []{5, 2, 3, 8, 7, 20, 15, 2, 1};
int resultado= cont(A, A.Length-1);
Console.WriteLine("A soma dos numeros pares deste vetor é de: {0}", resultado);

int cont (int [] vet, int pos){
    if(pos==-1)
        return 0;
    if (vet[pos]%2==0)
        return (vet[pos]+cont(vet, pos-1));
    return cont(vet,pos-1);
}