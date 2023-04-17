using tarefa02.Classes;

Pessoa[] pessoas = new Pessoa[]
{
    new Gerente{
        Nome = "Mariza"
        , Cargo = "Gerente"
        , Born = new(year:1990, month:10, day:22)
        , CPF = "990.145.123.45"
        , podeTomarDecisoesEstrategicas = true
    },
    new Supervisor{
        Nome = "Paulo"
        , Cargo = "Supervisor"
        , Born = new(year:1994, month:5, day:12)
        , CPF = "123.456.789.10"
        , podeDelegarTarefas = true
    },
    new Operario{
        Nome = "Rafael"
        , Cargo = "Operário"
        , Born = new(year:2000, month:12, day:3)
        , CPF = "109.876.543-21"
        , segueProcedimentos = true
    }
};

foreach(Pessoa pessoa in pessoas)
{
    string message = string.Empty;
    if(pessoas != null){
        message += $"Nome: {pessoa.Nome}\n";
        message += $"CPF: {pessoa.CPF}\n";
        message += $"Data Nasc: {pessoa.Born.ToShortDateString()}";
    }
    Console.WriteLine(message);
};