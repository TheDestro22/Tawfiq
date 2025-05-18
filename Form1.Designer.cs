namespace Tawfiq
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Side_panel = new System.Windows.Forms.Panel();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.Workers_btn = new System.Windows.Forms.Button();
            this.Requests_btn = new System.Windows.Forms.Button();
            this.Tasks_btn = new System.Windows.Forms.Button();
            this.Overview_btn = new System.Windows.Forms.Button();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Main_logo_picbox = new System.Windows.Forms.PictureBox();
            this.Tasks_panel = new System.Windows.Forms.Panel();
            this.Search_task_btn = new System.Windows.Forms.Button();
            this.Tasks_table = new System.Windows.Forms.DataGridView();
            this.tASKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_Worker_MatchingDataSet = new Tawfiq.Task_Worker_MatchingDataSet();
            this.edit_task_btn = new System.Windows.Forms.Button();
            this.delete_task_btn = new System.Windows.Forms.Button();
            this.load_tasks_btn = new System.Windows.Forms.Button();
            this.add_task_btn = new System.Windows.Forms.Button();
            this.new_average_fee = new System.Windows.Forms.Label();
            this.new_average_fee_txt = new System.Windows.Forms.TextBox();
            this.new_task_name_label = new System.Windows.Forms.Label();
            this.new_task_name_txt = new System.Windows.Forms.TextBox();
            this.new_required_speciality_label = new System.Windows.Forms.Label();
            this.new_required_speciality_txt = new System.Windows.Forms.TextBox();
            this.new_average_time = new System.Windows.Forms.Label();
            this.new_average_time_txt = new System.Windows.Forms.TextBox();
            this.new_task_id_label = new System.Windows.Forms.Label();
            this.new_task_id_txt = new System.Windows.Forms.TextBox();
            this.average_fee_btn = new System.Windows.Forms.Label();
            this.average_fee_txt = new System.Windows.Forms.TextBox();
            this.task_name_label = new System.Windows.Forms.Label();
            this.task_name_txt = new System.Windows.Forms.TextBox();
            this.required_speciality_label = new System.Windows.Forms.Label();
            this.required_speciality_txt = new System.Windows.Forms.TextBox();
            this.average_time_label = new System.Windows.Forms.Label();
            this.average_time_txt = new System.Windows.Forms.TextBox();
            this.task_id_label = new System.Windows.Forms.Label();
            this.task_id_txt = new System.Windows.Forms.TextBox();
            this.tASKTableAdapter = new Tawfiq.Task_Worker_MatchingDataSetTableAdapters.TASKTableAdapter();
            this.Overview_panel = new System.Windows.Forms.Panel();
            this.Generate_report_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpecialtyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Top_rated_workers_table = new System.Windows.Forms.DataGridView();
            this.Completed_tasks = new System.Windows.Forms.Label();
            this.Total_requests = new System.Windows.Forms.Label();
            this.Total_tasks = new System.Windows.Forms.Label();
            this.Requests_panel = new System.Windows.Forms.Panel();
            this.new_act_time_taken_label = new System.Windows.Forms.Label();
            this.new_actual_time_taken_txt = new System.Windows.Forms.TextBox();
            this.new_req_status_label = new System.Windows.Forms.Label();
            this.new_request_status_txt = new System.Windows.Forms.TextBox();
            this.new_pref_time_label = new System.Windows.Forms.Label();
            this.new_preferred_time_slot_txt = new System.Windows.Forms.TextBox();
            this.new_req_address_label = new System.Windows.Forms.Label();
            this.new_request_address_txt = new System.Windows.Forms.TextBox();
            this.new_taskId_label = new System.Windows.Forms.Label();
            this.new_request_task_id_txt = new System.Windows.Forms.TextBox();
            this.new_client_id_label = new System.Windows.Forms.Label();
            this.new_request_client_id_txt = new System.Windows.Forms.TextBox();
            this.new_req_time_label = new System.Windows.Forms.Label();
            this.new_request_time_txt = new System.Windows.Forms.TextBox();
            this.new_req_id_label = new System.Windows.Forms.Label();
            this.new_request_id_txt = new System.Windows.Forms.TextBox();
            this.act_time_taken_label = new System.Windows.Forms.Label();
            this.actual_time_taken_txt = new System.Windows.Forms.TextBox();
            this.request_status_label = new System.Windows.Forms.Label();
            this.request_status_txt = new System.Windows.Forms.TextBox();
            this.pref_time_slot_label = new System.Windows.Forms.Label();
            this.preferred_time_slot_txt = new System.Windows.Forms.TextBox();
            this.search_request_btn = new System.Windows.Forms.Button();
            this.Requests_table = new System.Windows.Forms.DataGridView();
            this.rEQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_Worker_MatchingDataSet1 = new Tawfiq.Task_Worker_MatchingDataSet1();
            this.edit_request_btn = new System.Windows.Forms.Button();
            this.delete_request_btn = new System.Windows.Forms.Button();
            this.load_requests_btn = new System.Windows.Forms.Button();
            this.add_request_btn = new System.Windows.Forms.Button();
            this.request_addresss_label = new System.Windows.Forms.Label();
            this.request_address_txt = new System.Windows.Forms.TextBox();
            this.taskID_label = new System.Windows.Forms.Label();
            this.request_task_id_txt = new System.Windows.Forms.TextBox();
            this.clientID_label = new System.Windows.Forms.Label();
            this.request_client_id_txt = new System.Windows.Forms.TextBox();
            this.request_time_label = new System.Windows.Forms.Label();
            this.request_time_txt = new System.Windows.Forms.TextBox();
            this.requestID_label = new System.Windows.Forms.Label();
            this.request_id_txt = new System.Windows.Forms.TextBox();
            this.Clients_panel = new System.Windows.Forms.Panel();
            this.Client_payment_into_label = new System.Windows.Forms.Label();
            this.Client_payment_info_txt = new System.Windows.Forms.TextBox();
            this.Search_client_btn = new System.Windows.Forms.Button();
            this.Clients_table = new System.Windows.Forms.DataGridView();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYMENTINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_Worker_MatchingDataSet3 = new Tawfiq.Task_Worker_MatchingDataSet3();
            this.Edit_client_btn = new System.Windows.Forms.Button();
            this.Delete_client_btn = new System.Windows.Forms.Button();
            this.Load_clients_btn = new System.Windows.Forms.Button();
            this.Add_client_btn = new System.Windows.Forms.Button();
            this.New_client_payment_info_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.New_client_phone_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.New_client_address_label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.New_client_email_label = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.New_client_name_label = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Client_email_label = new System.Windows.Forms.Label();
            this.Client_email_txt = new System.Windows.Forms.TextBox();
            this.Client_name_label = new System.Windows.Forms.Label();
            this.Client_name_txt = new System.Windows.Forms.TextBox();
            this.Client_phone_label = new System.Windows.Forms.Label();
            this.Client_phone_txt = new System.Windows.Forms.TextBox();
            this.Client_address_label = new System.Windows.Forms.Label();
            this.Client_address_txt = new System.Windows.Forms.TextBox();
            this.Client_id_label = new System.Windows.Forms.Label();
            this.Client_id_txt = new System.Windows.Forms.TextBox();
            this.rEQUESTTableAdapter = new Tawfiq.Task_Worker_MatchingDataSet1TableAdapters.REQUESTTableAdapter();
            this.Workers_panel = new System.Windows.Forms.Panel();
            this.Delete_Worker_btn = new System.Windows.Forms.Button();
            this.Search_Worker_btn = new System.Windows.Forms.Button();
            this.Load_Worker_btn = new System.Windows.Forms.Button();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.Specialty_textBox = new System.Windows.Forms.TextBox();
            this.SpecialtyID_textBox = new System.Windows.Forms.TextBox();
            this.Specialty_L = new System.Windows.Forms.Label();
            this.SpecialtyID_L = new System.Windows.Forms.Label();
            this.Year_L = new System.Windows.Forms.Label();
            this.Location_textBox = new System.Windows.Forms.TextBox();
            this.Location_L = new System.Windows.Forms.Label();
            this.Day_textBox = new System.Windows.Forms.TextBox();
            this.Day_L = new System.Windows.Forms.Label();
            this.EndTime_textBox = new System.Windows.Forms.TextBox();
            this.EndTime_L = new System.Windows.Forms.Label();
            this.Workers_table = new System.Windows.Forms.DataGridView();
            this.Edit_Panel_btn = new System.Windows.Forms.Button();
            this.Add_Worker_btn = new System.Windows.Forms.Button();
            this.Start_Time_L = new System.Windows.Forms.Label();
            this.StartTime_textBox = new System.Windows.Forms.TextBox();
            this.TimeSlotID_L = new System.Windows.Forms.Label();
            this.TimeSlotID_textBox = new System.Windows.Forms.TextBox();
            this.Worker_Name_L = new System.Windows.Forms.Label();
            this.WorkerName_textBox = new System.Windows.Forms.TextBox();
            this.Worker_ID_L = new System.Windows.Forms.Label();
            this.WorkerID_textBox = new System.Windows.Forms.TextBox();
            this.Edit_Worker_panel = new System.Windows.Forms.Panel();
            this.NewY_txt = new System.Windows.Forms.TextBox();
            this.NewSP_txt = new System.Windows.Forms.TextBox();
            this.SpecialtyID_Edit = new System.Windows.Forms.TextBox();
            this.New_Specialty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Year = new System.Windows.Forms.Label();
            this.New_L_txt = new System.Windows.Forms.TextBox();
            this.New_Location = new System.Windows.Forms.Label();
            this.NewD_txt = new System.Windows.Forms.TextBox();
            this.New_Day = new System.Windows.Forms.Label();
            this.NewET_txt = new System.Windows.Forms.TextBox();
            this.New_End_Time = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Edit_Worker_btn = new System.Windows.Forms.Button();
            this.New_Start_Time = new System.Windows.Forms.Label();
            this.NewST_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TimeSlotID_Edit = new System.Windows.Forms.TextBox();
            this.New_Worker_Name = new System.Windows.Forms.Label();
            this.New_WN_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WorkerID_Edit = new System.Windows.Forms.TextBox();
            this.cLIENTTableAdapter = new Tawfiq.Task_Worker_MatchingDataSet3TableAdapters.CLIENTTableAdapter();
            this.task_Worker_MatchingDataSet4 = new Tawfiq.Task_Worker_MatchingDataSet4();
            this.taskWorkerMatchingDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Side_panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo_picbox)).BeginInit();
            this.Tasks_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet)).BeginInit();
            this.Overview_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_rated_workers_table)).BeginInit();
            this.Requests_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requests_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet1)).BeginInit();
            this.Clients_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet3)).BeginInit();
            this.Workers_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workers_table)).BeginInit();
            this.Edit_Worker_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskWorkerMatchingDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Side_panel
            // 
            this.Side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Side_panel.Controls.Add(this.Clients_btn);
            this.Side_panel.Controls.Add(this.Workers_btn);
            this.Side_panel.Controls.Add(this.Requests_btn);
            this.Side_panel.Controls.Add(this.Tasks_btn);
            this.Side_panel.Controls.Add(this.Overview_btn);
            this.Side_panel.Controls.Add(this.Logo_Panel);
            this.Side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_panel.Location = new System.Drawing.Point(0, 0);
            this.Side_panel.Name = "Side_panel";
            this.Side_panel.Size = new System.Drawing.Size(300, 707);
            this.Side_panel.TabIndex = 1;
            // 
            // Clients_btn
            // 
            this.Clients_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clients_btn.FlatAppearance.BorderSize = 0;
            this.Clients_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Clients_btn.Location = new System.Drawing.Point(0, 520);
            this.Clients_btn.Name = "Clients_btn";
            this.Clients_btn.Size = new System.Drawing.Size(300, 55);
            this.Clients_btn.TabIndex = 5;
            this.Clients_btn.Text = "Clients";
            this.Clients_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clients_btn.UseVisualStyleBackColor = true;
            this.Clients_btn.Click += new System.EventHandler(this.Clients_btn_Click);
            // 
            // Workers_btn
            // 
            this.Workers_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Workers_btn.FlatAppearance.BorderSize = 0;
            this.Workers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Workers_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workers_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Workers_btn.Location = new System.Drawing.Point(0, 465);
            this.Workers_btn.Name = "Workers_btn";
            this.Workers_btn.Size = new System.Drawing.Size(300, 55);
            this.Workers_btn.TabIndex = 4;
            this.Workers_btn.Text = "Workers";
            this.Workers_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Workers_btn.UseVisualStyleBackColor = true;
            this.Workers_btn.Click += new System.EventHandler(this.Workers_btn_Click);
            // 
            // Requests_btn
            // 
            this.Requests_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Requests_btn.FlatAppearance.BorderSize = 0;
            this.Requests_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Requests_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requests_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Requests_btn.Location = new System.Drawing.Point(0, 410);
            this.Requests_btn.Name = "Requests_btn";
            this.Requests_btn.Size = new System.Drawing.Size(300, 55);
            this.Requests_btn.TabIndex = 3;
            this.Requests_btn.Text = "Requests";
            this.Requests_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Requests_btn.UseVisualStyleBackColor = true;
            this.Requests_btn.Click += new System.EventHandler(this.Requests_btn_Click);
            // 
            // Tasks_btn
            // 
            this.Tasks_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tasks_btn.FlatAppearance.BorderSize = 0;
            this.Tasks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tasks_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tasks_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Tasks_btn.Location = new System.Drawing.Point(0, 355);
            this.Tasks_btn.Name = "Tasks_btn";
            this.Tasks_btn.Size = new System.Drawing.Size(300, 55);
            this.Tasks_btn.TabIndex = 2;
            this.Tasks_btn.Text = "Tasks";
            this.Tasks_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tasks_btn.UseVisualStyleBackColor = true;
            this.Tasks_btn.Click += new System.EventHandler(this.Tasks_btn_Click);
            // 
            // Overview_btn
            // 
            this.Overview_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Overview_btn.FlatAppearance.BorderSize = 0;
            this.Overview_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overview_btn.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overview_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Overview_btn.Location = new System.Drawing.Point(0, 300);
            this.Overview_btn.Name = "Overview_btn";
            this.Overview_btn.Size = new System.Drawing.Size(300, 55);
            this.Overview_btn.TabIndex = 1;
            this.Overview_btn.Text = "Overview";
            this.Overview_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Overview_btn.UseVisualStyleBackColor = true;
            this.Overview_btn.Click += new System.EventHandler(this.Overview_btn_Click);
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Controls.Add(this.Main_logo_picbox);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(300, 300);
            this.Logo_Panel.TabIndex = 1;
            // 
            // Main_logo_picbox
            // 
            this.Main_logo_picbox.Image = ((System.Drawing.Image)(resources.GetObject("Main_logo_picbox.Image")));
            this.Main_logo_picbox.Location = new System.Drawing.Point(0, -3);
            this.Main_logo_picbox.Name = "Main_logo_picbox";
            this.Main_logo_picbox.Size = new System.Drawing.Size(300, 303);
            this.Main_logo_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_logo_picbox.TabIndex = 0;
            this.Main_logo_picbox.TabStop = false;
            // 
            // Tasks_panel
            // 
            this.Tasks_panel.Controls.Add(this.Search_task_btn);
            this.Tasks_panel.Controls.Add(this.Tasks_table);
            this.Tasks_panel.Controls.Add(this.edit_task_btn);
            this.Tasks_panel.Controls.Add(this.delete_task_btn);
            this.Tasks_panel.Controls.Add(this.load_tasks_btn);
            this.Tasks_panel.Controls.Add(this.add_task_btn);
            this.Tasks_panel.Controls.Add(this.new_average_fee);
            this.Tasks_panel.Controls.Add(this.new_average_fee_txt);
            this.Tasks_panel.Controls.Add(this.new_task_name_label);
            this.Tasks_panel.Controls.Add(this.new_task_name_txt);
            this.Tasks_panel.Controls.Add(this.new_required_speciality_label);
            this.Tasks_panel.Controls.Add(this.new_required_speciality_txt);
            this.Tasks_panel.Controls.Add(this.new_average_time);
            this.Tasks_panel.Controls.Add(this.new_average_time_txt);
            this.Tasks_panel.Controls.Add(this.new_task_id_label);
            this.Tasks_panel.Controls.Add(this.new_task_id_txt);
            this.Tasks_panel.Controls.Add(this.average_fee_btn);
            this.Tasks_panel.Controls.Add(this.average_fee_txt);
            this.Tasks_panel.Controls.Add(this.task_name_label);
            this.Tasks_panel.Controls.Add(this.task_name_txt);
            this.Tasks_panel.Controls.Add(this.required_speciality_label);
            this.Tasks_panel.Controls.Add(this.required_speciality_txt);
            this.Tasks_panel.Controls.Add(this.average_time_label);
            this.Tasks_panel.Controls.Add(this.average_time_txt);
            this.Tasks_panel.Controls.Add(this.task_id_label);
            this.Tasks_panel.Controls.Add(this.task_id_txt);
            this.Tasks_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tasks_panel.Location = new System.Drawing.Point(300, 0);
            this.Tasks_panel.Name = "Tasks_panel";
            this.Tasks_panel.Size = new System.Drawing.Size(1312, 707);
            this.Tasks_panel.TabIndex = 2;
            this.Tasks_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Tasks_panel_Paint);
            // 
            // Search_task_btn
            // 
            this.Search_task_btn.FlatAppearance.BorderSize = 0;
            this.Search_task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_task_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_task_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Search_task_btn.Location = new System.Drawing.Point(6, 598);
            this.Search_task_btn.Name = "Search_task_btn";
            this.Search_task_btn.Size = new System.Drawing.Size(309, 102);
            this.Search_task_btn.TabIndex = 41;
            this.Search_task_btn.Text = "Search for Task";
            this.Search_task_btn.UseVisualStyleBackColor = true;
            this.Search_task_btn.Click += new System.EventHandler(this.Search_task_btn_Click);
            // 
            // Tasks_table
            // 
            this.Tasks_table.AutoGenerateColumns = false;
            this.Tasks_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tasks_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tASKIDDataGridViewTextBoxColumn,
            this.tASKNAMEDataGridViewTextBoxColumn,
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn,
            this.aVERAGETIMEDataGridViewTextBoxColumn,
            this.aVERAGEFEEDataGridViewTextBoxColumn});
            this.Tasks_table.DataSource = this.tASKBindingSource;
            this.Tasks_table.Location = new System.Drawing.Point(746, 109);
            this.Tasks_table.Name = "Tasks_table";
            this.Tasks_table.RowHeadersWidth = 62;
            this.Tasks_table.Size = new System.Drawing.Size(554, 588);
            this.Tasks_table.TabIndex = 40;
            // 
            // tASKIDDataGridViewTextBoxColumn
            // 
            this.tASKIDDataGridViewTextBoxColumn.DataPropertyName = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.HeaderText = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tASKIDDataGridViewTextBoxColumn.Name = "tASKIDDataGridViewTextBoxColumn";
            this.tASKIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tASKNAMEDataGridViewTextBoxColumn
            // 
            this.tASKNAMEDataGridViewTextBoxColumn.DataPropertyName = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.HeaderText = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tASKNAMEDataGridViewTextBoxColumn.Name = "tASKNAMEDataGridViewTextBoxColumn";
            this.tASKNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rEQUIREDSPECIALITYDataGridViewTextBoxColumn
            // 
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.DataPropertyName = "REQUIRED_SPECIALITY";
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.HeaderText = "REQUIRED_SPECIALITY";
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.Name = "rEQUIREDSPECIALITYDataGridViewTextBoxColumn";
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.Width = 150;
            // 
            // aVERAGETIMEDataGridViewTextBoxColumn
            // 
            this.aVERAGETIMEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE_TIME";
            this.aVERAGETIMEDataGridViewTextBoxColumn.HeaderText = "AVERAGE_TIME";
            this.aVERAGETIMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aVERAGETIMEDataGridViewTextBoxColumn.Name = "aVERAGETIMEDataGridViewTextBoxColumn";
            this.aVERAGETIMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aVERAGEFEEDataGridViewTextBoxColumn
            // 
            this.aVERAGEFEEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE_FEE";
            this.aVERAGEFEEDataGridViewTextBoxColumn.HeaderText = "AVERAGE_FEE";
            this.aVERAGEFEEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aVERAGEFEEDataGridViewTextBoxColumn.Name = "aVERAGEFEEDataGridViewTextBoxColumn";
            this.aVERAGEFEEDataGridViewTextBoxColumn.Width = 150;
            // 
            // tASKBindingSource
            // 
            this.tASKBindingSource.DataMember = "TASK";
            this.tASKBindingSource.DataSource = this.task_Worker_MatchingDataSet;
            // 
            // task_Worker_MatchingDataSet
            // 
            this.task_Worker_MatchingDataSet.DataSetName = "Task_Worker_MatchingDataSet";
            this.task_Worker_MatchingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edit_task_btn
            // 
            this.edit_task_btn.FlatAppearance.BorderSize = 0;
            this.edit_task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_task_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_task_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.edit_task_btn.Location = new System.Drawing.Point(391, 382);
            this.edit_task_btn.Name = "edit_task_btn";
            this.edit_task_btn.Size = new System.Drawing.Size(309, 102);
            this.edit_task_btn.TabIndex = 39;
            this.edit_task_btn.Text = "Edit Task";
            this.edit_task_btn.UseVisualStyleBackColor = true;
            this.edit_task_btn.Click += new System.EventHandler(this.edit_task_btn_Click);
            // 
            // delete_task_btn
            // 
            this.delete_task_btn.FlatAppearance.BorderSize = 0;
            this.delete_task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_task_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_task_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.delete_task_btn.Location = new System.Drawing.Point(6, 490);
            this.delete_task_btn.Name = "delete_task_btn";
            this.delete_task_btn.Size = new System.Drawing.Size(309, 102);
            this.delete_task_btn.TabIndex = 38;
            this.delete_task_btn.Text = "Delete Task";
            this.delete_task_btn.UseVisualStyleBackColor = true;
            this.delete_task_btn.Click += new System.EventHandler(this.delete_task_btn_Click);
            // 
            // load_tasks_btn
            // 
            this.load_tasks_btn.FlatAppearance.BorderSize = 0;
            this.load_tasks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_tasks_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_tasks_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.load_tasks_btn.Location = new System.Drawing.Point(391, 490);
            this.load_tasks_btn.Name = "load_tasks_btn";
            this.load_tasks_btn.Size = new System.Drawing.Size(309, 102);
            this.load_tasks_btn.TabIndex = 37;
            this.load_tasks_btn.Text = "Load Tasks";
            this.load_tasks_btn.UseVisualStyleBackColor = true;
            this.load_tasks_btn.Click += new System.EventHandler(this.load_tasks_btn_Click);
            // 
            // add_task_btn
            // 
            this.add_task_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_task_btn.FlatAppearance.BorderSize = 0;
            this.add_task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_task_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_task_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.add_task_btn.Location = new System.Drawing.Point(6, 382);
            this.add_task_btn.Name = "add_task_btn";
            this.add_task_btn.Size = new System.Drawing.Size(309, 102);
            this.add_task_btn.TabIndex = 36;
            this.add_task_btn.Text = "Add Task";
            this.add_task_btn.UseVisualStyleBackColor = false;
            this.add_task_btn.Click += new System.EventHandler(this.add_task_btn_Click);
            // 
            // new_average_fee
            // 
            this.new_average_fee.AutoSize = true;
            this.new_average_fee.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_average_fee.Location = new System.Drawing.Point(387, 340);
            this.new_average_fee.Name = "new_average_fee";
            this.new_average_fee.Size = new System.Drawing.Size(142, 21);
            this.new_average_fee.TabIndex = 35;
            this.new_average_fee.Text = "New Average Fee";
            // 
            // new_average_fee_txt
            // 
            this.new_average_fee_txt.Location = new System.Drawing.Point(545, 341);
            this.new_average_fee_txt.Multiline = true;
            this.new_average_fee_txt.Name = "new_average_fee_txt";
            this.new_average_fee_txt.Size = new System.Drawing.Size(183, 20);
            this.new_average_fee_txt.TabIndex = 34;
            // 
            // new_task_name_label
            // 
            this.new_task_name_label.AutoSize = true;
            this.new_task_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_task_name_label.Location = new System.Drawing.Point(387, 175);
            this.new_task_name_label.Name = "new_task_name_label";
            this.new_task_name_label.Size = new System.Drawing.Size(135, 21);
            this.new_task_name_label.TabIndex = 33;
            this.new_task_name_label.Text = "New Task Name";
            // 
            // new_task_name_txt
            // 
            this.new_task_name_txt.Location = new System.Drawing.Point(528, 175);
            this.new_task_name_txt.Multiline = true;
            this.new_task_name_txt.Name = "new_task_name_txt";
            this.new_task_name_txt.Size = new System.Drawing.Size(200, 20);
            this.new_task_name_txt.TabIndex = 32;
            // 
            // new_required_speciality_label
            // 
            this.new_required_speciality_label.AutoSize = true;
            this.new_required_speciality_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_required_speciality_label.Location = new System.Drawing.Point(387, 230);
            this.new_required_speciality_label.Name = "new_required_speciality_label";
            this.new_required_speciality_label.Size = new System.Drawing.Size(200, 21);
            this.new_required_speciality_label.TabIndex = 31;
            this.new_required_speciality_label.Text = "New Required Speciality";
            // 
            // new_required_speciality_txt
            // 
            this.new_required_speciality_txt.Location = new System.Drawing.Point(603, 231);
            this.new_required_speciality_txt.Multiline = true;
            this.new_required_speciality_txt.Name = "new_required_speciality_txt";
            this.new_required_speciality_txt.Size = new System.Drawing.Size(125, 20);
            this.new_required_speciality_txt.TabIndex = 30;
            // 
            // new_average_time
            // 
            this.new_average_time.AutoSize = true;
            this.new_average_time.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_average_time.Location = new System.Drawing.Point(387, 284);
            this.new_average_time.Name = "new_average_time";
            this.new_average_time.Size = new System.Drawing.Size(154, 21);
            this.new_average_time.TabIndex = 29;
            this.new_average_time.Text = "New Average Time";
            // 
            // new_average_time_txt
            // 
            this.new_average_time_txt.Location = new System.Drawing.Point(556, 287);
            this.new_average_time_txt.Multiline = true;
            this.new_average_time_txt.Name = "new_average_time_txt";
            this.new_average_time_txt.Size = new System.Drawing.Size(172, 20);
            this.new_average_time_txt.TabIndex = 28;
            // 
            // new_task_id_label
            // 
            this.new_task_id_label.AutoSize = true;
            this.new_task_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_task_id_label.Location = new System.Drawing.Point(387, 109);
            this.new_task_id_label.Name = "new_task_id_label";
            this.new_task_id_label.Size = new System.Drawing.Size(113, 21);
            this.new_task_id_label.TabIndex = 27;
            this.new_task_id_label.Text = "New Task ID";
            // 
            // new_task_id_txt
            // 
            this.new_task_id_txt.Location = new System.Drawing.Point(528, 112);
            this.new_task_id_txt.Multiline = true;
            this.new_task_id_txt.Name = "new_task_id_txt";
            this.new_task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.new_task_id_txt.TabIndex = 26;
            // 
            // average_fee_btn
            // 
            this.average_fee_btn.AutoSize = true;
            this.average_fee_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_fee_btn.Location = new System.Drawing.Point(2, 340);
            this.average_fee_btn.Name = "average_fee_btn";
            this.average_fee_btn.Size = new System.Drawing.Size(104, 21);
            this.average_fee_btn.TabIndex = 25;
            this.average_fee_btn.Text = "Average Fee";
            // 
            // average_fee_txt
            // 
            this.average_fee_txt.Location = new System.Drawing.Point(124, 343);
            this.average_fee_txt.Multiline = true;
            this.average_fee_txt.Name = "average_fee_txt";
            this.average_fee_txt.Size = new System.Drawing.Size(191, 20);
            this.average_fee_txt.TabIndex = 24;
            // 
            // task_name_label
            // 
            this.task_name_label.AutoSize = true;
            this.task_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_name_label.Location = new System.Drawing.Point(2, 175);
            this.task_name_label.Name = "task_name_label";
            this.task_name_label.Size = new System.Drawing.Size(97, 21);
            this.task_name_label.TabIndex = 23;
            this.task_name_label.Text = "Task Name";
            // 
            // task_name_txt
            // 
            this.task_name_txt.Location = new System.Drawing.Point(115, 175);
            this.task_name_txt.Multiline = true;
            this.task_name_txt.Name = "task_name_txt";
            this.task_name_txt.Size = new System.Drawing.Size(200, 20);
            this.task_name_txt.TabIndex = 22;
            // 
            // required_speciality_label
            // 
            this.required_speciality_label.AutoSize = true;
            this.required_speciality_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_speciality_label.Location = new System.Drawing.Point(2, 230);
            this.required_speciality_label.Name = "required_speciality_label";
            this.required_speciality_label.Size = new System.Drawing.Size(162, 21);
            this.required_speciality_label.TabIndex = 21;
            this.required_speciality_label.Text = "Required Speciality";
            // 
            // required_speciality_txt
            // 
            this.required_speciality_txt.Location = new System.Drawing.Point(170, 230);
            this.required_speciality_txt.Multiline = true;
            this.required_speciality_txt.Name = "required_speciality_txt";
            this.required_speciality_txt.Size = new System.Drawing.Size(145, 20);
            this.required_speciality_txt.TabIndex = 20;
            // 
            // average_time_label
            // 
            this.average_time_label.AutoSize = true;
            this.average_time_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_time_label.Location = new System.Drawing.Point(2, 284);
            this.average_time_label.Name = "average_time_label";
            this.average_time_label.Size = new System.Drawing.Size(116, 21);
            this.average_time_label.TabIndex = 19;
            this.average_time_label.Text = "Average Time";
            // 
            // average_time_txt
            // 
            this.average_time_txt.Location = new System.Drawing.Point(124, 285);
            this.average_time_txt.Multiline = true;
            this.average_time_txt.Name = "average_time_txt";
            this.average_time_txt.Size = new System.Drawing.Size(191, 20);
            this.average_time_txt.TabIndex = 18;
            // 
            // task_id_label
            // 
            this.task_id_label.AutoSize = true;
            this.task_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_id_label.Location = new System.Drawing.Point(2, 109);
            this.task_id_label.Name = "task_id_label";
            this.task_id_label.Size = new System.Drawing.Size(75, 21);
            this.task_id_label.TabIndex = 17;
            this.task_id_label.Text = "Task ID";
            // 
            // task_id_txt
            // 
            this.task_id_txt.Location = new System.Drawing.Point(115, 109);
            this.task_id_txt.Multiline = true;
            this.task_id_txt.Name = "task_id_txt";
            this.task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.task_id_txt.TabIndex = 16;
            // 
            // tASKTableAdapter
            // 
            this.tASKTableAdapter.ClearBeforeFill = true;
            // 
            // Overview_panel
            // 
            this.Overview_panel.Controls.Add(this.Generate_report_btn);
            this.Overview_panel.Controls.Add(this.label1);
            this.Overview_panel.Controls.Add(this.panel1);
            this.Overview_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Overview_panel.Location = new System.Drawing.Point(300, 0);
            this.Overview_panel.Name = "Overview_panel";
            this.Overview_panel.Size = new System.Drawing.Size(1312, 707);
            this.Overview_panel.TabIndex = 42;
            this.Overview_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Overview_panel_Paint);
            // 
            // Generate_report_btn
            // 
            this.Generate_report_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Generate_report_btn.Cursor = System.Windows.Forms.Cursors.No;
            this.Generate_report_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_report_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Generate_report_btn.Location = new System.Drawing.Point(833, 345);
            this.Generate_report_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Generate_report_btn.Name = "Generate_report_btn";
            this.Generate_report_btn.Size = new System.Drawing.Size(149, 120);
            this.Generate_report_btn.TabIndex = 32;
            this.Generate_report_btn.Text = "Generate Report";
            this.Generate_report_btn.UseVisualStyleBackColor = false;
            this.Generate_report_btn.Click += new System.EventHandler(this.Generate_report_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(549, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Overview";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.SpecialtyChart);
            this.panel1.Controls.Add(this.Top_rated_workers_table);
            this.panel1.Controls.Add(this.Completed_tasks);
            this.panel1.Controls.Add(this.Total_requests);
            this.panel1.Controls.Add(this.Total_tasks);
            this.panel1.Location = new System.Drawing.Point(160, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 402);
            this.panel1.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 347);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Top Rated Workers";
            // 
            // SpecialtyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SpecialtyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.SpecialtyChart.Legends.Add(legend2);
            this.SpecialtyChart.Location = new System.Drawing.Point(270, 127);
            this.SpecialtyChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SpecialtyChart.Name = "SpecialtyChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SpecialtyChart.Series.Add(series2);
            this.SpecialtyChart.Size = new System.Drawing.Size(277, 244);
            this.SpecialtyChart.TabIndex = 29;
            this.SpecialtyChart.Text = "chart1";
            // 
            // Top_rated_workers_table
            // 
            this.Top_rated_workers_table.AllowUserToOrderColumns = true;
            this.Top_rated_workers_table.AutoGenerateColumns = false;
            this.Top_rated_workers_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top_rated_workers_table.DataSource = this.task_Worker_MatchingDataSet;
            this.Top_rated_workers_table.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Top_rated_workers_table.Location = new System.Drawing.Point(16, 129);
            this.Top_rated_workers_table.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Top_rated_workers_table.Name = "Top_rated_workers_table";
            this.Top_rated_workers_table.RowHeadersWidth = 51;
            this.Top_rated_workers_table.RowTemplate.Height = 24;
            this.Top_rated_workers_table.Size = new System.Drawing.Size(250, 209);
            this.Top_rated_workers_table.TabIndex = 28;
            // 
            // Completed_tasks
            // 
            this.Completed_tasks.AutoSize = true;
            this.Completed_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completed_tasks.Location = new System.Drawing.Point(374, 58);
            this.Completed_tasks.Name = "Completed_tasks";
            this.Completed_tasks.Size = new System.Drawing.Size(156, 24);
            this.Completed_tasks.TabIndex = 27;
            this.Completed_tasks.Text = "Completed Tasks";
            // 
            // Total_requests
            // 
            this.Total_requests.AutoSize = true;
            this.Total_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_requests.Location = new System.Drawing.Point(199, 58);
            this.Total_requests.Name = "Total_requests";
            this.Total_requests.Size = new System.Drawing.Size(135, 24);
            this.Total_requests.TabIndex = 27;
            this.Total_requests.Text = "Total Requests";
            // 
            // Total_tasks
            // 
            this.Total_tasks.AutoSize = true;
            this.Total_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_tasks.Location = new System.Drawing.Point(20, 58);
            this.Total_tasks.Name = "Total_tasks";
            this.Total_tasks.Size = new System.Drawing.Size(105, 24);
            this.Total_tasks.TabIndex = 26;
            this.Total_tasks.Text = "Total Tasks";
            // 
            // Requests_panel
            // 
            this.Requests_panel.Controls.Add(this.new_act_time_taken_label);
            this.Requests_panel.Controls.Add(this.new_actual_time_taken_txt);
            this.Requests_panel.Controls.Add(this.new_req_status_label);
            this.Requests_panel.Controls.Add(this.new_request_status_txt);
            this.Requests_panel.Controls.Add(this.new_pref_time_label);
            this.Requests_panel.Controls.Add(this.new_preferred_time_slot_txt);
            this.Requests_panel.Controls.Add(this.new_req_address_label);
            this.Requests_panel.Controls.Add(this.new_request_address_txt);
            this.Requests_panel.Controls.Add(this.new_taskId_label);
            this.Requests_panel.Controls.Add(this.new_request_task_id_txt);
            this.Requests_panel.Controls.Add(this.new_client_id_label);
            this.Requests_panel.Controls.Add(this.new_request_client_id_txt);
            this.Requests_panel.Controls.Add(this.new_req_time_label);
            this.Requests_panel.Controls.Add(this.new_request_time_txt);
            this.Requests_panel.Controls.Add(this.new_req_id_label);
            this.Requests_panel.Controls.Add(this.new_request_id_txt);
            this.Requests_panel.Controls.Add(this.act_time_taken_label);
            this.Requests_panel.Controls.Add(this.actual_time_taken_txt);
            this.Requests_panel.Controls.Add(this.request_status_label);
            this.Requests_panel.Controls.Add(this.request_status_txt);
            this.Requests_panel.Controls.Add(this.pref_time_slot_label);
            this.Requests_panel.Controls.Add(this.preferred_time_slot_txt);
            this.Requests_panel.Controls.Add(this.search_request_btn);
            this.Requests_panel.Controls.Add(this.Requests_table);
            this.Requests_panel.Controls.Add(this.edit_request_btn);
            this.Requests_panel.Controls.Add(this.delete_request_btn);
            this.Requests_panel.Controls.Add(this.load_requests_btn);
            this.Requests_panel.Controls.Add(this.add_request_btn);
            this.Requests_panel.Controls.Add(this.request_addresss_label);
            this.Requests_panel.Controls.Add(this.request_address_txt);
            this.Requests_panel.Controls.Add(this.taskID_label);
            this.Requests_panel.Controls.Add(this.request_task_id_txt);
            this.Requests_panel.Controls.Add(this.clientID_label);
            this.Requests_panel.Controls.Add(this.request_client_id_txt);
            this.Requests_panel.Controls.Add(this.request_time_label);
            this.Requests_panel.Controls.Add(this.request_time_txt);
            this.Requests_panel.Controls.Add(this.requestID_label);
            this.Requests_panel.Controls.Add(this.request_id_txt);
            this.Requests_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Requests_panel.Location = new System.Drawing.Point(300, 0);
            this.Requests_panel.Name = "Requests_panel";
            this.Requests_panel.Size = new System.Drawing.Size(1312, 707);
            this.Requests_panel.TabIndex = 42;
            // 
            // new_act_time_taken_label
            // 
            this.new_act_time_taken_label.AutoSize = true;
            this.new_act_time_taken_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_act_time_taken_label.Location = new System.Drawing.Point(385, 324);
            this.new_act_time_taken_label.Name = "new_act_time_taken_label";
            this.new_act_time_taken_label.Size = new System.Drawing.Size(178, 21);
            this.new_act_time_taken_label.TabIndex = 127;
            this.new_act_time_taken_label.Text = "New Act. Time Taken";
            // 
            // new_actual_time_taken_txt
            // 
            this.new_actual_time_taken_txt.Location = new System.Drawing.Point(569, 327);
            this.new_actual_time_taken_txt.Multiline = true;
            this.new_actual_time_taken_txt.Name = "new_actual_time_taken_txt";
            this.new_actual_time_taken_txt.Size = new System.Drawing.Size(160, 20);
            this.new_actual_time_taken_txt.TabIndex = 126;
            // 
            // new_req_status_label
            // 
            this.new_req_status_label.AutoSize = true;
            this.new_req_status_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_req_status_label.Location = new System.Drawing.Point(385, 245);
            this.new_req_status_label.Name = "new_req_status_label";
            this.new_req_status_label.Size = new System.Drawing.Size(162, 21);
            this.new_req_status_label.TabIndex = 125;
            this.new_req_status_label.Text = "New Request Status";
            // 
            // new_request_status_txt
            // 
            this.new_request_status_txt.Location = new System.Drawing.Point(553, 245);
            this.new_request_status_txt.Multiline = true;
            this.new_request_status_txt.Name = "new_request_status_txt";
            this.new_request_status_txt.Size = new System.Drawing.Size(176, 20);
            this.new_request_status_txt.TabIndex = 124;
            // 
            // new_pref_time_label
            // 
            this.new_pref_time_label.AutoSize = true;
            this.new_pref_time_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pref_time_label.Location = new System.Drawing.Point(385, 287);
            this.new_pref_time_label.Name = "new_pref_time_label";
            this.new_pref_time_label.Size = new System.Drawing.Size(167, 21);
            this.new_pref_time_label.TabIndex = 123;
            this.new_pref_time_label.Text = "New Pref. Time Slot";
            // 
            // new_preferred_time_slot_txt
            // 
            this.new_preferred_time_slot_txt.Location = new System.Drawing.Point(557, 287);
            this.new_preferred_time_slot_txt.Multiline = true;
            this.new_preferred_time_slot_txt.Name = "new_preferred_time_slot_txt";
            this.new_preferred_time_slot_txt.Size = new System.Drawing.Size(171, 20);
            this.new_preferred_time_slot_txt.TabIndex = 122;
            // 
            // new_req_address_label
            // 
            this.new_req_address_label.AutoSize = true;
            this.new_req_address_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_req_address_label.Location = new System.Drawing.Point(385, 203);
            this.new_req_address_label.Name = "new_req_address_label";
            this.new_req_address_label.Size = new System.Drawing.Size(174, 21);
            this.new_req_address_label.TabIndex = 121;
            this.new_req_address_label.Text = "New Request Address";
            // 
            // new_request_address_txt
            // 
            this.new_request_address_txt.Location = new System.Drawing.Point(565, 203);
            this.new_request_address_txt.Multiline = true;
            this.new_request_address_txt.Name = "new_request_address_txt";
            this.new_request_address_txt.Size = new System.Drawing.Size(163, 20);
            this.new_request_address_txt.TabIndex = 120;
            // 
            // new_taskId_label
            // 
            this.new_taskId_label.AutoSize = true;
            this.new_taskId_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_taskId_label.Location = new System.Drawing.Point(385, 82);
            this.new_taskId_label.Name = "new_taskId_label";
            this.new_taskId_label.Size = new System.Drawing.Size(113, 21);
            this.new_taskId_label.TabIndex = 119;
            this.new_taskId_label.Text = "New Task ID";
            // 
            // new_request_task_id_txt
            // 
            this.new_request_task_id_txt.Location = new System.Drawing.Point(529, 82);
            this.new_request_task_id_txt.Multiline = true;
            this.new_request_task_id_txt.Name = "new_request_task_id_txt";
            this.new_request_task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.new_request_task_id_txt.TabIndex = 118;
            // 
            // new_client_id_label
            // 
            this.new_client_id_label.AutoSize = true;
            this.new_client_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_client_id_label.Location = new System.Drawing.Point(385, 122);
            this.new_client_id_label.Name = "new_client_id_label";
            this.new_client_id_label.Size = new System.Drawing.Size(121, 21);
            this.new_client_id_label.TabIndex = 117;
            this.new_client_id_label.Text = "New Client ID";
            // 
            // new_request_client_id_txt
            // 
            this.new_request_client_id_txt.Location = new System.Drawing.Point(527, 122);
            this.new_request_client_id_txt.Multiline = true;
            this.new_request_client_id_txt.Name = "new_request_client_id_txt";
            this.new_request_client_id_txt.Size = new System.Drawing.Size(200, 20);
            this.new_request_client_id_txt.TabIndex = 116;
            // 
            // new_req_time_label
            // 
            this.new_req_time_label.AutoSize = true;
            this.new_req_time_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_req_time_label.Location = new System.Drawing.Point(385, 162);
            this.new_req_time_label.Name = "new_req_time_label";
            this.new_req_time_label.Size = new System.Drawing.Size(154, 21);
            this.new_req_time_label.TabIndex = 115;
            this.new_req_time_label.Text = "New Request Time";
            // 
            // new_request_time_txt
            // 
            this.new_request_time_txt.Location = new System.Drawing.Point(545, 164);
            this.new_request_time_txt.Multiline = true;
            this.new_request_time_txt.Name = "new_request_time_txt";
            this.new_request_time_txt.Size = new System.Drawing.Size(184, 20);
            this.new_request_time_txt.TabIndex = 114;
            // 
            // new_req_id_label
            // 
            this.new_req_id_label.AutoSize = true;
            this.new_req_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_req_id_label.Location = new System.Drawing.Point(385, 44);
            this.new_req_id_label.Name = "new_req_id_label";
            this.new_req_id_label.Size = new System.Drawing.Size(136, 21);
            this.new_req_id_label.TabIndex = 113;
            this.new_req_id_label.Text = "New Request ID";
            // 
            // new_request_id_txt
            // 
            this.new_request_id_txt.Location = new System.Drawing.Point(527, 46);
            this.new_request_id_txt.Multiline = true;
            this.new_request_id_txt.Name = "new_request_id_txt";
            this.new_request_id_txt.Size = new System.Drawing.Size(200, 20);
            this.new_request_id_txt.TabIndex = 112;
            // 
            // act_time_taken_label
            // 
            this.act_time_taken_label.AutoSize = true;
            this.act_time_taken_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act_time_taken_label.Location = new System.Drawing.Point(11, 324);
            this.act_time_taken_label.Name = "act_time_taken_label";
            this.act_time_taken_label.Size = new System.Drawing.Size(140, 21);
            this.act_time_taken_label.TabIndex = 111;
            this.act_time_taken_label.Text = "Act. Time Taken";
            // 
            // actual_time_taken_txt
            // 
            this.actual_time_taken_txt.Location = new System.Drawing.Point(153, 327);
            this.actual_time_taken_txt.Multiline = true;
            this.actual_time_taken_txt.Name = "actual_time_taken_txt";
            this.actual_time_taken_txt.Size = new System.Drawing.Size(171, 20);
            this.actual_time_taken_txt.TabIndex = 110;
            // 
            // request_status_label
            // 
            this.request_status_label.AutoSize = true;
            this.request_status_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_status_label.Location = new System.Drawing.Point(11, 245);
            this.request_status_label.Name = "request_status_label";
            this.request_status_label.Size = new System.Drawing.Size(124, 21);
            this.request_status_label.TabIndex = 109;
            this.request_status_label.Text = "Request Status";
            // 
            // request_status_txt
            // 
            this.request_status_txt.Location = new System.Drawing.Point(141, 245);
            this.request_status_txt.Multiline = true;
            this.request_status_txt.Name = "request_status_txt";
            this.request_status_txt.Size = new System.Drawing.Size(183, 20);
            this.request_status_txt.TabIndex = 108;
            // 
            // pref_time_slot_label
            // 
            this.pref_time_slot_label.AutoSize = true;
            this.pref_time_slot_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pref_time_slot_label.Location = new System.Drawing.Point(11, 287);
            this.pref_time_slot_label.Name = "pref_time_slot_label";
            this.pref_time_slot_label.Size = new System.Drawing.Size(129, 21);
            this.pref_time_slot_label.TabIndex = 107;
            this.pref_time_slot_label.Text = "Pref. Time Slot";
            // 
            // preferred_time_slot_txt
            // 
            this.preferred_time_slot_txt.Location = new System.Drawing.Point(153, 287);
            this.preferred_time_slot_txt.Multiline = true;
            this.preferred_time_slot_txt.Name = "preferred_time_slot_txt";
            this.preferred_time_slot_txt.Size = new System.Drawing.Size(171, 20);
            this.preferred_time_slot_txt.TabIndex = 106;
            // 
            // search_request_btn
            // 
            this.search_request_btn.FlatAppearance.BorderSize = 0;
            this.search_request_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_request_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_request_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.search_request_btn.Location = new System.Drawing.Point(229, 561);
            this.search_request_btn.Name = "search_request_btn";
            this.search_request_btn.Size = new System.Drawing.Size(309, 103);
            this.search_request_btn.TabIndex = 105;
            this.search_request_btn.Text = "Search for Request";
            this.search_request_btn.UseVisualStyleBackColor = true;
            this.search_request_btn.Click += new System.EventHandler(this.search_request_btn_Click);
            // 
            // Requests_table
            // 
            this.Requests_table.AutoGenerateColumns = false;
            this.Requests_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Requests_table.DataSource = this.taskWorkerMatchingDataSet4BindingSource;
            this.Requests_table.Location = new System.Drawing.Point(745, 44);
            this.Requests_table.Name = "Requests_table";
            this.Requests_table.RowHeadersWidth = 62;
            this.Requests_table.Size = new System.Drawing.Size(557, 601);
            this.Requests_table.TabIndex = 104;
            // 
            // rEQUESTBindingSource
            // 
            this.rEQUESTBindingSource.DataMember = "REQUEST";
            this.rEQUESTBindingSource.DataSource = this.task_Worker_MatchingDataSet1;
            // 
            // task_Worker_MatchingDataSet1
            // 
            this.task_Worker_MatchingDataSet1.DataSetName = "Task_Worker_MatchingDataSet1";
            this.task_Worker_MatchingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edit_request_btn
            // 
            this.edit_request_btn.FlatAppearance.BorderSize = 0;
            this.edit_request_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_request_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_request_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.edit_request_btn.Location = new System.Drawing.Point(399, 376);
            this.edit_request_btn.Name = "edit_request_btn";
            this.edit_request_btn.Size = new System.Drawing.Size(290, 85);
            this.edit_request_btn.TabIndex = 103;
            this.edit_request_btn.Text = "Edit Request";
            this.edit_request_btn.UseVisualStyleBackColor = true;
            this.edit_request_btn.Click += new System.EventHandler(this.edit_request_btn_Click);
            // 
            // delete_request_btn
            // 
            this.delete_request_btn.FlatAppearance.BorderSize = 0;
            this.delete_request_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_request_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_request_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.delete_request_btn.Location = new System.Drawing.Point(35, 465);
            this.delete_request_btn.Name = "delete_request_btn";
            this.delete_request_btn.Size = new System.Drawing.Size(290, 85);
            this.delete_request_btn.TabIndex = 102;
            this.delete_request_btn.Text = "Delete Request";
            this.delete_request_btn.UseVisualStyleBackColor = true;
            this.delete_request_btn.Click += new System.EventHandler(this.delete_request_btn_Click);
            // 
            // load_requests_btn
            // 
            this.load_requests_btn.FlatAppearance.BorderSize = 0;
            this.load_requests_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_requests_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_requests_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.load_requests_btn.Location = new System.Drawing.Point(399, 465);
            this.load_requests_btn.Name = "load_requests_btn";
            this.load_requests_btn.Size = new System.Drawing.Size(290, 85);
            this.load_requests_btn.TabIndex = 101;
            this.load_requests_btn.Text = "Load Requests";
            this.load_requests_btn.UseVisualStyleBackColor = true;
            this.load_requests_btn.Click += new System.EventHandler(this.load_requests_btn_Click);
            // 
            // add_request_btn
            // 
            this.add_request_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_request_btn.FlatAppearance.BorderSize = 0;
            this.add_request_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_request_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_request_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.add_request_btn.Location = new System.Drawing.Point(35, 376);
            this.add_request_btn.Name = "add_request_btn";
            this.add_request_btn.Size = new System.Drawing.Size(290, 85);
            this.add_request_btn.TabIndex = 100;
            this.add_request_btn.Text = "Add Request";
            this.add_request_btn.UseVisualStyleBackColor = false;
            this.add_request_btn.Click += new System.EventHandler(this.add_request_btn_Click);
            // 
            // request_addresss_label
            // 
            this.request_addresss_label.AutoSize = true;
            this.request_addresss_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_addresss_label.Location = new System.Drawing.Point(11, 203);
            this.request_addresss_label.Name = "request_addresss_label";
            this.request_addresss_label.Size = new System.Drawing.Size(136, 21);
            this.request_addresss_label.TabIndex = 99;
            this.request_addresss_label.Text = "Request Address";
            // 
            // request_address_txt
            // 
            this.request_address_txt.Location = new System.Drawing.Point(153, 203);
            this.request_address_txt.Multiline = true;
            this.request_address_txt.Name = "request_address_txt";
            this.request_address_txt.Size = new System.Drawing.Size(171, 20);
            this.request_address_txt.TabIndex = 98;
            // 
            // taskID_label
            // 
            this.taskID_label.AutoSize = true;
            this.taskID_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskID_label.Location = new System.Drawing.Point(11, 82);
            this.taskID_label.Name = "taskID_label";
            this.taskID_label.Size = new System.Drawing.Size(75, 21);
            this.taskID_label.TabIndex = 97;
            this.taskID_label.Text = "Task ID";
            // 
            // request_task_id_txt
            // 
            this.request_task_id_txt.Location = new System.Drawing.Point(124, 82);
            this.request_task_id_txt.Multiline = true;
            this.request_task_id_txt.Name = "request_task_id_txt";
            this.request_task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.request_task_id_txt.TabIndex = 96;
            // 
            // clientID_label
            // 
            this.clientID_label.AutoSize = true;
            this.clientID_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_label.Location = new System.Drawing.Point(11, 122);
            this.clientID_label.Name = "clientID_label";
            this.clientID_label.Size = new System.Drawing.Size(83, 21);
            this.clientID_label.TabIndex = 95;
            this.clientID_label.Text = "Client ID";
            // 
            // request_client_id_txt
            // 
            this.request_client_id_txt.Location = new System.Drawing.Point(123, 122);
            this.request_client_id_txt.Multiline = true;
            this.request_client_id_txt.Name = "request_client_id_txt";
            this.request_client_id_txt.Size = new System.Drawing.Size(200, 20);
            this.request_client_id_txt.TabIndex = 94;
            // 
            // request_time_label
            // 
            this.request_time_label.AutoSize = true;
            this.request_time_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_time_label.Location = new System.Drawing.Point(11, 162);
            this.request_time_label.Name = "request_time_label";
            this.request_time_label.Size = new System.Drawing.Size(116, 21);
            this.request_time_label.TabIndex = 93;
            this.request_time_label.Text = "Request Time";
            // 
            // request_time_txt
            // 
            this.request_time_txt.Location = new System.Drawing.Point(133, 164);
            this.request_time_txt.Multiline = true;
            this.request_time_txt.Name = "request_time_txt";
            this.request_time_txt.Size = new System.Drawing.Size(191, 20);
            this.request_time_txt.TabIndex = 92;
            // 
            // requestID_label
            // 
            this.requestID_label.AutoSize = true;
            this.requestID_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestID_label.Location = new System.Drawing.Point(11, 44);
            this.requestID_label.Name = "requestID_label";
            this.requestID_label.Size = new System.Drawing.Size(98, 21);
            this.requestID_label.TabIndex = 91;
            this.requestID_label.Text = "Request ID";
            // 
            // request_id_txt
            // 
            this.request_id_txt.Location = new System.Drawing.Point(123, 46);
            this.request_id_txt.Multiline = true;
            this.request_id_txt.Name = "request_id_txt";
            this.request_id_txt.Size = new System.Drawing.Size(200, 20);
            this.request_id_txt.TabIndex = 90;
            // 
            // Clients_panel
            // 
            this.Clients_panel.Controls.Add(this.Client_payment_into_label);
            this.Clients_panel.Controls.Add(this.Client_payment_info_txt);
            this.Clients_panel.Controls.Add(this.Search_client_btn);
            this.Clients_panel.Controls.Add(this.Clients_table);
            this.Clients_panel.Controls.Add(this.Edit_client_btn);
            this.Clients_panel.Controls.Add(this.Delete_client_btn);
            this.Clients_panel.Controls.Add(this.Load_clients_btn);
            this.Clients_panel.Controls.Add(this.Add_client_btn);
            this.Clients_panel.Controls.Add(this.New_client_payment_info_label);
            this.Clients_panel.Controls.Add(this.textBox2);
            this.Clients_panel.Controls.Add(this.New_client_phone_label);
            this.Clients_panel.Controls.Add(this.textBox3);
            this.Clients_panel.Controls.Add(this.New_client_address_label);
            this.Clients_panel.Controls.Add(this.textBox4);
            this.Clients_panel.Controls.Add(this.New_client_email_label);
            this.Clients_panel.Controls.Add(this.textBox5);
            this.Clients_panel.Controls.Add(this.New_client_name_label);
            this.Clients_panel.Controls.Add(this.textBox6);
            this.Clients_panel.Controls.Add(this.Client_email_label);
            this.Clients_panel.Controls.Add(this.Client_email_txt);
            this.Clients_panel.Controls.Add(this.Client_name_label);
            this.Clients_panel.Controls.Add(this.Client_name_txt);
            this.Clients_panel.Controls.Add(this.Client_phone_label);
            this.Clients_panel.Controls.Add(this.Client_phone_txt);
            this.Clients_panel.Controls.Add(this.Client_address_label);
            this.Clients_panel.Controls.Add(this.Client_address_txt);
            this.Clients_panel.Controls.Add(this.Client_id_label);
            this.Clients_panel.Controls.Add(this.Client_id_txt);
            this.Clients_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clients_panel.Location = new System.Drawing.Point(300, 0);
            this.Clients_panel.Name = "Clients_panel";
            this.Clients_panel.Size = new System.Drawing.Size(1312, 707);
            this.Clients_panel.TabIndex = 44;
            this.Clients_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Clients_panel_Paint);
            // 
            // Client_payment_into_label
            // 
            this.Client_payment_into_label.AutoSize = true;
            this.Client_payment_into_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_payment_into_label.Location = new System.Drawing.Point(6, 355);
            this.Client_payment_into_label.Name = "Client_payment_into_label";
            this.Client_payment_into_label.Size = new System.Drawing.Size(117, 21);
            this.Client_payment_into_label.TabIndex = 69;
            this.Client_payment_into_label.Text = "Payment Info";
            // 
            // Client_payment_info_txt
            // 
            this.Client_payment_info_txt.Location = new System.Drawing.Point(131, 355);
            this.Client_payment_info_txt.Multiline = true;
            this.Client_payment_info_txt.Name = "Client_payment_info_txt";
            this.Client_payment_info_txt.Size = new System.Drawing.Size(191, 20);
            this.Client_payment_info_txt.TabIndex = 68;
            // 
            // Search_client_btn
            // 
            this.Search_client_btn.FlatAppearance.BorderSize = 0;
            this.Search_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_client_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_client_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Search_client_btn.Location = new System.Drawing.Point(6, 602);
            this.Search_client_btn.Name = "Search_client_btn";
            this.Search_client_btn.Size = new System.Drawing.Size(309, 102);
            this.Search_client_btn.TabIndex = 67;
            this.Search_client_btn.Text = "Search for Client";
            this.Search_client_btn.UseVisualStyleBackColor = true;
            // 
            // Clients_table
            // 
            this.Clients_table.AutoGenerateColumns = false;
            this.Clients_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pAYMENTINFODataGridViewTextBoxColumn});
            this.Clients_table.DataSource = this.cLIENTBindingSource;
            this.Clients_table.Location = new System.Drawing.Point(706, 72);
            this.Clients_table.Name = "Clients_table";
            this.Clients_table.RowHeadersWidth = 62;
            this.Clients_table.Size = new System.Drawing.Size(603, 602);
            this.Clients_table.TabIndex = 66;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 150;
            // 
            // pAYMENTINFODataGridViewTextBoxColumn
            // 
            this.pAYMENTINFODataGridViewTextBoxColumn.DataPropertyName = "PAYMENT_INFO";
            this.pAYMENTINFODataGridViewTextBoxColumn.HeaderText = "PAYMENT_INFO";
            this.pAYMENTINFODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pAYMENTINFODataGridViewTextBoxColumn.Name = "pAYMENTINFODataGridViewTextBoxColumn";
            this.pAYMENTINFODataGridViewTextBoxColumn.Width = 150;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.task_Worker_MatchingDataSet3;
            // 
            // task_Worker_MatchingDataSet3
            // 
            this.task_Worker_MatchingDataSet3.DataSetName = "Task_Worker_MatchingDataSet3";
            this.task_Worker_MatchingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Edit_client_btn
            // 
            this.Edit_client_btn.FlatAppearance.BorderSize = 0;
            this.Edit_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_client_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_client_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Edit_client_btn.Location = new System.Drawing.Point(356, 495);
            this.Edit_client_btn.Name = "Edit_client_btn";
            this.Edit_client_btn.Size = new System.Drawing.Size(309, 102);
            this.Edit_client_btn.TabIndex = 65;
            this.Edit_client_btn.Text = "Edit Client";
            this.Edit_client_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_client_btn
            // 
            this.Delete_client_btn.FlatAppearance.BorderSize = 0;
            this.Delete_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_client_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_client_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Delete_client_btn.Location = new System.Drawing.Point(6, 509);
            this.Delete_client_btn.Name = "Delete_client_btn";
            this.Delete_client_btn.Size = new System.Drawing.Size(309, 102);
            this.Delete_client_btn.TabIndex = 64;
            this.Delete_client_btn.Text = "Delete Client";
            this.Delete_client_btn.UseVisualStyleBackColor = true;
            // 
            // Load_clients_btn
            // 
            this.Load_clients_btn.FlatAppearance.BorderSize = 0;
            this.Load_clients_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_clients_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_clients_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Load_clients_btn.Location = new System.Drawing.Point(350, 602);
            this.Load_clients_btn.Name = "Load_clients_btn";
            this.Load_clients_btn.Size = new System.Drawing.Size(309, 102);
            this.Load_clients_btn.TabIndex = 63;
            this.Load_clients_btn.Text = "Load Clients";
            this.Load_clients_btn.UseVisualStyleBackColor = true;
            // 
            // Add_client_btn
            // 
            this.Add_client_btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_client_btn.FlatAppearance.BorderSize = 0;
            this.Add_client_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_client_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_client_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Add_client_btn.Location = new System.Drawing.Point(3, 410);
            this.Add_client_btn.Name = "Add_client_btn";
            this.Add_client_btn.Size = new System.Drawing.Size(309, 102);
            this.Add_client_btn.TabIndex = 62;
            this.Add_client_btn.Text = "Add Client";
            this.Add_client_btn.UseVisualStyleBackColor = false;
            this.Add_client_btn.Click += new System.EventHandler(this.Add_client_btn_Click);
            // 
            // New_client_payment_info_label
            // 
            this.New_client_payment_info_label.AutoSize = true;
            this.New_client_payment_info_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_client_payment_info_label.Location = new System.Drawing.Point(346, 352);
            this.New_client_payment_info_label.Name = "New_client_payment_info_label";
            this.New_client_payment_info_label.Size = new System.Drawing.Size(155, 21);
            this.New_client_payment_info_label.TabIndex = 61;
            this.New_client_payment_info_label.Text = "New Payment Info";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 353);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 60;
            // 
            // New_client_phone_label
            // 
            this.New_client_phone_label.AutoSize = true;
            this.New_client_phone_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_client_phone_label.Location = new System.Drawing.Point(346, 187);
            this.New_client_phone_label.Name = "New_client_phone_label";
            this.New_client_phone_label.Size = new System.Drawing.Size(164, 21);
            this.New_client_phone_label.TabIndex = 59;
            this.New_client_phone_label.Text = "New Phone Number";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(487, 187);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 58;
            // 
            // New_client_address_label
            // 
            this.New_client_address_label.AutoSize = true;
            this.New_client_address_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_client_address_label.Location = new System.Drawing.Point(346, 242);
            this.New_client_address_label.Name = "New_client_address_label";
            this.New_client_address_label.Size = new System.Drawing.Size(108, 21);
            this.New_client_address_label.TabIndex = 57;
            this.New_client_address_label.Text = "New Address";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(562, 243);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 56;
            // 
            // New_client_email_label
            // 
            this.New_client_email_label.AutoSize = true;
            this.New_client_email_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_client_email_label.Location = new System.Drawing.Point(346, 296);
            this.New_client_email_label.Name = "New_client_email_label";
            this.New_client_email_label.Size = new System.Drawing.Size(96, 21);
            this.New_client_email_label.TabIndex = 55;
            this.New_client_email_label.Text = "New Email";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(515, 299);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 20);
            this.textBox5.TabIndex = 54;
            // 
            // New_client_name_label
            // 
            this.New_client_name_label.AutoSize = true;
            this.New_client_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_client_name_label.Location = new System.Drawing.Point(346, 121);
            this.New_client_name_label.Name = "New_client_name_label";
            this.New_client_name_label.Size = new System.Drawing.Size(92, 21);
            this.New_client_name_label.TabIndex = 53;
            this.New_client_name_label.Text = "New Name";
            this.New_client_name_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(487, 124);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 52;
            // 
            // Client_email_label
            // 
            this.Client_email_label.AutoSize = true;
            this.Client_email_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_email_label.Location = new System.Drawing.Point(9, 303);
            this.Client_email_label.Name = "Client_email_label";
            this.Client_email_label.Size = new System.Drawing.Size(58, 21);
            this.Client_email_label.TabIndex = 51;
            this.Client_email_label.Text = "Email";
            // 
            // Client_email_txt
            // 
            this.Client_email_txt.Location = new System.Drawing.Point(131, 306);
            this.Client_email_txt.Multiline = true;
            this.Client_email_txt.Name = "Client_email_txt";
            this.Client_email_txt.Size = new System.Drawing.Size(191, 20);
            this.Client_email_txt.TabIndex = 50;
            // 
            // Client_name_label
            // 
            this.Client_name_label.AutoSize = true;
            this.Client_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_name_label.Location = new System.Drawing.Point(9, 138);
            this.Client_name_label.Name = "Client_name_label";
            this.Client_name_label.Size = new System.Drawing.Size(54, 21);
            this.Client_name_label.TabIndex = 49;
            this.Client_name_label.Text = "Name";
            // 
            // Client_name_txt
            // 
            this.Client_name_txt.Location = new System.Drawing.Point(122, 138);
            this.Client_name_txt.Multiline = true;
            this.Client_name_txt.Name = "Client_name_txt";
            this.Client_name_txt.Size = new System.Drawing.Size(200, 20);
            this.Client_name_txt.TabIndex = 48;
            // 
            // Client_phone_label
            // 
            this.Client_phone_label.AutoSize = true;
            this.Client_phone_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_phone_label.Location = new System.Drawing.Point(9, 193);
            this.Client_phone_label.Name = "Client_phone_label";
            this.Client_phone_label.Size = new System.Drawing.Size(126, 21);
            this.Client_phone_label.TabIndex = 47;
            this.Client_phone_label.Text = "Phone Number";
            // 
            // Client_phone_txt
            // 
            this.Client_phone_txt.Location = new System.Drawing.Point(141, 193);
            this.Client_phone_txt.Multiline = true;
            this.Client_phone_txt.Name = "Client_phone_txt";
            this.Client_phone_txt.Size = new System.Drawing.Size(181, 20);
            this.Client_phone_txt.TabIndex = 46;
            // 
            // Client_address_label
            // 
            this.Client_address_label.AutoSize = true;
            this.Client_address_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_address_label.Location = new System.Drawing.Point(9, 247);
            this.Client_address_label.Name = "Client_address_label";
            this.Client_address_label.Size = new System.Drawing.Size(70, 21);
            this.Client_address_label.TabIndex = 45;
            this.Client_address_label.Text = "Address";
            // 
            // Client_address_txt
            // 
            this.Client_address_txt.Location = new System.Drawing.Point(92, 248);
            this.Client_address_txt.Multiline = true;
            this.Client_address_txt.Name = "Client_address_txt";
            this.Client_address_txt.Size = new System.Drawing.Size(230, 20);
            this.Client_address_txt.TabIndex = 44;
            // 
            // Client_id_label
            // 
            this.Client_id_label.AutoSize = true;
            this.Client_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_id_label.Location = new System.Drawing.Point(9, 72);
            this.Client_id_label.Name = "Client_id_label";
            this.Client_id_label.Size = new System.Drawing.Size(83, 21);
            this.Client_id_label.TabIndex = 43;
            this.Client_id_label.Text = "Client ID";
            // 
            // Client_id_txt
            // 
            this.Client_id_txt.Location = new System.Drawing.Point(124, 73);
            this.Client_id_txt.Multiline = true;
            this.Client_id_txt.Name = "Client_id_txt";
            this.Client_id_txt.Size = new System.Drawing.Size(200, 20);
            this.Client_id_txt.TabIndex = 42;
            // 
            // rEQUESTTableAdapter
            // 
            this.rEQUESTTableAdapter.ClearBeforeFill = true;
            // 
            // Workers_panel
            // 
            this.Workers_panel.Controls.Add(this.Delete_Worker_btn);
            this.Workers_panel.Controls.Add(this.Search_Worker_btn);
            this.Workers_panel.Controls.Add(this.Load_Worker_btn);
            this.Workers_panel.Controls.Add(this.Year_textBox);
            this.Workers_panel.Controls.Add(this.Specialty_textBox);
            this.Workers_panel.Controls.Add(this.SpecialtyID_textBox);
            this.Workers_panel.Controls.Add(this.Specialty_L);
            this.Workers_panel.Controls.Add(this.SpecialtyID_L);
            this.Workers_panel.Controls.Add(this.Year_L);
            this.Workers_panel.Controls.Add(this.Location_textBox);
            this.Workers_panel.Controls.Add(this.Location_L);
            this.Workers_panel.Controls.Add(this.Day_textBox);
            this.Workers_panel.Controls.Add(this.Day_L);
            this.Workers_panel.Controls.Add(this.EndTime_textBox);
            this.Workers_panel.Controls.Add(this.EndTime_L);
            this.Workers_panel.Controls.Add(this.Workers_table);
            this.Workers_panel.Controls.Add(this.Edit_Panel_btn);
            this.Workers_panel.Controls.Add(this.Add_Worker_btn);
            this.Workers_panel.Controls.Add(this.Start_Time_L);
            this.Workers_panel.Controls.Add(this.StartTime_textBox);
            this.Workers_panel.Controls.Add(this.TimeSlotID_L);
            this.Workers_panel.Controls.Add(this.TimeSlotID_textBox);
            this.Workers_panel.Controls.Add(this.Worker_Name_L);
            this.Workers_panel.Controls.Add(this.WorkerName_textBox);
            this.Workers_panel.Controls.Add(this.Worker_ID_L);
            this.Workers_panel.Controls.Add(this.WorkerID_textBox);
            this.Workers_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workers_panel.Location = new System.Drawing.Point(300, 0);
            this.Workers_panel.Name = "Workers_panel";
            this.Workers_panel.Size = new System.Drawing.Size(1312, 707);
            this.Workers_panel.TabIndex = 44;
            // 
            // Delete_Worker_btn
            // 
            this.Delete_Worker_btn.FlatAppearance.BorderSize = 0;
            this.Delete_Worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Worker_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Delete_Worker_btn.Location = new System.Drawing.Point(220, 386);
            this.Delete_Worker_btn.Name = "Delete_Worker_btn";
            this.Delete_Worker_btn.Size = new System.Drawing.Size(200, 100);
            this.Delete_Worker_btn.TabIndex = 78;
            this.Delete_Worker_btn.Text = "Delete Worker";
            this.Delete_Worker_btn.UseVisualStyleBackColor = true;
            this.Delete_Worker_btn.Click += new System.EventHandler(this.Delete_Worker_btn_Click);
            // 
            // Search_Worker_btn
            // 
            this.Search_Worker_btn.FlatAppearance.BorderSize = 0;
            this.Search_Worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Worker_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Search_Worker_btn.Location = new System.Drawing.Point(465, 386);
            this.Search_Worker_btn.Name = "Search_Worker_btn";
            this.Search_Worker_btn.Size = new System.Drawing.Size(200, 100);
            this.Search_Worker_btn.TabIndex = 77;
            this.Search_Worker_btn.Text = "Search Worker";
            this.Search_Worker_btn.UseVisualStyleBackColor = true;
            this.Search_Worker_btn.Click += new System.EventHandler(this.Search_Worker_btn_Click);
            // 
            // Load_Worker_btn
            // 
            this.Load_Worker_btn.FlatAppearance.BorderSize = 0;
            this.Load_Worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_Worker_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Load_Worker_btn.Location = new System.Drawing.Point(706, 386);
            this.Load_Worker_btn.Name = "Load_Worker_btn";
            this.Load_Worker_btn.Size = new System.Drawing.Size(200, 100);
            this.Load_Worker_btn.TabIndex = 76;
            this.Load_Worker_btn.Text = "Load Workers";
            this.Load_Worker_btn.UseVisualStyleBackColor = true;
            this.Load_Worker_btn.Click += new System.EventHandler(this.Load_Worker_btn_Click);
            // 
            // Year_textBox
            // 
            this.Year_textBox.Location = new System.Drawing.Point(141, 207);
            this.Year_textBox.Multiline = true;
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(74, 23);
            this.Year_textBox.TabIndex = 75;
            // 
            // Specialty_textBox
            // 
            this.Specialty_textBox.Location = new System.Drawing.Point(407, 139);
            this.Specialty_textBox.Multiline = true;
            this.Specialty_textBox.Name = "Specialty_textBox";
            this.Specialty_textBox.Size = new System.Drawing.Size(74, 23);
            this.Specialty_textBox.TabIndex = 74;
            // 
            // SpecialtyID_textBox
            // 
            this.SpecialtyID_textBox.Location = new System.Drawing.Point(141, 139);
            this.SpecialtyID_textBox.Multiline = true;
            this.SpecialtyID_textBox.Name = "SpecialtyID_textBox";
            this.SpecialtyID_textBox.Size = new System.Drawing.Size(74, 23);
            this.SpecialtyID_textBox.TabIndex = 73;
            // 
            // Specialty_L
            // 
            this.Specialty_L.AutoSize = true;
            this.Specialty_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialty_L.Location = new System.Drawing.Point(263, 141);
            this.Specialty_L.Name = "Specialty_L";
            this.Specialty_L.Size = new System.Drawing.Size(81, 21);
            this.Specialty_L.TabIndex = 72;
            this.Specialty_L.Text = "Specialty";
            // 
            // SpecialtyID_L
            // 
            this.SpecialtyID_L.AutoSize = true;
            this.SpecialtyID_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialtyID_L.Location = new System.Drawing.Point(10, 141);
            this.SpecialtyID_L.Name = "SpecialtyID_L";
            this.SpecialtyID_L.Size = new System.Drawing.Size(108, 21);
            this.SpecialtyID_L.TabIndex = 71;
            this.SpecialtyID_L.Text = "Specialty ID";
            // 
            // Year_L
            // 
            this.Year_L.AutoSize = true;
            this.Year_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_L.Location = new System.Drawing.Point(10, 209);
            this.Year_L.Name = "Year_L";
            this.Year_L.Size = new System.Drawing.Size(48, 21);
            this.Year_L.TabIndex = 70;
            this.Year_L.Text = "Year";
            // 
            // Location_textBox
            // 
            this.Location_textBox.Location = new System.Drawing.Point(407, 207);
            this.Location_textBox.Multiline = true;
            this.Location_textBox.Name = "Location_textBox";
            this.Location_textBox.Size = new System.Drawing.Size(74, 23);
            this.Location_textBox.TabIndex = 69;
            // 
            // Location_L
            // 
            this.Location_L.AutoSize = true;
            this.Location_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_L.Location = new System.Drawing.Point(263, 209);
            this.Location_L.Name = "Location_L";
            this.Location_L.Size = new System.Drawing.Size(80, 21);
            this.Location_L.TabIndex = 68;
            this.Location_L.Text = "Location";
            // 
            // Day_textBox
            // 
            this.Day_textBox.Location = new System.Drawing.Point(407, 343);
            this.Day_textBox.Multiline = true;
            this.Day_textBox.Name = "Day_textBox";
            this.Day_textBox.Size = new System.Drawing.Size(74, 23);
            this.Day_textBox.TabIndex = 67;
            // 
            // Day_L
            // 
            this.Day_L.AutoSize = true;
            this.Day_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day_L.Location = new System.Drawing.Point(263, 343);
            this.Day_L.Name = "Day_L";
            this.Day_L.Size = new System.Drawing.Size(42, 21);
            this.Day_L.TabIndex = 66;
            this.Day_L.Text = "Day";
            // 
            // EndTime_textBox
            // 
            this.EndTime_textBox.Location = new System.Drawing.Point(407, 277);
            this.EndTime_textBox.Multiline = true;
            this.EndTime_textBox.Name = "EndTime_textBox";
            this.EndTime_textBox.Size = new System.Drawing.Size(74, 23);
            this.EndTime_textBox.TabIndex = 65;
            // 
            // EndTime_L
            // 
            this.EndTime_L.AutoSize = true;
            this.EndTime_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime_L.Location = new System.Drawing.Point(263, 279);
            this.EndTime_L.Name = "EndTime_L";
            this.EndTime_L.Size = new System.Drawing.Size(87, 21);
            this.EndTime_L.TabIndex = 64;
            this.EndTime_L.Text = "End Time";
            // 
            // Workers_table
            // 
            this.Workers_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Workers_table.Location = new System.Drawing.Point(567, 63);
            this.Workers_table.Name = "Workers_table";
            this.Workers_table.RowHeadersWidth = 62;
            this.Workers_table.Size = new System.Drawing.Size(561, 303);
            this.Workers_table.TabIndex = 63;
            // 
            // Edit_Panel_btn
            // 
            this.Edit_Panel_btn.FlatAppearance.BorderSize = 0;
            this.Edit_Panel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Panel_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Panel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Edit_Panel_btn.Location = new System.Drawing.Point(912, 386);
            this.Edit_Panel_btn.Name = "Edit_Panel_btn";
            this.Edit_Panel_btn.Size = new System.Drawing.Size(200, 100);
            this.Edit_Panel_btn.TabIndex = 62;
            this.Edit_Panel_btn.Text = "Edit Panel";
            this.Edit_Panel_btn.UseVisualStyleBackColor = true;
            this.Edit_Panel_btn.Click += new System.EventHandler(this.Edit_Panel_btn_Click);
            // 
            // Add_Worker_btn
            // 
            this.Add_Worker_btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Worker_btn.FlatAppearance.BorderSize = 0;
            this.Add_Worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Worker_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Add_Worker_btn.Location = new System.Drawing.Point(14, 386);
            this.Add_Worker_btn.Name = "Add_Worker_btn";
            this.Add_Worker_btn.Size = new System.Drawing.Size(200, 100);
            this.Add_Worker_btn.TabIndex = 61;
            this.Add_Worker_btn.Text = "Add Worker";
            this.Add_Worker_btn.UseVisualStyleBackColor = false;
            this.Add_Worker_btn.Click += new System.EventHandler(this.Add_Worker_btn_Click);
            // 
            // Start_Time_L
            // 
            this.Start_Time_L.AutoSize = true;
            this.Start_Time_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Time_L.Location = new System.Drawing.Point(10, 343);
            this.Start_Time_L.Name = "Start_Time_L";
            this.Start_Time_L.Size = new System.Drawing.Size(93, 21);
            this.Start_Time_L.TabIndex = 60;
            this.Start_Time_L.Text = "Start Time";
            // 
            // StartTime_textBox
            // 
            this.StartTime_textBox.Location = new System.Drawing.Point(141, 343);
            this.StartTime_textBox.Multiline = true;
            this.StartTime_textBox.Name = "StartTime_textBox";
            this.StartTime_textBox.Size = new System.Drawing.Size(74, 23);
            this.StartTime_textBox.TabIndex = 59;
            // 
            // TimeSlotID_L
            // 
            this.TimeSlotID_L.AutoSize = true;
            this.TimeSlotID_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSlotID_L.Location = new System.Drawing.Point(10, 279);
            this.TimeSlotID_L.Name = "TimeSlotID_L";
            this.TimeSlotID_L.Size = new System.Drawing.Size(113, 21);
            this.TimeSlotID_L.TabIndex = 58;
            this.TimeSlotID_L.Text = "Time Slot ID";
            // 
            // TimeSlotID_textBox
            // 
            this.TimeSlotID_textBox.Location = new System.Drawing.Point(141, 277);
            this.TimeSlotID_textBox.Multiline = true;
            this.TimeSlotID_textBox.Name = "TimeSlotID_textBox";
            this.TimeSlotID_textBox.Size = new System.Drawing.Size(74, 23);
            this.TimeSlotID_textBox.TabIndex = 57;
            // 
            // Worker_Name_L
            // 
            this.Worker_Name_L.AutoSize = true;
            this.Worker_Name_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worker_Name_L.Location = new System.Drawing.Point(263, 75);
            this.Worker_Name_L.Name = "Worker_Name_L";
            this.Worker_Name_L.Size = new System.Drawing.Size(118, 21);
            this.Worker_Name_L.TabIndex = 56;
            this.Worker_Name_L.Text = "Worker Name";
            // 
            // WorkerName_textBox
            // 
            this.WorkerName_textBox.Location = new System.Drawing.Point(407, 73);
            this.WorkerName_textBox.Multiline = true;
            this.WorkerName_textBox.Name = "WorkerName_textBox";
            this.WorkerName_textBox.Size = new System.Drawing.Size(74, 23);
            this.WorkerName_textBox.TabIndex = 55;
            // 
            // Worker_ID_L
            // 
            this.Worker_ID_L.AutoSize = true;
            this.Worker_ID_L.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worker_ID_L.Location = new System.Drawing.Point(10, 75);
            this.Worker_ID_L.Name = "Worker_ID_L";
            this.Worker_ID_L.Size = new System.Drawing.Size(96, 21);
            this.Worker_ID_L.TabIndex = 54;
            this.Worker_ID_L.Text = "Worker ID";
            // 
            // WorkerID_textBox
            // 
            this.WorkerID_textBox.Location = new System.Drawing.Point(141, 73);
            this.WorkerID_textBox.Multiline = true;
            this.WorkerID_textBox.Name = "WorkerID_textBox";
            this.WorkerID_textBox.Size = new System.Drawing.Size(74, 23);
            this.WorkerID_textBox.TabIndex = 53;
            // 
            // Edit_Worker_panel
            // 
            this.Edit_Worker_panel.Controls.Add(this.NewY_txt);
            this.Edit_Worker_panel.Controls.Add(this.NewSP_txt);
            this.Edit_Worker_panel.Controls.Add(this.SpecialtyID_Edit);
            this.Edit_Worker_panel.Controls.Add(this.New_Specialty);
            this.Edit_Worker_panel.Controls.Add(this.label2);
            this.Edit_Worker_panel.Controls.Add(this.New_Year);
            this.Edit_Worker_panel.Controls.Add(this.New_L_txt);
            this.Edit_Worker_panel.Controls.Add(this.New_Location);
            this.Edit_Worker_panel.Controls.Add(this.NewD_txt);
            this.Edit_Worker_panel.Controls.Add(this.New_Day);
            this.Edit_Worker_panel.Controls.Add(this.NewET_txt);
            this.Edit_Worker_panel.Controls.Add(this.New_End_Time);
            this.Edit_Worker_panel.Controls.Add(this.dataGridView2);
            this.Edit_Worker_panel.Controls.Add(this.Edit_Worker_btn);
            this.Edit_Worker_panel.Controls.Add(this.New_Start_Time);
            this.Edit_Worker_panel.Controls.Add(this.NewST_txt);
            this.Edit_Worker_panel.Controls.Add(this.label8);
            this.Edit_Worker_panel.Controls.Add(this.TimeSlotID_Edit);
            this.Edit_Worker_panel.Controls.Add(this.New_Worker_Name);
            this.Edit_Worker_panel.Controls.Add(this.New_WN_txt);
            this.Edit_Worker_panel.Controls.Add(this.label10);
            this.Edit_Worker_panel.Controls.Add(this.WorkerID_Edit);
            this.Edit_Worker_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edit_Worker_panel.Location = new System.Drawing.Point(300, 0);
            this.Edit_Worker_panel.Name = "Edit_Worker_panel";
            this.Edit_Worker_panel.Size = new System.Drawing.Size(1312, 707);
            this.Edit_Worker_panel.TabIndex = 79;
            // 
            // NewY_txt
            // 
            this.NewY_txt.Location = new System.Drawing.Point(141, 277);
            this.NewY_txt.Multiline = true;
            this.NewY_txt.Name = "NewY_txt";
            this.NewY_txt.Size = new System.Drawing.Size(74, 23);
            this.NewY_txt.TabIndex = 75;
            // 
            // NewSP_txt
            // 
            this.NewSP_txt.Location = new System.Drawing.Point(141, 207);
            this.NewSP_txt.Multiline = true;
            this.NewSP_txt.Name = "NewSP_txt";
            this.NewSP_txt.Size = new System.Drawing.Size(74, 23);
            this.NewSP_txt.TabIndex = 74;
            // 
            // SpecialtyID_Edit
            // 
            this.SpecialtyID_Edit.Location = new System.Drawing.Point(407, 73);
            this.SpecialtyID_Edit.Multiline = true;
            this.SpecialtyID_Edit.Name = "SpecialtyID_Edit";
            this.SpecialtyID_Edit.Size = new System.Drawing.Size(74, 23);
            this.SpecialtyID_Edit.TabIndex = 73;
            // 
            // New_Specialty
            // 
            this.New_Specialty.AutoSize = true;
            this.New_Specialty.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Specialty.Location = new System.Drawing.Point(10, 209);
            this.New_Specialty.Name = "New_Specialty";
            this.New_Specialty.Size = new System.Drawing.Size(119, 21);
            this.New_Specialty.TabIndex = 72;
            this.New_Specialty.Text = "New Specialty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Specialty ID";
            // 
            // New_Year
            // 
            this.New_Year.AutoSize = true;
            this.New_Year.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Year.Location = new System.Drawing.Point(10, 279);
            this.New_Year.Name = "New_Year";
            this.New_Year.Size = new System.Drawing.Size(86, 21);
            this.New_Year.TabIndex = 70;
            this.New_Year.Text = "New Year";
            // 
            // New_L_txt
            // 
            this.New_L_txt.Location = new System.Drawing.Point(407, 207);
            this.New_L_txt.Multiline = true;
            this.New_L_txt.Name = "New_L_txt";
            this.New_L_txt.Size = new System.Drawing.Size(74, 23);
            this.New_L_txt.TabIndex = 69;
            // 
            // New_Location
            // 
            this.New_Location.AutoSize = true;
            this.New_Location.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Location.Location = new System.Drawing.Point(263, 209);
            this.New_Location.Name = "New_Location";
            this.New_Location.Size = new System.Drawing.Size(118, 21);
            this.New_Location.TabIndex = 68;
            this.New_Location.Text = "New Location";
            // 
            // NewD_txt
            // 
            this.NewD_txt.Location = new System.Drawing.Point(407, 343);
            this.NewD_txt.Multiline = true;
            this.NewD_txt.Name = "NewD_txt";
            this.NewD_txt.Size = new System.Drawing.Size(74, 23);
            this.NewD_txt.TabIndex = 67;
            // 
            // New_Day
            // 
            this.New_Day.AutoSize = true;
            this.New_Day.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Day.Location = new System.Drawing.Point(263, 343);
            this.New_Day.Name = "New_Day";
            this.New_Day.Size = new System.Drawing.Size(80, 21);
            this.New_Day.TabIndex = 66;
            this.New_Day.Text = "New Day";
            // 
            // NewET_txt
            // 
            this.NewET_txt.Location = new System.Drawing.Point(407, 277);
            this.NewET_txt.Multiline = true;
            this.NewET_txt.Name = "NewET_txt";
            this.NewET_txt.Size = new System.Drawing.Size(74, 23);
            this.NewET_txt.TabIndex = 65;
            // 
            // New_End_Time
            // 
            this.New_End_Time.AutoSize = true;
            this.New_End_Time.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_End_Time.Location = new System.Drawing.Point(263, 279);
            this.New_End_Time.Name = "New_End_Time";
            this.New_End_Time.Size = new System.Drawing.Size(125, 21);
            this.New_End_Time.TabIndex = 64;
            this.New_End_Time.Text = "New End Time";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(567, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(561, 303);
            this.dataGridView2.TabIndex = 63;
            // 
            // Edit_Worker_btn
            // 
            this.Edit_Worker_btn.FlatAppearance.BorderSize = 0;
            this.Edit_Worker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Worker_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Worker_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Edit_Worker_btn.Location = new System.Drawing.Point(14, 386);
            this.Edit_Worker_btn.Name = "Edit_Worker_btn";
            this.Edit_Worker_btn.Size = new System.Drawing.Size(200, 100);
            this.Edit_Worker_btn.TabIndex = 62;
            this.Edit_Worker_btn.Text = "Edit Worker";
            this.Edit_Worker_btn.UseVisualStyleBackColor = true;
            this.Edit_Worker_btn.Click += new System.EventHandler(this.Edit_Worker_btn_Click);
            // 
            // New_Start_Time
            // 
            this.New_Start_Time.AutoSize = true;
            this.New_Start_Time.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Start_Time.Location = new System.Drawing.Point(10, 343);
            this.New_Start_Time.Name = "New_Start_Time";
            this.New_Start_Time.Size = new System.Drawing.Size(131, 21);
            this.New_Start_Time.TabIndex = 60;
            this.New_Start_Time.Text = "New Start Time";
            // 
            // NewST_txt
            // 
            this.NewST_txt.Location = new System.Drawing.Point(141, 343);
            this.NewST_txt.Multiline = true;
            this.NewST_txt.Name = "NewST_txt";
            this.NewST_txt.Size = new System.Drawing.Size(74, 23);
            this.NewST_txt.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 58;
            this.label8.Text = "Time Slot ID";
            // 
            // TimeSlotID_Edit
            // 
            this.TimeSlotID_Edit.Location = new System.Drawing.Point(141, 139);
            this.TimeSlotID_Edit.Multiline = true;
            this.TimeSlotID_Edit.Name = "TimeSlotID_Edit";
            this.TimeSlotID_Edit.Size = new System.Drawing.Size(74, 23);
            this.TimeSlotID_Edit.TabIndex = 57;
            // 
            // New_Worker_Name
            // 
            this.New_Worker_Name.AutoSize = true;
            this.New_Worker_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Worker_Name.Location = new System.Drawing.Point(263, 141);
            this.New_Worker_Name.Name = "New_Worker_Name";
            this.New_Worker_Name.Size = new System.Drawing.Size(156, 21);
            this.New_Worker_Name.TabIndex = 56;
            this.New_Worker_Name.Text = "New Worker Name";
            // 
            // New_WN_txt
            // 
            this.New_WN_txt.Location = new System.Drawing.Point(444, 139);
            this.New_WN_txt.Multiline = true;
            this.New_WN_txt.Name = "New_WN_txt";
            this.New_WN_txt.Size = new System.Drawing.Size(74, 23);
            this.New_WN_txt.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Worker ID";
            // 
            // WorkerID_Edit
            // 
            this.WorkerID_Edit.Location = new System.Drawing.Point(141, 73);
            this.WorkerID_Edit.Multiline = true;
            this.WorkerID_Edit.Name = "WorkerID_Edit";
            this.WorkerID_Edit.Size = new System.Drawing.Size(74, 23);
            this.WorkerID_Edit.TabIndex = 53;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // task_Worker_MatchingDataSet4
            // 
            this.task_Worker_MatchingDataSet4.DataSetName = "Task_Worker_MatchingDataSet4";
            this.task_Worker_MatchingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskWorkerMatchingDataSet4BindingSource
            // 
            this.taskWorkerMatchingDataSet4BindingSource.DataSource = this.task_Worker_MatchingDataSet4;
            this.taskWorkerMatchingDataSet4BindingSource.Position = 0;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1612, 707);
            this.Controls.Add(this.Requests_panel);
            this.Controls.Add(this.Clients_panel);
            this.Controls.Add(this.Tasks_panel);
            this.Controls.Add(this.Edit_Worker_panel);
            this.Controls.Add(this.Workers_panel);
            this.Controls.Add(this.Overview_panel);
            this.Controls.Add(this.Side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.Side_panel.ResumeLayout(false);
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo_picbox)).EndInit();
            this.Tasks_panel.ResumeLayout(false);
            this.Tasks_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet)).EndInit();
            this.Overview_panel.ResumeLayout(false);
            this.Overview_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top_rated_workers_table)).EndInit();
            this.Requests_panel.ResumeLayout(false);
            this.Requests_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Requests_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet1)).EndInit();
            this.Clients_panel.ResumeLayout(false);
            this.Clients_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet3)).EndInit();
            this.Workers_panel.ResumeLayout(false);
            this.Workers_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workers_table)).EndInit();
            this.Edit_Worker_panel.ResumeLayout(false);
            this.Edit_Worker_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskWorkerMatchingDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_panel;
        private System.Windows.Forms.Button Clients_btn;
        private System.Windows.Forms.Button Workers_btn;
        private System.Windows.Forms.Button Requests_btn;
        private System.Windows.Forms.Button Tasks_btn;
        private System.Windows.Forms.Button Overview_btn;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.PictureBox Main_logo_picbox;
        private System.Windows.Forms.Panel Tasks_panel;
        private System.Windows.Forms.Label average_fee_btn;
        private System.Windows.Forms.TextBox average_fee_txt;
        private System.Windows.Forms.Label task_name_label;
        private System.Windows.Forms.TextBox task_name_txt;
        private System.Windows.Forms.Label required_speciality_label;
        private System.Windows.Forms.TextBox required_speciality_txt;
        private System.Windows.Forms.Label average_time_label;
        private System.Windows.Forms.TextBox average_time_txt;
        private System.Windows.Forms.Label task_id_label;
        private System.Windows.Forms.TextBox task_id_txt;
        private System.Windows.Forms.Label new_average_fee;
        private System.Windows.Forms.TextBox new_average_fee_txt;
        private System.Windows.Forms.Label new_task_name_label;
        private System.Windows.Forms.TextBox new_task_name_txt;
        private System.Windows.Forms.Label new_required_speciality_label;
        private System.Windows.Forms.TextBox new_required_speciality_txt;
        private System.Windows.Forms.Label new_average_time;
        private System.Windows.Forms.TextBox new_average_time_txt;
        private System.Windows.Forms.Label new_task_id_label;
        private System.Windows.Forms.TextBox new_task_id_txt;
        private System.Windows.Forms.Button edit_task_btn;
        private System.Windows.Forms.Button delete_task_btn;
        private System.Windows.Forms.Button load_tasks_btn;
        private System.Windows.Forms.Button add_task_btn;
        private System.Windows.Forms.DataGridView Tasks_table;
        private Task_Worker_MatchingDataSet task_Worker_MatchingDataSet;
        private System.Windows.Forms.BindingSource tASKBindingSource;
        private Task_Worker_MatchingDataSetTableAdapters.TASKTableAdapter tASKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUIREDSPECIALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search_task_btn;
        private System.Windows.Forms.Panel Overview_panel;
        private System.Windows.Forms.Panel Requests_panel;
        private System.Windows.Forms.Panel Clients_panel;
        private Task_Worker_MatchingDataSet1 task_Worker_MatchingDataSet1;
        private System.Windows.Forms.BindingSource rEQUESTBindingSource;
        private Task_Worker_MatchingDataSet1TableAdapters.REQUESTTableAdapter rEQUESTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpecialtyChart;
        private System.Windows.Forms.DataGridView Top_rated_workers_table;
        private System.Windows.Forms.Label Completed_tasks;
        private System.Windows.Forms.Label Total_requests;
        private System.Windows.Forms.Label Total_tasks;
        private System.Windows.Forms.Button Generate_report_btn;
        private System.Windows.Forms.Panel Workers_panel;
        private System.Windows.Forms.Button Delete_Worker_btn;
        private System.Windows.Forms.Button Search_Worker_btn;
        private System.Windows.Forms.Button Load_Worker_btn;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.TextBox Specialty_textBox;
        private System.Windows.Forms.TextBox SpecialtyID_textBox;
        private System.Windows.Forms.Label Specialty_L;
        private System.Windows.Forms.Label SpecialtyID_L;
        private System.Windows.Forms.Label Year_L;
        private System.Windows.Forms.TextBox Location_textBox;
        private System.Windows.Forms.Label Location_L;
        private System.Windows.Forms.TextBox Day_textBox;
        private System.Windows.Forms.Label Day_L;
        private System.Windows.Forms.TextBox EndTime_textBox;
        private System.Windows.Forms.Label EndTime_L;
        private System.Windows.Forms.DataGridView Workers_table;
        private System.Windows.Forms.Button Edit_Panel_btn;
        private System.Windows.Forms.Button Add_Worker_btn;
        private System.Windows.Forms.Label Start_Time_L;
        private System.Windows.Forms.TextBox StartTime_textBox;
        private System.Windows.Forms.Label TimeSlotID_L;
        private System.Windows.Forms.TextBox TimeSlotID_textBox;
        private System.Windows.Forms.Label Worker_Name_L;
        private System.Windows.Forms.TextBox WorkerName_textBox;
        private System.Windows.Forms.Label Worker_ID_L;
        private System.Windows.Forms.TextBox WorkerID_textBox;
        private System.Windows.Forms.Panel Edit_Worker_panel;
        private System.Windows.Forms.TextBox NewY_txt;
        private System.Windows.Forms.TextBox NewSP_txt;
        private System.Windows.Forms.TextBox SpecialtyID_Edit;
        private System.Windows.Forms.Label New_Specialty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label New_Year;
        private System.Windows.Forms.TextBox New_L_txt;
        private System.Windows.Forms.Label New_Location;
        private System.Windows.Forms.TextBox NewD_txt;
        private System.Windows.Forms.Label New_Day;
        private System.Windows.Forms.TextBox NewET_txt;
        private System.Windows.Forms.Label New_End_Time;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Edit_Worker_btn;
        private System.Windows.Forms.Label New_Start_Time;
        private System.Windows.Forms.TextBox NewST_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TimeSlotID_Edit;
        private System.Windows.Forms.Label New_Worker_Name;
        private System.Windows.Forms.TextBox New_WN_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WorkerID_Edit;
        private System.Windows.Forms.Button Search_client_btn;
        private System.Windows.Forms.DataGridView Clients_table;
        private System.Windows.Forms.Button Edit_client_btn;
        private System.Windows.Forms.Button Delete_client_btn;
        private System.Windows.Forms.Button Load_clients_btn;
        private System.Windows.Forms.Button Add_client_btn;
        private System.Windows.Forms.Label New_client_payment_info_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label New_client_phone_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label New_client_address_label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label New_client_email_label;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Client_email_label;
        private System.Windows.Forms.TextBox Client_email_txt;
        private System.Windows.Forms.Label Client_name_label;
        private System.Windows.Forms.TextBox Client_name_txt;
        private System.Windows.Forms.Label Client_phone_label;
        private System.Windows.Forms.TextBox Client_phone_txt;
        private System.Windows.Forms.Label Client_address_label;
        private System.Windows.Forms.TextBox Client_address_txt;
        private System.Windows.Forms.Label Client_id_label;
        private System.Windows.Forms.TextBox Client_id_txt;
        private System.Windows.Forms.Label Client_payment_into_label;
        private System.Windows.Forms.TextBox Client_payment_info_txt;
        private Task_Worker_MatchingDataSet3 task_Worker_MatchingDataSet3;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private Task_Worker_MatchingDataSet3TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYMENTINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label New_client_name_label;
        private System.Windows.Forms.Label new_act_time_taken_label;
        private System.Windows.Forms.TextBox new_actual_time_taken_txt;
        private System.Windows.Forms.Label new_req_status_label;
        private System.Windows.Forms.TextBox new_request_status_txt;
        private System.Windows.Forms.Label new_pref_time_label;
        private System.Windows.Forms.TextBox new_preferred_time_slot_txt;
        private System.Windows.Forms.Label new_req_address_label;
        private System.Windows.Forms.TextBox new_request_address_txt;
        private System.Windows.Forms.Label new_taskId_label;
        private System.Windows.Forms.TextBox new_request_task_id_txt;
        private System.Windows.Forms.Label new_client_id_label;
        private System.Windows.Forms.TextBox new_request_client_id_txt;
        private System.Windows.Forms.Label new_req_time_label;
        private System.Windows.Forms.TextBox new_request_time_txt;
        private System.Windows.Forms.Label new_req_id_label;
        private System.Windows.Forms.TextBox new_request_id_txt;
        private System.Windows.Forms.Label act_time_taken_label;
        private System.Windows.Forms.TextBox actual_time_taken_txt;
        private System.Windows.Forms.Label request_status_label;
        private System.Windows.Forms.TextBox request_status_txt;
        private System.Windows.Forms.Label pref_time_slot_label;
        private System.Windows.Forms.TextBox preferred_time_slot_txt;
        private System.Windows.Forms.Button search_request_btn;
        private System.Windows.Forms.DataGridView Requests_table;
        private System.Windows.Forms.Button edit_request_btn;
        private System.Windows.Forms.Button delete_request_btn;
        private System.Windows.Forms.Button load_requests_btn;
        private System.Windows.Forms.Button add_request_btn;
        private System.Windows.Forms.Label request_addresss_label;
        private System.Windows.Forms.TextBox request_address_txt;
        private System.Windows.Forms.Label taskID_label;
        private System.Windows.Forms.TextBox request_task_id_txt;
        private System.Windows.Forms.Label clientID_label;
        private System.Windows.Forms.TextBox request_client_id_txt;
        private System.Windows.Forms.Label request_time_label;
        private System.Windows.Forms.TextBox request_time_txt;
        private System.Windows.Forms.Label requestID_label;
        private System.Windows.Forms.TextBox request_id_txt;
        private System.Windows.Forms.BindingSource taskWorkerMatchingDataSet4BindingSource;
        private Task_Worker_MatchingDataSet4 task_Worker_MatchingDataSet4;
    }
}

