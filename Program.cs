class Program{
    static void Main(string[] args){
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }
    static double f(double x){
        double sum = 0;
        if(x>-1 && x<=0){
            sum = Math.Sqrt(1-Math.Pow(x, 2));
        }else if(x>0 && x<=1){
            sum = -(Math.Sqrt(1-Math.Pow(x, 2)));
        }else if(x<=-1){
            sum = f(x+2);
        }else if(x>1){
            sum = f(x-2);
        }
        return sum;
    }
}