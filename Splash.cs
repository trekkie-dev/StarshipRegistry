using System.Media;
using System.Runtime.InteropServices;

namespace StarshipRegistryGUI
    {

    #region Form Specific Methods
    public partial class Splash : Form
        {
        // rounds corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Splash()
            {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // helps to draw rounded corners
            }

        private void Splash_Load(object sender, EventArgs e)
            {
            SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.scrshow);
            sPlayer.Play();
            }

        #endregion


        #region Navigation
        public void splashLogout_Click(object sender, EventArgs e)
            {
            // plays exit program sound
            SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.communications_end_transmission);
            sPlayer.PlaySync();

            Application.Exit(); // exits the program
            }


        public void splashLogin_Click(object sender, EventArgs e)
            {
            Focus();
            String userName = splNameInput.Text;


            if (userName != String.Empty)
                {
                accessStatus.ForeColor = Color.FromArgb(153, 170, 102);
                accessStatus.Text = "ACCESS GRANTED.";

                SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.input_ok_3_clean);
                sPlayer.PlaySync();

                // takes input from User Name field and sends it to mainForm
                MainForm spl = new MainForm(this);
                spl.ShowDialog();


                MainForm newForm = new MainForm();
                newForm.Show();

                Application.Exit();
                }
            else
                {
                // failed input audio indicator
                SoundPlayer sPlayer = new SoundPlayer(Properties.Resources.input_failed_clean);
                sPlayer.Play();

                // failed input text
                accessStatus.ForeColor = Color.FromArgb(204, 75, 75);
                accessStatus.Text = "ACCESS DENIED. TRY AGAIN.";
                splNameInput.Focus();

                #endregion

                }
            }
        }
    }
