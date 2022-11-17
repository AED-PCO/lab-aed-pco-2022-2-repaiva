internal class Program
{
    static void Main(string[] args)
    {
        Fila fila = new Fila();
        Elemento elemento = new Elemento();
        Elemento elemento01 = new Elemento();
        Elemento elemento02 = new Elemento();
        Random aux = new Random();
        elemento.aluno.Matricula = aux.Next(1000);
        fila.inserir(elemento);
        elemento01.aluno.Matricula = aux.Next(1000);
        fila.inserir(elemento01);
        elemento02.aluno.Matricula = aux.Next(1000);
        fila.inserir(elemento02);
        fila.imprimir();
        string sn = "";
        do
        {
            Console.WriteLine("Deseja retirar algum valor? S/N");
            sn = Console.ReadLine();
            if(sn == "S" || sn == "s")
                fila.retirar();
        }while(sn == "S" || sn == "s");
        fila.imprimir();
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
public class Fila
{
    public Elemento primeiro;
    public Elemento ultimo;
    public Fila()
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
    public void inserir(Elemento novo) 
    {
        if (confereSeVazia())
        {
            primeiro.proximo = novo;
            ultimo = novo;
        }
        else
        {
            ultimo.proximo = novo;
            ultimo = novo;
        }
    }
    public void retirar() 
    {
        if (confereSeVazia())
            Console.WriteLine("A fila está vazia");        
        else
        {
            Console.WriteLine("Elemento retirado: {0}", primeiro.proximo.aluno.Matricula);
            primeiro.proximo = primeiro.proximo.proximo;
        }
    }
    public void imprimir() 
    {
        Elemento elemento = this.primeiro.proximo;
        Console.WriteLine("FILA:");
        while(elemento != null)
        {
            Console.Write(elemento.aluno.Matricula+"\t");
            elemento = elemento.proximo;
        }
        Console.WriteLine();
    }
}