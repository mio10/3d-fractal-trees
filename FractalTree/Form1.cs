using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform;

namespace FractalTree
{
    public partial class Form : System.Windows.Forms.Form
    {
        double WOOD_LENGTH = 0.25;
        double WOOD_RED = 0.58;
        double WOOD_GREEN = 0.29;
        double WOOD_BLUE = 0;

        const double LEAF_SIZE = 0.01;
        double LEAF_RED = 0;
        double LEAF_GREEN = 0.65;
        double LEAF_BLUE = 0.41;

        const string AXIOM = "X";
        const string RULE = "F[@[[+{0}{1}{2}-{3}{4}{5}XL]-{6}{7}{8}XL]+{9}{10}{11}XL]";

        const double TO_RADIANS = Math.PI / 180;

        int DEPTH = 8;
        int crown = 45;
        int angle = 0;
        string sequence;

        int growthCount = 0;

        Timer timer = new Timer();
        Timer growthTimer = new Timer();
        Random rand = new Random((int) DateTime.Now.Ticks & 0x0000FFFF);
        Stack<State> memory = new Stack<State>();
        State current = new State();
        
        public struct State
        {
            public double x, y, z,
                          ax,ay,az,
                          w, len,
                          r, g, b;

            public State(double x, double y, double z,
                         double ax,double ay,double az,
                         double w,
                         double len,
                         double r, double g, double b)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.w = w;
                this.ax = ax;
                this.ay = ay;
                this.az = az;
                this.len = len;
                this.r = r;
                this.g = g;
                this.b = b;
            }
        }

        public Form()
        {
            InitializeComponent();
            canvas.InitializeContexts();

            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            growthTimer.Interval = 75;
            growthTimer.Tick += GrowthTimer_Tick;

            GrowTreeAnimated(DEPTH);

            Gl.glViewport(0, 0, canvas.Width, canvas.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void GrowthTimer_Tick(object sender, EventArgs e)
        {
            
            if (growthCount < DEPTH)
            {
                growthCount++;
                if (growthCount == 1)
                {
                    sequence = ConstructSequence(1, AXIOM);
                }
                else
                {
                    sequence = ConstructSequence(1, sequence);
                }
                canvas.Invalidate();
            }
            else
            {
                growthTimer.Stop();
            }
        }

        private void GrowTreeAnimated(int depth)
        {
            timer.Start();
            growthCount = 0;
            growthTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 2;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if (sequence == null)
                return;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, canvas.Width / canvas.Height, 0.1, 100);
            Gl.glTranslated(0,-0.8, -2.5);

            Gl.glRotated(angle, 0, 1, 0);
            
            current = new State(0, 0, 0, 0, 0, 0, 10, WOOD_LENGTH, WOOD_RED, WOOD_GREEN, WOOD_BLUE);

            for (int i = 0; i < sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case 'L':
                        if (sequence[i - 1] == 'X')
                            Leaf();
                        break;
                    case 'X':
                        Forward();
                        break;
                    case 'F':
                        Forward();
                        break;
                    case '+':
                        current.ax += Int32.Parse(String.Concat(sequence[i + 1], sequence[i + 2]));
                        current.ay += Int32.Parse(String.Concat(sequence[i + 3], sequence[i + 4]));
                        current.az += Int32.Parse(String.Concat(sequence[i + 5], sequence[i + 6]));
                        break;
                    case '-':
                        current.ax -= Int32.Parse(String.Concat(sequence[i + 1], sequence[i + 2]));
                        current.ay -= Int32.Parse(String.Concat(sequence[i + 3], sequence[i + 4]));
                        current.az -= Int32.Parse(String.Concat(sequence[i + 5], sequence[i + 6]));
                        break;
                    case '[':
                        memory.Push(current);
                        break;
                    case ']':
                        current = memory.Pop();
                        break;
                    case '@':
                        current.w  *= 0.66;
                        current.len *= 0.8;
                        current.r *= 0.9;
                        current.g *= 1.1;
                        break;
                }
            }
        }

        Stack<double> GenerateAngles(Stack<double> angles, string sequence)
        {
            angles.Clear();
            foreach (char c in sequence)
            {
                if ((c == '+') || (c == '-'))
                {
                    angles.Push(rand.NextDouble() * crown);
                    angles.Push(rand.NextDouble() * crown);
                    angles.Push(rand.NextDouble() * crown);
                }
            }
            return angles;
        }

        void Forward()
        {
            Gl.glLineWidth((float)current.w);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3d(current.r, current.g, current.b);
            Gl.glVertex3d(current.x, current.y, current.z);

            double[,] fig =
            {
                {0, current.len, 0, 1 },
                {0, 0,           0, 1 }
            };

            fig = Rotation(fig, current.ax, current.ay, current.az);
            current.x += fig[0, 0];
            current.y += fig[0, 1];
            current.z += fig[0, 2];

            Gl.glVertex3d(current.x, current.y, current.z);
            Gl.glEnd();
        }

        void Leaf()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3d(LEAF_RED, LEAF_GREEN, LEAF_BLUE);
            Gl.glVertex3d(current.x + LEAF_SIZE, current.y, current.z);
            Gl.glVertex3d(current.x, current.y + LEAF_SIZE, current.z);
            Gl.glVertex3d(current.x - LEAF_SIZE, current.y, current.z);
            Gl.glVertex3d(current.x, current.y - LEAF_SIZE, current.z);

