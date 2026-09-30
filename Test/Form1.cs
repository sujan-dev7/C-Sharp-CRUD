namespace Test
{
    public partial class Form1 : Form
    {
        int nextId = 1;
        public Form1()
        {
            InitializeComponent();

            // Add countries to ComboBox
            comboCountry.Items.Add("Nepal");
            comboCountry.Items.Add("India");
            comboCountry.Items.Add("China");
            comboCountry.Items.Add("USA");
            comboCountry.Items.Add("UK");

            // Create DataGridView columns
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Country", "Country");
            dataGridView1.Columns.Add("Gender", "Gender");

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check required fields
            if (txtName.Text == "" ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" ||
                comboCountry.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please fill all fields.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            // Get gender
            string gender = "";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            else if (radioButton3.Checked)
            {
                gender = "Others";
            }
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }
            // Add data to DataGridView
            dataGridView1.Rows.Add(
                nextId,
                txtName.Text,
                txtAddress.Text,
                txtEmail.Text,
                comboCountry.Text,
                gender
            );

            // Increase ID
            nextId++;

            MessageBox.Show(
                "Record added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Clear fields
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        // CLEAR FUNCTION
        private void ClearFields()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();

            comboCountry.SelectedIndex = -1;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(
                    dataGridView1.SelectedRows[0].Index
                );

                MessageBox.Show("Record deleted successfully.");
            }
            // DELETE BUTTON

        }
    }
}





