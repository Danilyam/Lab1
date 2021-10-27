using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<Human> CreateHuman()
        {
            List<Human> humans = new List<Human>();
            Human pip = new Human(177, "Grigoriy", "Bochkarev", 18);
            Human pip1 = new Human(256, "Andrew", "Mihalkov", 35);
            Human pip2 = new Human(017, "Natasha", "Kravchenko", 19);
            Human pip3 = new Human(100, "Sasha", "Ivanova", 25);

            humans.Add(pip);
            humans.Add(pip1);
            humans.Add(pip2);
            humans.Add(pip);
            return humans;
        }

        public void InitionalDatatable()
        {
            List<Human> humans = CreateHuman();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Surname");
            table.Columns.Add("Age");
            foreach(Human a in humans)
            {
                table.Rows.Add(a.Id, a.Name, a.Surname, a.Age);
            }
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitionalDatatable();
            InitionalChart();
        }

        private void InitionalChart()
        {
            List<Human> humans = CreateHuman();
            for (int i = 0; i < humans.Count; i++)
            {
                chart1.Series["Age"].Points.AddXY(humans[i].Name, humans[i].Age);
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
