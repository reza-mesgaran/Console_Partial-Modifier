using System;
/*
 Note: 
  partial-Keyword :
    1.Partial Class/struct/Interface : (In reality all partial x,considered as one Class/Struct/Interface)  
    so :
      partial class Earth : Planet, IRotate { } &
      partial class Earth : IRevolve { }     these two line are equal ===> class Earth : Planet, IRotate, IRevolve { }
  
    2.Partial Method :
    Rules:
        1.Only partial class/Struct can have partial method 
        2.The signatures in both parts of partial type must be same.
        3.Each partial method has two main part:
            a.declaration : declaration part represents a signature of the partial method 
            b.definition  : definition part will represents an implementation of partial method.
            If declaration part uses without definition part ; the compiler will remove definition and method's callers.  
    3.Partial Method can not return anything (Only void)
        4.Partial Method implicity is private
        5.Partial Method doesn't accept access modifier
        6.Partial Method can not be virtual / abstract / sealed
        7.Partial Method can be static or generic
        8.Partial methods 
            can have ref parameters
            can NOT have out parameters    
 */

namespace Console_Partial_Modifier
{
    public partial class MyClass   // Partial Class
    {
        static void Main(string[] args)
        {
            MyMethod();
            Console.ReadKey();

        }
        static partial void MyMethod();    // Partial Method (Declaration part)

    }
    public partial class MyClass     // Partial Class
    {
        static partial void MyMethod()    // Partial Method (definition part)
        {
            Console.WriteLine("I'm a partial method");
        }
    }
}
