## Questão 01 - Copiar uma pilha para outra pilha mantendo na ordem original.

Nessa questão, no próprio progrma principal "main" fazemos um loop chamando a função de iserir valor na pilha com flag de -1, assim temos uma pilha inicial. Após isso, chamamos a função "PilhaParaPilha" que contém a solução do problema de fato. Nesta função, temos uma pilha auxiliar onde será inserido os valores removidos das pilha original, como na pilha só conseguimos remover valores da última posição, a pilha auxiliar tera os valores da pilha original de traz para frente. Na próxima etapa inserimos os valores dessa pilha auxiliar na pilha original e na pilha de saída, denovo, seguindo a filosofia da pilha, as pilhas original e de saída receberam os valores da pilha auxiliar de trás para frente, agora sim na ordem da pilha inicializada pelo usuário. Observação: os valores impressos no console mostram os valores da pilha de trás para frente pois é assim que a pilha enxerga.  

![Print EX 01](img/EX01.png)

## Questão 02 - Copiar uma fila para outra fila invertendo a ordem original.

Nessa questão, no próprio progrma principal "main" fazemos um loop chamando a função de iserir valor na fila com flag de -1, assim temos uma fila inicial. Após isso, chamamos a função "FilaParaFila" que contém a solução do problema de fato. Nesta função, no primeiro loop inserimos os valores da fila original em uma fila auxiliar e em uma pilha auxiliar. Em um proximo loop inserimos os valores da pilha em uma fila de saída e voltamos com os valores armazenados na fila auxilar para a fila original. 

![Print EX 02](img/EX02.png)

## Questão 03 - Copiar uma lista para outra lista metade original e metade invertida.

Nesse execício a função de inserir valor já foi explicada no relatório do laboratório anterior. A função ListaParaLista cria um lista auxiliar, pega o ultimo valor da lista original e coloca na primeira posição da lista auxiliar. Sendo assim, teremos agora duas lista, a lista orignal com a ordem inicial, e a lista auxiliar com a ordem inversa, agora basta concatenar as duas em uma lista resultante que imprimimos no console. 

![Print EX 02](img/EX03.png)