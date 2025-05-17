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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.Top_rated_workers_table = new System.Windows.Forms.DataGridView();
            this.Worker_location_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Requests_panel = new System.Windows.Forms.Panel();
            this.Workers_panel = new System.Windows.Forms.Panel();
            this.Clients_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.task_Worker_MatchingDataSet1 = new Tawfiq.Task_Worker_MatchingDataSet1();
            this.rEQUESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEQUESTTableAdapter = new Tawfiq.Task_Worker_MatchingDataSet1TableAdapters.REQUESTTableAdapter();
            this.Side_panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo_picbox)).BeginInit();
            this.Tasks_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet)).BeginInit();
            this.Overview_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top_rated_workers_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worker_location_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).BeginInit();
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
            this.Side_panel.Size = new System.Drawing.Size(300, 712);
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
            this.Tasks_panel.Size = new System.Drawing.Size(1312, 712);
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
            this.Overview_panel.Controls.Add(this.dataGridView1);
            this.Overview_panel.Controls.Add(this.Top_rated_workers_table);
            this.Overview_panel.Controls.Add(this.Worker_location_chart);
            this.Overview_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Overview_panel.Location = new System.Drawing.Point(300, 0);
            this.Overview_panel.Name = "Overview_panel";
            this.Overview_panel.Size = new System.Drawing.Size(1312, 712);
            this.Overview_panel.TabIndex = 42;
            this.Overview_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Overview_panel_Paint);
            // 
            // Top_rated_workers_table
            // 
            this.Top_rated_workers_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top_rated_workers_table.Location = new System.Drawing.Point(671, 195);
            this.Top_rated_workers_table.Name = "Top_rated_workers_table";
            this.Top_rated_workers_table.Size = new System.Drawing.Size(555, 323);
            this.Top_rated_workers_table.TabIndex = 3;
            // 
            // Worker_location_chart
            // 
            chartArea11.Name = "ChartArea1";
            this.Worker_location_chart.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.Worker_location_chart.Legends.Add(legend11);
            this.Worker_location_chart.Location = new System.Drawing.Point(87, 195);
            this.Worker_location_chart.Name = "Worker_location_chart";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.Worker_location_chart.Series.Add(series11);
            this.Worker_location_chart.Size = new System.Drawing.Size(474, 323);
            this.Worker_location_chart.TabIndex = 2;
            this.Worker_location_chart.Text = "chart1";
            // 
            // Requests_panel
            // 
            this.Requests_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Requests_panel.Location = new System.Drawing.Point(300, 0);
            this.Requests_panel.Name = "Requests_panel";
            this.Requests_panel.Size = new System.Drawing.Size(1312, 712);
            this.Requests_panel.TabIndex = 42;
            // 
            // Workers_panel
            // 
            this.Workers_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workers_panel.Location = new System.Drawing.Point(300, 0);
            this.Workers_panel.Name = "Workers_panel";
            this.Workers_panel.Size = new System.Drawing.Size(1312, 712);
            this.Workers_panel.TabIndex = 43;
            // 
            // Clients_panel
            // 
            this.Clients_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clients_panel.Location = new System.Drawing.Point(300, 0);
            this.Clients_panel.Name = "Clients_panel";
            this.Clients_panel.Size = new System.Drawing.Size(1312, 712);
            this.Clients_panel.TabIndex = 44;
            this.Clients_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Clients_panel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // task_Worker_MatchingDataSet1
            // 
            this.task_Worker_MatchingDataSet1.DataSetName = "Task_Worker_MatchingDataSet1";
            this.task_Worker_MatchingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEQUESTBindingSource
            // 
            this.rEQUESTBindingSource.DataMember = "REQUEST";
            this.rEQUESTBindingSource.DataSource = this.task_Worker_MatchingDataSet1;
            // 
            // rEQUESTTableAdapter
            // 
            this.rEQUESTTableAdapter.ClearBeforeFill = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1612, 712);
            this.Controls.Add(this.Requests_panel);
            this.Controls.Add(this.Tasks_panel);
            this.Controls.Add(this.Overview_panel);
            this.Controls.Add(this.Clients_panel);
            this.Controls.Add(this.Workers_panel);
            this.Controls.Add(this.Side_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.Top_rated_workers_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worker_location_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEQUESTBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView Top_rated_workers_table;
        private System.Windows.Forms.DataVisualization.Charting.Chart Worker_location_chart;
        private System.Windows.Forms.Panel Requests_panel;
        private System.Windows.Forms.Panel Workers_panel;
        private System.Windows.Forms.Panel Clients_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Task_Worker_MatchingDataSet1 task_Worker_MatchingDataSet1;
        private System.Windows.Forms.BindingSource rEQUESTBindingSource;
        private Task_Worker_MatchingDataSet1TableAdapters.REQUESTTableAdapter rEQUESTTableAdapter;
    }
}

