Console.WriteLine("Informe o número que deseja descobrir sua fatorial");
double fat = double.Parse(Console.ReadLine());
double resultado= fatorial (fat);
if(resultado!=-1)
    Console.WriteLine("A fatorial de {0} é {1}", fat, resultado);
else
    Console.WriteLine("Não existe fatorial de número negativo");   

double fatorial (double fat){
    if(fat==0)
        return 1;
    if(fat>0){
        return (fat*(fatorial(fat-1)));
    }
    return -1;
}