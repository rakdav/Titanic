using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titanic
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(Titanic titanic)
        {
            InitializeComponent();
            comboBoxSurvived.SelectedIndex = (titanic.Survived==0)?0:1;
            comboBoxClass.Text=titanic.Pclass.ToString();
            textBoxName.Text=titanic.Passenger.ToString();
            comboBoxSex.Text = titanic.Sex.ToString();
            numericUpDownAge.Value = titanic.Age??0;
            numericUpDownSibSp.Value = titanic.Sibsp;
            numericUpDownParch.Value = titanic.Parch;
            textBoxTicket.Text=titanic.Ticket;
            textBoxFare.Text = titanic.Fare.ToString();
            textBoxCabin.Text = titanic.Cabin!.ToString();
            comboBoxEmbarced.Text=titanic.Embarced.ToString();
        }
    }
}
