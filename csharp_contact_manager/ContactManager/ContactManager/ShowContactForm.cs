using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ContactManager {
    public partial class ShowContactForm : Form {
        public ArrayList Data;
        public ShowContactForm() {
            InitializeComponent();
        }
        public int _currentRow = 0;

        public void SetData( ArrayList lines ) {
            Data = lines;
            outputLabel.Text = "Found (" + Data.Count + ") rows";
            Render();
        }

        private void nextButton_Click( object sender, EventArgs e ) {
            //if the current row is the last row display a message and stop incrementing
            if ( _currentRow + 1 == Data.Count ) {
                MessageBox.Show( "This is the last row" );
            }
            else {
                _currentRow++;
            }
            Render();
        }

        private void prevButton_Click( object sender, EventArgs e ) {
            if ( _currentRow == 0 ) {
                MessageBox.Show( "This is the first row" );
            }
            else {
                _currentRow--;
            }
            Render();
        }

        private void Render() {
            string contact = Data[_currentRow].ToString();
            string[] tokens = contact.Split( ',' );
            nameTextBox.Text = tokens[0];
            telephoneTextBox.Text = tokens[1];
            emailTextBox.Text = tokens[2];
            organizationTextBox.Text = tokens[3];
        }

        private void deleteButton_Click( object sender, EventArgs e ) {
            string line = Data[_currentRow].ToString();

            Data.RemoveAt( _currentRow );
            Render();
        }
    }
}
