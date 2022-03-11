/*1.Entrar via teclado com a base e a altura de um
retângulo, calcular e exibir sua área
double b, a, area;
Console.WriteLine("Insira o valor da base:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor da altura:");
a = double.Parse(Console.ReadLine());
area = b * a;
Console.WriteLine("A área do retângulo é: {0}",area);*/

/*2. Calcular e exibir a área de um quadrado, a partir
do valor de sua aresta que será digitado.
double a, area;
Console.WriteLine("Insira o valor da aresta do quadrado:");
a = double.Parse(Console.ReadLine());
area = Math.Pow(a,2);
Console.WriteLine("A área do quadrado é: {0}", area);*/

/*3. Calcular e exibir a área de um quadrado a partir do
valor de sua diagonal que será digitado.
double d, area;
Console.WriteLine("Insira o valor da diagonal do quadrado:");
d = double.Parse(Console.ReadLine());
area = (Math.Pow(d, 2))/2;
Console.WriteLine("A área do quadrado é: {0}", area);*/


/*4. A partir dos valores da base e altura de um
triângulo, calcular e exibir sua área.
double b, a, area;
Console.WriteLine("Insira o valor da base:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor da altura:");
a = double.Parse(Console.ReadLine());
area = (b * a)/2;
Console.WriteLine("A área do retângulo é: {0}", area);*/

/*5. Calcular e exibir o volume de uma esfera a partir do
valor de seu diâmetro que será digitado.
double d, r, volume;
Console.WriteLine("Insira o valor do diâmetro da esfera:");
d = double.Parse(Console.ReadLine());
r = d / 2;
volume = (4*(Math.PI)*(Math.Pow(r,3)))/3;
Console.WriteLine("O volume da esfera é: {0}", volume);*/


/*6. Calcular e exibir a média aritmética de quatro
valores quaisquer que serão digitados
double a,b,c,d,media;
Console.WriteLine("Insira a nota 1:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota 2:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota 3:");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a nota 4:");
d = double.Parse(Console.ReadLine());
media = (a+b+c+d)/4;
Console.WriteLine("A média das notas é: {0}", media);*/


/*7. Calcular e exibir a média geométrica de dois
valores quaisquer que serão digitados.
double a, b, media;
Console.WriteLine("Insira o valor 1:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor 2:");
b = double.Parse(Console.ReadLine());
media = Math.Sqrt((a * b));
Console.WriteLine("A média das notas é: {0}", media);*/



/*8. Sabendo que uma milha marítima equivale a um
mil, oitocentos e cinquenta e dois metros e que um
quilômetro possui mil metros, fazer um programa
para converter milhas marítimas em quilômetros.
double m, converte;
Console.WriteLine("Insira o valor em milhas marítimas:");
m = double.Parse(Console.ReadLine());
converte = m * 1.852;
Console.WriteLine("O valor em Km é: {0}km", converte);*/

/*9. Calcular e exibir a tensão de um determinado
circuito eletrônico a partir dos valores da resistência
e corrente elétrica que serão digitados. Utilize a lei
de Ohm.
double v, r, i;
Console.WriteLine("Insira a Corrente elétrica (Amperes)");
i = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a Resistência elétrica (Ohm)");
r = double.Parse(Console.ReadLine());
v = r * i;
Console.WriteLine("A tensão elétrica é de: {0} Volts", v); */



/*10. Entrar via teclado com o valor de uma temperatura
em graus Celsius, calcular e exibir sua temperatura
equivalente em Fahrenheit.
double c, f;
Console.WriteLine("Insira a temperatura (ºC)");
c = double.Parse(Console.ReadLine());
f = (c*1.8)+32;
Console.WriteLine("A temperatura em Fahrenheit é de: {0} F", f);*/

/*11. A partir do diâmetro de um círculo que será
digitado, calcular e exibir sua área.
double d, a;
Console.WriteLine("Insira o diâmetro do círculo (em metros)");
d = double.Parse(Console.ReadLine());
a = ( (Math.PI) * (Math.Pow((d/2), 2)));
Console.WriteLine("A área do círculo é de: {0} m²", a);*/

