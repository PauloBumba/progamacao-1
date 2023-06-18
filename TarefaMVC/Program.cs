using TarefaMVC.Views;

int option = 0;

do{
  
  Console.WriteLine("-------------------------------");
  Console.WriteLine("Programa para gestão de dados!");
  Console.WriteLine("------------------------------");
  Console.WriteLine("1 - Animais");

  option = Convert.ToInt32(Console.ReadLine());

  switch(option)
  {

    case 1:
      Console.WriteLine("Opção Animais");
      AnimalView animalView = new AnimalView();
    break;

  }
}

while (option > 0);