Console.WriteLine("Informe a base");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a potencia");
int pot = int.Parse(Console.ReadLine());
potencia(ref B, pot);
Console.WriteLine("O resultado é: {0}", B);

void potencia (ref int x, int y){
    int aux=x;
    for(int i=1; i<y; i++)
       x=x*aux;
}