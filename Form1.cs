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
            if(Globals.events.Count> 0)
            {
                managerControl1.eventListBox.Items.Clear();
                managerControl1.raceListBox.Items.Clear();
                managerControl1.horseListBox.Items.Clear();
                managerControl1.disableFeatures();
                foreach (Event event1 in Globals.events)
                {
                    managerControl1.eventListBox.Items.Add(event1);
                }
            }
        }

        private void ownerButton_Click(object sender, EventArgs e)
        {
            ownerControl1.Show();
            ownerControl1.switchVisibilityVisible();
            managerControl1.Hide();
            if (Globals.events.Count > 0)
            {
                ownerControl1.eventListBox.Items.Clear();
                ownerControl1.raceListBox.Items.Clear();
                ownerControl1.horseListBox.Items.Clear();
                ownerControl1.disableFeatures();
                foreach (Event event1 in Globals.events)
                {
                    ownerControl1.eventListBox.Items.Add(event1);
                }
            }
        }

        private void goerButton_Click(object sender, EventArgs e)
        {
            ownerControl1.Show();
            managerControl1.Hide();
            ownerControl1.switchVisibilityInvisible();
            if (Globals.events.Count > 0)
            {
                ownerControl1.eventListBox.Items.Clear();
                ownerControl1.raceListBox.Items.Clear();
                ownerControl1.horseListBox.Items.Clear();
                ownerControl1.disableFeatures();
                foreach (Event event1 in Globals.events)
                {
                    ownerControl1.eventListBox.Items.Add(event1);
                }
            }

        }
    }
}