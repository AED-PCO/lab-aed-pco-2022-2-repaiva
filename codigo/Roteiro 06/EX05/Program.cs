Console.WriteLine("quickSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
quickSort(0, vetor.Length-1);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

void quickSort (int inicio, int fim){
    int i = inicio;
    int j = fim;
    int pivo = vetor[(inicio+fim)/2];
    while(i<=j){
        while(vetor[i] < pivo)
            i++;
        while(vetor[j] > pivo)
            j--;
            if(i<=j){
                int aux = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = aux;
                i++;
                j--;
            }
    }
    if(inicio<j)
        quickSort(inicio, j);
    if(i<fim)
        quickSort(i, fim);

}

void imprimeVet (int []vet){
    for (int  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t");
    Console.WriteLine(); 
}

int []prencherVet (int []vet){
    Random aux = new Random();
    for(int i = 0; i<vet.Length; i++)
        vet[i] = aux.Next(100);
    return vet;
}

