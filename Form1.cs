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
        // Fix for CS0120: An object reference is required for the non-static field, method, or property 'Task_Worker_MatchingDataSet2.WORKER'

        // The issue occurs because `Task_Worker_MatchingDataSet2.WORKER` is being accessed as if it were a static property, 
        // but it is an instance property. You need to create an instance of `Task_Worker_MatchingDataSet2` and access the `WORKER` property through that instance.

        private Task_Worker_MatchingDataSet2 task_Worker_MatchingDataSet2 = new Task_Worker_MatchingDataSet2(); // Add this instance variable
        private Task_Worker_MatchingDataSet4TableAdapters.REQUESTTableAdapter requestTableAdapter4 = new Task_Worker_MatchingDataSet4TableAdapters.REQUESTTableAdapter();
        

        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_Worker_MatchingDataSet3.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.task_Worker_MatchingDataSet3.CLIENT);
            // TODO: This line of code loads data into the 'task_Worker_MatchingDataSet4.REQUEST' table. You can move, or remove it, as needed.
            requestTableAdapter4.Fill(task_Worker_MatchingDataSet4.REQUEST);
            Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
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
            Edit_Worker_panel.Visible = false;

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
            Edit_Worker_panel.Visible = false;
        }

        private void Workers_btn_Click(object sender, EventArgs e)
        {
            Workers_panel.Visible = true;
            Requests_panel.Visible = false;
            Tasks_panel.Visible = false;
            Overview_panel.Visible = false;
            Clients_panel.Visible = false;
            Edit_Worker_panel.Visible = false;
        }

        private void Clients_btn_Click(object sender, EventArgs e)
        {
            Clients_panel.Visible = true;
            Workers_panel.Visible = false;
            Requests_panel.Visible = false;
            Tasks_panel.Visible = false;
            Overview_panel.Visible = false;
            Edit_Worker_panel.Visible = false;
        }

        private void Tasks_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Generate_report_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;";

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

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control.HasChildren)
                {
                    ClearAllTextBoxes(control); // Recursively check inner controls like panels, groupboxes
                }
            }
        }
        private int GenerateNextWorkerID()
        {
            int nextID = 1;

            using (SqlConnection con = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                con.Open();

                string query = "SELECT ISNULL(MAX(WORKER_ID), 0) + 1 FROM WORKER";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    nextID = Convert.ToInt32(result);
                }

                con.Close();
            }

            return nextID;
        }
        private int GenerateNextSpecialtyID()
        {
            int nextID = 1;

            using (SqlConnection con = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                con.Open();

                string query = "SELECT ISNULL(MAX(SPECIALTY_ID), 0) + 1 FROM WORKER_SPECIALTY";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    nextID = Convert.ToInt32(result);
                }

                con.Close();
            }

            return nextID;
        }
        private void Load_Worker_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True"))
            {
                con.Open();
                string query = @"
                    SELECT 
                        W.WORKER_ID,
                        W.NAME,
                        WL.LOCATION,
	                    WS.SPECIALTY_ID,
                        WS.SPECIALTY,
                        E.YEAR,
                        TS.TIME_SLOT_ID,
                        TS.START_TIME,
                        TS.END_TIME,
                        TS.DAY
                    FROM WORKER W
                    LEFT JOIN WORKER_LOCATION WL ON W.WORKER_ID = WL.WORKER_ID
                    LEFT JOIN EXPERIENCE E ON W.WORKER_ID = E.WORKER_ID
                    LEFT JOIN WORKER_SPECIALTY WS ON E.SPECIALTY_ID = WS.SPECIALTY_ID
                    LEFT JOIN TIME_SLOT TS ON W.WORKER_ID = TS.WORKER_ID 
                    ";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Workers_table.AutoGenerateColumns = true;
                Workers_table.DataSource = dt;
                ClearAllTextBoxes(this);
            }
        }

        private void Add_Worker_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sqlConnection.Open();
                if (string.IsNullOrWhiteSpace(TimeSlotID_textBox.Text))
                {
                    MessageBox.Show("Please enter a Time Slot ID.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Location_textBox.Text))
                {
                    MessageBox.Show("Please enter a Location.");
                    return;
                }
                int newWorkerID = GenerateNextWorkerID();
                int newSpecialtyID = GenerateNextSpecialtyID();
                ////////////////////--Worker--\\\\\\\\\\\\\\\\\\\\
                string query = "INSERT INTO WORKER (WORKER_ID, NAME) VALUES (@WorkerID, @Name)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", newWorkerID);
                    sqlCommand.Parameters.AddWithValue("@Name", WorkerName_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Worker added with ID: " + newWorkerID);
                }
                /////////////////////--Worker Specialty--\\\\\\\\\\\\\\\\\\\\\\\\
                query = "INSERT INTO WORKER_SPECIALTY (SPECIALTY_ID, SPECIALTY) VALUES (@SpecialtyID, @Specialty)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@SpecialtyID", newSpecialtyID);
                    sqlCommand.Parameters.AddWithValue("@Specialty", Specialty_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Specialty added with ID: " + newSpecialtyID);
                }
                ///////////////////--Time Slot--\\\\\\\\\\\\\\\\\
                query = "INSERT INTO TIME_SLOT (TIME_SLOT_ID, WORKER_ID, START_TIME, END_TIME, DAY) VALUES (@TimeSlotID, @WorkerID, @StartTime, @EndTime, @Day)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@TimeSlotID", TimeSlotID_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@WorkerID", newWorkerID);
                    sqlCommand.Parameters.AddWithValue("@StartTime", StartTime_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@EndTime", EndTime_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Day", Day_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                ////////////////////--Location--\\\\\\\\\\\\\\\\\\
                query = "INSERT INTO WORKER_LOCATION (LOCATION, WORKER_ID) VALUES (@Location, @WorkerID)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Location", Location_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@WorkerID", newWorkerID);
                    sqlCommand.ExecuteNonQuery();
                }
                ///////////////////--Eperience--\\\\\\\\\\\\\\\\
                query = "INSERT INTO EXPERIENCE (WORKER_ID, SPECIALTY_ID, YEAR) VALUES (@WorkerID, @SpecialtyID, @Year)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", newWorkerID);
                    sqlCommand.Parameters.AddWithValue("@SpecialtyID", newSpecialtyID);
                    sqlCommand.Parameters.AddWithValue("@Year", Year_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Worker added successfully.");
                //this.wORKERTableAdapter.Fill(this.task_Worker_MatchingDataSet2.WORKER);

                // Update the problematic line to use the instance:
                Workers_table.DataSource = task_Worker_MatchingDataSet2.WORKER;
                ClearAllTextBoxes(this);
                sqlConnection.Close();
            }
        }

        private void Edit_Panel_btn_Click(object sender, EventArgs e)
        {
            Edit_Worker_panel.Visible = true;
            Workers_panel.Visible = false;
            Overview_panel.Visible = false;
            Tasks_panel.Visible = false;
            Requests_panel.Visible = false;
            Clients_panel.Visible = false;
            
        }

        private void Edit_Worker_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sqlConnection.Open();

                /////////////////////////--Update WORKER--\\\\\\\\\\\\\\\\\\\\\\\
                if (!string.IsNullOrWhiteSpace(WorkerID_Edit.Text) && !string.IsNullOrWhiteSpace(New_WN_txt.Text))
                {
                    string query = "UPDATE WORKER SET NAME = @Name WHERE WORKER_ID = @WorkerID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Name", New_WN_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_Edit.Text);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                /////////////////////--Update WORKER_SPECIALTY--\\\\\\\\\\\\\\\\\\\\
                if (!string.IsNullOrWhiteSpace(SpecialtyID_Edit.Text) && !string.IsNullOrWhiteSpace(NewSP_txt.Text))
                {
                    string query = "UPDATE WORKER_SPECIALTY SET SPECIALTY = @Specialty WHERE SPECIALTY_ID = @SpecialtyID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Specialty", NewSP_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@SpecialtyID", SpecialtyID_Edit.Text);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                ////////////////////--Update WORKER_LOCATION--\\\\\\\\\\\\\\\\\\\\\\\\
                if (!string.IsNullOrWhiteSpace(WorkerID_Edit.Text) && !string.IsNullOrWhiteSpace(New_L_txt.Text))
                {
                    string query = "UPDATE WORKER_LOCATION SET LOCATION = @Location WHERE WORKER_ID = @WorkerID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Location", New_L_txt.Text);
                        sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_Edit.Text);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                /////////////////////--Update TIME_SLOT--\\\\\\\\\\\\\\\\\\\\
                if (!string.IsNullOrWhiteSpace(WorkerID_Edit.Text) || !string.IsNullOrWhiteSpace(TimeSlotID_Edit.Text))
                {
                    string query = "UPDATE TIME_SLOT SET START_TIME = @StartTime, END_TIME = @EndTime, DAY = @Day WHERE WORKER_ID = @WorkerID OR TIME_SLOT_ID = @TSID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@TSID", TimeSlotID_Edit.Text);
                        sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_Edit.Text);
                        if (!string.IsNullOrWhiteSpace(NewST_txt.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@StartTime", NewST_txt.Text);
                        }
                        if (!string.IsNullOrWhiteSpace(NewET_txt.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@EndTime", NewET_txt.Text);
                        }
                        if (!string.IsNullOrWhiteSpace(NewD_txt.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@Day", NewD_txt.Text);
                        }
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                /////////////////--Update EXPERIENCE--\\\\\\\\\\\\\\\\\\\\\\
                if ((!string.IsNullOrWhiteSpace(WorkerID_Edit.Text) || !string.IsNullOrWhiteSpace(SpecialtyID_Edit.Text)) && !string.IsNullOrWhiteSpace(NewY_txt.Text))
                {
                    string query = "UPDATE EXPERIENCE SET YEAR = @Year WHERE WORKER_ID = @WorkerID OR SPECIALTY_ID = @SpecialtyID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_Edit.Text);
                        sqlCommand.Parameters.AddWithValue("@SpecialtyID", SpecialtyID_Edit.Text);
                        sqlCommand.Parameters.AddWithValue("@Year", NewY_txt.Text);
                        sqlCommand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("All records updated successfully.");
                ClearAllTextBoxes(this);
                sqlConnection.Close();
            }
        }

        private void Search_Worker_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql_connection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sql_connection.Open();

                List<string> conditions = new List<string>();
                SqlCommand sql_command = new SqlCommand();

                if (!string.IsNullOrEmpty(WorkerID_textBox.Text))
                {
                    conditions.Add("W.WORKER_ID = @WorkerID");
                    sql_command.Parameters.AddWithValue("@WorkerID", WorkerID_textBox.Text);
                }
                if (!string.IsNullOrEmpty(WorkerName_textBox.Text))
                {
                    conditions.Add("W.NAME = @WorkerName");
                    sql_command.Parameters.AddWithValue("@WorkerName", WorkerName_textBox.Text);
                }
                if (!string.IsNullOrEmpty(SpecialtyID_textBox.Text))
                {
                    conditions.Add("WS.SPECIALTY_ID = @SpecialtyID");
                    sql_command.Parameters.AddWithValue("@SpecialtyID", SpecialtyID_textBox.Text);
                }
                if (!string.IsNullOrEmpty(Specialty_textBox.Text))
                {
                    conditions.Add("WS.SPECIALTY = @Specialty");
                    sql_command.Parameters.AddWithValue("@Specialty", Specialty_textBox.Text);
                }
                if (!string.IsNullOrEmpty(Year_textBox.Text))
                {
                    conditions.Add("E.YEAR = @Year");
                    sql_command.Parameters.AddWithValue("@Year", Year_textBox.Text);
                }
                if (!string.IsNullOrEmpty(Location_textBox.Text))
                {
                    conditions.Add("WL.LOCATION = @Location");
                    sql_command.Parameters.AddWithValue("@Location", Location_textBox.Text);
                }
                if (!string.IsNullOrEmpty(TimeSlotID_textBox.Text))
                {
                    conditions.Add("TS.TIME_SLOT_ID = @TimeSlotID");
                    sql_command.Parameters.AddWithValue("@TimeSlotID", TimeSlotID_textBox.Text);
                }
                if (!string.IsNullOrEmpty(StartTime_textBox.Text))
                {
                    conditions.Add("TS.START_TIME = @StartTime");
                    sql_command.Parameters.AddWithValue("@StartTime", StartTime_textBox.Text);
                }
                if (!string.IsNullOrEmpty(EndTime_textBox.Text))
                {
                    conditions.Add("TS.END_TIME = @EndTime");
                    sql_command.Parameters.AddWithValue("@EndTime", EndTime_textBox.Text);
                }
                if (!string.IsNullOrEmpty(Day_textBox.Text))
                {
                    conditions.Add("TS.DAY = @Day");
                    sql_command.Parameters.AddWithValue("@Day", Day_textBox.Text);
                }
                if (conditions.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to search for a task");
                    return;
                }
                string where_clause = string.Join(" AND ", conditions);
                string SelectAndFrom = @"
                        SELECT 
                            W.WORKER_ID, W.NAME, 
                            WL.LOCATION, 
                            WS.SPECIALTY, 
                            E.YEAR, 
                            TS.TIME_SLOT_ID, TS.START_TIME, TS.END_TIME, TS.DAY
                        FROM WORKER W
                        LEFT JOIN WORKER_LOCATION WL ON W.WORKER_ID = WL.WORKER_ID
                        LEFT JOIN EXPERIENCE E ON W.WORKER_ID = E.WORKER_ID
                        LEFT JOIN WORKER_SPECIALTY WS ON E.SPECIALTY_ID = WS.SPECIALTY_ID
                        LEFT JOIN TIME_SLOT TS ON W.WORKER_ID = TS.WORKER_ID
                ";
                sql_command.CommandText = $@"
                        {SelectAndFrom} 
                        WHERE 
                            {where_clause}";
                sql_command.Connection = sql_connection;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql_command))
                {
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    Workers_table.DataSource = results;

                    MessageBox.Show($"{results.Rows.Count} rows found.");
                }
                ClearAllTextBoxes(this);
                sql_connection.Close();
            }
        }

        private void Delete_Worker_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sqlConnection.Open();
                if (string.IsNullOrWhiteSpace(WorkerID_textBox.Text))
                {
                    MessageBox.Show("Please enter a Worker ID.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(SpecialtyID_textBox.Text))
                {
                    MessageBox.Show("Please enter a Specialty ID.");
                    return;
                }
                ///////////////////--Delet Time Slot--\\\\\\\\\\\\\\\\\

                string query = "DELETE FROM TIME_SLOT WHERE WORKER_ID = @WorkerID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                ///////////////////--Delet Worker Location--\\\\\\\\\\\\\\\\\

                query = "DELETE FROM WORKER_LOCATION WHERE WORKER_ID = @WorkerID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                ///////////////////--Delet Experience--\\\\\\\\\\\\\\\\\

                query = "DELETE FROM EXPERIENCE WHERE WORKER_ID = @WorkerID AND SPECIALTY_ID = @SpecialtyID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@SpecialtyID", SpecialtyID_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                ///////////////////--Delet Worker Specialty--\\\\\\\\\\\\\\\\\

                query = "DELETE FROM WORKER_SPECIALTY WHERE SPECIALTY_ID = @SpecialtyID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@SpecialtyID", SpecialtyID_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                ///////////////////--Delet Worker--\\\\\\\\\\\\\\\\\
                query = "DELETE FROM WORKER WHERE WORKER_ID = @WorkerID";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@WorkerID", WorkerID_textBox.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Worker Deleted successfully.");
                ClearAllTextBoxes(this);
                sqlConnection.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Add_client_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source = THEDESTRO22; Initial Catalog = Task_Worker_Matching; Integrated Security = True;"))
            {
                sqlConnection.Open();
                // Changed to insert into CLIENT table with client columns
                string query = "INSERT INTO CLIENT (CLIENT_ID, NAME, PHONE, ADDRESS, EMAIL, PAYMENT_INFO) VALUES (@ClientID, @ClientName, @ClientPhone, @ClientAddress, @ClientEmail, @ClientPaymentInfo)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@ClientID", Client_id_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientName", Client_name_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientPhone", Client_phone_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientAddress", Client_address_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientEmail", Client_email_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientPaymentInfo", Client_payment_info_txt.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Client added successfully.");
                    this.cLIENTTableAdapter.Fill(this.task_Worker_MatchingDataSet3.CLIENT);
                    Clients_table.DataSource = task_Worker_MatchingDataSet3.CLIENT;
                    sqlConnection.Close();
                }
            }
        }

        private void add_request_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                sqlConnection.Open();
                string query = "INSERT INTO REQUEST (REQUEST_ID, TASK_ID, CLIENT_ID, REQUEST_TIME, REQUEST_ADDRESS, REQUEST_STATUS, PREFERRED_TIME_SLOT, ACTUAL_TIME_TAKEN) " +
                               "VALUES (@RequestID, @TaskID, @ClientID, @RequestTime, @RequestAddress, @RequestStatus, @PreferredTimeSlot, @ActualTimeTaken)";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@RequestID", request_id_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@TaskID", request_task_id_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ClientID", request_client_id_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@RequestTime", request_time_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@RequestAddress", request_address_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@RequestStatus", request_status_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@PreferredTimeSlot", preferred_time_slot_txt.Text);
                    sqlCommand.Parameters.AddWithValue("@ActualTimeTaken", actual_time_taken_txt.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Request added successfully.");
                    requestTableAdapter4.Fill(task_Worker_MatchingDataSet4.REQUEST);
                    Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
                    Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
                    sqlConnection.Close();
                }
            }

        }

        private void delete_request_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                sqlConnection.Open();

                List<string> conditions = new List<string>();
                SqlCommand sqlCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(request_id_txt.Text))
                {
                    conditions.Add("REQUEST_ID = @RequestID");
                    sqlCommand.Parameters.AddWithValue("@RequestID", request_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_task_id_txt.Text))
                {
                    conditions.Add("TASK_ID = @TaskID");
                    sqlCommand.Parameters.AddWithValue("@TaskID", request_task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_client_id_txt.Text))
                {
                    conditions.Add("CLIENT_ID = @ClientID");
                    sqlCommand.Parameters.AddWithValue("@ClientID", request_client_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_time_txt.Text))
                {
                    conditions.Add("REQUEST_TIME = @RequestTime");
                    sqlCommand.Parameters.AddWithValue("@RequestTime", request_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_address_txt.Text))
                {
                    conditions.Add("REQUEST_ADDRESS = @RequestAddress");
                    sqlCommand.Parameters.AddWithValue("@RequestAddress", request_address_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_status_txt.Text))
                {
                    conditions.Add("REQUEST_STATUS = @RequestStatus");
                    sqlCommand.Parameters.AddWithValue("@RequestStatus", request_status_txt.Text);
                }
                if (!string.IsNullOrEmpty(preferred_time_slot_txt.Text))
                {
                    conditions.Add("PREFERRED_TIME_SLOT = @PreferredTimeSlot");
                    sqlCommand.Parameters.AddWithValue("@PreferredTimeSlot", preferred_time_slot_txt.Text);
                }
                if (!string.IsNullOrEmpty(actual_time_taken_txt.Text))
                {
                    conditions.Add("ACTUAL_TIME_TAKEN = @ActualTimeTaken");
                    sqlCommand.Parameters.AddWithValue("@ActualTimeTaken", actual_time_taken_txt.Text);
                }

                if (conditions.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to delete a request");
                    return;
                }
                string where_clause = string.Join(" AND ", conditions);
                sqlCommand.CommandText = $"DELETE FROM REQUEST WHERE {where_clause}";
                sqlCommand.Connection = sqlConnection;

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} rows deleted.");
                requestTableAdapter4.Fill(task_Worker_MatchingDataSet4.REQUEST);
                Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
                Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
                sqlConnection.Close();
            }
        }

        private void search_request_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                sqlConnection.Open();

                List<string> conditions = new List<string>();
                SqlCommand sqlCommand = new SqlCommand();

                if (!string.IsNullOrEmpty(request_id_txt.Text))
                {
                    conditions.Add("REQUEST_ID = @RequestID");
                    sqlCommand.Parameters.AddWithValue("@RequestID", request_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_task_id_txt.Text))
                {
                    conditions.Add("TASK_ID = @TaskID");
                    sqlCommand.Parameters.AddWithValue("@TaskID", request_task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_client_id_txt.Text))
                {
                    conditions.Add("CLIENT_ID = @ClientID");
                    sqlCommand.Parameters.AddWithValue("@ClientID", request_client_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_time_txt.Text))
                {
                    conditions.Add("REQUEST_TIME = @RequestTime");
                    sqlCommand.Parameters.AddWithValue("@RequestTime", request_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_address_txt.Text))
                {
                    conditions.Add("REQUEST_ADDRESS = @RequestAddress");
                    sqlCommand.Parameters.AddWithValue("@RequestAddress", request_address_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_status_txt.Text))
                {
                    conditions.Add("REQUEST_STATUS = @RequestStatus");
                    sqlCommand.Parameters.AddWithValue("@RequestStatus", request_status_txt.Text);
                }
                if (!string.IsNullOrEmpty(preferred_time_slot_txt.Text))
                {
                    conditions.Add("PREFERRED_TIME_SLOT = @PreferredTimeSlot");
                    sqlCommand.Parameters.AddWithValue("@PreferredTimeSlot", preferred_time_slot_txt.Text);
                }
                if (!string.IsNullOrEmpty(actual_time_taken_txt.Text))
                {
                    conditions.Add("ACTUAL_TIME_TAKEN = @ActualTimeTaken");
                    sqlCommand.Parameters.AddWithValue("@ActualTimeTaken", actual_time_taken_txt.Text);
                }

                if (conditions.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to search for a request");
                    return;
                }
                string where_clause = string.Join(" AND ", conditions);
                sqlCommand.CommandText = $"SELECT * FROM REQUEST WHERE {where_clause}";
                sqlCommand.Connection = sqlConnection;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    Requests_table.DataSource = results;

                    MessageBox.Show($"{results.Rows.Count} rows found.");
                }
                sqlConnection.Close();
            }
        }

        private void load_requests_btn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the TableAdapter for the REQUEST table in Task_Worker_MatchingDataSet4
            var requestAdapter = new Task_Worker_MatchingDataSet4TableAdapters.REQUESTTableAdapter();
            var requestTable = new Task_Worker_MatchingDataSet4.REQUESTDataTable();

            // Fill the DataTable with data from the database
            requestAdapter.Fill(requestTable);

            // Now you can use requestTable as needed, for example, bind it to a DataGridView
            Requests_table.DataSource = requestTable;
        }

        private void edit_request_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection("Data Source=THEDESTRO22;Initial Catalog=Task_Worker_Matching;Integrated Security=True;"))
            {
                sqlConnection.Open();

                List<string> where_conditions = new List<string>();
                List<string> set_conditions = new List<string>();
                SqlCommand sqlCommand = new SqlCommand();

                // Where conditions
                if (!string.IsNullOrEmpty(request_id_txt.Text))
                {
                    where_conditions.Add("REQUEST_ID = @RequestID");
                    sqlCommand.Parameters.AddWithValue("@RequestID", request_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_task_id_txt.Text))
                {
                    where_conditions.Add("TASK_ID = @TaskID");
                    sqlCommand.Parameters.AddWithValue("@TaskID", request_task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_client_id_txt.Text))
                {
                    where_conditions.Add("CLIENT_ID = @ClientID");
                    sqlCommand.Parameters.AddWithValue("@ClientID", request_client_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_time_txt.Text))
                {
                    where_conditions.Add("REQUEST_TIME = @RequestTime");
                    sqlCommand.Parameters.AddWithValue("@RequestTime", request_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_address_txt.Text))
                {
                    where_conditions.Add("REQUEST_ADDRESS = @RequestAddress");
                    sqlCommand.Parameters.AddWithValue("@RequestAddress", request_address_txt.Text);
                }
                if (!string.IsNullOrEmpty(request_status_txt.Text))
                {
                    where_conditions.Add("REQUEST_STATUS = @RequestStatus");
                    sqlCommand.Parameters.AddWithValue("@RequestStatus", request_status_txt.Text);
                }
                if (!string.IsNullOrEmpty(preferred_time_slot_txt.Text))
                {
                    where_conditions.Add("PREFERRED_TIME_SLOT = @PreferredTimeSlot");
                    sqlCommand.Parameters.AddWithValue("@PreferredTimeSlot", preferred_time_slot_txt.Text);
                }
                if (!string.IsNullOrEmpty(actual_time_taken_txt.Text))
                {
                    where_conditions.Add("ACTUAL_TIME_TAKEN = @ActualTimeTaken");
                    sqlCommand.Parameters.AddWithValue("@ActualTimeTaken", actual_time_taken_txt.Text);
                }

                // Set conditions (new values)
                if (!string.IsNullOrEmpty(new_request_id_txt.Text))
                {
                    set_conditions.Add("REQUEST_ID = @NewRequestID");
                    sqlCommand.Parameters.AddWithValue("@NewRequestID", new_request_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_request_task_id_txt.Text))
                {
                    set_conditions.Add("TASK_ID = @NewTaskID");
                    sqlCommand.Parameters.AddWithValue("@NewTaskID", new_request_task_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_request_client_id_txt.Text))
                {
                    set_conditions.Add("CLIENT_ID = @NewClientID");
                    sqlCommand.Parameters.AddWithValue("@NewClientID", new_request_client_id_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_request_time_txt.Text))
                {
                    set_conditions.Add("REQUEST_TIME = @NewRequestTime");
                    sqlCommand.Parameters.AddWithValue("@NewRequestTime", new_request_time_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_request_address_txt.Text))
                {
                    set_conditions.Add("REQUEST_ADDRESS = @NewRequestAddress");
                    sqlCommand.Parameters.AddWithValue("@NewRequestAddress", new_request_address_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_request_status_txt.Text))
                {
                    set_conditions.Add("REQUEST_STATUS = @NewRequestStatus");
                    sqlCommand.Parameters.AddWithValue("@NewRequestStatus", new_request_status_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_preferred_time_slot_txt.Text))
                {
                    set_conditions.Add("PREFERRED_TIME_SLOT = @NewPreferredTimeSlot");
                    sqlCommand.Parameters.AddWithValue("@NewPreferredTimeSlot", new_preferred_time_slot_txt.Text);
                }
                if (!string.IsNullOrEmpty(new_actual_time_taken_txt.Text))
                {
                    set_conditions.Add("ACTUAL_TIME_TAKEN = @NewActualTimeTaken");
                    sqlCommand.Parameters.AddWithValue("@NewActualTimeTaken", new_actual_time_taken_txt.Text);
                }

                if (set_conditions.Count == 0)
                {
                    MessageBox.Show("Please specify at least one new value to update.");
                    return;
                }
                if (where_conditions.Count == 0)
                {
                    MessageBox.Show("Please specify at least one condition to match.");
                    return;
                }

                string set_clause = string.Join(", ", set_conditions);
                string where_clause = string.Join(" AND ", where_conditions);
                sqlCommand.CommandText = $"UPDATE REQUEST SET {set_clause} WHERE {where_clause}";
                sqlCommand.Connection = sqlConnection;

                int rowsAffected = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} rows updated.");
                requestTableAdapter4.Fill(task_Worker_MatchingDataSet4.REQUEST);
                Requests_table.DataSource = task_Worker_MatchingDataSet4.REQUEST;
                sqlConnection.Close();
            }
        }
    }


}
