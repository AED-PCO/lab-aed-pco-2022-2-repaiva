Console.WriteLine("IsertionSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
IsertionSort(vetor);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

int []IsertionSort (int []vet){
    for(int i = 1; i<vet.Length; i++){
        int j = i-1;
        int aux = vet[i];
        while(j>=0 && (vet[j]>aux)){
            vet[j+1] = vet[j];
            j--;
        }
        vet[j+1] = aux;
    }
    return vet;
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

