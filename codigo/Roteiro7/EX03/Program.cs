StreamReader sr = new StreamReader("entrada.txt");
string line = sr.ReadLine();
char[] arr;
char [] resultado = new char[line.Length];
arr = line.ToCharArray(0, line.Length);
for(int i =0; i<arr.Length; i++){
   resultado[i] = arr[arr.Length-1-i];
}
using (StreamWriter writer = new StreamWriter("saida.txt", true))
{
	    writer.WriteLine(resultado);
}