using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kontr_lab01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Green;
            this.Width = 300;
            this.Height = 300;

            CloseButton.Location = new Point(
                (this.Width - CloseButton.Width) / 2,
                (this.Height - CloseButton.Height) / 2
            );
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(new Point[]
                {
                    new Point(this.Width / 2, 0),
                    new Point(this.Width, this.Height / 2),
                    new Point(this.Width / 2, this.Height),
                    new Point(0, this.Height / 2)
                });
                this.Region = new Region(path);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
