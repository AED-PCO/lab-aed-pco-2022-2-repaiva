Console.WriteLine("selectSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
selectSort(vetor);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

int []selectSort (int []vet){
    for(int i=0; i<vet.Length-1; i++){
        int pos=i;
        for(int j=i+1; j<vet.Length; j++){    
            if(vet[j]<vet[pos])
                pos = j;
        }
        int aux = vet[i];
        vet[i] = vet[pos];
        vet[pos] = aux;

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

