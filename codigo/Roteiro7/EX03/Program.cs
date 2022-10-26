StreamReader sr = new StreamReader("entrada.txt");
string line = sr.ReadLine();
char[] vet;
char [] resultado = new char[line.Length];
vet = line.ToCharArray(0, line.Length);
for(int i = 0; i<vet.Length; i++){
   resultado[i] = vet[vet.Length-1-i];
}
using (StreamWriter writer = new StreamWriter("saida.txt", true))
{
	writer.WriteLine(resultado);
}