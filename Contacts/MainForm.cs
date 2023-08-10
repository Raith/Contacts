using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace Contacts
{
    public enum DBAction
    {
        Add,
        Edit
    }

    public partial class MainForm : Form
    {
        private SqlConnection? sqlConnection;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {
            SqlDataAdapter adapter = new("CSelect", sqlConnection);

            DataTable table = new();
            adapter.Fill(table);

            dataGridView.DataSource = table;
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Sort(dataGridView.Columns["Name"], ListSortDirection.Ascending);
            dataGridView.Columns["DOB"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            sqlConnection = new(connectionString);

            PopulateDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogArgs args = ShowDialog();

            if (args != null)
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new("CAddContact", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new("@Name", args.Name));
                    command.Parameters.Add(new("@Phone", args.Phone));
                    command.Parameters.Add(new("@DOB", args.DOB));
                    command.ExecuteNonQuery();

                    sqlConnection.Close();

                    PopulateDataGridView();
                }
                catch (SqlException ex)
                {
                    if (ex.Message == "Error converting data type nvarchar to date.")
                    {
                        MessageBox.Show("Date format error. \n\nUse: YYYY-MM-DD");
                    }
                    sqlConnection.Close();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null &&
                int.TryParse(dataGridView.CurrentRow.Cells["ID"].Value.ToString(), out int ID))
            {
                DialogArgs args = new(
                    dataGridView.CurrentRow.Cells["Name"].Value.ToString(),
                    dataGridView.CurrentRow.Cells["Phone"].Value.ToString(),
                    dataGridView.CurrentRow.Cells["DOB"].FormattedValue.ToString());

                args = ShowDialog(args);

                if (args != null)
                {
                    try
                    {
                        sqlConnection.Open();

                        SqlCommand command = new("CUpdateContact", sqlConnection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new("@ID", ID));
                        command.Parameters.Add(new("@Name", args.Name));
                        command.Parameters.Add(new("@Phone", args.Phone));
                        command.Parameters.Add(new("@DOB", args.DOB));
                        command.ExecuteNonQuery();

                        sqlConnection.Close();

                        PopulateDataGridView();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message == "Error converting data type nvarchar to date.")
                        {
                            MessageBox.Show("Date format error.\n\nUse: YYYY-MM-DD");
                        }
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView.CurrentRow != null &&
                int.TryParse(dataGridView.CurrentRow.Cells["ID"].Value.ToString(), out int ID))
            {
                try
                {
                    sqlConnection.Open();

                    SqlCommand command = new("CDeleteContact", sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ID", ID));
                    command.ExecuteNonQuery();

                    sqlConnection.Close();

                    PopulateDataGridView();
                }
                catch
                {
                    sqlConnection.Close();
                }
            }
        }

        public static DialogArgs? ShowDialog(DialogArgs? args = null)
        {
            Dialog dialog = new();

            if (args != null)
            {
                dialog.Text = "Edit";
                dialog.FillData(args);
            }
            else
            {
                dialog.Text = "Add";
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.ReturnData();
            };

            return null;
        }
    }
}
