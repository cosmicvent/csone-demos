using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Linq;

namespace ContactManager {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addContactButton_Click( object sender, EventArgs e ) {
            string name = nameTextBox.Text;
            string telephone = telephoneTextBox.Text;
            string email = emailTextBox.Text;
            string organization = organizationTextBox.Text;


            using ( StreamWriter sw = new StreamWriter( @"D:\contacts.csv", true ) ) {
                string line = name + "," + telephone + "," + email + "," + organization;
                sw.WriteLine( line );
            }

            nameTextBox.Text = "";
            telephoneTextBox.Text = "";
            emailTextBox.Text = "";
            organizationTextBox.Text = "";

            MessageBox.Show( name + " was successfullly added to the contacts" );

            nameTextBox.Focus();
        }

        private void searchButton_Click( object sender, EventArgs e ) {
            //get the name for the search
            string name = nameTextBox.Text;
            //search in the file
            IList<string> result = new List<string>();

            using ( StreamReader sr = new StreamReader( @"D:\contacts.csv" ) ) {
                while ( !sr.EndOfStream ) {
                    string line = sr.ReadLine();
                    //if it is a match add it to the result
                    if ( line.ToLower().Contains( name.ToLower() ) ) {
                        result.Add( line );
                    }
                }
            }

            result.Where( x => x.StartsWith( "a" ) );
            //display contacts
            ShowContactForm showForm = new ShowContactForm();
            showForm.SetData( result );
            showForm.Show();
        }



    }
}
