using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace Together_Culture
{
    public partial class Title : Form
    {
        //Credit: https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms/18822204

        public Title()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public Loginpage Loginpage
        {
            get => default;
            set
            {
            }
        }

        private Point mouseLocation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void Title_Load(object sender, EventArgs e)
        {
            Timer titletime = new Timer();
            titletime.Interval = 2000;
            titletime.Tick += (source, e) =>
            {
                Loginpage goto_login = new Loginpage();
                goto_login.Show();
                this.Hide();
                titletime.Stop();
            };
            titletime.Start();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

        private async void mouse_Move(object sender, MouseEventArgs e)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;

                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}