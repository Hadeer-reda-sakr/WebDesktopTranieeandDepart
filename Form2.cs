using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDesktopTranieeandDepart
{
	public partial class Form2 : Form
	{
		HttpClient client;

		public Form2()
		{
			InitializeComponent();
			client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7282/");
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			HttpResponseMessage parts = client.GetAsync("api/Department").Result;

			if (parts.IsSuccessStatusCode)
			{
				List<Departments> departments = parts.Content.ReadAsAsync<List<Departments>>().Result;

				dataGridView1.DataSource = departments;
			}
			HttpResponseMessage message = client.GetAsync("api/Trainee").Result;
			if (parts.IsSuccessStatusCode)
			{
				List<traniee> tdepartments = message.Content.ReadAsAsync<List<traniee>>().Result;

				combtraniee.DataSource = tdepartments;
				combtraniee.ValueMember = "id";
				combtraniee.DisplayMember = "name";


			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Departments d = new Departments()
			{
				DepartName = textName.Text,

				//traineeid = (int)combDeparts.SelectedValue
			};

			HttpResponseMessage mess = client.PostAsJsonAsync("api/Department", d).Result;


			if (mess.IsSuccessStatusCode)
			{
				MessageBox.Show("Added Successed");
				Form2_Load(null, null);
			}
		}
	}
}
