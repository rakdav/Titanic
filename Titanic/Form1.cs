using Microsoft.EntityFrameworkCore;

namespace Titanic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            using (PostgresContext db = new PostgresContext())
            {
                dataGridView1.DataSource = await db.Titanics.ToListAsync();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AddEditForm form=new AddEditForm();
            if (form.ShowDialog()==DialogResult.OK)
            {
                Titanic titanic = new Titanic();
                titanic.Survived = form.comboBoxSurvived.SelectedIndex;
                titanic.Pclass = int.Parse(form.comboBoxClass.SelectedItem!.ToString()!);
                titanic.Passenger=form.textBoxName.Text;
                if (form.comboBoxSex.SelectedIndex == 0) titanic.Sex = "male";
                else titanic.Sex = "female";
                titanic.Age=(int)form.numericUpDownAge.Value;
                titanic.Sibsp=(int)form.numericUpDownSibSp.Value;
                titanic.Parch= (int)form.numericUpDownParch.Value;
                titanic.Ticket=form.textBoxTicket.Text;
                titanic.Fare = float.Parse(form.textBoxFare.Text);
                titanic.Cabin = form.textBoxCabin.Text;
                titanic.Embarced = char.Parse(form.comboBoxEmbarced.SelectedItem!.ToString()!);
                Save(titanic);
                LoadData();
            }
        }
        private async void Save(Titanic titanic)
        {
            using(var db = new PostgresContext())
            {
                db.Titanics.Add(titanic);
                await db.SaveChangesAsync();
            }
        }
    }
}
