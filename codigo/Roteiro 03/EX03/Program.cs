Console.WriteLine("Informe o tamanho do vetor desejado (maior que zero)");
int tam = int.Parse(Console.ReadLine());
int []resultado = new int[tam];
lerVet(resultado);
resultado = parteVet(resultado);
imprimeVet(resultado);

int[] parteVet (int []vet){
    if(vet.Length==1)
        return vet;

    if(vet.Length%2==0){
        int []B = new int [((vet.Length)/2)];
        int []C = new int [((vet.Length)/2)];
        for(int i=0; i<B.Length; i++)   
            B[i]=vet[i];
        for(int i=0; i<C.Length; i++)
            C[i]=vet[i+vet.Length/2]; 
        int[] ordeB = new int [B.Length];
        int[] ordeC = new int [C.Length];  
        ordeB = parteVet(B);
        ordeC = parteVet(C);
        resultado = ordenaVet(ordeB, ordeC);
    }

    else {
    int []B = new int [(vet.Length/2)];
    int []C = new int [((vet.Length/2)+1)];
    for(int i=0; i<B.Length; i++)   
        B[i]=vet[i];
    for(int i=0; i<C.Length; i++)
        C[i]=vet[i+vet.Length/2];
    int[] ordeB = new int [B.Length];
    int[] ordeC = new int [C.Length];
    ordeB = parteVet(B);
    ordeC = parteVet(C);
    resultado = ordenaVet(ordeB, ordeC);
    }

    return resultado;
}

int []ordenaVet(int []vet1, int []vet2){
    int cont1=0; 
    int cont2=0;
    int []ordenado = new int [vet1.Length+vet2.Length];
    for(int i = 0; i<ordenado.Length; i++){
        if(cont1==vet1.Length){
            ordenado[i]=vet2[cont2];
            cont2++;
        }
        else if(cont2==vet2.Length){
            ordenado[i]=vet1[cont1];
            cont1++;
        }
        else if(vet1[cont1]<vet2[cont2]){
            ordenado[i]=vet1[cont1];
            cont1++;
        }
        else{
            ordenado[i]=vet2[cont2];
            cont2++;
        }
    }
    return ordenado;
}

void lerVet (int []vet){
    Console.WriteLine("Digite os {0} valores do vetor", tam);
    for(int i = 0; i<vet.Length; i++)
        vet[i] = int.Parse(Console.ReadLine());
}

void imprimeVet (int []vet){
    Console.WriteLine();
    Console.WriteLine("O vetor ordenado é:");
    for (int  i = 0; i < resultado.Length;  i++ ) 
        Console.Write(resultado[i]+"\t"); 
}
