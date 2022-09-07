int aux=0;     
Console.WriteLine("Informe o primeiro número da multiplicação");
int multA = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número da multiplicação");
int multB = int.Parse(Console.ReadLine());
int resultado= multiplica (multA, multB);
Console.WriteLine("{0} vezes {1} é igual {2}", multA, multB, resultado);

int multiplica (int A, int B){
    if(B==0)
        return 0;
    if(B>0)
        return (A+(multiplica(A, B-1)));
    if(B<0 && A<0 && aux==0){
        aux++;
        return (A+(multiplica(A, B+1)))*-1;
        }
    return (A+(multiplica(A, B+1)));
}
