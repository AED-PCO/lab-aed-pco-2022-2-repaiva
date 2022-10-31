Console.WriteLine("Informe quantos CPFs deseja gerar");
int tam = int.Parse(Console.ReadLine());
long []vetor = new long [tam];
preencheVet (vetor);
Console.WriteLine("Vetor Gerado:");
imprimeVet(vetor);
quickSort(0, tam-1);
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
    string cpf = rnd.Next(100000000, 999999999).ToString();

    for (int i = 0; i < 9; i++)
        soma += int.Parse(cpf[i].ToString()) * multiplicador1[i];

    resto = soma % 11;
    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    cpf = cpf + resto;
    soma = 0;

    for (int i = 0; i < 10; i++)
        soma += int.Parse(cpf[i].ToString()) * multiplicador2[i];

    resto = soma % 11;

    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    cpf = cpf + resto;
    long retorno = long.Parse(cpf);
    return retorno;
}

void quickSort (int inicio, int fim){
    int i = inicio;
    int j = fim;
    long pivo = vetor[(inicio+fim)/2];
    while(i<=j){
        while(vetor[i] < pivo)
            i++;
        while(vetor[j] > pivo)
            j--;
            if(i<=j){
                long aux = vetor[i];
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

void imprimeVet (long []vet){
    for (int  i = 0; i < vet.Length;  i++ ) 
        Console.Write(vet[i]+"\t");
    Console.WriteLine(); 
}

using (StreamWriter writer = new StreamWriter("CPFs.txt", true))
{
    for(int i = 0; i<vetor.Length; i++){
        writer.Write(vetor[i]);
        writer.Write("   ");
    }
}