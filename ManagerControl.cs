using CA1HorseSystemJeremiah.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Reflection;

namespace CA1HorseSystemJeremiah
{
    public partial class ManagerControl : UserControl
    {
        private bool eventNameAdded = false;
        private bool eventLocationAdded = false;

        private bool eventClicked = false;

        private bool raceNameAdded = false;
        private bool raceHoursAdded = false;
        private bool raceMinutesAdded = false;
        public ManagerControl()
        {
            InitializeComponent();
        }
        private void ManagerControl_Load(object sender, EventArgs e)
        {
            disableFeatures();
        }

        public void disableFeatures()
        {
            addEventButton.Enabled = false;
            addRaceButton.Enabled = false;
            raceNameTextBox.Enabled = false;
            hoursUpDown.Enabled = false;
            minutesUpDown.Enabled = false;
            uploadButton.Enabled = false;
        }

        private void eventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event event1 = (Event)eventListBox.SelectedItem;
            if(event1 != null)
            {
                raceNameTextBox.Enabled = true;
                hoursUpDown.Enabled = true;
                minutesUpDown.Enabled = true;
                eventClicked = true;
                horseListBox.Items.Clear();
                raceListBox_SelectedIndexChanged(sender, e);
            }
            else
            {
                raceNameTextBox.Enabled = false;
                hoursUpDown.Enabled = false;
                minutesUpDown.Enabled = false;
                eventClicked = false;
            }

        }

        private void raceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event event1 = (Event)eventListBox.SelectedItem;
            
            if (event1 != null && eventClicked)
            {
                raceListBox.Items.Clear();
                foreach(Race race in event1.Races)
                {
                    raceListBox.Items.Add(race);
                }

                eventClicked = false;
            }

            Race r = (Race)raceListBox.SelectedItem;

            if (r != null)
            {
                uploadButton.Enabled = true;
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

        private void addEventButton_Click(object sender, EventArgs e)
        {
            string eventName = eventNameTextBox.Text;
            string eventLocation = eventLocationTextBox.Text;

            Event event1 = new Event(eventName, eventLocation);

            Globals.events.Add(event1);
            eventListBox.Items.Add(event1);

            eventNameTextBox.Text = null;
            eventLocationTextBox.Text = null;
        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(eventNameTextBox.Text.Length > 0)
            {
                eventNameAdded = true;
            }
            else
            {
                eventNameAdded = false;
            }
            eventButtonEnabler(eventNameAdded, eventLocationAdded, addEventButton);
        }

        private void eventLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            if(eventLocationTextBox.Text.Length > 0)
            {
                eventLocationAdded = true;
            }
            else
            {
                eventLocationAdded = false;
            }
            eventButtonEnabler(eventNameAdded, eventLocationAdded, addEventButton);
        }

        //RACES///////////////////////////////

        private void raceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(raceNameTextBox.Text.Length > 0)
            {
                raceNameAdded = true;
            }
            else
            {
                raceNameAdded = false;
            }
            eventButtonEnabler(raceNameAdded, raceHoursAdded, raceMinutesAdded, addRaceButton);
        }

        private void hoursUpDown_ValueChanged(object sender, EventArgs e)
        {
            raceHoursAdded = true;
            eventButtonEnabler(raceNameAdded, raceHoursAdded, raceMinutesAdded, addRaceButton);
        }

        private void minutesUpDown_ValueChanged(object sender, EventArgs e)
        {
            raceMinutesAdded = true;
            eventButtonEnabler(raceNameAdded, raceHoursAdded, raceMinutesAdded, addRaceButton);
        }

        private void addRaceButton_Click(object sender, EventArgs e)
        {
            string raceName = raceNameTextBox.Text;
            int hours = (int)hoursUpDown.Value;
            int minutes = (int)minutesUpDown.Value;

            int index = eventListBox.SelectedIndex;
            Event event1 = (Event)eventListBox.SelectedItem;
            Race race = new Race(raceName, hours, minutes);

            //race.Horses.Add(new Horse("JUAN", DateTime.Now));

            event1.Races.Add(race);
            eventListBox.Items[index] = event1;


            raceNameTextBox.Text = null;
            hoursUpDown.Value = 0;
            minutesUpDown.Value = 0;
            raceHoursAdded = false;
            raceMinutesAdded = false;
        }

        //functions/////////////////////////////////////////

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

        private void eventButtonEnabler(bool x, bool y, bool z, Button button)
        {
            if (x && y && z)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            Race r = (Race)raceListBox.SelectedItem;
            int index = raceListBox.SelectedIndex;

            if (r != null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    //openFileDialog.InitialDirectory = selectedFolder;
                    openFileDialog.Filter = "JSON Files (*.json)|*.json";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;

                        if (!string.IsNullOrEmpty(selectedFilePath))
                        {
                            try
                            {
                                string jsonContent = File.ReadAllText(selectedFilePath);
                                List<Horse> horses = JsonConvert.DeserializeObject<List<Horse>>(jsonContent);
                                
                                

                                // Now you have the JSON data deserialized into a list of Horse objects
                                foreach (Horse horse in horses)
                                {
                                    //Debug.WriteLine(horse.HorseName);
                                    //Debug.WriteLine(horse);
                                    r.Horses.Add(horse);
                                    raceListBox.Items[index] = r;
                                }
                            }
                            catch (Exception se)
                            {
                                Console.WriteLine($"Error reading JSON file: {se.Message}");
                            }
                        }
                    }
                }
            }
        }
    }
}
