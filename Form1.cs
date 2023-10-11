using CA1HorseSystemJeremiah.models;

namespace CA1HorseSystemJeremiah
{
    public partial class HorseSystem : Form
    {

        public HorseSystem()
        {
            InitializeComponent();
        }

        private void HorseSystem_Load(object sender, EventArgs e)
        {
            ownerControl1.Hide();
            managerControl1.Show();

        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ownerControl1.Hide();
            managerControl1.Show();
        }

        private void ownerButton_Click(object sender, EventArgs e)
        {
            ownerControl1.Show();
            managerControl1.Hide();
        }
    }
}