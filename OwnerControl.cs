using CA1HorseSystemJeremiah.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA1HorseSystemJeremiah
{
    public partial class OwnerControl : UserControl
    {
        private bool horseNameAdded = false;
        private bool horsedoBAdded = false;

        private bool eventClicked = false;

        public OwnerControl()
        {
            InitializeComponent();
        }

        private void OwnerControl_Load(object sender, EventArgs e)
        {
            disableFeatures();
        }

        public void disableFeatures()
        {
            horseNameTextBox.Enabled = false;
            horsedoBTextBox.Enabled = false;
            addHorseToRaceButton.Enabled = false;
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event event1 = (Event)eventListBox.SelectedItem;
            if (event1 != null)
            {
                eventClicked = true;
                horseListBox.Items.Clear();
                raceListBox_SelectedIndexChanged(sender, e);
            }
            else
            {
                eventClicked = false;
            }

        }

        private void raceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //raceListBox.Items.Clear();
            Event event1 = (Event)eventListBox.SelectedItem;

            if (event1 != null && eventClicked)
            {
                raceListBox.Items.Clear();
                foreach (Race race in event1.Races)
                {
                    raceListBox.Items.Add(race);
                }

                eventClicked = false;
            }

            Race r = (Race)raceListBox.SelectedItem;

            if (r != null)
            {
                horseNameTextBox.Enabled = true;
                horsedoBTextBox.Enabled = true;
                horseListBox.Items.Clear();
                foreach (Horse horse in r.Horses)
                {
                    horseListBox.Items.Add(horse);
                }
            }
        }

        private void horseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void horseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(horseNameTextBox.Text.Length > 0)
            {
                horseNameAdded = true;
            }
            else
            {
                horseNameAdded = false;
            }
            eventButtonEnabler(horseNameAdded, horsedoBAdded, addHorseToRaceButton);
        }

        private void horsedoBTextBox_ValueChanged(object sender, EventArgs e)
        {
            if(horsedoBTextBox.Text.Length > 0)
            {
                horsedoBAdded = true;
            }
            else
            {
                horsedoBAdded = false;
            }
            eventButtonEnabler(horseNameAdded, horsedoBAdded, addHorseToRaceButton);
        }

        private void addHorseToRaceButton_Click(object sender, EventArgs e)
        {
            string horseName = horseNameTextBox.Text;
            string[] doBTextBox = horsedoBTextBox.Text.Split(' ');
            DateTime doB = DateTime.Parse(doBTextBox[0]);
            
            Horse horse = new Horse(horseName, doB);

            int index = raceListBox.SelectedIndex;
            Race r = (Race)raceListBox.SelectedItem;


            if(r != null)
            {
                r.Horses.Add(horse);
                raceListBox.Items[index] = r;

                disableFeatures();
            }
        }

        private void eventButtonEnabler(bool x, bool y, Button button)
        {
            if (x && y)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        public void switchVisibilityInvisible()
        {
            label1.Visible = false;
            label2.Visible = false;
            horseNameTextBox.Visible = false;
            horsedoBTextBox.Visible = false;
            addHorseToRaceButton.Visible = false;
        }

        public void switchVisibilityVisible()
        {
            label1.Visible = true;
            label2.Visible = true;
            horseNameTextBox.Visible = true;
            horsedoBTextBox.Visible = true;
            addHorseToRaceButton.Visible = true;
        }
    }
}
