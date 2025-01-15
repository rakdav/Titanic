using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

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
            AddEditForm form = new AddEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Titanic titanic = new Titanic();
                titanic.Survived = form.comboBoxSurvived.SelectedIndex;
                titanic.Pclass = int.Parse(form.comboBoxClass.SelectedItem!.ToString()!);
                titanic.Passenger = form.textBoxName.Text;
                if (form.comboBoxSex.SelectedIndex == 0) titanic.Sex = "male";
                else titanic.Sex = "female";
                titanic.Age = (int)form.numericUpDownAge.Value;
                titanic.Sibsp = (int)form.numericUpDownSibSp.Value;
                titanic.Parch = (int)form.numericUpDownParch.Value;
                titanic.Ticket = form.textBoxTicket.Text;
                titanic.Fare = float.Parse(form.textBoxFare.Text);
                titanic.Cabin = form.textBoxCabin.Text;
                titanic.Embarced = char.Parse(form.comboBoxEmbarced.SelectedItem!.ToString()!);
                Save(titanic);
                LoadData();
            }
        }
        private async void Save(Titanic titanic)
        {
            using (var db = new PostgresContext())
            {
                db.Titanics.Add(titanic);
                await db.SaveChangesAsync();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            using (PostgresContext db = new PostgresContext())
            {
                List<Titanic> list = db.Titanics.ToList();
                Titanic titanic = list[index];
                AddEditForm form = new AddEditForm(titanic);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    titanic.Survived = (form.comboBoxSurvived.SelectedIndex == -1) ? titanic.Survived : form.comboBoxSurvived.SelectedIndex;
                    titanic.Pclass = int.Parse(form.comboBoxClass.SelectedItem!.ToString()!);
                    titanic.Passenger = form.textBoxName.Text;
                    if (form.comboBoxSex.SelectedIndex == 0) titanic.Sex = "male";
                    else titanic.Sex = "female";
                    titanic.Age = (int)form.numericUpDownAge.Value;
                    titanic.Sibsp = (int)form.numericUpDownSibSp.Value;
                    titanic.Parch = (int)form.numericUpDownParch.Value;
                    titanic.Ticket = form.textBoxTicket.Text;
                    titanic.Fare = float.Parse(form.textBoxFare.Text);
                    titanic.Cabin = form.textBoxCabin.Text;
                    titanic.Embarced = char.Parse(form.comboBoxEmbarced.SelectedItem!.ToString()!);
                    Update(titanic);
                    LoadData();
                }
            }
        }
        private async void Update(Titanic titanic)
        {
            using (var db = new PostgresContext())
            {
                db.Titanics.Update(titanic);
                await db.SaveChangesAsync();
            }
        }

        private async void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            using (var db = new PostgresContext())
            {
                List<Titanic> list = db.Titanics.ToList();
                Titanic titanic = list[index];
                db.Titanics.Remove(titanic);
                await db.SaveChangesAsync();
                LoadData();
            }
        }
    }
}
