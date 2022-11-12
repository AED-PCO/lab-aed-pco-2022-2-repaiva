internal class Program
{   
    static int aux = 0;
    static  void inserirNumero(int[] vet)
        {         
            Console.WriteLine("Informe a posição que deseja inserir no vetor (-1 termina)");
            int flag = int.Parse(Console.ReadLine());
            while(flag != -1){
                Console.WriteLine("Informe o valor que quer inserir");
                int val = int.Parse(Console.ReadLine());
                if(flag >= aux){
                    vet[aux] = val;
                    aux++;
                }
                else{
                    aux++;
                    shiftDireita(vet, flag);
                    vet[flag] = val;
                }
                Console.WriteLine("Vetor Resultante:");
                imprimeVet(vet, aux);        
                Console.WriteLine("Informe a posição que deseja inserir no vetor (-1 termina)");
                flag = int.Parse(Console.ReadLine());
            }
        }
    static void ListaParaLista(int[] vet)
        {  
            int [] resultado = new int[aux*2];
            int []listaAux = new int [aux];
            for(int i = 0; i <listaAux.Length; i++)
                listaAux[i] = vet[listaAux.Length-i-1];
            for(int i = 0; i <resultado.Length; i++)
                resultado[i] = vet[i];
            for(int i = listaAux.Length; i <resultado.Length; i++)
                resultado[i] = listaAux[i-listaAux.Length];
            imprimeVet(resultado, resultado.Length);
        }
    static void imprimeVet (int []vet, int aux){
        for (int  i = 0; i < aux;  i++ ) 
            Console.Write(vet[i]+"\t");
        Console.WriteLine(); 
    }
    static void shiftDireita(int []vet, int fim){
        for(int i = aux-1; i>fim; i--)
            vet[i] = vet[i-1];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("LISTA");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        inserirNumero(vetor);
        ListaParaLista(vetor); 
    }
}