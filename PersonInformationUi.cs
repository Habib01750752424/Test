using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
         Person aPerson;
         Person bPerson;
        public PersonInformationUi()
        {
            InitializeComponent();
        }


       
        private void saveButton_Click(object sender, EventArgs e)
        {
           // aPerson.firstName = firstNameTextBox.Text;
           // aPerson.middleName = middleNameTextBox.Text;
          //  aPerson.lastName = lastNameTextBox.Text;

         // aPerson.FirstName = firstNameTextBox.Text;
         // aPerson.MiddleName = middleNameTextBox.Text;
         // aPerson.LastName = lastNameTextBox.Text;

         aPerson= new Person(firstNameTextBox.Text,middleNameTextBox.Text,lastNameTextBox.Text);

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
           // firstNameTextBox.Text = aPerson.FirstName;
          //  middleNameTextBox.Text = aPerson.MiddleName;
          //  lastNameTextBox.Text = aPerson.LastName;


           // string fullName = aPerson.GetFullName();
            fullNameTextBox.Text = aPerson.FirstName+ ""+aPerson.MiddleName+""+aPerson.LastName;
        }


    }
}
