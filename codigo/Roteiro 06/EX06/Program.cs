Console.WriteLine("mergeSort");
Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
long tam = long.Parse(Console.ReadLine());
long []vetor = new long[tam];
prencherVet(vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
mergeSort(0, vetor.Length-1);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

void mergeSort (long inicio, long fim){
    if (inicio < fim){
        long meio = (inicio + fim) / 2;
        mergeSort(inicio, meio);
        mergeSort(meio + 1, fim);
        longercalar(inicio, meio, fim);
    }
}

 void longercalar(long inicio, long meio, long fim){
      long ninicio = (meio+1)-inicio;
      long nfim = fim - meio;
      long[] arrayinicio = new long[ninicio+1];
      long[] arrayfim = new long[nfim+1];
      arrayinicio[ninicio] = arrayfim[nfim] = 0x7FFFFFFF;
      long iinicio, ifim, i;     
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

void imprimeVet (long []vet){
    for (long  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t");
    Console.WriteLine(); 
}

long []prencherVet (long []vet){
    Random aux = new Random();
    for(long i = 0; i<vet.Length; i++)
        vet[i] = aux.Next(100);
    return vet;
}

