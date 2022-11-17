internal class Program
{
    private static void Main(string[] args)
    {
        Pilha pilha = new Pilha();
        Elemento elemento = new Elemento();
        Elemento elemento01 = new Elemento();
        Elemento elemento02 = new Elemento();
        Random aux = new Random();
        elemento.aluno.Matricula = aux.Next(1000);
        pilha.inserir(elemento);
        elemento01.aluno.Matricula = aux.Next(1000);
        pilha.inserir(elemento01);
        elemento02.aluno.Matricula = aux.Next(1000);
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
    public bool confereSeVazia()
    {
        if(topo.proximo == null)
            return true;
        else
            return false;
    }
    public void inserir(Elemento novo) 
    {
        if (confereSeVazia())
            topo.proximo = novo;
        else
        {
            novo.proximo = topo.proximo;
            topo.proximo = novo;
        }
    }
    public void retirar()
    {
        if (confereSeVazia())
            Console.WriteLine("A pilha está vazia");
        else
        {
            Elemento retirado = topo.proximo;
            topo.proximo = topo.proximo.proximo;
            Console.WriteLine("Elemento retirado:{0}", retirado.aluno.Matricula);
        }
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
