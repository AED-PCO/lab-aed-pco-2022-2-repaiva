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
            Console.WriteLine(vet[aux-1]);    
            aux--;
            Console.WriteLine("Deseja retirar outro valor valor? R: S/N");
            sn = Console.ReadLine();
            }while((sn == "S" || sn == "s") && aux>0);
            }
            Console.WriteLine("Vetor com os valores retirados");
            imprimeVet(vet);
            Console.WriteLine();
        }

    static void imprimeVet (int []vet){
        int j = aux;
        int [] VetAux = new int [vet.Length];
        for(int i = 0; j>0; i++){
            VetAux[i] = vet[j-1];
            j--;
        }
         for(int i = 0; i<aux; i++)
            Console.Write(VetAux[i]+"\t");
    }    

//    static void imprimeVet (int []vet){
//         int j = aux;
//         while(j>0){
//         int r = vet[aux-1];
//         Console.Write(r+"\t");
//         shift(vet);
//         vet[0] = r;
//         j--;
//         }
//     }

    // static void shift(int []vet){
    //     for(int i = aux-1; i>0; i--)
    //         vet[i] = vet[i-1];
    // }
    static void Main(string[] args)
    {
        Console.WriteLine("PILHA");
        Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
        int tam = int.Parse(Console.ReadLine());
        int[] vetor = new int[tam];
        inserirNumero(vetor);
        consumirNumero(vetor); 
    }
}