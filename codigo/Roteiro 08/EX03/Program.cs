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
                imprimeVet(vet);        
                Console.WriteLine("Informe a posição que deseja inserir no vetor (-1 termina)");
                flag = int.Parse(Console.ReadLine());
            }
        }
    static void retirarNumero(int[] vet)
        {  
            Console.WriteLine("Informe a posição do valor que deseja retiar do vetor (-1 termina)");
            int flag = int.Parse(Console.ReadLine());
            while(flag != -1){
                if(flag >= aux)
                    Console.WriteLine("INFORME UMA POSIÇÃO QUE EXISTA NA LISTA OU -1 PARA ENCERAR");
                if(flag == aux-1)                 
                    aux--;
                if(flag < aux-1){
                    shiftEsquerda(vet, flag);
                    aux--;
                }
                Console.WriteLine("Vetor Resultante:");
                imprimeVet(vet);
                Console.WriteLine("Informe a posição do valor que deseja retiar do vetor (-1 termina)");
                flag = int.Parse(Console.ReadLine());
            }
        }
    static void imprimeVet (int []vet){
        for (int  i = 0; i < aux;  i++ ) 
            Console.Write(vet[i]+"\t");
        Console.WriteLine(); 
    }
    static void shiftDireita(int []vet, int fim){
        for(int i = aux-1; i>fim; i--)
            vet[i] = vet[i-1];
    }
    static void shiftEsquerda(int []vet, int inicio){
        for(int i = inicio; i<aux; i++)
            vet[i] = vet[i+1];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("LISTA");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        inserirNumero(vetor);
        retirarNumero(vetor); 
    }
}