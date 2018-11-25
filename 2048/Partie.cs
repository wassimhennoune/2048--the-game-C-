using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _2048
{
    class Partie
    {
        private int elem;
        public Boolean go;
        public int _elem
        {
            get
            {
                //logic here 
                return elem;
            }
            set
            {
                //logic here
                elem = value;
            }
        }
        private int faire { get; set; }
        public int[,] t = new int[4, 4];
        private int score;
        public List<E> pile;
        private int essai;
        public int _essai
        {
            get
            {
                //logic here 
                return essai;
            }
            set
            {
                //logic here
                essai = value;
            }
        }
        public int _score
        {
            get
            {
                //logic here 
                return score;
            }
            set
            {
                //logic here
                score = value;
            }
        }


        public Partie()
        {
            start();
            go = false;
            score = 0;
            _essai = 5;
            pile = new List<E>();
           
        }
        public void start()
        {
            int i, j;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    t[i, j] = 0;
                }
            }
            faire = 1;
            ins();
            ins();
        }

        public void up()
        {
           // empiler();
            int i = 0, j;
            Boolean stop = false;
            int[,] v = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            faire = 0;
            while (!stop)
            {
                stop = true;
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (t[i, j] == 0)
                        {
                            if ((t[i + 1, j] != 0))
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] = t[i + 1, j];
                                t[i + 1, j] = 0;

                            }
                        }
                        else
                        {
                            if ((t[i, j] == t[i + 1, j]) && (v[i + 1, j] == 1))
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] += t[i + 1, j];
                                score += t[i, j];
                                t[i + 1, j] = 0;
                                elem = elem - 1;
                                v[i, j] = 0;
                            }
                        }
                    }
                }

            }
            this.ins();
           
        }

      

        public void left()
        {
         //   empiler();
            int i = 0, j;
            Boolean stop = false;
            int[,] v = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            faire = 0;
            while (!stop)
            {
                stop = true;
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (t[i, j] == 0)
                        {
                            if ((t[i, j + 1] != 0))
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] = t[i, j + 1];
                                t[i, j + 1] = 0;

                            }
                        }
                        else
                        {
                            if ((t[i, j] == t[i, j + 1]) && (v[i, j + 1] == 1))
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] += t[i, j + 1];
                                score += t[i, j];
                                t[i, j + 1] = 0;
                                elem = elem - 1;
                                v[i, j] = 0;
                            }
                        }
                    }
                }

            }
            this.ins();
           
        }

        
        public void kill()
        {
            go = true; 
        }

        public void right()
        {
         //   empiler();
            int i = 0, j;
            Boolean stop = false;
            int[,] v = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            faire = 0;
            while (!stop)
            {
                stop = true;
                for (i = 3; i > -1; i--)
                {
                    for (j = 3; j > 0; j--)
                    {
                        if (t[i, j] == 0)
                        {
                            if (t[i, j - 1] != 0)
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] = t[i, j - 1];
                                t[i, j - 1] = 0;
                            }
                        }
                        else
                        {
                            if ((t[i, j] == t[i, j - 1]) && (v[i, j - 1] == 1))
                            {
                                stop = true;
                                faire = 1;
                                t[i, j] += t[i, j - 1];
                                score += t[i, j];
                                elem = elem - 1;
                                t[i, j - 1] = 0;
                                v[i, j] = 0;
                            }
                        }

                    }
                }
            }
            this.ins();
            
        }

        public void down()
        {
          //  empiler();
            int i = 0, j;
            Boolean stop = false;
            int[,] v = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            faire = 0;
            while (!stop)
            {
                stop = true;
                for (i = 3; i > 0; i--)
                {
                    for (j = 3; j > -1; j--)
                    {
                        if (t[i, j] == 0)
                        {
                            if (t[i - 1, j] != 0)
                            {
                                stop = false;
                                faire = 1;
                                t[i, j] = t[i - 1, j];
                                t[i - 1, j] = 0;
                            }
                        }
                        else
                        {
                            if ((t[i, j] == t[i - 1, j]) && (v[i - 1, j] == 1))
                            {
                                stop = true;
                                faire = 1;
                                t[i, j] += t[i - 1, j];
                                score += t[i, j];
                                t[i - 1, j] = 0;
                                elem = elem - 1;
                                v[i, j] = 0;
                            }
                        }

                    }
                }
            }
            this.ins();
        }
       public int GameOver()
        {
            int i, j, go1 = 0, go2 = 0;
            if ((t[0, 0] != t[0, 1]) && (t[1, 0] != t[0, 0]) && (t[3, 2] != t[3, 3]) && (t[3, 3] != t[2, 3]) && (t[0, 3] != t[0, 2]) && (t[0, 3] != t[1, 3]) && (t[3, 0] != t[2, 0]) && (t[3, 0] != t[3, 1])) go1 = 1;

            for (i = 1; i < 3; i++)
            {
                for (j = 1; j < 3; j++)
                {
                    if ((t[i, j] != t[i + 1, j]) && (t[i - 1, j] != t[i, j]) && (t[i, j] != t[i, j + 1]) && (t[i, j] != t[i, j - 1])) go2 = 1;
                }
            }

            return (go1 + go2) - 1;
        }
       public void ins()
        {
            int i, j;
            if (faire == 1)
            {
                do
                {
                    Random rand = new Random();
                    i = rand.Next(4);
                    j = rand.Next(4);
                } while (t[i, j] != 0);
                t[i, j] = 2;
                elem = elem + 1;
            }
        }

        public void empiler()
        {
            E e = new E((int[,])t.Clone(), score,elem);
            pile.Add(e);
            regler();
           
        }

        
        public void depiler()
        {
            int a = pile.Count;
            t = pile[a-1].a;
            score = pile[a - 1].s;
            elem = pile[a - 1].e;
            pile.RemoveAt(a-1);
            
            
        }
        private void regler()
        {
            while (pile.Count > 5)
            {
                pile.RemoveAt(0);
            }
        }


    }
    class E
    {
        public int[,] a;
        public int s;
        public int e;
        public E(int[,]a,int s,int e)
        {
            this.a = a;
            this.s = s;
            this.e = e;
        }
    }
}
