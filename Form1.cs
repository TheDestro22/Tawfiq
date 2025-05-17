using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tawfiq
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_Worker_MatchingDataSet.TASK' table. You can move, or remove it, as needed.
            this.tASKTableAdapter.Fill(this.task_Worker_MatchingDataSet.TASK);
            
        }

        private void add_task_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sqlConnection.Open();
                string query = "INSERT INTO TASK (TASK_ID, TASK_NAME, REQUIRED_SPECIALITY, AVERAGE_TIME, AVERAGE_FEE) VALUES (@TaskID, @TaskName, @RequiredSpeciality, @AverageTime, @AverageFee)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@TaskID", task_id_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@TaskName", task_name_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@RequiredSpeciality", required_speciality_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@AverageTime", average_time_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@AverageFee", average_fee_txt.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Task added successfully.");
                    this.tASKTableAdapter.Fill(this.task_Worker_MatchingDataSet.TASK);
                    Tasks_table.DataSource = task_Worker_MatchingDataSet.TASK;
                    sqlConnection.Close();
                }
            }
        }

        private void edit_task_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql_connection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sql_connection.Open();

                List<string> where_conditions = new List<string>();
                List<string> set_conditions = new List<string>();
                SqlCommand sql_command = new SqlCommand();

                ///////////////Where conditions///////////////////////
                if (!string.IsNullOrEmpty(task_id_txt.Text))
                {
                    where_conditions.Add("TASK_ID = @TaskID");
                    sql_command.Parameters.AddWithValue("@TaskID", task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(task_name_txt.Text))
                {
                    where_conditions.Add("TASK_NAME = @TaskName");
                    sql_command.Parameters.AddWithValue("@TaskName", task_name_txt.Text);
                }
                if (!string.IsNullOrEmpty(required_speciality_txt.Text))
                {
                    where_conditions.Add("REQUIRED_SPECIALITY = @RequiredSpeciality");
                    sql_command.Parameters.AddWithValue("@RequiredSpeciality", required_speciality_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_time_txt.Text))
                {
                    where_conditions.Add("AVERAGE_TIME = @AverageTime");
                    sql_command.Parameters.AddWithValue("@AverageTime", average_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_fee_txt.Text))
                {
                    where_conditions.Add("AVERAGE_FEE = @AverageFee");
                    sql_command.Parameters.AddWithValue("@AverageFee", average_fee_txt.Text);
                }


                //////////////////////////Set conditions//////////////////////////
                if (!string.IsNullOrEmpty(new_task_id_txt.Text))
                {
                    set_conditions.Add("TASK_ID = @NewTaskID");
                    sql_command.Parameters.AddWithValue("@NewTaskID", new_task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_task_name_txt.Text))
                {
                    set_conditions.Add("TASK_NAME = @NewTaskName");
                    sql_command.Parameters.AddWithValue("@NewTaskName", new_task_name_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_required_speciality_txt.Text))
                {
                    set_conditions.Add("REQUIRED_SPECIALITY = @NewRequiredSpeciality");
                    sql_command.Parameters.AddWithValue("@NewRequiredSpeciality", new_required_speciality_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_average_time_txt.Text))
                {
                    set_conditions.Add("AVERAGE_TIME = @NewAverageTime");
                    sql_command.Parameters.AddWithValue("@NewAverageTime", new_average_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_average_time_txt.Text))
                {
                    set_conditions.Add("AVERAGE_FEE = @NewAverageFee");
                    sql_command.Parameters.AddWithValue("@NewAverageFee", new_average_time_txt.Text);
                }
                if (set_conditions.Count == 0)
                {
                    MessageBox.Show("Updating all instances in the table");
                    return;
                }
                if (where_conditions.Count == 0)
                {
                    MessageBox.Show("Updating all instances in the table");
                    return;
                }
                string set_clause = string.Join(", ", set_conditions);
                string where_clause = string.Join(" AND ", where_conditions);
                sql_command.CommandText = $"UPDATE TASK SET {set_clause} WHERE {where_clause}";
                sql_command.Connection = sql_connection;

                int rowsAffected = sql_command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} rows updated.");
                this.tASKTableAdapter.Fill(this.task_Worker_MatchingDataSet.TASK);
                Tasks_table.DataSource = task_Worker_MatchingDataSet.TASK;
                sql_connection.Close();

            }
        }

        private void delete_task_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql_connection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sql_connection.Open();

                List<string> conditions = new List<string>();
                SqlCommand sql_command = new SqlCommand();

                if (!string.IsNullOrEmpty(task_id_txt.Text))
                {
                    conditions.Add("TASK_ID = @TaskID");
                    sql_command.Parameters.AddWithValue("@TaskID", task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(task_name_txt.Text))
                {
                    conditions.Add("TASK_NAME = @TaskName");
                    sql_command.Parameters.AddWithValue("@TaskName", task_name_txt.Text);
                }
                if (!string.IsNullOrEmpty(required_speciality_txt.Text))
                {
                    conditions.Add("REQUIRED_SPECIALITY = @RequiredSpeciality");
                    sql_command.Parameters.AddWithValue("@RequiredSpeciality", required_speciality_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_time_txt.Text))
                {
                    conditions.Add("AVERAGE_TIME = @AverageTime");
                    sql_command.Parameters.AddWithValue("@AverageTime", average_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_fee_txt.Text))
                {
                    conditions.Add("AVERAGE_FEE = @AverageFee");
                    sql_command.Parameters.AddWithValue("@AverageFee", average_fee_txt.Text);
                }
                if (conditions.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to delete a task");
                    return;
                }
                string where_clause = string.Join(" AND ", conditions);
                sql_command.CommandText = $"DELETE FROM TASK WHERE {where_clause}";
                sql_command.Connection = sql_connection;

                int rowsAffected = sql_command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} rows deleted.");
                this.tASKTableAdapter.Fill(this.task_Worker_MatchingDataSet.TASK);
                Tasks_table.DataSource = task_Worker_MatchingDataSet.TASK;
                sql_connection.Close();

            }
        }

        private void load_tasks_btn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_Worker_MatchingDataSet.TASK' table. You can move, or remove it, as needed.
            this.tASKTableAdapter.Fill(this.task_Worker_MatchingDataSet.TASK);
            Tasks_table.DataSource = task_Worker_MatchingDataSet.TASK;
        }

        private void Search_task_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql_connection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sql_connection.Open();

                List<string> conditions = new List<string>();
                SqlCommand sql_command = new SqlCommand();

                if (!string.IsNullOrEmpty(task_id_txt.Text))
                {
                    conditions.Add("TASK_ID = @TaskID");
                    sql_command.Parameters.AddWithValue("@TaskID", task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(task_name_txt.Text))
                {
                    conditions.Add("TASK_NAME = @TaskName");
                    sql_command.Parameters.AddWithValue("@TaskName", task_name_txt.Text);
                }
                if (!string.IsNullOrEmpty(required_speciality_txt.Text))
                {
                    conditions.Add("REQUIRED_SPECIALITY = @RequiredSpeciality");
                    sql_command.Parameters.AddWithValue("@RequiredSpeciality", required_speciality_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_time_txt.Text))
                {
                    conditions.Add("AVERAGE_TIME = @AverageTime");
                    sql_command.Parameters.AddWithValue("@AverageTime", average_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(average_fee_txt.Text))
                {
                    conditions.Add("AVERAGE_FEE = @AverageFee");
                    sql_command.Parameters.AddWithValue("@AverageFee", average_fee_txt.Text);
                }
                if (conditions.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to search for a task");
                    return;
                }
                string where_clause = string.Join(" AND ", conditions);
                sql_command.CommandText = $"SELECT * FROM TASK WHERE {where_clause}";
                sql_command.Connection = sql_connection;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql_command))
                {
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    Tasks_table.DataSource = results;

                    MessageBox.Show($"{results.Rows.Count} rows found.");
                }
                sql_connection.Close();
            }
        }

        private void Overview_btn_Click(object sender, EventArgs e)
        {
            Overview_panel.Visible = true;
            Tasks_panel.Visible = false;

        }

        private void Tasks_btn_Click(object sender, EventArgs e)
        {
            Overview_panel.Visible = false;
            Tasks_panel.Visible = true;

        }

        private void Overview_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
