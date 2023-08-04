

namespace demo1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(args.Length);
        MyMaths x1 = new(1,3);
        Console.WriteLine(x1.Add());
    }
}

 class MyMaths{
    int operand1;
    int operand2;
    public MyMaths(int operand1,int operand2){
     this.operand1=operand1;
     this.operand2=operand2;
    }
    public int Add(){
        return operand1+operand2;
    }
}