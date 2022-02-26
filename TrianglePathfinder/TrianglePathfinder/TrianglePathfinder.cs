using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrianglePathfinder.Modules;

namespace TrianglePathfinder
{
    public partial class TrianglePathfinder : Form
    {
        public TrianglePathfinder()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            resultInfoBox.Clear();

            int trglSize = int.Parse(triangleSizeMasked.Text) - 1;
            int trglIndent = 40;
            int lowerBound = 1, upperBound = 100;
            Random rnd = new Random();

            while (trglIndent * (trglSize + 25) > picBoxGraph.Width)
            { picBoxGraph.Width = (int)(picBoxGraph.Width * 1.5); picBoxGraph.Height = (int)(picBoxGraph.Height * 1.5); }

            List<Vertex> V = new List<Vertex>();
            List<Edge> E = new List<Edge>();
            DrawGraph G = new DrawGraph(picBoxGraph.Width, picBoxGraph.Height);

            int vectorStart = picBoxGraph.Width / 2 + trglIndent * 2;

            picBoxGraph.Image = G.GetBitmap();

            V.Add(new Vertex(vectorStart - trglIndent * 2, trglIndent * 2, rnd.Next(lowerBound, upperBound)));
            for (int i = 0; i < trglSize; i++)
            {
                int startIndent = -trglIndent * (i + 3);
                for (int j = 0; j < i + 2; j++)
                {
                    V.Add(new Vertex(vectorStart + startIndent, trglIndent * (i + 3), rnd.Next(lowerBound, upperBound)));
                    startIndent += trglIndent * 2;
                }
            }
            int k = 1;
            int[,] matrix = new int[V.Count, V.Count];
            matrix[0, 0] = V[0].weigth;
            for (int i = 0; i < V.Count; i++)
                if (i + k + 1 < V.Count)
                {
                    for (int j = i + k; j <= i + k + 1; j++)
                        if (j > i)
                        {
                            matrix[i, j] = V[j].weigth;
                            E.Add(new Edge(i, j));
                        }
                    if (i + 1 == k * (k + 1) / 2)
                        k++;
                }
                else break;
            G.drawALLGraph(V, E);
            string[] path = PathfinderModule.Dijkstra(matrix);
            resultInfoBox.Text += "Отчет: " + string.Join("\n", path).Replace("-", " -> ");
        }
    }
}
