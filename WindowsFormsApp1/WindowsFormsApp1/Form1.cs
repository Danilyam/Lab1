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

        private List<Teacher> CreateStudent()
        {
            List<Teacher> teach_list = new List<Teacher>();
            Student pip = new Student("Danil", "Prosenko", 18, "Ukraine", "Skadovsk", "Gorkogo", 8);
            Student pip1 = new Student("Natasha", "Ivanova", 16, "Ukraine", "Kherson", "Perekopskaya", 175);
            Student pip2 = new Student("Ivan", "Matveev", 19, "Ukraine", "Kiyev", "Kolhoznaya", 17);

            Teacher pop = new Teacher("Nikita", "Bondarenko", 25, "Ukraine", "Kherson", "Liteynaya", 25);
            Teacher pop1 = new Teacher("Anna", "Grigoryeva", 33, "Ukraine", "Kiyev", "Pobedu", 17);
           

            teach_list.Add(pop);
            teach_list.Add(pop1);
            teach_list[1].stdAdd(pip2);
            teach_list[0].stdAdd(pip1);
            teach_list[0].stdAdd(pip);
            return teach_list;
        }

        public void InitionalDatatable()
        {
            List<Human> humans = CreateHuman();
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("Surname");
            table.Columns.Add("Age");
            foreach (Human a in humans)
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
