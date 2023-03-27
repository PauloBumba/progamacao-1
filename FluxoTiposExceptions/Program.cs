
//Operadores Unários

int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++;
int incrementoPrefixado = ++x;

Console.WriteLine($"Posfixado: {incrementoPosfixado}");

Console.WriteLine($"Prefixado: {incrementoPrefixado}");

//Como obter o tipo de uma variavel

Type tipoDeInteiro = typeof(int);

Type tipoDeX = x.GetType();

//Como obter o nome de uma variável

string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);

Console.WriteLine( "Nome da var: " + nomeDaVariavel );