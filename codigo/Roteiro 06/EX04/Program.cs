Console.WriteLine("shellSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o hop h inicial (maior que zero e menor que o tamnho do vetor)");
int hop = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
shellSort(vetor);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

int []shellSort (int []vet){
    for(int h = hop; h>0; h=h/2){
        for(int i = h; i<vet.Length; i++){
            int j = i-h;
            int aux = vet[i];
            while(j>=0 && (vet[j]>aux)){
                vet[j+h] = vet[j];
                j = j-h;
            }
            vet[j+h] = aux;
        }
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

