
for(int i=1000; i<=9999; i++){
    int centenas = i/100;
    int dezenas = i%100;
    if(Math.Pow((centenas+dezenas), 2)==i)
        Console.WriteLine("{0}", i);
}
