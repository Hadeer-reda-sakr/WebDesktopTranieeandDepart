using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDesktopTranieeandDepart
{
	public class Departments
	{
		public int DeptId { get; set; }
		public string DepartName { get; set; }
		public int traineeid { get; set; }


		public List<string> TranieerName { get; set; } = new List<string>();
		


	}
}
