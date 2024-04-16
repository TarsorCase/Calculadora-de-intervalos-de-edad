int yes = 1; 
while(yes == 1){
  Console.WriteLine("\n***** CALCULADORA_DE_EDAD *****");
  Console.WriteLine("Ingrese su edad: ");
  int n1 = Convert.ToInt32(Console.ReadLine());
  if (n1 > 0){
      if(n1 >= 0 && n1 <= 3){
        Console.WriteLine($"recien nacido\n");
      }else if(n1 >= 4 && n1 <= 9){
        Console.WriteLine($"infante\n");
      }else if(n1 >= 10 && n1 <= 12){
        Console.WriteLine($"puberto\n");
      }else if(n1 >= 13 && n1 <= 19){
        Console.WriteLine($"adolescente\n");
      }else if(n1 >= 20 && n1 <= 29){
        Console.WriteLine($"joven");
      }else if(n1 >= 30 && n1 <= 49){
        Console.WriteLine($"adulto");
      }else if(n1 >= 50 && n1 <= 59){
        Console.WriteLine($"adulto mayor");
      }else if(n1 >= 60){
        Console.WriteLine($"anciano");
      }
  }else
  {
    Console.WriteLine($"Una de dos usted no existe o se equivoco porfavor ingresar un valor real"); 
  }
  Console.WriteLine("Would you want to continue making calculations? 1 --> yes | 2 --> no\n");
  yes = Convert.ToInt32(Console.ReadLine());
}
if (yes == 2)
{
  Console.WriteLine("\nThank you for using this calculator :)");
  Console.WriteLine(" /\\_/\\");
  Console.WriteLine("( o.o )");  
  Console.WriteLine(" > ^ <");
}
