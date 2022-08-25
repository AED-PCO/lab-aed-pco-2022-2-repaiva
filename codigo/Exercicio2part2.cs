for(int i=1; i<1000; i++){
    int b=0;
    for(int j=1; j<i; j++){
        int a=0;
        a = divisor(i,j);
        if(a>0)
            b=soma(b,a);
    }
    if(b==i)
        Console.WriteLine(b);
}

int soma(int x, int y){
    return (x+y);
}

int divisor( int n, int p){
    if(n%p==0)
        return p;
    else
        return 0;
}