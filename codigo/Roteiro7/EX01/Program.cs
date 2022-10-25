int diferente=0;
int igual=0;
Console.WriteLine("Digite uma frase");
string text = Console.ReadLine();
string[] lines = System.IO.File.ReadAllLines(@"arq1.txt");
foreach(string line in lines){
    if(text == line)
        igual++;
    else
        diferente++;
}
Console.WriteLine("A frase escolhida possui {0} linhas diferentes e {1} linhas iguais", diferente, igual);