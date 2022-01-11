namespace ExemploPOO.Interfaces
{
  public interface ICalculadora
  {
    // É uma boa prática colocar o "i" na frente do nome de uma interface
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Dividir(int num1, int num2);
    int Multiplicar(int num1, int num2)
    {
      return num1 * num2;
    }
  }
}