internal class Program
{   
    static void inserirVal (int[] vet, int val, ref int aux)
        {           
            vet[aux] = val;
            aux++;
        }
            
    static int removerValFila (int[] vet, ref int aux)
        {  
            int valor = vet[0];
            shift(vet, aux);
            aux--;
            return valor;    
        }

    static int removerValPilha (int[] vet, ref int aux)
        {  
            aux--;
            return vet[aux];    
        }

   static void imprimeVet (int []vet, int aux){
        int j = aux;
        while(j>0){
        int r = vet[0];
        Console.Write(r+"\t");
        shift(vet, aux);    
        vet[aux-1] = r;
        j--;
        }
        Console.WriteLine();
    } 
    static void shift(int []vet, int aux){
        for(int i = 0; i<aux-1; i++)
            vet[i] = vet[i+1];
    }

    static void FilaParaFila (int []vet, ref int aux)
    {
        int [] FilaAux = new int[vet.Length];
        int [] PilhaAux = new int[vet.Length];
        int [] resultado = new int[vet.Length];
        int referencia = 0;
        int referencia2 = 0;
        int referencia3 = 0;
        int referencia4 = 0;
        for(int i = aux; i > 0; i--)
        {
            int removido = removerValFila(vet, ref aux);
            inserirVal(PilhaAux, removido, ref referencia);
            inserirVal(FilaAux, removido, ref referencia2);
        }
        for(int i = referencia; i > 0; i--)
        {
            int removido = removerValPilha(PilhaAux, ref referencia);
            inserirVal(resultado, removido, ref referencia3);
            removido = removerValFila(FilaAux, ref referencia2);
            inserirVal(vet, removido, ref referencia4);
        }
        Console.WriteLine("Fila de Entrada:");
        imprimeVet(vet, referencia4);
        Console.WriteLine("Fila de Saída:");
        imprimeVet(resultado, referencia3);
        
    }
   static void Main(string[] args)
    {
        Console.WriteLine("LAB 09 - EX01");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        int []resultado;
        int referencia = 0;
        Console.WriteLine("Informe o valor que deseja inserir na fila (-1 termina)");
        int val = int.Parse(Console.ReadLine());
        while(val != -1)
        {
        inserirVal(vetor, val, ref referencia);
        Console.WriteLine("Informe o valor que deseja inserir na fila (-1 termina)");
        val = int.Parse(Console.ReadLine());
        }
        FilaParaFila(vetor, ref referencia);
    }
}