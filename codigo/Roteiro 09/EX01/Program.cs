internal class Program
{   
    static void inserirVal (int[] vet, int val, ref int aux)
        {           
            vet[aux] = val;
            aux++;
        }
            
      static int removerVal (int[] vet, ref int aux)
        {  
            aux--;
            return vet[aux];    
        }

    static void imprimeVet (int []vet, int aux)
    {
        int j = aux;
        int [] VetAux = new int [vet.Length];
        for(int i = 0; j>0; i++){
            VetAux[i] = vet[j-1];
            j--;
        }
         for(int i = 0; i<aux; i++)
            Console.Write(VetAux[i]+"\t");
        Console.WriteLine();
    }    
    
    static void PilhaParaPilha (int []vet, ref int aux)
    {
        int [] PilhaAux = new int[vet.Length];
        int [] resultado = new int[vet.Length];
        int referencia = 0;
        int referencia2 = 0;
        for(int i = aux; i > 0; i--)
        {
            int removido = removerVal(vet, ref aux);
            inserirVal(PilhaAux, removido, ref referencia);
        }
        for(int i = referencia; i > 0; i--)
        {
            int removido = removerVal(PilhaAux, ref referencia);
            inserirVal(vet, removido, ref aux);
            inserirVal(resultado, removido, ref referencia2);
        }
        Console.WriteLine("Pilha de Entrada:");
        imprimeVet(vet, aux);
        Console.WriteLine("Pilha de Saída:");
        imprimeVet(resultado, referencia2);
        
    }
   static void Main(string[] args)
    {
        Console.WriteLine("LAB 09 - EX01");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        int []resultado;
        int referencia = 0;
        Console.WriteLine("Informe o valor que deseja inserir na pilha (-1 termina)");
        int val = int.Parse(Console.ReadLine());
        while(val != -1)
        {
        inserirVal(vetor, val, ref referencia);
        Console.WriteLine("Informe o valor que deseja inserir na pilha (-1 termina)");
        val = int.Parse(Console.ReadLine());
        }
        PilhaParaPilha(vetor, ref referencia);
    }
}