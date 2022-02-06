using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        class Coor
        {
            public double x, y;
            public Coor() { }
            public Coor(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class Data
        {
            public Coor coor;
            public double v;
        }

        static double distance(Coor u, Coor v)
        {
            double x1 = u.x, y1 = u.y;
            double x2 = v.x, y2 = v.y;
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static int getNodeInd(Data[] datas, ref double time)
        {
            double dist, t;
            int N = datas.Length;
            for (int i = 0; i < N - 1; i++)
            {
                dist = distance(datas[i + 1].coor, datas[i].coor);
                t = dist / datas[i].v;
                if (time - t <= 0) return i;
                time -= t;
                Console.WriteLine(time);
            }
            return -1;
        }

        static Coor getPoint(Data[] datas, int nodeind, double t)
        {
            double d = distance(datas[nodeind + 1].coor, datas[nodeind].coor);
            double s = t * datas[nodeind].v;
            double time = d / datas[nodeind].v;
            //double p = t / time;
            double x = datas[nodeind + 1].coor.x - datas[nodeind].coor.x;
            double y = datas[nodeind + 1].coor.y - datas[nodeind].coor.y;
            Coor coor = new Coor();
            coor.x = datas[nodeind].coor.x + s/d * x;
            coor.y = datas[nodeind].coor.y + s/d * y;
            return coor;
        }

        /*static Coor getPoint(Data prevNode, double t)
        {
            Coor coor = new Coor();
            coor.x = prevNode.coor.x + t * prevNode.v;
            coor.y = prevNode.coor.y + t * prevNode.v;
            return coor;
        }*/

        static void show(Data[] datas)
        {
            foreach (Data data in datas) 
            {
                Console.WriteLine("<({0}, {1}), {2}>", data.coor.x, data.coor.y, data.v);
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int N = 10;
            Data[] route = new Data[N];

            route[0] = new Data();
            route[0].coor = new Coor();
            route[0].coor.x = 15 * random.NextDouble();
            route[0].coor.y = 15 * random.NextDouble();
            route[0].v = 15 * random.NextDouble();
            for (int i = 1; i < N; i++)
            {
                route[i] = new Data();
                route[i].coor = new Coor();
                route[i].coor.x = route[i - 1].coor.x + 10 * random.NextDouble();
                route[i].coor.y = route[i - 1].coor.y + 10 * random.NextDouble();
                route[i].v = 5 * random.NextDouble();
            }

            show(route);

            double time = 40;
            Coor coor = new Coor();

            int nodeind = getNodeInd(route, ref time);
            if (nodeind == -1)
            {
                Console.WriteLine("Out of the route!");
            }
            else
            {
                coor = getPoint(route, nodeind, time);
                Console.WriteLine();
                Console.WriteLine("<({0}, {1}), {2}>", route[nodeind].coor.x, route[nodeind].coor.y, route[nodeind].v);
                Console.WriteLine("({0}, {1})", coor.x, coor.y);
                Console.WriteLine("({0}, {1})", route[nodeind + 1].coor.x, route[nodeind + 1].coor.y);
                Console.WriteLine();
                double dist = distance(coor, route[nodeind].coor);
                double diff = Math.Abs(time * route[nodeind].v - dist);
                Console.WriteLine(diff);
            }

            /*int nodeind = getNodeInd(route, ref time);
            if (nodeind == -1)
            {
                Console.WriteLine("Out of the route!");
            }
            //if (coor.x > route[N - 1].coor.x || coor.y > route[N - 1].coor.y)
            else
            {
                Console.WriteLine(nodeind);
                ILine line = getLine(route[nodeind].coor, route[nodeind + 1].coor);
                Console.WriteLine(line.GetType());
                Coor[] coors = new Coor[2];
                coors = getPoint(line, route[nodeind].coor, route[nodeind + 1].coor, route[nodeind].v, time);
                coor = coors[0];
                Console.WriteLine("({0}, {1})", coor.x, coor.y);
                coor = coors[1];
                Console.WriteLine("({0}, {1})", coor.x, coor.y);
            }*/
            
            Console.WriteLine("Press enter to close...");
            Console.ReadKey();
        }



        //The code in the below has no meaning in the program but I did not delete that part just for showing my understanding of OOP to you.
        interface ILine
        {
            ILine getLine(Coor u, Coor v);
            Coor[] getPoint(Coor u, Coor v, double speed, double time);
        }

        class LinePQ : ILine //Px + Qy = 1
        {
            public double P, Q;
            public ILine getLine(Coor u, Coor v)
            {
                double x1 = u.x, y1 = u.y;
                double x2 = v.x, y2 = v.y;
                if (x1 != 0)
                {
                    Q = (1 - x2 / x1) / (y2 - y1 * x2 / x1);
                    P = (1 - Q * y1) / x1;
                }
                else
                {
                    Q = (1 - x1 / x2) / (y1 - y2 * x1 / x2);
                    P = (1 - Q * y2) / x2;
                }
                return this;
            }
            public Coor[] getPoint(Coor u, Coor v, double speed, double time)
            {
                double x1 = u.x, y1 = u.y;
                double x2 = v.x, y2 = v.y;
                double x0, y0;
                if (x1 != 0)
                {
                    x0 = x1;
                    y0 = y1;
                }
                else
                {
                    x0 = x2;
                    y0 = y2;
                }
                double a, b, c, P = this.P, Q = this.Q, s = time * speed;
                a = 1 + P / Q * P / Q;
                b = -(2 * y0 + 2 * Q / P * (1 / P - x0));
                c = (1 / P - x0) * (1 / P - x0) - s * s;
                double x, y;
                Coor[] coors = new Coor[2];
                y = (Math.Sqrt(b * b - 4 * a * c) + b) / (2 * a);
                x = (1 - Q * y) / P;
                coors[0] = new Coor(x, y);
                y = -y;
                x = (1 - Q * y) / P;
                coors[1] = new Coor(x, y);

                return coors;
            }
        }

        class LineABC : ILine //Ax + By + C = 0
        {
            public double A, B, C = 0;
            public double a
            {
                get { return A; }
                set { A = value; }
            }
            public ILine getLine(Coor u, Coor v)
            {
                return new LineABC();
            }

            public Coor[] getPoint(Coor u, Coor v, double speed, double time)
            {
                return new Coor[2];
            }
        }

        static ILine getLine(Coor u, Coor v)
        {
            double x1 = u.x, y1 = u.y;
            double x2 = v.x, y2 = v.y;
            ILine line;
            if (x1 / x2 == y1 / y2)
                line = new LineABC();
            else
                line = new LinePQ();
            return line.getLine(u, v); ;
        }

        static Data getNode(Data[] datas, ref double time)
        {
            double dist, t;
            int N = datas.Length;
            for (int i = 0; i < N - 1; i++)
            {
                dist = distance(datas[i + 1].coor, datas[i].coor);
                t = dist / datas[i].v;
                if (time - t <= 0) { Console.WriteLine(i); Console.WriteLine(time); return datas[i]; }
                time -= t;
            }
            return null;
        }

        static Coor[] getPoint(ILine line, Coor u, Coor v, double speed, double time)
        {
            Coor[] coors = new Coor[2];
            coors = line.getPoint(u, v, speed, time);
            return coors; //or just return line.getPoint();
        }
    }
}

