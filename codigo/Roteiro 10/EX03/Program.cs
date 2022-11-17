internal class Program
{
    private static void Main(string[] args)
    {
        int val;
        Lista lista = new Lista();
        Elemento elemento = new Elemento();
        Elemento elemento01 = new Elemento();
        Elemento elemento02 = new Elemento();
        Elemento elemento03 = new Elemento();
        Elemento elementoainserir = new Elemento();
        Random aux = new Random();
        elemento.aluno.Matricula = aux.Next(1000);
        lista.inserir(elemento);
        elemento01.aluno.Matricula = aux.Next(1000);
        lista.inserir(elemento01);
        elemento02.aluno.Matricula = aux.Next(1000);
        lista.inserir(elemento02);
        elemento03.aluno.Matricula = aux.Next(1000);
        lista.inserir(elemento03);
        lista.imprimir();
        Console.WriteLine("Informe a posição que deseja inserir");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor que deseja inserir");
        val = int.Parse(Console.ReadLine());
        elementoainserir.aluno.Matricula = val;
        lista.inserir(elementoainserir, pos);
        lista.imprimir();
        string sn = "";
        do
        {
            Console.WriteLine("Deseja retirar algum valor? S/N");
            sn = Console.ReadLine();
            if(sn == "S" || sn == "s")
            {
                Console.WriteLine("Qual elemento deseja retirar da lista?");
                val = int.Parse(Console.ReadLine());
                lista.retirar(val);
            }
        }while(sn == "S" || sn == "s");
        lista.imprimir();
    }
}
public class Aluno
{
    private int matricula;
    public int Matricula 
    {
        get{return matricula;}
        set{matricula = value;}
    }
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
public class Lista
{
    public Elemento primeiro;
    public Elemento ultimo;
    public Lista()
    {
        primeiro = new Elemento();
        ultimo = new Elemento();
        primeiro.aluno = null;
        primeiro.proximo = null;
        ultimo.aluno = null;
        ultimo.proximo = null;
    }
    public bool confereSeVazia()
    {
        if(primeiro.proximo == null)
            return true;
        else
            return false;
    }
    public void inserir(Elemento novo, int pos = -1)
    {
        int cont = 1;
        if (confereSeVazia())
        {
            primeiro.proximo = novo;
            ultimo = novo;
        }
        else
        {
            if (pos == -1)
                {
                    ultimo.proximo = novo;
                    ultimo = novo;
                }
            else
            {
                Elemento aux = primeiro;
                Elemento auxRet;
                while (cont < pos && aux.proximo != null)
                {
                    cont++;
                    aux = aux.proximo;
                }
                novo.proximo = aux.proximo;
                aux.proximo = novo;
            }
        }
    }
    public void retirar(int val)
    {
        if (confereSeVazia())
            Console.WriteLine("A Lista está vazia");
        else
        {
            Elemento aux = primeiro;
            Elemento auxRet;
            bool procura = false;
            while (aux.proximo != null)
            {
                if (aux.proximo.aluno.Matricula == val)
                {
                    procura = true;
                    break;
                }                    
                aux = aux.proximo;
            }
            if(procura)
            {
                auxRet = aux.proximo;
                aux.proximo = auxRet.proximo;
                Console.WriteLine("Elemento retirado: {0}", auxRet.aluno.Matricula);
            }
            else
                Console.WriteLine("Elemento não encontrado na lista!");
        }
    }
    public void imprimir()
    {
        Elemento elemento = primeiro.proximo;
        Console.WriteLine("LISTA:");
        while (elemento != null)
        {
            Console.Write(elemento.aluno.Matricula+"\t");
            elemento = elemento.proximo;
        }
        Console.WriteLine();
    }
}