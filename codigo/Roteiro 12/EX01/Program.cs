using arvore;
internal class Program
{
    private static void Main(string[] args)
    {
        no raiz = new no();
        int reg = -1;
        Console.WriteLine("Informe o valor que deseja inserir");
        reg = int.Parse(Console.ReadLine());
        while(reg != -1)
        {
            arvore.porValor.inserir(ref raiz, reg);
            Console.WriteLine("Informe o valor que deseja inserir");
            reg = int.Parse(Console.ReadLine());
        }
        string[] resultado = arvore.metodosComuns.emOrdem(ref raiz).Split("$");
        for(int i = resultado.Length-2; i > -1; i--)
            Console.Write(resultado[i]+"\t");
    }
}

namespace arvore{
    class no{
        public int registro;
        public no filhoEsquerda;
        public no filhoDireita;

        public no(){
            this.filhoEsquerda = null;
            this.filhoDireita = null;
        }
    }

    class metodosComuns{
        public static string emOrdem(ref no raiz)
        {
            string resultado;
            if(raiz.filhoEsquerda == null)
                resultado = raiz.registro + "$";
        
            else
                resultado = emOrdem(ref raiz.filhoEsquerda) + raiz.registro + "$";
        
            if(raiz.filhoDireita != null)
                resultado += emOrdem(ref raiz.filhoDireita) + "$";
            
            return resultado;
        }
    }

    class porValor{
        public static void inserir(ref no raiz, int reg){
            no novo = new no();
            novo.registro = reg;

            if(raiz.registro < novo.registro){
                if(raiz.filhoEsquerda == null)
                    raiz.filhoEsquerda = novo;
                
                else
                    inserir(ref raiz.filhoEsquerda, reg);
                
            }
            else{
                if(raiz.filhoDireita == null)
                    raiz.filhoDireita = novo;
                
                else
                    inserir(ref raiz.filhoDireita, reg);
            }
        }
    }
}