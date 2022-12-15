using arvore;
internal class Program
{
    private static void Main(string[] args)
    {
        no raiz = new no();
        int flag = -1;
        while(flag != 0)
        {
            Console.WriteLine();
            Console.WriteLine("ESCOLHA UMA OPÇÃO: \n 1 - Inserir \n 2 - Em Ordem \n 3 - Pré Ordem \n 4 - Pos Ordem \n 0 - terminar");
            flag = int.Parse(Console.ReadLine());
            switch(flag)
            {
                case 1: insere.Chamainserir(raiz); Console.WriteLine(); break;
                case 2: impressao.emOrdem(raiz); Console.WriteLine(); break;
                case 3: impressao.PreOrdem(raiz); Console.WriteLine(); break;
                case 4: impressao.PosOrdem(raiz); Console.WriteLine(); break;
            }
        }
    }
}

namespace arvore{
class no{
    public int registro;
    public no filhoEsquerda;
    public no filhoDireita;
    public no()
    {
        this.filhoEsquerda = null;
        this.filhoDireita = null;
    }
}

class impressao{
        public static void emOrdem(no raiz)
        {
            if (raiz!=null) {
                emOrdem(raiz.filhoEsquerda);
                Console.Write(raiz.registro+"\t");
                emOrdem(raiz.filhoDireita);
            }
        }
        public static void PreOrdem(no raiz) {
        if (raiz!=null) {
            Console.Write(raiz.registro+"\t");
            PreOrdem(raiz.filhoEsquerda);
            PreOrdem(raiz.filhoDireita);
        }
    }
    public static void PosOrdem(no raiz) {
        if (raiz!=null) {            
            PosOrdem(raiz.filhoEsquerda);
            PosOrdem(raiz.filhoDireita);
            Console.Write(raiz.registro+"\t");
        }
    }
}
class insere{
    public static void Chamainserir(no raiz)
    {
        Console.WriteLine("Informe o valor que deseja inserir");
        int reg = int.Parse(Console.ReadLine());
        inserir(raiz, reg);
    }
    public static void inserir(no raiz, int reg){
        no novo = new no();
        novo.registro = reg;
        if(raiz.registro < novo.registro){
            if(raiz.filhoEsquerda == null)
                raiz.filhoEsquerda = novo;
                
            else
                inserir(raiz.filhoEsquerda, reg);  
        }
        
        else{
            if(raiz.filhoDireita == null)
                raiz.filhoDireita = novo;
            
            else
                inserir(raiz.filhoDireita, reg);
        }
    }
}
}
