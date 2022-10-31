Console.WriteLine("Informe um valor para a função");
int teste = int.Parse(Console.ReadLine());
int resultado = FuncRec1(teste);
Console.WriteLine("A função retornou {0}", resultado);

int FuncRec1(int a){
    if(a<=1)
        return 0;
    else 
        return FuncRec1((a-2)+5);
}