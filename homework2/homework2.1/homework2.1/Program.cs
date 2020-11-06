using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1
{
    abstract class Shape
    {
        public abstract double Area(); 
        public abstract void Init();
        public abstract string getType();
    }

    class Rectangle : Shape
    {
        double width;
        double height;
        string type = "矩形";
        public Rectangle()
        {
            Init();
        }

        public override string getType()
        {
            return type;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Init()
        {
            Console.WriteLine("请选择输入长方形的长：");
            string widthStr = Console.ReadLine();
            Console.WriteLine("请选择输入长方形的宽：");
            string heightStr = Console.ReadLine();
            if (!double.TryParse(widthStr, out width) || !double.TryParse(heightStr, out height))
            {
                Console.WriteLine("只能输入数字！");
            }
            else
            {
                Console.WriteLine("成功生成矩形！");
            }
        }
    }

    class Square : Shape 
    {
        double sideLength;
        string type = "正方形";

        public Square()
        {
            Init();
        }

        public override string getType()
        {
            return type;
        }
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double Area()
        {
            return sideLength * sideLength;
        }

        public override void Init()
        {
            Console.WriteLine("请选择输入正方形边长：");
            string sideLengthStr = Console.ReadLine();
            if (!double.TryParse(sideLengthStr, out sideLength))
            {
                Console.WriteLine("只能输入数字！");
            }
            else
            {
                Console.WriteLine("成功生成正方形！");
            }
        }

    }

    class Triangle : Shape
    {
        double a;
        double b;
        string type = "三角形";
        public Triangle()
        {
            Init();
        }

        public Triangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string getType()
        {
            return type;
        }
        public override double Area()
        {
            return (a * b)/2;
        }

        public override void Init()
        {

            Console.WriteLine("请选择输入三角形的底：");
            string aStr = Console.ReadLine();
            Console.WriteLine("请选择输入三角形高：");
            string bStr = Console.ReadLine();

            if (!double.TryParse(aStr, out a) || !double.TryParse(bStr, out b) )
            {
                Console.WriteLine("只能输入数字！");
                    
            }
            else
            {
                Console.WriteLine("成功生成三角形！");
            }

            
        }
    }
    class Factory
    {
        public static Shape GetShape(int name, double width, double height, double sideLength, double a, double b)
        {
            switch (name)
            {
                case 1: return new Rectangle(width, height);
                case 2: return new Square(sideLength);
                case 3: return new Triangle(a,b);
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double areaSum = 0;
            int i = 0;
            Random ran = new Random();
            while (i < 10)
            {
                
                int name = ran.Next(1, 4);  
           
                double width = ran.NextDouble() * 10;
         
                double height  = ran.NextDouble() * 10;
              
                double sideLength = ran.NextDouble() * 10;
             
                double a = ran.NextDouble() * 10;
               
                double b = ran.NextDouble() * 10;

                Shape shape = Factory.GetShape(name, width, height, sideLength, a, b);
                if (shape != null)
                {
                    Console.WriteLine("生成：{0}\r\n面积为：{1}", shape.getType(), shape.Area().ToString("f2"));
                    areaSum += shape.Area();
                    i++;
                }
            }
            Console.WriteLine("面积和为：{0}", areaSum.ToString("f2"));
            Console.ReadKey();
        }
    }
}