            Gl.glVertex3d(current.x + LEAF_SIZE, current.y, current.z);
            Gl.glVertex3d(current.x, current.y, current.z + LEAF_SIZE);
            Gl.glVertex3d(current.x - LEAF_SIZE, current.y, current.z);
            Gl.glVertex3d(current.x, current.y, current.z - LEAF_SIZE);

            Gl.glVertex3d(current.x, current.y + LEAF_SIZE, current.z);
            Gl.glVertex3d(current.x, current.y, current.z + LEAF_SIZE);
            Gl.glVertex3d(current.x, current.y - LEAF_SIZE, current.z);
            Gl.glVertex3d(current.x, current.y, current.z - LEAF_SIZE);
            Gl.glEnd();
        }


        string ConstructSequence(int depth, string sequence)
        {
            for (int i = 0; i < depth; i++)
            {
                int position = 0;
                while (position < sequence.Length)
                {
                    bool flag = false;
                    if ((position < sequence.Length) && (sequence[position] == 'X'))
                    {
                        sequence = sequence.Remove(position, 1);
                        string[] angles = new string[12];
                        for (int j = 0; j < 12; j++)
                        {
                            angles[j] = (rand.NextDouble() * crown).ToString("00");
                        }
                        string newPiece = String.Format(RULE, angles);
                        sequence = sequence.Insert(position, newPiece);
                        position += newPiece.Length;
                        flag = true;
                    }
                    if (!flag)
                    {
                        position++;
                    }
                }
            }
            return sequence;
        }

        double[,] Rotation(double[,] fig, double angleX, double angleY, double angleZ)
        {
            angleX *= TO_RADIANS;
            angleY *= TO_RADIANS;
            angleZ *= TO_RADIANS;
            double[,] rotX =
            {
                {1, 0,                  0,                  0 },
                {0, Math.Cos(angleX),   Math.Sin(angleX),   0 },
                {0,-Math.Sin(angleX),   Math.Cos(angleX),   0 },
                {0, 0,                  0,                  0 }
            };
            double[,] rotY =
            {
                {Math.Cos(angleY),  0, -Math.Sin(angleY),  0 },
                {0,                 1,  0,                 0 },
                {Math.Sin(angleY),  0,  Math.Cos(angleY),  0 },
                {0,                 0,  0,                 1 }
            };
            double[,] rotZ =
            {
                { Math.Cos(angleZ), Math.Sin(angleZ),   0,  0 },
                {-Math.Sin(angleZ), Math.Cos(angleZ),   0,  0 },
                { 0,                0,                  1,  0 },
                { 0,                0,                  0,  1 }
            };
            double[,] result = Mult(fig, rotX);
            result = Mult(result, rotY);
            return Mult(result, rotZ);
        }

        double[,] Mult(double[,] a, double[,] b)
        {
            double[,] res = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return res;
        }

        private void trackBarCrown_Scroll(object sender, EventArgs e)
        {
            crown = trackBarCrown.Value;
            canvas.Invalidate();
        }

        private void trackBarWoodR_Scroll(object sender, EventArgs e)
        {
            WOOD_RED = trackBarWoodR.Value / 100.0;
        }

        private void trackBarWoodG_Scroll(object sender, EventArgs e)
        {
            WOOD_GREEN = trackBarWoodG.Value / 100.0;
        }

        private void trackBarWoodB_Scroll(object sender, EventArgs e)
        {
            WOOD_BLUE = trackBarWoodB.Value / 100.0;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            WOOD_LENGTH = trackBarSize.Value / 100.0;
        }

        private void trackBarLeavesR_Scroll(object sender, EventArgs e)
        {
            LEAF_RED = trackBarLeavesR.Value / 100.0;
        }

        private void trackBarLeavesG_Scroll(object sender, EventArgs e)
        {
            LEAF_GREEN = trackBarLeavesG.Value / 100.0;
        }

        private void trackBarLeavesB_Scroll(object sender, EventArgs e)
        {
            LEAF_BLUE = trackBarLeavesB.Value / 100.0;
        }

        private void trackBarDensity_Scroll(object sender, EventArgs e)
        {
            DEPTH = trackBarDensity.Value;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            DEPTH = trackBarDensity.Value;
            LEAF_BLUE = trackBarLeavesB.Value / 100.0;
            LEAF_GREEN = trackBarLeavesG.Value / 100.0;
            LEAF_RED = trackBarLeavesR.Value / 100.0;
            WOOD_LENGTH = trackBarSize.Value / 100.0;
            WOOD_BLUE = trackBarWoodB.Value / 100.0;
            WOOD_GREEN = trackBarWoodG.Value / 100.0;
            WOOD_RED = trackBarWoodR.Value / 100.0;
            crown = trackBarCrown.Value;

            GrowTreeAnimated(DEPTH);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            trackBarDensity.Value = rand.Next(6, 9);
            trackBarCrown.Value = rand.Next(20, 90);
            trackBarSize.Value = rand.Next(20, 35);
            
            trackBarWoodR.Value = rand.Next(0, 100);
            trackBarWoodG.Value = rand.Next(0, 100);
            trackBarWoodB.Value = rand.Next(0, 100);

            trackBarLeavesR.Value = rand.Next(0, 100);
            trackBarLeavesG.Value = rand.Next(0, 100);
            trackBarLeavesB.Value = rand.Next(0, 100);
        }
    }
}
