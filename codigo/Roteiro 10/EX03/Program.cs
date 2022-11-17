internal class Program
{
    private static void Main(string[] args)
    {
        Lista lista = new Lista();
        int flag = 0;
        while(flag != -1)
        {
            Console.WriteLine("ESCOLHA UMA OPÇÃO: \n 1 - Inserir \n 2 - retirar \n -1 termina");
            flag = int.Parse(Console.ReadLine());
            switch(flag)
            {
                case 1: lista.inserir(); break;
                case 2: lista.retirar(); break;
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
    public void inserir()
    {
        Console.WriteLine("Informe a posição que deseja inserir (-1 termina)");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor que deseja inserir");
        int val = int.Parse(Console.ReadLine());
        Elemento elemento = new Elemento();
        elemento.aluno.Matricula = val;
        int cont = 0;
        if (primeiro.proximo == null)
        {
            primeiro.proximo = elemento;
            ultimo = elemento;
        }
        else
        {
            Elemento aux = primeiro;
            while (cont < pos && aux.proximo != null)
            {
                cont++;
                aux = aux.proximo;
            }
            elemento.proximo = aux.proximo;
            aux.proximo = elemento; 
        }
        imprimir();
    }
    public void retirar()
    {
        Console.WriteLine("Informe o valor que deseja retirar");
        int val = int.Parse(Console.ReadLine());
        if (primeiro.proximo == null)
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
        imprimir();
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