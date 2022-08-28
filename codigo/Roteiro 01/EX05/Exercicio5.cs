 
int N, Fat=1; 
char repetir; 
do { 
 Fat=1;
 Console.WriteLine();
 Console.WriteLine("EXEMPLO PARA CALCULAR FATORIAL DE N"); 
 Console.WriteLine("Entre com um valor para cálculo do fatorial: "); 
 N = int.Parse(Console.ReadLine()); 
 if (N >= 0) 
 { 
    int numero=N;
    while(numero>0)
    {
        Fat=Fat*numero;
        numero--;
    }
   Console.WriteLine("O fatorial de {0} é {1}", N, Fat); 
 } 
 else Console.WriteLine("Não posso calcular fatorial de número negativo");
 Console.WriteLine("\n Deseja repetir o programa ? (S / N)"); 
repetir = Console.ReadKey().KeyChar; 
} while (repetir == 'S' || repetir == 's'); 

