namespace ScreenshotDemo
{
    public partial class ScreenshotDemo : Form
    {
        public ScreenshotDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dropWindows.DataSource = ScreenshotHelper.GetAllWindowHandleNames();
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            string selection = dropWindows.SelectedValue.ToString();
            if (string.IsNullOrEmpty(selection))
            {
                MessageBox.Show("fuck you");
                return;
            }
            var img = ScreenshotHelper.GetBitmapScreenshot(selection);
            if (img == null)
            {
                MessageBox.Show("Image is null");
                return;
            }
            txtCurrent.Text = selection;
            pictureScreenshot.SizeMode = PictureBoxSizeMode.Zoom;
            pictureScreenshot.Image = img;
        }
    }
}