internal class Program
{   
    static int aux = 0;
    static void inserirNumero(int[] vet)
        {           
            string sn;
            do{
            Console.WriteLine("Informe o valor a ser inserido no vetor");
            int val = int.Parse(Console.ReadLine());
            vet[aux] = val;
            aux++;
            Console.WriteLine("Deseja inserir outro valor? R: S/N");
            sn = Console.ReadLine();
            }while((sn == "S" || sn == "s") && aux<vet.Length);
            Console.WriteLine("Vetor com os valores inseridos");
            imprimeVet(vet);
            Console.WriteLine();
        }
    static void consumirNumero(int[] vet)
        {  
            string sn;
            Console.WriteLine("Deseja retirar um valor valor? R: S/N");
            sn = Console.ReadLine();
            if(sn == "S" || sn == "s"){
            do{
            Console.WriteLine("Valor retirado");
            Console.WriteLine(vet[0]);    
            shift(vet);
            aux--;
            Console.WriteLine("Deseja retirar outro valor valor? R: S/N");
            sn = Console.ReadLine();
            }while(sn == "S" || sn == "s");
            }
            Console.WriteLine("Vetor depois dos valores retirados");
            imprimeVet(vet);
            Console.WriteLine();
        }
   static void imprimeVet (int []vet){
        int j = aux;
        while(j>0){
        int r = vet[0];
        Console.Write(r+"\t");
        shift(vet);    
        vet[aux-1] = r;
        j--;
        }
    }
    static void shift(int []vet){
        for(int i = 0; i<aux-1; i++)
            vet[i] = vet[i+1];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("FILA");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        inserirNumero(vetor);
        consumirNumero(vetor); 
    }
}