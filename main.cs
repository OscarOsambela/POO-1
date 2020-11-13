using System;

class MainClass {
  public static void Main (string[] args) {
    
    Ejemplo1 objEjemplo = new Ejemplo1();

    Console.WriteLine("La multiplicación de " + objEjemplo.Numero + " es " + objEjemplo.CalculoNumero(2));
    Console.WriteLine(objEjemplo.Numero);
  
    Coche objCoche = new Coche();
    Console.WriteLine("La marca del coche es " + objCoche.marca + " y el color es " + objCoche.color + ".");
  }
}
//clase ejemplo 1
class Ejemplo1{
  public int Numero = 2;
  public int CalculoNumero(int d){
    return Numero * d;
  }
}
//clase ejemplo 2
class Coche{
  public string color = "rojo";
  public string marca = "Hyundai";
}