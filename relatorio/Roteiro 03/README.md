# Documentação da aula de laboratório

Para cada aula de laboratório, salvar print da execução de cada atividade com o resultado da execução do programa.

# Relatório exercício 01 - 

### Pergunta:

Ordenação binária com pos

### Resposta:

A ordenação binária com o auxiliar pos se assemelha muito a ordenação sem o pos, tendo em vista que não há a necessidade da mesma. A explicação mais completa da resolução se encontra na próxima questão, aqui é importante ressaltarmos somente que o "pos" cumpre o papel de ir nos informando o tamanho do vetor que vamos quebrando recursivamente a cada ciclo. 

![Print EX01](img/EX01.png)

# Relatório exercício 02 - 

### Pergunta:

Ordenação binária sem pos 

### Resposta:

Nesse exercício há várias funções, "prencherVet" para gerar um vetor com tamanho desejado, "imprimeVet" para imprimir o vetor no terminal, "parteVet" para partir o vetor de forma binária e recursiva, e por fim "ordenaVet" que faz as comparações entre os vetores para ordena-los. A função parteVet parte e prenche os vetores auxiliares A, B, ordeB e ordeC de forma recursiva até a condição de parada que neste caso é quando o vetor tenha somente uma posição. Após isso a função chama a função ordenaVet passando os vetores ordeB e ordeC com uma uma única posição, conforme a ideia de partição binária, assim tendo a certeza de que os vetores passados para a função ordenaVet estão ordenados. 

![Print EX02](img/EX02.png)

# Relatório exercício 03 - 

### Pergunta:

Pesquisa binária com pos

### Resposta:

Nessa questão ao chamar a função de pesquisa binária passamos 3 parametros, nosso vetor, o número desejado e um auxiliar pos contendo a posição do meio do vetor. A função possui 4 testes, primeiramente testamos "if(pesq==vet[pos])" que é nossa primeira condição de parada, caso o número finalmente seja encontrado. Caso não entre nessa condição testamso a segunda condição de parada "if(pos == vet.Length-1 || pos == 0)" caso o número desejado não exista no vetor. As outras duas condições são para descobrirmos se vamos andar com o pos na parte superior ou inferior do vetor.

![Print EX03](img/EX03.png)

# Relatório exercício 04 - 

### Pergunta:

Pesquisa binária sem pos

### Resposta:

Para essa questão foi necessário criar um vetor auxiliar B que a cada ciclo da recursividade partia o vetor ao meio. Esse vetor auxiliar B é passado como parâmetro de entrada na próxima chamada da função, assim formando um ciclo. É necessário também realizar alguns testes, sendo eles, "if(vet[meio]== pesq)" que é nossa condidção de parada, testa se o número desejado é igual ao meio, partindo o vetor auxiliar ao meio a cada ciclo uma hora entraremos nessa condição caso o número desejado exista no vetor. Caso não entre no if anterior, testamos se o meio é igual a zero, pois, se o meio é igual a zero e não entrou no if anterior obrigatoriamente não existe o parâmetro no vetor, assim retornando -1. Caso não entre em nenhum dos returns anteriosres há mais dois testes para descobrirmos se vamos prencher o vetor auxiliar B com a parte de superior do vetor ou inferior ao meio.

![Print EX04](img/EX04.png)