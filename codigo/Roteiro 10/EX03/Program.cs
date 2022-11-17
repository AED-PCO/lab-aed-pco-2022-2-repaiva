internal class Program
{
    private static void Main(string[] args)
    {
        Lista lista = new Lista();
        Elemento elemento = new Elemento();
        Elemento elemento01 = new Elemento();
        Elemento elemento02 = new Elemento();

        Console.WriteLine("Informe a posição que deseja inserir");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor que deseja inserir");
        int val = int.Parse(Console.ReadLine());
        elemento.aluno.Matricula = val;
        lista.inserir(elemento, pos);
        Console.WriteLine("Informe a posição que deseja inserir");
        pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor que deseja inserir");
        val = int.Parse(Console.ReadLine());
        elemento01.aluno.Matricula = val;
        lista.inserir(elemento01, pos);
        Console.WriteLine("Informe a posição que deseja inserir");
        pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor que deseja inserir");
        val = int.Parse(Console.ReadLine());
        elemento02.aluno.Matricula = val;
        lista.inserir(elemento02, pos);
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
    public void inserir(Elemento novo, int pos)
    {
        int cont = 0;
        if (confereSeVazia())
        {
            primeiro.proximo = novo;
            ultimo = novo;
        }
        else
        {
            Elemento aux = primeiro;
            while (cont < pos && aux.proximo != null)
            {
                cont++;
                aux = aux.proximo;
            }
            novo.proximo = aux.proximo;
            aux.proximo = novo; 
        }
    }
    public void retirar(int val)
    {
        if (confereSeVazia())
            Console.WriteLine("A Lista está vazia");
        else
        {
            int flag = 0;
            Elemento aux = primeiro;
            while (aux.proximo != null && flag != -1)
            {
                if (aux.proximo.aluno.Matricula == val)
                {
                    aux.proximo = aux.proximo.proximo;
                    flag = -1;
                }
                else               
                    aux = aux.proximo;    
            }
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