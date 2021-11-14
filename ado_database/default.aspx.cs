using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ado_database
{
	public partial class _default : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
			displaycustomers();
			
		}
		public static void AddCustomer(Customer newCustomer)
		{
			// this takes in the results from button click method and adds it to the database 
			var customer = new Customer();
			customer.CustomerID = newCustomer.CustomerID;
			customer.name = newCustomer.name;
			customer.address = newCustomer.address;
			customer.City = newCustomer.City;
			customer.ZipCode = newCustomer.ZipCode;
			customer.Notes = newCustomer.Notes;

			ACME db = new ACME();
			var dbcustomers = db.Customers;
		

			dbcustomers.Add(customer);
			db.SaveChanges();	
		}

		protected void buttonEnterData_Click(object sender, EventArgs e)
		{
			// this take in the infomation from the textboxs and pass's into the addCustomer method, also calls the display customer method which updates the gridview

			var newCustomer = new Customer();
			newCustomer.CustomerID = Guid.NewGuid();
			newCustomer.name = tbName.Text;
			newCustomer.address = tbAddress.Text;
			newCustomer.City = tbCity.Text;
			newCustomer.ZipCode = tbPostCode.Text;
			newCustomer.Notes = tbNotes.Text;

			AddCustomer(newCustomer);
			displaycustomers();


		}

		private void displaycustomers()
		{
			//  Updates the gridview to show new database entrites also

			ACME db = new ACME();
			
			// the data sorce must be as list to work, have to call ADO model and not database

			gridviewCustomers.DataSource = db.Customers.ToList();
			gridviewCustomers.DataBind();

		}
	}
}