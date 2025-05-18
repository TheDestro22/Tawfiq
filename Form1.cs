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
using System.Windows.Forms.DataVisualization.Charting;

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
            // TODO: This line of code loads data into the 'task_Worker_MatchingDataSet1.REQUEST' table. You can move, or remove it, as needed.
          
            this.rEQUESTTableAdapter.Fill(this.task_Worker_MatchingDataSet1.REQUEST);
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
            Requests_panel.Visible = false;
            Clients_panel.Visible = false;
            Workers_panel.Visible = false;

        }

        private void Tasks_btn_Click(object sender, EventArgs e)
        {
            Tasks_panel.Visible = true;
            Overview_panel.Visible = false;
            Requests_panel.Visible = false;
            Clients_panel.Visible = false;
            Workers_panel.Visible = false;

        }

        private void Overview_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clients_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Requests_btn_Click(object sender, EventArgs e)
        {
            Requests_panel.Visible = true;
            Tasks_panel.Visible = false;
            Overview_panel.Visible = false;
            Clients_panel.Visible = false;
            Workers_panel.Visible = false;
        }

        private void Workers_btn_Click(object sender, EventArgs e)
        {
            Workers_panel.Visible = true;
            Requests_panel.Visible = false;
            Tasks_panel.Visible = false;
            Overview_panel.Visible = false;
            Clients_panel.Visible = false;
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Clients_panel.Visible = true;
            Workers_panel.Visible = false;
            Requests_panel.Visible = false;
            Tasks_panel.Visible = false;
            Overview_panel.Visible = false;
        }

        private void Tasks_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Total_tasks_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-4TMJQMK;Initial Catalog=Task_Worker_Matching;Integrated Security=True;";

            // 1. Top Rated Workers
            string topRatedQuery = @"
                SELECT 
                    w.Worker_ID,
                    w.Name,
                    AVG(f.Rating) AS AverageRating,
                    COUNT(f.Rating) AS TotalRatings
                FROM 
                    Feedback f
                JOIN 
                    Worker w ON f.Worker_ID = w.Worker_ID
                WHERE 
                    f.From_Client = 1 AND f.Rating IS NOT NULL
                GROUP BY 
                    w.Worker_ID, w.Name
                ORDER BY 
                    AverageRating DESC;";

            // 2. Specialty Chart
            string specialtyQuery = @"
        SELECT ws.SPECIALTY, COUNT(e.WORKER_ID) AS WorkerCount
        FROM WORKER_SPECIALTY ws
        LEFT JOIN EXPERIENCE e ON ws.SPECIALTY_ID = e.SPECIALTY_ID
        GROUP BY ws.SPECIALTY
        ORDER BY WorkerCount DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Top Rated Workers
                using (SqlCommand command = new SqlCommand(topRatedQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    Top_rated_workers_table.AutoGenerateColumns = true;
                    DataTable results = new DataTable();
                    adapter.Fill(results);
                    Top_rated_workers_table.DataSource = results;
                }

                // Summary Stats
                int totalTasks = 0, totalRequests = 0, completedTasks = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TASK", connection))
                    totalTasks = (int)cmd.ExecuteScalar();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM REQUEST", connection))
                    totalRequests = (int)cmd.ExecuteScalar();
                using (SqlCommand cmd = new SqlCommand(@"
            SELECT COUNT(*) 
            FROM Task T
            JOIN Request R ON T.Task_ID = R.Task_ID
            WHERE R.Request_Status = 'Completed'", connection))
                    completedTasks = (int)cmd.ExecuteScalar();

                Total_tasks.Text = $"Total Tasks: {totalTasks}";
                Total_requests.Text = $"Total Requests: {totalRequests}";
                Completed_tasks.Text = $"Completed Tasks: {completedTasks}";

                // Specialty Chart
                using (SqlCommand command = new SqlCommand(specialtyQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    SpecialtyChart.Series.Clear();
                    Series series = new Series("Top Specialties");
                    series.ChartType = SeriesChartType.Pie; // or Column, Bar, etc.

                    while (reader.Read())
                    {
                        string specialty = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        series.Points.AddXY(specialty, count);
                    }

                    SpecialtyChart.Series.Add(series);
                    SpecialtyChart.ChartAreas[0].AxisX.Title = "Specialty";
                    SpecialtyChart.ChartAreas[0].AxisY.Title = "Number of Workers";
                }
            }

        }
    }
}
