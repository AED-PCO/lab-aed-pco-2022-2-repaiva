using classesPilha;
internal class Program
{
    private static void Main(string[] args)
    {
            Pilha pilha = new Pilha();
            Elemento elemento = new Elemento();
            Elemento elemento01 = new Elemento();
            Elemento elemento02 = new Elemento();
            Random aux = new Random();
            elemento.aluno.matricula = aux.Next(1000);
            pilha.inserir(elemento);
            elemento01.aluno.matricula = aux.Next(1000);
            pilha.inserir(elemento01);
            elemento02.aluno.matricula = aux.Next(1000);
            pilha.inserir(elemento02);
            pilha.imprimir();
            string sn = "";
            do
            {
                Console.WriteLine("Deseja retirar algum valor? S/N");
                sn = Console.ReadLine();
                if(sn == "S" || sn == "s")
                    pilha.retirar();
            }while(sn == "S" || sn == "s");
            pilha.imprimir();
    }
}

namespace classesPilha
{
    public class Aluno
    {
        public int matricula {get; set;}
        public Aluno(){}
    }
    public class Elemento
    {
        public Aluno aluno;
        public Elemento proximo;

        public Elemento()
        {
            this.aluno = new Aluno();
            this.proximo = null;
        }
    }
    public class Pilha
    {
        public Elemento primeiro;
        public Pilha()
        {
            primeiro = new Elemento();
            primeiro.aluno = null;
            primeiro.proximo = null;
        }
        public bool confereSeVazia()
        {
            if(primeiro.proximo == null)
                return true;
            else
                return false;
        }
        public void inserir(Elemento novo)
        {
            if (confereSeVazia())
                primeiro.proximo = novo;
            else
            {
                novo.proximo = primeiro.proximo;
                primeiro.proximo = novo;
            }
        }
        public void retirar()
        {
            if (confereSeVazia())
                Console.WriteLine("A pilha está vazia");
            else
            {
                Console.WriteLine("Elemento retirado: {0}", primeiro.proximo.aluno.matricula);
                primeiro.proximo = primeiro.proximo.proximo;
            }
        }
        public void imprimir()
        {
            Elemento dado = primeiro.proximo;

            Console.WriteLine("PILHA:");
            while (dado != null)
            {
                Console.Write(dado.aluno.matricula+"\t");
                dado = dado.proximo;
            }
            Console.WriteLine();
        }
    }
}