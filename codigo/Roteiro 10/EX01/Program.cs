internal class Program
{
    static void Main(string[] args)
    {
        Fila fila = new Fila();
        Elemento elemento = new Elemento();
        Elemento elemento01 = new Elemento();
        Elemento elemento02 = new Elemento();
        Console.WriteLine("Informe o valor que deseja inserir");
        int val = int.Parse(Console.ReadLine());
        elemento.aluno.Matricula = val;
        fila.inserir(elemento);
        Console.WriteLine("Informe o valor que deseja inserir");
        val = int.Parse(Console.ReadLine());
        elemento01.aluno.Matricula = val;
        fila.inserir(elemento01);
        Console.WriteLine("Informe o valor que deseja inserir");
        val = int.Parse(Console.ReadLine());
        elemento02.aluno.Matricula = val;
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
            primeiro.proximo = primeiro.proximo.proximo;
        
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