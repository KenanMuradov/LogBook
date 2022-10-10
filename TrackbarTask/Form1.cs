namespace TrackbarTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)=>
            panelColor.BackColor = Color.FromArgb(trackBarRed.Value,trackBarGreen.Value,trackBarBlue.Value);

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            lblRed.Text = trackBarRed.Value.ToString();
            lblGreen.Text = trackBarGreen.Value.ToString();
            lblBlue.Text = trackBarBlue.Value.ToString();

            panelColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }
    }
}