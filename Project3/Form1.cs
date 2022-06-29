namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        bool isBlack = true;

        public Form1()
        {
            InitializeComponent();

            //  그래픽 관련 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black);
            wBrush = new SolidBrush(Color.White);
            bBrush = new SolidBrush(Color.Black);

            //  바둑판 색, 크기
            this.Text = "오목 v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            //Console.WriteLine("x:{0}, y:{1}", x, y);

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2,
                                          margin + sizeNun * y - sizeNun / 2, 
                                          sizeDol, 
                                          sizeDol);

            if (isBlack)
            {
                g.FillEllipse(bBrush, dol);
                isBlack = false;
            }
            else 
            {
                g.FillEllipse(wBrush, dol);
                isBlack = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //  바둑판 눈금 그리기
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeNun * i, margin), new Point(margin + sizeNun * i, margin + 18 * sizeNun));
                g.DrawLine(pen, new Point(margin, margin + sizeNun * i), new Point(margin + 18 * sizeNun, margin + sizeNun * i));
            }
        }
    }
}