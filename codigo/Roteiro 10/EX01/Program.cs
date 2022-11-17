internal class Program
{
    static void Main(string[] args)
    {
        Fila fila = new Fila();
        int flag = 0;
        while(flag != -1)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO: \n 1 - Inserir \n 2 - retirar \n -1 termina");
            flag = int.Parse(Console.ReadLine());
            switch(flag)
            {
                case 1: fila.inserir(); break;
                case 2: fila.retirar(); break;
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
    public void inserir() 
    {
        Console.WriteLine("Informe o valor que deseja inserir");
        int val = int.Parse(Console.ReadLine());
        Elemento elemento = new Elemento();
        elemento.aluno.Matricula = val;
        if (primeiro.proximo == null)
        {
            primeiro.proximo = elemento;
            ultimo = elemento;
        }
        else
        {
            ultimo.proximo = elemento;
            ultimo = elemento;
        }
        imprimir();
    }
    public void retirar() 
    {
        if (primeiro.proximo == null)
            Console.WriteLine("A fila está vazia");        
        else
            primeiro.proximo = primeiro.proximo.proximo;
        imprimir();
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