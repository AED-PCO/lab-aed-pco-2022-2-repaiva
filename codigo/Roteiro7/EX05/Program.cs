int []v = new int[]{10, 5, 7, 15, 22, 9, 30};
int a = 6;
int resultado = funcao(a, v);
Console.WriteLine(resultado);
int funcao (int a, int []v){
    if(a == 1)
        return v[0];
    else{
        int x;
        x = funcao(a-1, v);

        if(x > v[a-1])
            return x;
        else    
            return v[a-1];
    }
}

