Console.WriteLine("Informe o número");
int primo= int.Parse(Console.ReadLine());
int resultado= ehprimo(primo);
if(resultado==0)
    Console.WriteLine("O número é primo");        
else
    Console.WriteLine("O número não é primo");

int ehprimo(int primo){
    int aux=0;
    for(int i=2; i<primo; i++){
        if(primo%i == 0)
            aux++;
}
    return aux;
}