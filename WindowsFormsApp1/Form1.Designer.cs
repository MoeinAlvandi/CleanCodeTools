namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_IRepositry = new System.Windows.Forms.TextBox();
            this.txt_Context = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Repository = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IService = new System.Windows.Forms.TextBox();
            this.txt_Service = new System.Windows.Forms.TextBox();
            this.txt_IOC_Service = new System.Windows.Forms.TextBox();
            this.txt_IOC_Repository = new System.Windows.Forms.TextBox();
            this.btn_Create_Repository = new System.Windows.Forms.Button();
            this.btn_Create_IService = new System.Windows.Forms.Button();
            this.btn_Create_Service = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_opendialog_Irepository = new System.Windows.Forms.Button();
            this.fbd_Irepository = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_Irepository_FolderPAth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_repository_FolderPAth = new System.Windows.Forms.TextBox();
            this.btn_opendialog_repository = new System.Windows.Forms.Button();
            this.fbd_repository = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_IserviceFolderPath = new System.Windows.Forms.TextBox();
            this.btn_opendialog_Iservice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fbd_IService = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_service_folderpath = new System.Windows.Forms.TextBox();
            this.btn_opendialog_service = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fbd_Service = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_messageIrepository = new System.Windows.Forms.Label();
            this.lbl_messageRepository = new System.Windows.Forms.Label();
            this.lbl_messageIService = new System.Windows.Forms.Label();
            this.lbl_messageService = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btn_Copy_Service = new System.Windows.Forms.Button();
            this.btn_Copy_IService = new System.Windows.Forms.Button();
            this.btn_Copy_Repository = new System.Windows.Forms.Button();
            this.btn_Create_IRepository = new System.Windows.Forms.Button();
            this.btn_copy_IRepository = new System.Windows.Forms.Button();
            this.chk_RepositoryTryCatch = new System.Windows.Forms.CheckBox();
            this.txt_repository_Catch_Code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_service_Catch_Code = new System.Windows.Forms.TextBox();
            this.chk_ServiceTryCatch = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Copy_IOCService = new System.Windows.Forms.Button();
            this.btn_Copy_IOCRepository = new System.Windows.Forms.Button();
            this.lbl_Message_IOC = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(18, 178);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(375, 20);
            this.txt_model.TabIndex = 0;
            this.txt_model.Text = "SwitchHard";
            this.txt_model.Leave += new System.EventHandler(this.txt_model_Leave);
            // 
            // txt_IRepositry
            // 
            this.txt_IRepositry.Location = new System.Drawing.Point(440, 48);
            this.txt_IRepositry.Multiline = true;
            this.txt_IRepositry.Name = "txt_IRepositry";
            this.txt_IRepositry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_IRepositry.Size = new System.Drawing.Size(618, 82);
            this.txt_IRepositry.TabIndex = 2;
            // 
            // txt_Context
            // 
            this.txt_Context.Location = new System.Drawing.Point(18, 139);
            this.txt_Context.Name = "txt_Context";
            this.txt_Context.Size = new System.Drawing.Size(375, 20);
            this.txt_Context.TabIndex = 3;
            this.txt_Context.Text = "FavaContext";
            this.txt_Context.Leave += new System.EventHandler(this.txt_Context_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Context";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repository Folder Path";
            // 
            // txt_Repository
            // 
            this.txt_Repository.Location = new System.Drawing.Point(440, 207);
            this.txt_Repository.Multiline = true;
            this.txt_Repository.Name = "txt_Repository";
            this.txt_Repository.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Repository.Size = new System.Drawing.Size(618, 107);
            this.txt_Repository.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(18, 231);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(375, 20);
            this.txt_id.TabIndex = 9;
            this.txt_id.Text = "SwitchID";
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Field ID Name";
            // 
            // txt_IService
            // 
            this.txt_IService.Location = new System.Drawing.Point(440, 405);
            this.txt_IService.Multiline = true;
            this.txt_IService.Name = "txt_IService";
            this.txt_IService.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_IService.Size = new System.Drawing.Size(618, 81);
            this.txt_IService.TabIndex = 11;
            // 
            // txt_Service
            // 
            this.txt_Service.Location = new System.Drawing.Point(440, 574);
            this.txt_Service.Multiline = true;
            this.txt_Service.Name = "txt_Service";
            this.txt_Service.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Service.Size = new System.Drawing.Size(618, 86);
            this.txt_Service.TabIndex = 13;
            // 
            // txt_IOC_Service
            // 
            this.txt_IOC_Service.Location = new System.Drawing.Point(18, 294);
            this.txt_IOC_Service.Name = "txt_IOC_Service";
            this.txt_IOC_Service.Size = new System.Drawing.Size(375, 20);
            this.txt_IOC_Service.TabIndex = 15;
            // 
            // txt_IOC_Repository
            // 
            this.txt_IOC_Repository.Location = new System.Drawing.Point(18, 333);
            this.txt_IOC_Repository.Name = "txt_IOC_Repository";
            this.txt_IOC_Repository.Size = new System.Drawing.Size(375, 20);
            this.txt_IOC_Repository.TabIndex = 16;
            this.txt_IOC_Repository.TextChanged += new System.EventHandler(this.txt_IOC_Repository_TextChanged);
            // 
            // btn_Create_Repository
            // 
            this.btn_Create_Repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create_Repository.Image = global::WindowsFormsApp1.Properties.Resources.add_plus_button;
            this.btn_Create_Repository.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create_Repository.Location = new System.Drawing.Point(440, 320);
            this.btn_Create_Repository.Name = "btn_Create_Repository";
            this.btn_Create_Repository.Size = new System.Drawing.Size(134, 23);
            this.btn_Create_Repository.TabIndex = 20;
            this.btn_Create_Repository.Text = "Create RepositoryFile";
            this.btn_Create_Repository.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Create_Repository.UseVisualStyleBackColor = true;
            this.btn_Create_Repository.Click += new System.EventHandler(this.btn_Create_Repository_Click);
            // 
            // btn_Create_IService
            // 
            this.btn_Create_IService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create_IService.Image = global::WindowsFormsApp1.Properties.Resources.add_plus_button;
            this.btn_Create_IService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create_IService.Location = new System.Drawing.Point(440, 492);
            this.btn_Create_IService.Name = "btn_Create_IService";
            this.btn_Create_IService.Size = new System.Drawing.Size(134, 23);
            this.btn_Create_IService.TabIndex = 22;
            this.btn_Create_IService.Text = "Create IServiceFile";
            this.btn_Create_IService.UseVisualStyleBackColor = true;
            this.btn_Create_IService.Click += new System.EventHandler(this.btn_Create_IService_Click);
            // 
            // btn_Create_Service
            // 
            this.btn_Create_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create_Service.Image = global::WindowsFormsApp1.Properties.Resources.add_plus_button;
            this.btn_Create_Service.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create_Service.Location = new System.Drawing.Point(440, 666);
            this.btn_Create_Service.Name = "btn_Create_Service";
            this.btn_Create_Service.Size = new System.Drawing.Size(134, 23);
            this.btn_Create_Service.TabIndex = 24;
            this.btn_Create_Service.Text = "Create ServiceFile";
            this.btn_Create_Service.UseVisualStyleBackColor = true;
            this.btn_Create_Service.Click += new System.EventHandler(this.btn_Create_Service_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "IOC.Service";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "IOC.Repository";
            // 
            // btn_opendialog_Irepository
            // 
            this.btn_opendialog_Irepository.Location = new System.Drawing.Point(1025, 22);
            this.btn_opendialog_Irepository.Name = "btn_opendialog_Irepository";
            this.btn_opendialog_Irepository.Size = new System.Drawing.Size(33, 23);
            this.btn_opendialog_Irepository.TabIndex = 29;
            this.btn_opendialog_Irepository.Text = "...";
            this.btn_opendialog_Irepository.UseVisualStyleBackColor = true;
            this.btn_opendialog_Irepository.Click += new System.EventHandler(this.btn_opendialog_Irepository_Click);
            // 
            // txt_Irepository_FolderPAth
            // 
            this.txt_Irepository_FolderPAth.Location = new System.Drawing.Point(440, 24);
            this.txt_Irepository_FolderPAth.Name = "txt_Irepository_FolderPAth";
            this.txt_Irepository_FolderPAth.Size = new System.Drawing.Size(579, 20);
            this.txt_Irepository_FolderPAth.TabIndex = 30;
            this.txt_Irepository_FolderPAth.TextChanged += new System.EventHandler(this.txt_Irepository_FolderPAth_TextChanged);
            this.txt_Irepository_FolderPAth.Leave += new System.EventHandler(this.txt_Irepository_FolderPAth_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "IRepository Folder Path";
            // 
            // txt_repository_FolderPAth
            // 
            this.txt_repository_FolderPAth.Location = new System.Drawing.Point(440, 181);
            this.txt_repository_FolderPAth.Name = "txt_repository_FolderPAth";
            this.txt_repository_FolderPAth.Size = new System.Drawing.Size(579, 20);
            this.txt_repository_FolderPAth.TabIndex = 33;
            this.txt_repository_FolderPAth.Leave += new System.EventHandler(this.txt_repository_FolderPAth_Leave);
            // 
            // btn_opendialog_repository
            // 
            this.btn_opendialog_repository.Location = new System.Drawing.Point(1025, 179);
            this.btn_opendialog_repository.Name = "btn_opendialog_repository";
            this.btn_opendialog_repository.Size = new System.Drawing.Size(33, 23);
            this.btn_opendialog_repository.TabIndex = 32;
            this.btn_opendialog_repository.Text = "...";
            this.btn_opendialog_repository.UseVisualStyleBackColor = true;
            this.btn_opendialog_repository.Click += new System.EventHandler(this.btn_opendialog_repository_Click);
            // 
            // txt_IserviceFolderPath
            // 
            this.txt_IserviceFolderPath.Location = new System.Drawing.Point(440, 379);
            this.txt_IserviceFolderPath.Name = "txt_IserviceFolderPath";
            this.txt_IserviceFolderPath.Size = new System.Drawing.Size(579, 20);
            this.txt_IserviceFolderPath.TabIndex = 36;
            this.txt_IserviceFolderPath.Leave += new System.EventHandler(this.txt_IserviceFolderPath_Leave);
            // 
            // btn_opendialog_Iservice
            // 
            this.btn_opendialog_Iservice.Location = new System.Drawing.Point(1025, 377);
            this.btn_opendialog_Iservice.Name = "btn_opendialog_Iservice";
            this.btn_opendialog_Iservice.Size = new System.Drawing.Size(33, 23);
            this.btn_opendialog_Iservice.TabIndex = 35;
            this.btn_opendialog_Iservice.Text = "...";
            this.btn_opendialog_Iservice.UseVisualStyleBackColor = true;
            this.btn_opendialog_Iservice.Click += new System.EventHandler(this.btn_opendialog_Iservice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "IService Folder Path";
            // 
            // txt_service_folderpath
            // 
            this.txt_service_folderpath.Location = new System.Drawing.Point(440, 548);
            this.txt_service_folderpath.Name = "txt_service_folderpath";
            this.txt_service_folderpath.Size = new System.Drawing.Size(579, 20);
            this.txt_service_folderpath.TabIndex = 39;
            this.txt_service_folderpath.Leave += new System.EventHandler(this.txt_service_folderpath_Leave);
            // 
            // btn_opendialog_service
            // 
            this.btn_opendialog_service.Location = new System.Drawing.Point(1025, 546);
            this.btn_opendialog_service.Name = "btn_opendialog_service";
            this.btn_opendialog_service.Size = new System.Drawing.Size(33, 23);
            this.btn_opendialog_service.TabIndex = 38;
            this.btn_opendialog_service.Text = "...";
            this.btn_opendialog_service.UseVisualStyleBackColor = true;
            this.btn_opendialog_service.Click += new System.EventHandler(this.btn_opendialog_service_Click);
            this.btn_opendialog_service.Leave += new System.EventHandler(this.btn_opendialog_service_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Service Folder Path";
            // 
            // lbl_messageIrepository
            // 
            this.lbl_messageIrepository.AutoSize = true;
            this.lbl_messageIrepository.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_messageIrepository.Location = new System.Drawing.Point(580, 136);
            this.lbl_messageIrepository.Name = "lbl_messageIrepository";
            this.lbl_messageIrepository.Size = new System.Drawing.Size(50, 13);
            this.lbl_messageIrepository.TabIndex = 40;
            this.lbl_messageIrepository.Text = "Message";
            // 
            // lbl_messageRepository
            // 
            this.lbl_messageRepository.AutoSize = true;
            this.lbl_messageRepository.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_messageRepository.Location = new System.Drawing.Point(580, 321);
            this.lbl_messageRepository.Name = "lbl_messageRepository";
            this.lbl_messageRepository.Size = new System.Drawing.Size(50, 13);
            this.lbl_messageRepository.TabIndex = 41;
            this.lbl_messageRepository.Text = "Message";
            this.lbl_messageRepository.Click += new System.EventHandler(this.lbl_messageRepository_Click);
            // 
            // lbl_messageIService
            // 
            this.lbl_messageIService.AutoSize = true;
            this.lbl_messageIService.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_messageIService.Location = new System.Drawing.Point(580, 497);
            this.lbl_messageIService.Name = "lbl_messageIService";
            this.lbl_messageIService.Size = new System.Drawing.Size(50, 13);
            this.lbl_messageIService.TabIndex = 42;
            this.lbl_messageIService.Text = "Message";
            // 
            // lbl_messageService
            // 
            this.lbl_messageService.AutoSize = true;
            this.lbl_messageService.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_messageService.Location = new System.Drawing.Point(580, 667);
            this.lbl_messageService.Name = "lbl_messageService";
            this.lbl_messageService.Size = new System.Drawing.Size(50, 13);
            this.lbl_messageService.TabIndex = 43;
            this.lbl_messageService.Text = "Message";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 54);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Lime;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripLabel1.RightToLeftAutoMirrorImage = true;
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 51);
            this.toolStripLabel1.Text = "Start";
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 51);
            this.toolStripLabel2.Text = "Clear All";
            this.toolStripLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(58, 51);
            this.toolStripLabel4.Text = "Create All";
            this.toolStripLabel4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // btn_Copy_Service
            // 
            this.btn_Copy_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy_Service.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_Copy_Service.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy_Service.Location = new System.Drawing.Point(958, 666);
            this.btn_Copy_Service.Name = "btn_Copy_Service";
            this.btn_Copy_Service.Size = new System.Drawing.Size(100, 23);
            this.btn_Copy_Service.TabIndex = 23;
            this.btn_Copy_Service.Text = "Copy";
            this.btn_Copy_Service.UseVisualStyleBackColor = true;
            this.btn_Copy_Service.Click += new System.EventHandler(this.btn_Copy_Service_Click);
            // 
            // btn_Copy_IService
            // 
            this.btn_Copy_IService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy_IService.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_Copy_IService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy_IService.Location = new System.Drawing.Point(958, 492);
            this.btn_Copy_IService.Name = "btn_Copy_IService";
            this.btn_Copy_IService.Size = new System.Drawing.Size(100, 23);
            this.btn_Copy_IService.TabIndex = 21;
            this.btn_Copy_IService.Text = "Copy";
            this.btn_Copy_IService.UseVisualStyleBackColor = true;
            this.btn_Copy_IService.Click += new System.EventHandler(this.btn_Copy_IService_Click);
            // 
            // btn_Copy_Repository
            // 
            this.btn_Copy_Repository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy_Repository.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_Copy_Repository.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy_Repository.Location = new System.Drawing.Point(958, 320);
            this.btn_Copy_Repository.Name = "btn_Copy_Repository";
            this.btn_Copy_Repository.Size = new System.Drawing.Size(100, 23);
            this.btn_Copy_Repository.TabIndex = 19;
            this.btn_Copy_Repository.Text = "Copy";
            this.btn_Copy_Repository.UseVisualStyleBackColor = true;
            this.btn_Copy_Repository.Click += new System.EventHandler(this.btn_Copy_Repository_Click);
            // 
            // btn_Create_IRepository
            // 
            this.btn_Create_IRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create_IRepository.Image = global::WindowsFormsApp1.Properties.Resources.add_plus_button;
            this.btn_Create_IRepository.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Create_IRepository.Location = new System.Drawing.Point(440, 136);
            this.btn_Create_IRepository.Name = "btn_Create_IRepository";
            this.btn_Create_IRepository.Size = new System.Drawing.Size(134, 23);
            this.btn_Create_IRepository.TabIndex = 18;
            this.btn_Create_IRepository.Text = "Create IRepositoryFile";
            this.btn_Create_IRepository.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Create_IRepository.UseVisualStyleBackColor = true;
            this.btn_Create_IRepository.Click += new System.EventHandler(this.btn_Create_IRepository_Click);
            // 
            // btn_copy_IRepository
            // 
            this.btn_copy_IRepository.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_copy_IRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy_IRepository.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_copy_IRepository.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_copy_IRepository.Location = new System.Drawing.Point(958, 136);
            this.btn_copy_IRepository.Name = "btn_copy_IRepository";
            this.btn_copy_IRepository.Size = new System.Drawing.Size(100, 23);
            this.btn_copy_IRepository.TabIndex = 17;
            this.btn_copy_IRepository.Text = "Copy";
            this.btn_copy_IRepository.UseVisualStyleBackColor = true;
            this.btn_copy_IRepository.Click += new System.EventHandler(this.btn_copy_IRepository_Click);
            // 
            // chk_RepositoryTryCatch
            // 
            this.chk_RepositoryTryCatch.AutoSize = true;
            this.chk_RepositoryTryCatch.Location = new System.Drawing.Point(18, 426);
            this.chk_RepositoryTryCatch.Name = "chk_RepositoryTryCatch";
            this.chk_RepositoryTryCatch.Size = new System.Drawing.Size(238, 17);
            this.chk_RepositoryTryCatch.TabIndex = 47;
            this.chk_RepositoryTryCatch.Text = "Generate Try/Catch Code in Repository File?";
            this.chk_RepositoryTryCatch.UseVisualStyleBackColor = true;
            this.chk_RepositoryTryCatch.CheckedChanged += new System.EventHandler(this.chk_RepositoryTryCatch_CheckedChanged);
            // 
            // txt_repository_Catch_Code
            // 
            this.txt_repository_Catch_Code.Enabled = false;
            this.txt_repository_Catch_Code.Location = new System.Drawing.Point(12, 473);
            this.txt_repository_Catch_Code.Multiline = true;
            this.txt_repository_Catch_Code.Name = "txt_repository_Catch_Code";
            this.txt_repository_Catch_Code.Size = new System.Drawing.Size(375, 72);
            this.txt_repository_Catch_Code.TabIndex = 48;
            this.txt_repository_Catch_Code.Text = "Console.WriteLine(ex.ToString());";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "When Your Code Is Crash This Code Run in Repository File";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "When Your Code Is Crash This Code Run in Service File";
            // 
            // txt_service_Catch_Code
            // 
            this.txt_service_Catch_Code.Enabled = false;
            this.txt_service_Catch_Code.Location = new System.Drawing.Point(12, 612);
            this.txt_service_Catch_Code.Multiline = true;
            this.txt_service_Catch_Code.Name = "txt_service_Catch_Code";
            this.txt_service_Catch_Code.Size = new System.Drawing.Size(375, 72);
            this.txt_service_Catch_Code.TabIndex = 51;
            this.txt_service_Catch_Code.Text = "MessageBox.Show(ex.ToString());";
            // 
            // chk_ServiceTryCatch
            // 
            this.chk_ServiceTryCatch.AutoSize = true;
            this.chk_ServiceTryCatch.Location = new System.Drawing.Point(15, 576);
            this.chk_ServiceTryCatch.Name = "chk_ServiceTryCatch";
            this.chk_ServiceTryCatch.Size = new System.Drawing.Size(224, 17);
            this.chk_ServiceTryCatch.TabIndex = 50;
            this.chk_ServiceTryCatch.Text = "Generate Try/Catch Code in Service File?";
            this.chk_ServiceTryCatch.UseVisualStyleBackColor = true;
            this.chk_ServiceTryCatch.CheckedChanged += new System.EventHandler(this.chk_ServiceTryCatch_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "ProjectName";
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(15, 71);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(375, 20);
            this.txt_ProjectName.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 12);
            this.label13.TabIndex = 55;
            this.label13.Text = "namespace YourProjectName.Core.Service";
            // 
            // btn_Copy_IOCService
            // 
            this.btn_Copy_IOCService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy_IOCService.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_Copy_IOCService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy_IOCService.Location = new System.Drawing.Point(399, 291);
            this.btn_Copy_IOCService.Name = "btn_Copy_IOCService";
            this.btn_Copy_IOCService.Size = new System.Drawing.Size(23, 23);
            this.btn_Copy_IOCService.TabIndex = 56;
            this.btn_Copy_IOCService.UseVisualStyleBackColor = true;
            this.btn_Copy_IOCService.Click += new System.EventHandler(this.btn_Copy_IOCService_Click);
            // 
            // btn_Copy_IOCRepository
            // 
            this.btn_Copy_IOCRepository.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy_IOCRepository.Image = global::WindowsFormsApp1.Properties.Resources.copy_content21;
            this.btn_Copy_IOCRepository.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy_IOCRepository.Location = new System.Drawing.Point(399, 331);
            this.btn_Copy_IOCRepository.Name = "btn_Copy_IOCRepository";
            this.btn_Copy_IOCRepository.Size = new System.Drawing.Size(23, 23);
            this.btn_Copy_IOCRepository.TabIndex = 57;
            this.btn_Copy_IOCRepository.UseVisualStyleBackColor = true;
            this.btn_Copy_IOCRepository.Click += new System.EventHandler(this.btn_Copy_IOCRepository_Click);
            // 
            // lbl_Message_IOC
            // 
            this.lbl_Message_IOC.AutoSize = true;
            this.lbl_Message_IOC.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Message_IOC.Location = new System.Drawing.Point(15, 363);
            this.lbl_Message_IOC.Name = "lbl_Message_IOC";
            this.lbl_Message_IOC.Size = new System.Drawing.Size(50, 13);
            this.lbl_Message_IOC.TabIndex = 58;
            this.lbl_Message_IOC.Text = "Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 720);
            this.Controls.Add(this.lbl_Message_IOC);
            this.Controls.Add(this.btn_Copy_IOCRepository);
            this.Controls.Add(this.btn_Copy_IOCService);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_ProjectName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_service_Catch_Code);
            this.Controls.Add(this.chk_ServiceTryCatch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_repository_Catch_Code);
            this.Controls.Add(this.chk_RepositoryTryCatch);
            this.Controls.Add(this.lbl_messageService);
            this.Controls.Add(this.lbl_messageIService);
            this.Controls.Add(this.lbl_messageRepository);
            this.Controls.Add(this.lbl_messageIrepository);
            this.Controls.Add(this.txt_service_folderpath);
            this.Controls.Add(this.btn_opendialog_service);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_IserviceFolderPath);
            this.Controls.Add(this.btn_opendialog_Iservice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_repository_FolderPAth);
            this.Controls.Add(this.btn_opendialog_repository);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Irepository_FolderPAth);
            this.Controls.Add(this.btn_opendialog_Irepository);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Create_Service);
            this.Controls.Add(this.btn_Copy_Service);
            this.Controls.Add(this.btn_Create_IService);
            this.Controls.Add(this.btn_Copy_IService);
            this.Controls.Add(this.btn_Create_Repository);
            this.Controls.Add(this.btn_Copy_Repository);
            this.Controls.Add(this.btn_Create_IRepository);
            this.Controls.Add(this.btn_copy_IRepository);
            this.Controls.Add(this.txt_IOC_Repository);
            this.Controls.Add(this.txt_IOC_Service);
            this.Controls.Add(this.txt_Service);
            this.Controls.Add(this.txt_IService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Repository);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Context);
            this.Controls.Add(this.txt_IRepositry);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_IRepositry;
        private System.Windows.Forms.TextBox txt_Context;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Repository;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IService;
        private System.Windows.Forms.TextBox txt_Service;
        private System.Windows.Forms.TextBox txt_IOC_Service;
        private System.Windows.Forms.TextBox txt_IOC_Repository;
        private System.Windows.Forms.Button btn_Create_IRepository;
        private System.Windows.Forms.Button btn_Create_Repository;
        private System.Windows.Forms.Button btn_Copy_Repository;
        private System.Windows.Forms.Button btn_Create_IService;
        private System.Windows.Forms.Button btn_Copy_IService;
        private System.Windows.Forms.Button btn_Create_Service;
        private System.Windows.Forms.Button btn_Copy_Service;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_opendialog_Irepository;
        private System.Windows.Forms.FolderBrowserDialog fbd_Irepository;
        private System.Windows.Forms.TextBox txt_Irepository_FolderPAth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_repository_FolderPAth;
        private System.Windows.Forms.Button btn_opendialog_repository;
        private System.Windows.Forms.FolderBrowserDialog fbd_repository;
        private System.Windows.Forms.TextBox txt_IserviceFolderPath;
        private System.Windows.Forms.Button btn_opendialog_Iservice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbd_IService;
        private System.Windows.Forms.TextBox txt_service_folderpath;
        private System.Windows.Forms.Button btn_opendialog_service;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog fbd_Service;
        private System.Windows.Forms.Label lbl_messageIrepository;
        private System.Windows.Forms.Label lbl_messageRepository;
        private System.Windows.Forms.Label lbl_messageIService;
        private System.Windows.Forms.Label lbl_messageService;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btn_copy_IRepository;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.CheckBox chk_RepositoryTryCatch;
        private System.Windows.Forms.TextBox txt_repository_Catch_Code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_service_Catch_Code;
        private System.Windows.Forms.CheckBox chk_ServiceTryCatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Copy_IOCService;
        private System.Windows.Forms.Button btn_Copy_IOCRepository;
        private System.Windows.Forms.Label lbl_Message_IOC;
    }
}

