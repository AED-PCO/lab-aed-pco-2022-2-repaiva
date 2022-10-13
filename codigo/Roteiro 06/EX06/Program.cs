Console.WriteLine("mergeSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []vetor = new int[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
mergeSort(0, vetor.Length-1);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

void mergeSort (int inicio, int fim){
    if (inicio < fim){
        int meio = (inicio + fim) / 2;
        mergeSort(inicio, meio);
        mergeSort(meio + 1, fim);
        intercalar(inicio, meio, fim);
    }
}

 void intercalar(int inicio, int meio, int fim){
      int ninicio = (meio+1)-inicio;
      int nfim = fim - meio;
      int[] arrayinicio = new int[ninicio+1];
      int[] arrayfim = new int[nfim+1];
      arrayinicio[ninicio] = arrayfim[nfim] = 0x7FFFFFFF;
      int iinicio, ifim, i;     
      for (iinicio = 0; iinicio < ninicio; iinicio++){
         arrayinicio[iinicio] = vetor[inicio+iinicio];
      }
      for (ifim = 0; ifim < nfim; ifim++){
         arrayfim[ifim] = vetor[(meio+1)+ifim];
      }
      for (iinicio = ifim = 0, i = inicio; i <= fim; i++){
         vetor[i] = (arrayinicio[iinicio] <= arrayfim[ifim]) ? arrayinicio[iinicio++] : arrayfim[ifim++];
      }
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

