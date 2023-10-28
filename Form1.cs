namespace WebDesktopTranieeandDepart
{
	public partial class Form1 : Form
	{
		HttpClient client;
		public Form1()
		{
			InitializeComponent();
			client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7282/");

		}

		private void Form1_Load(object sender, EventArgs e)
		{

			HttpResponseMessage message = client.GetAsync("api/Trainee").Result;

			if (message.IsSuccessStatusCode)
			{
				List<traniee> traniees = message.Content.ReadAsAsync<List<traniee>>().Result;

				dataGridView1.DataSource = traniees;
			}


			HttpResponseMessage parts = client.GetAsync("api/Department").Result;

			if (parts.IsSuccessStatusCode)
			{
				List<Departments> departments = parts.Content.ReadAsAsync<List<Departments>>().Result;

				combDeparts.DataSource = departments;
				combDeparts.ValueMember = "DeptId";
				combDeparts.DisplayMember = "DepartName";


			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			traniee traniee = new traniee()
			{
				name = textName.Text,
				address = textaddress.Text,
				Dept_id = (int)combDeparts.SelectedValue
			};

			HttpResponseMessage mess = client.PostAsJsonAsync("api/Trainee", traniee).Result;


			if (mess.IsSuccessStatusCode)
			{
				MessageBox.Show("Added Successed");
				Form1_Load(null, null);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			this.Hide();
			form2.ShowDialog();
		}
	}
}