using System;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form1 : Form
    {
        SQLEngine sql = new SQLEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MSRunQuery("SELECT NameProduct,NameCategorie FROM Meal,Categories,Productss WHERE Meal.Id_Categories = Categories.Id_Categories AND Meal.Id_Productss = Productss.Id_Productss ORDER BY(NameProduct)", true);
        }
    }
}