/*12. Calcular e exibir o volume de um cone a partir dos
valores da altura e do raio da base que serão
digitados.
double a, r, v;
Console.WriteLine("Insira o valor da altura do cone (em m):");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor do raio da base do cone (em m):");
r = double.Parse(Console.ReadLine());
v = ((Math.PI * Math.Pow(r, 2) * a)/3); 
Console.WriteLine("O valor do volume do cone é: {0}m³", v);*/

/*13. Calcular e exibir a velocidade final (em km/h) de
um automóvel, a partir dos valores da velocidade
inicial (em m/s), da aceleração(m/s²) e do tempo
de percurso(em s) que serão digitados.
double vf,vi,a,t;
Console.WriteLine("Insira a velocidade inicial (m/s):");
vi = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a aceleração (m/s²):");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o tempo (s):");
t = double.Parse(Console.ReadLine());
vf =((vi + (a * t))*3.6);
Console.WriteLine("A velocidade final é de: {0} Km/h", vf); */

/*14. Calcular e exibir o volume livre de um ambiente que
contém uma esfera de raio “r” inscrita em um cubo
perfeito de aresta “a”. Os valores de “r“ e “a” serão
digitados.
double vl, vc, ve, r, a;
Console.WriteLine("Insira o raio da esfera:");
r = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a aresta do cubo:");
a = double.Parse(Console.ReadLine());
vc = Math.Pow(a, 3);
ve = (4*(Math.PI)*(Math.Pow(r,3)))/3;
vl = vc - ve;
Console.WriteLine("O volume livre do ambiente é de: {0}m", vl);*/


/*15. Entrar via teclado com o valor da cotação do dólar
e uma certa quantidade de dólares. Calcular e
exibir o valor correspondente em Reais (R$).
double c, d, r;
Console.WriteLine("Insira a cotação do Dólar (R$)");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Insira a quantidade de Doláres (US$):");
d = double.Parse(Console.ReadLine());
r = c * d;
Console.WriteLine("O valor em Reais é: R${0}",r);*/

/*16.Entrar via teclado com o valor de um ângulo em
graus, calcular e exibir as seguintes funções
trigonométricas: seno, coseno, tangente e secante
deste ângulo. Lembre-se que uma função
trigonométrica trabalha em radianos.

double ang, angrad, sen, cos, tan, sec;
Console.WriteLine("Insira o ângulo:");
ang = double.Parse(Console.ReadLine());
angrad = ang * (Math.PI / 180);
sen = Math.Sin(angrad);
cos = Math.Cos(angrad);
tan = Math.Tan(angrad);
sec = Math.Cos(angrad)*(-1);
Console.WriteLine("Seno, Cos, Tan e Sec do angulo inserido:{0}, {1}, {2}, {3}", sen, cos, tan, sec); */


/*17. Entrar via teclado com dois valores quaisquer “X” e
“X”. Calcular e exibir o cálculo XY (“X” elevado a
“Y”). Pesquisar as funções Exp e Ln.

double x, y,r;
Console.WriteLine("Insira o valor X");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor Y");
y = double.Parse(Console.ReadLine());
r = (Math.Pow(x,y));
Console.WriteLine("A exponenciação é: {0}", r);*/

/*18. Entrar via teclado com o valor de cinco produtos.
Após as entradas, digitar um valor referente ao
pagamento da somatória destes valores. Calcular e
exibir o troco que deverá ser devolvido
double n1, n2, n3, n4, n5,vt, vp, t;
Console.WriteLine("Insira o 1º valor:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o 2º valor:");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o 3º valor:");
n3 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o 4º valor:");
n4 = double.Parse(Console.ReadLine());
Console.WriteLine("Insira o 5º valor:");
n5 = double.Parse(Console.ReadLine());
vt = n1 + n2 + n3 + n4 + n5;
Console.WriteLine("Insira o valor Pago:");
vp = double.Parse(Console.ReadLine());

t = vp - vt;

Console.WriteLine("O seu troco é: R${0}",t);*/


