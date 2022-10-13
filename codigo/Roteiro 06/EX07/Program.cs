Console.WriteLine("countingSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
int []resultado = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
countingSort();
//Console.WriteLine("Vetor Ordenado:");
//imprimeVet(vetor);

void countingSort (){
    int maior = 0;
    for(int i = 0; i<vetor.Length-1; i++)
        if(vetor[i]>maior)
            maior = vetor[i];
    int []cont = new int[maior+1];
    int []ordenado = new int[vetor.Length];
    for(int i = 0; i<vetor.Length; i++)
            cont[vetor[i]]++;
    for(int i = 1; i<cont.Length; i++)
        cont[i] += cont[i-1];
    for(int i = vetor.Length-1; i>=0; cont[vetor[i]]--, i--)
        ordenado[cont[vetor[i]]-1] = vetor[i];
    Console.WriteLine("Vetor Ordenado:");
    imprimeVet(ordenado);
}

void imprimeVet (int []vet){
    for (int  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t");
    Console.WriteLine(); 
}

int []prencherVet (int []vet){
    Random aux = new Random();
    for(int i = 0; i<vet.Length; i++)
        vet[i] = aux.Next(50);
    return vet;
}

