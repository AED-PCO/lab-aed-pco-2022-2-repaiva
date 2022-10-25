Console.WriteLine("Informe quantos CPFs deseja gerar");
int tam = int.Parse(Console.ReadLine());
long []vetor = new long [tam];
preencheVet(vetor);
//mergeSort(0, vetor.Length-1);
Console.WriteLine("Vetor Ordenado:");
imprimeVet(vetor);

void preencheVet (long []vet){
     for(int i = 0; i<vet.Length; i++)
        vet[i] = GerarCpf(); 
}

long GerarCpf(){
 int soma = 0, resto = 0;
    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

    Random rnd = new Random();
    string semente = rnd.Next(100000000, 999999999).ToString();

    for (int i = 0; i < 9; i++)
        soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

    resto = soma % 11;
    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    semente = semente + resto;
    soma = 0;

    for (int i = 0; i < 10; i++)
        soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

    resto = soma % 11;

    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    semente = semente + resto;
    long cpf = long.Parse(semente);
    return cpf;
}

void mergeSort (long inicio, long fim){
    if (inicio < fim){
        long meio = (inicio + fim) / 2;
        mergeSort(inicio, meio);
        mergeSort(meio + 1, fim);
        intercalar(inicio, meio, fim);
    }
}

 void intercalar(long inicio, long meio, long fim){
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
    for (int  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t");
    Console.WriteLine(); 
}
