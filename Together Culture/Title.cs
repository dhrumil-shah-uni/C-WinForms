using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace Together_Culture
{
    public partial class Title : Form
    {
        

        public Title()
        {
            InitializeComponent();

            //Following code draws a curved border, purely design purposes
            //Credit: https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms/18822204
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

        //Parameters to draw the form border
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
            //Loads the next page after a few seconds
            Timer titletime = new Timer();
            titletime.Interval = 2000;
            titletime.Tick += (source, e) =>
            {
                //Goes to Login Page
                Loginpage goto_login = new Loginpage();
                goto_login.Show();
                this.Hide(); //Hides this form
                titletime.Stop();
            };
            titletime.Start();
        }

        //Code to allow dragging the window around the screen, even without a border
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