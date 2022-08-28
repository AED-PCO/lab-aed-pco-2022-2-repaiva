int aux=0;     
Console.WriteLine("Informe a base desejada");
int bas = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o expoente desejado");
int exp = int.Parse(Console.ReadLine());
int resultado= potencia (bas, exp);
Console.WriteLine("{0} elevado a {1} é igual {2}", bas, exp, resultado);

int potencia (int B, int pot){
    if(pot==0)
        return 1;
    return (B*potencia(B, pot-1));
}
