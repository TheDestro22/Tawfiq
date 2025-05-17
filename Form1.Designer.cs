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
            this.Side_panel = new System.Windows.Forms.Panel();
            this.Clients_btn = new System.Windows.Forms.Button();
            this.Workers_btn = new System.Windows.Forms.Button();
            this.Requests_btn = new System.Windows.Forms.Button();
            this.Tasks_btn = new System.Windows.Forms.Button();
            this.Overview_btn = new System.Windows.Forms.Button();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Main_logo_picbox = new System.Windows.Forms.PictureBox();
            this.Tasks_panel = new System.Windows.Forms.Panel();
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
            this.edit_task_btn = new System.Windows.Forms.Button();
            this.delete_task_btn = new System.Windows.Forms.Button();
            this.load_tasks_btn = new System.Windows.Forms.Button();
            this.add_task_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.task_Worker_MatchingDataSet = new Tawfiq.Task_Worker_MatchingDataSet();
            this.tASKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tASKTableAdapter = new Tawfiq.Task_Worker_MatchingDataSetTableAdapters.TASKTableAdapter();
            this.tASKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side_panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_logo_picbox)).BeginInit();
            this.Tasks_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).BeginInit();
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
            this.Side_panel.Size = new System.Drawing.Size(300, 800);
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
            this.Tasks_panel.Controls.Add(this.dataGridView1);
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
            this.Tasks_panel.Size = new System.Drawing.Size(1280, 800);
            this.Tasks_panel.TabIndex = 2;
            // 
            // average_fee_btn
            // 
            this.average_fee_btn.AutoSize = true;
            this.average_fee_btn.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_fee_btn.Location = new System.Drawing.Point(35, 350);
            this.average_fee_btn.Name = "average_fee_btn";
            this.average_fee_btn.Size = new System.Drawing.Size(104, 21);
            this.average_fee_btn.TabIndex = 25;
            this.average_fee_btn.Text = "Average Fee";
            // 
            // average_fee_txt
            // 
            this.average_fee_txt.Location = new System.Drawing.Point(157, 353);
            this.average_fee_txt.Multiline = true;
            this.average_fee_txt.Name = "average_fee_txt";
            this.average_fee_txt.Size = new System.Drawing.Size(191, 20);
            this.average_fee_txt.TabIndex = 24;
            // 
            // task_name_label
            // 
            this.task_name_label.AutoSize = true;
            this.task_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_name_label.Location = new System.Drawing.Point(35, 185);
            this.task_name_label.Name = "task_name_label";
            this.task_name_label.Size = new System.Drawing.Size(97, 21);
            this.task_name_label.TabIndex = 23;
            this.task_name_label.Text = "Task Name";
            // 
            // task_name_txt
            // 
            this.task_name_txt.Location = new System.Drawing.Point(148, 185);
            this.task_name_txt.Multiline = true;
            this.task_name_txt.Name = "task_name_txt";
            this.task_name_txt.Size = new System.Drawing.Size(200, 20);
            this.task_name_txt.TabIndex = 22;
            // 
            // required_speciality_label
            // 
            this.required_speciality_label.AutoSize = true;
            this.required_speciality_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.required_speciality_label.Location = new System.Drawing.Point(35, 240);
            this.required_speciality_label.Name = "required_speciality_label";
            this.required_speciality_label.Size = new System.Drawing.Size(162, 21);
            this.required_speciality_label.TabIndex = 21;
            this.required_speciality_label.Text = "Required Speciality";
            // 
            // required_speciality_txt
            // 
            this.required_speciality_txt.Location = new System.Drawing.Point(203, 240);
            this.required_speciality_txt.Multiline = true;
            this.required_speciality_txt.Name = "required_speciality_txt";
            this.required_speciality_txt.Size = new System.Drawing.Size(145, 20);
            this.required_speciality_txt.TabIndex = 20;
            // 
            // average_time_label
            // 
            this.average_time_label.AutoSize = true;
            this.average_time_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_time_label.Location = new System.Drawing.Point(35, 294);
            this.average_time_label.Name = "average_time_label";
            this.average_time_label.Size = new System.Drawing.Size(116, 21);
            this.average_time_label.TabIndex = 19;
            this.average_time_label.Text = "Average Time";
            // 
            // average_time_txt
            // 
            this.average_time_txt.Location = new System.Drawing.Point(157, 295);
            this.average_time_txt.Multiline = true;
            this.average_time_txt.Name = "average_time_txt";
            this.average_time_txt.Size = new System.Drawing.Size(191, 20);
            this.average_time_txt.TabIndex = 18;
            // 
            // task_id_label
            // 
            this.task_id_label.AutoSize = true;
            this.task_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_id_label.Location = new System.Drawing.Point(35, 119);
            this.task_id_label.Name = "task_id_label";
            this.task_id_label.Size = new System.Drawing.Size(75, 21);
            this.task_id_label.TabIndex = 17;
            this.task_id_label.Text = "Task ID";
            // 
            // task_id_txt
            // 
            this.task_id_txt.Location = new System.Drawing.Point(148, 119);
            this.task_id_txt.Multiline = true;
            this.task_id_txt.Name = "task_id_txt";
            this.task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.task_id_txt.TabIndex = 16;
            // 
            // new_average_fee
            // 
            this.new_average_fee.AutoSize = true;
            this.new_average_fee.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_average_fee.Location = new System.Drawing.Point(420, 350);
            this.new_average_fee.Name = "new_average_fee";
            this.new_average_fee.Size = new System.Drawing.Size(142, 21);
            this.new_average_fee.TabIndex = 35;
            this.new_average_fee.Text = "New Average Fee";
            // 
            // new_average_fee_txt
            // 
            this.new_average_fee_txt.Location = new System.Drawing.Point(578, 351);
            this.new_average_fee_txt.Multiline = true;
            this.new_average_fee_txt.Name = "new_average_fee_txt";
            this.new_average_fee_txt.Size = new System.Drawing.Size(183, 20);
            this.new_average_fee_txt.TabIndex = 34;
            // 
            // new_task_name_label
            // 
            this.new_task_name_label.AutoSize = true;
            this.new_task_name_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_task_name_label.Location = new System.Drawing.Point(420, 185);
            this.new_task_name_label.Name = "new_task_name_label";
            this.new_task_name_label.Size = new System.Drawing.Size(135, 21);
            this.new_task_name_label.TabIndex = 33;
            this.new_task_name_label.Text = "New Task Name";
            // 
            // new_task_name_txt
            // 
            this.new_task_name_txt.Location = new System.Drawing.Point(561, 185);
            this.new_task_name_txt.Multiline = true;
            this.new_task_name_txt.Name = "new_task_name_txt";
            this.new_task_name_txt.Size = new System.Drawing.Size(200, 20);
            this.new_task_name_txt.TabIndex = 32;
            // 
            // new_required_speciality_label
            // 
            this.new_required_speciality_label.AutoSize = true;
            this.new_required_speciality_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_required_speciality_label.Location = new System.Drawing.Point(420, 240);
            this.new_required_speciality_label.Name = "new_required_speciality_label";
            this.new_required_speciality_label.Size = new System.Drawing.Size(200, 21);
            this.new_required_speciality_label.TabIndex = 31;
            this.new_required_speciality_label.Text = "New Required Speciality";
            // 
            // new_required_speciality_txt
            // 
            this.new_required_speciality_txt.Location = new System.Drawing.Point(636, 241);
            this.new_required_speciality_txt.Multiline = true;
            this.new_required_speciality_txt.Name = "new_required_speciality_txt";
            this.new_required_speciality_txt.Size = new System.Drawing.Size(125, 20);
            this.new_required_speciality_txt.TabIndex = 30;
            // 
            // new_average_time
            // 
            this.new_average_time.AutoSize = true;
            this.new_average_time.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_average_time.Location = new System.Drawing.Point(420, 294);
            this.new_average_time.Name = "new_average_time";
            this.new_average_time.Size = new System.Drawing.Size(154, 21);
            this.new_average_time.TabIndex = 29;
            this.new_average_time.Text = "New Average Time";
            // 
            // new_average_time_txt
            // 
            this.new_average_time_txt.Location = new System.Drawing.Point(589, 297);
            this.new_average_time_txt.Multiline = true;
            this.new_average_time_txt.Name = "new_average_time_txt";
            this.new_average_time_txt.Size = new System.Drawing.Size(172, 20);
            this.new_average_time_txt.TabIndex = 28;
            // 
            // new_task_id_label
            // 
            this.new_task_id_label.AutoSize = true;
            this.new_task_id_label.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_task_id_label.Location = new System.Drawing.Point(420, 119);
            this.new_task_id_label.Name = "new_task_id_label";
            this.new_task_id_label.Size = new System.Drawing.Size(113, 21);
            this.new_task_id_label.TabIndex = 27;
            this.new_task_id_label.Text = "New Task ID";
            // 
            // new_task_id_txt
            // 
            this.new_task_id_txt.Location = new System.Drawing.Point(561, 122);
            this.new_task_id_txt.Multiline = true;
            this.new_task_id_txt.Name = "new_task_id_txt";
            this.new_task_id_txt.Size = new System.Drawing.Size(200, 20);
            this.new_task_id_txt.TabIndex = 26;
            // 
            // edit_task_btn
            // 
            this.edit_task_btn.FlatAppearance.BorderSize = 0;
            this.edit_task_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_task_btn.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_task_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.edit_task_btn.Location = new System.Drawing.Point(424, 392);
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
            this.delete_task_btn.Location = new System.Drawing.Point(39, 500);
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
            this.load_tasks_btn.Location = new System.Drawing.Point(424, 500);
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
            this.add_task_btn.Location = new System.Drawing.Point(39, 392);
            this.add_task_btn.Name = "add_task_btn";
            this.add_task_btn.Size = new System.Drawing.Size(309, 102);
            this.add_task_btn.TabIndex = 36;
            this.add_task_btn.Text = "Add Task";
            this.add_task_btn.UseVisualStyleBackColor = false;
            this.add_task_btn.Click += new System.EventHandler(this.add_task_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tASKIDDataGridViewTextBoxColumn,
            this.tASKNAMEDataGridViewTextBoxColumn,
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn,
            this.aVERAGETIMEDataGridViewTextBoxColumn,
            this.aVERAGEFEEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tASKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(791, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 666);
            this.dataGridView1.TabIndex = 40;
            // 
            // task_Worker_MatchingDataSet
            // 
            this.task_Worker_MatchingDataSet.DataSetName = "Task_Worker_MatchingDataSet";
            this.task_Worker_MatchingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tASKBindingSource
            // 
            this.tASKBindingSource.DataMember = "TASK";
            this.tASKBindingSource.DataSource = this.task_Worker_MatchingDataSet;
            // 
            // tASKTableAdapter
            // 
            this.tASKTableAdapter.ClearBeforeFill = true;
            // 
            // tASKIDDataGridViewTextBoxColumn
            // 
            this.tASKIDDataGridViewTextBoxColumn.DataPropertyName = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.HeaderText = "TASK_ID";
            this.tASKIDDataGridViewTextBoxColumn.Name = "tASKIDDataGridViewTextBoxColumn";
            // 
            // tASKNAMEDataGridViewTextBoxColumn
            // 
            this.tASKNAMEDataGridViewTextBoxColumn.DataPropertyName = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.HeaderText = "TASK_NAME";
            this.tASKNAMEDataGridViewTextBoxColumn.Name = "tASKNAMEDataGridViewTextBoxColumn";
            // 
            // rEQUIREDSPECIALITYDataGridViewTextBoxColumn
            // 
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.DataPropertyName = "REQUIRED_SPECIALITY";
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.HeaderText = "REQUIRED_SPECIALITY";
            this.rEQUIREDSPECIALITYDataGridViewTextBoxColumn.Name = "rEQUIREDSPECIALITYDataGridViewTextBoxColumn";
            // 
            // aVERAGETIMEDataGridViewTextBoxColumn
            // 
            this.aVERAGETIMEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE_TIME";
            this.aVERAGETIMEDataGridViewTextBoxColumn.HeaderText = "AVERAGE_TIME";
            this.aVERAGETIMEDataGridViewTextBoxColumn.Name = "aVERAGETIMEDataGridViewTextBoxColumn";
            // 
            // aVERAGEFEEDataGridViewTextBoxColumn
            // 
            this.aVERAGEFEEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE_FEE";
            this.aVERAGEFEEDataGridViewTextBoxColumn.HeaderText = "AVERAGE_FEE";
            this.aVERAGEFEEDataGridViewTextBoxColumn.Name = "aVERAGEFEEDataGridViewTextBoxColumn";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1580, 800);
            this.Controls.Add(this.Tasks_panel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_Worker_MatchingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASKBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private Task_Worker_MatchingDataSet task_Worker_MatchingDataSet;
        private System.Windows.Forms.BindingSource tASKBindingSource;
        private Task_Worker_MatchingDataSetTableAdapters.TASKTableAdapter tASKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUIREDSPECIALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEFEEDataGridViewTextBoxColumn;
    }
}

