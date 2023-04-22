namespace Store
{
    public partial class Form1 : Form
    {
        private ClothesDatabase _clothes;
        public Form1()
        {
            InitializeComponent();
            _clothes = new ClothesDatabase();
            _clothes.Initialize();

            dataGridView1.DataSource = _clothes.Clothes.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
               dataGridView1.DataSource = _clothes.Clothes.ToList();
            }
            else
            {
                var initials = _clothes.Clothes.Where(s => s.SellerName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                dataGridView1.DataSource = initials;
            }
        }
    }
}