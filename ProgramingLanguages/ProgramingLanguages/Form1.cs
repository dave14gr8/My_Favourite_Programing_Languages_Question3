using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingLanguages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newLanguage = textBoxEnterLanguage.Text.Trim();

            //Prevent empty input when user whant to add somthing to the list so he can't add a blank space
            if (string.IsNullOrEmpty(newLanguage))
            {
                labOutput.Text = "Error: Please enter a programming language.";
                return;
            }

            //Prevent duplicate languages to be added to the list 
            foreach (var item in listBoxLanguages.Items)
            {
                if (item.ToString().Equals(newLanguage, StringComparison.OrdinalIgnoreCase))
                {
                    labOutput.Text = $"Error: '{newLanguage}' is already in the list.";
                    return;
                }
            }

            //Add to list and display the timestamp
            listBoxLanguages.Items.Add(newLanguage);
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            labOutput.Text = $"Added '{newLanguage}' at {timestamp}";

            //Clear the input box so the user can enter a nother language if he wants to 
            textBoxEnterLanguage.Clear();
            textBoxEnterLanguage.Focus();
        }
        

        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Check if an item is selected in the list you whant to remove 
            if (listBoxLanguages.SelectedItem != null)
            {
                string removedLanguage = listBoxLanguages.SelectedItem.ToString();
                listBoxLanguages.Items.Remove(listBoxLanguages.SelectedItem);

                //Display timestamp of removal
                string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
                labOutput.Text = $"Removed '{removedLanguage}' at {timestamp}";
            }
            else
            {
                labOutput.Text = "Please select a language from the list to remove.";
            }
        }

        private void labOutput_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnterLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
