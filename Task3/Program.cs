using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    public class Point
    {
        public char sign;
        public int x;
        public int y;

        public Point() { }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        

    }
    class Program : GO
    {
        public static Thread t = null;
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.CursorVisible = false;
            
            
            Program p = new Program();
            t = new Thread(new ThreadStart(p.Play));
            t.IsBackground = true;
            t.Start();
            p.Move(0, 1);
            p.Play();
            
        }
        

        
    }
    public abstract class GO:Point
    {
        public Point sin = new Point(0,10);

        public void Move(int dx, int dy)
        {
            sin.x += dx;
            sin.y += dy;
            Console.Clear();
            Draw();
            Play();
        }

        public void Draw()
        {
            
                Console.SetCursorPosition(sin.x, sin.y);
                Console.Write('o');
            
        }
        public int q = 1;
        public void Play()
        {
            

            while (true)
            {
                if(sin.y>0 && sin.y < 20)
                {
                    Move(0, q);
                }
                if (sin.y <= 0)
                {
                    Move(0, q);
                    q = 1;

                }
                if (sin.y >= 20)
                {
                    Move(0, q);
                    
                    q = -1;
                }
                Thread.Sleep(500);
                Draw();
                
            }
        }
    }

}
