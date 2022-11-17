internal class Program
{
    private static void Main(string[] args)
    {
        Pilha pilha = new Pilha();
        int flag = 0;
        while(flag != -1)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO: \n 1 - Inserir \n 2 - retirar \n -1 termina");
            flag = int.Parse(Console.ReadLine());
            switch(flag)
            {
                case 1: pilha.inserir(); break;
                case 2: pilha.retirar(); break;
            }
        }
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
public class Pilha
{
    public Elemento topo;
    public Pilha()
    {
        topo = new Elemento();
        topo.aluno = null;
        topo.proximo = null;
    }
    public void inserir() 
    {
        Console.WriteLine("Informe o valor que deseja inserir");
        int val = int.Parse(Console.ReadLine());
        Elemento elemento = new Elemento();
        elemento.aluno.Matricula = val;
        if (topo.proximo == null)
            topo.proximo = elemento;
        else
        {
            elemento.proximo = topo.proximo;
            topo.proximo = elemento;
        }
        imprimir();
    }
    public void retirar()
    {
        if (topo.proximo == null)
            Console.WriteLine("A pilha está vazia");
        else
        {
            Elemento retirado = topo.proximo;
            topo.proximo = topo.proximo.proximo;
        }
        imprimir();
    }
    public void imprimir()
    {
        Elemento elemento = topo.proximo;
        Console.WriteLine("PILHA:");
        while (elemento != null)
        {
            Console.Write(elemento.aluno.Matricula+"\t");
            elemento = elemento.proximo;
        }
        Console.WriteLine();
    }
}
