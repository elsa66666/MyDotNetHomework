using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._3
{
    public delegate void TickHandler(object sender, TickEventArgs e);

    public class TickEventArgs {
        public int timeLeft { get; set; }
    }
        
    public class Clock
    {
        public event TickHandler OnTick;
        public void Tick(int tleft)
        {
            Console.WriteLine("开始倒计时：");
            TickEventArgs args = new TickEventArgs() { timeLeft = tleft };
            OnTick(this, args);
        
            
        }
    }

    public class Form 
    {
        public Clock clock1 = new Clock();
        public Form()
        {
            clock1.OnTick += new TickHandler(clk_OnTick);
            clock1.OnTick += clk_OnTick2;
        }

        void clk_OnTick(object sender, TickEventArgs args)
        {
            while(args.timeLeft > 0)
            {
                Console.WriteLine("ticking...剩余时间:{0}", args.timeLeft);
                System.Threading.Thread.Sleep(1000);
                args.timeLeft -= 1; 
            }
        }

        void clk_OnTick2(object sender, TickEventArgs args)
        {
            while(args.timeLeft == 0){
                Console.WriteLine("闹钟铃声响起");
                args.timeLeft = -1;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.clock1.Tick(10);
            Console.ReadKey();
        }
    }
}
