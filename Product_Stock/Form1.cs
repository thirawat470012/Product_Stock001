namespace Product_Stock
{
    public partial class Form1 : Form
    {
        List<Product> listproduct = new List<Product>();       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPd = id.Text;
            string NamePd = name.Text;
            string CaterogyPd = category.Text;
            double PricePd = double.Parse(price.Text);
            int QuantityPd = int.Parse(quantity.Text);

            Product product = new Product();
            product.IdPd = idPd;
            product.NamePd = NamePd;
            product.CategoryPd = CaterogyPd;
            product.PricePd = PricePd;
            product.QuantityPd = QuantityPd;
            listproduct.Add(product);
            refreshdatagrid();
        }

        private void refreshdatagrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Product i in listproduct)
            {
                dataGridView1.Rows.Add(i.IdPd, i.NamePd, i.CategoryPd, i.PricePd, i.QuantityPd);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            listproduct.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Product Stock";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    file.WriteLine("Id,Name,Category,Price,Quantity");
                    foreach (Product item in listproduct)
                    {
                        file.WriteLine($"{item.IdPd},{item.NamePd},{item.CategoryPd},{item.PricePd},{item.QuantityPd}");
                    }
                }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (.csv)|*.csv|All files (.)|.";
            MessageBox.Show("Open File");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    listproduct.Clear();
                    dataGridView1.Rows.Clear();
                    using (StreamReader file = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        int count = 0;
                        while ((line = file.ReadLine()) != null)
                        {
                            if (count == 0)
                            {
                                count++;
                                continue;
                            }
                            else
                            {
                                string[] data = line.Split(',');
                                listproduct.Add(new Product()
                                {
                                    IdPd = data[0],
                                    NamePd = data[1],
                                    CategoryPd = (data[2]),
                                    PricePd = int.Parse(data[3]),
                                    QuantityPd = int.Parse(data[4])
                                });
                            }
                        }
                        refreshdatagrid();
                    }
                }
            }
        }
    }
}