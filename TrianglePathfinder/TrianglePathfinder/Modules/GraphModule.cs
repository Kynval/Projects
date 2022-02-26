using System.Collections.Generic;
using System.Drawing;

namespace TrianglePathfinder.Modules
{
    public class Vertex
    {
        public int x, y, weigth;

        public Vertex(int x, int y, int weigth)
        {
            this.x = x;
            this.y = y;
            this.weigth = weigth;
        }
    }

    public class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    public class DrawGraph
    {
        private readonly Bitmap bitmap;
        private readonly Pen blackPen;
        private readonly Pen darkBluePen;
        private readonly Graphics graphics;
        private readonly Font font;
        private readonly Brush brush;
        private PointF floatPoint;
        public int R = 20;

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            graphics = Graphics.FromImage(bitmap);
            ClearPicBox();
            blackPen = new Pen(Color.Black) { Width = 2 };
            darkBluePen = new Pen(Color.Silver) { Width = 2 };
            font = new Font("Arial", 7);
            brush = Brushes.Black;
        }
        public Bitmap GetBitmap()
        {
            return bitmap;
        }
        public void ClearPicBox()
        {
            graphics.Clear(Color.White);
        }

        public void drawVertex(int x, int y, string number)
        {
            graphics.FillEllipse(Brushes.White, x - R, y - R, 2 * R, 2 * R);
            graphics.DrawEllipse(blackPen, x - R, y - R, 2 * R, 2 * R);
            floatPoint = new PointF(x - 9, y - 9);
            graphics.DrawString(number, font, brush, floatPoint);
        }
        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            for (int i = 0; i < E.Count; i++)
            {
                graphics.DrawLine(darkBluePen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                floatPoint = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
            }
            for (int i = 0; i < V.Count; i++)
                drawVertex(V[i].x, V[i].y, $"{i + 1}.=\n{V[i].weigth}");
        }

    }
}
