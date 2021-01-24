namespace Projekat_Bioskop
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.addMovieTabPage = new System.Windows.Forms.TabPage();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.producerTextBox = new System.Windows.Forms.TextBox();
            this.screenPlayTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.runningTimeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.screenPlayLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addMovieNoteLabel = new System.Windows.Forms.Label();
            this.showingsTabPage = new System.Windows.Forms.TabPage();
            this.showingsNoteLabel = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.endOfShowingsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startOfShowingsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endOfShowingsLabel = new System.Windows.Forms.Label();
            this.startOfShowingsLabel = new System.Windows.Forms.Label();
            this.selectMovieComboBox = new System.Windows.Forms.ComboBox();
            this.fILMOVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIOSKOPDataSet = new Projekat_Bioskop.BIOSKOPDataSet();
            this.selectMovieLabel = new System.Windows.Forms.Label();
            this.addUserTabPage = new System.Windows.Forms.TabPage();
            this.addUserNoteLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addWorkerTabPage = new System.Windows.Forms.TabPage();
            this.fireWorkerButton = new System.Windows.Forms.Button();
            this.workerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.workerUsernameLabel = new System.Windows.Forms.Label();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.workStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workStartLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addWorkerLabel = new System.Windows.Forms.Label();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.loadReportIDLabel = new System.Windows.Forms.Label();
            this.reportIDLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.greskaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisgreskeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gREŠKEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bIOSKOPDataSet1 = new Projekat_Bioskop.BIOSKOPDataSet1();
            this.fILMOVITableAdapter = new Projekat_Bioskop.BIOSKOPDataSetTableAdapters.FILMOVITableAdapter();
            this.gREŠKETableAdapter = new Projekat_Bioskop.BIOSKOPDataSet1TableAdapters.GREŠKETableAdapter();
            this.adminTabControl.SuspendLayout();
            this.addMovieTabPage.SuspendLayout();
            this.showingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fILMOVIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet)).BeginInit();
            this.addUserTabPage.SuspendLayout();
            this.addWorkerTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gREŠKEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.addMovieTabPage);
            this.adminTabControl.Controls.Add(this.showingsTabPage);
            this.adminTabControl.Controls.Add(this.addUserTabPage);
            this.adminTabControl.Controls.Add(this.addWorkerTabPage);
            this.adminTabControl.Controls.Add(this.reportsTabPage);
            this.adminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabControl.Location = new System.Drawing.Point(0, 0);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(464, 420);
            this.adminTabControl.TabIndex = 0;
            // 
            // addMovieTabPage
            // 
            this.addMovieTabPage.Controls.Add(this.addMovieButton);
            this.addMovieTabPage.Controls.Add(this.languageTextBox);
            this.addMovieTabPage.Controls.Add(this.countryTextBox);
            this.addMovieTabPage.Controls.Add(this.producerTextBox);
            this.addMovieTabPage.Controls.Add(this.screenPlayTextBox);
            this.addMovieTabPage.Controls.Add(this.directorTextBox);
            this.addMovieTabPage.Controls.Add(this.runningTimeTextBox);
            this.addMovieTabPage.Controls.Add(this.yearTextBox);
            this.addMovieTabPage.Controls.Add(this.languageLabel);
            this.addMovieTabPage.Controls.Add(this.producerLabel);
            this.addMovieTabPage.Controls.Add(this.countryLabel);
            this.addMovieTabPage.Controls.Add(this.genreComboBox);
            this.addMovieTabPage.Controls.Add(this.screenPlayLabel);
            this.addMovieTabPage.Controls.Add(this.genreLabel);
            this.addMovieTabPage.Controls.Add(this.yearLabel);
            this.addMovieTabPage.Controls.Add(this.runningTimeLabel);
            this.addMovieTabPage.Controls.Add(this.directorLabel);
            this.addMovieTabPage.Controls.Add(this.titleTextBox);
            this.addMovieTabPage.Controls.Add(this.titleLabel);
            this.addMovieTabPage.Controls.Add(this.addMovieNoteLabel);
            this.addMovieTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addMovieTabPage.Location = new System.Drawing.Point(4, 22);
            this.addMovieTabPage.Name = "addMovieTabPage";
            this.addMovieTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addMovieTabPage.Size = new System.Drawing.Size(456, 394);
            this.addMovieTabPage.TabIndex = 0;
            this.addMovieTabPage.Text = "Dodaj film";
            this.addMovieTabPage.UseVisualStyleBackColor = true;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(185, 340);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(100, 30);
            this.addMovieButton.TabIndex = 10;
            this.addMovieButton.Text = "Dodaj";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(110, 297);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(250, 20);
            this.languageTextBox.TabIndex = 9;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(110, 267);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(250, 20);
            this.countryTextBox.TabIndex = 8;
            // 
            // producerTextBox
            // 
            this.producerTextBox.Location = new System.Drawing.Point(110, 237);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(250, 20);
            this.producerTextBox.TabIndex = 7;
            // 
            // screenPlayTextBox
            // 
            this.screenPlayTextBox.Location = new System.Drawing.Point(110, 207);
            this.screenPlayTextBox.Name = "screenPlayTextBox";
            this.screenPlayTextBox.Size = new System.Drawing.Size(250, 20);
            this.screenPlayTextBox.TabIndex = 6;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(110, 177);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(250, 20);
            this.directorTextBox.TabIndex = 5;
            // 
            // runningTimeTextBox
            // 
            this.runningTimeTextBox.Location = new System.Drawing.Point(110, 147);
            this.runningTimeTextBox.Name = "runningTimeTextBox";
            this.runningTimeTextBox.Size = new System.Drawing.Size(250, 20);
            this.runningTimeTextBox.TabIndex = 4;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(110, 117);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(250, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(10, 300);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(31, 13);
            this.languageLabel.TabIndex = 9;
            this.languageLabel.Text = "Jezik";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Location = new System.Drawing.Point(10, 240);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(56, 13);
            this.producerLabel.TabIndex = 7;
            this.producerLabel.Text = "Producent";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(10, 270);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(38, 13);
            this.countryLabel.TabIndex = 8;
            this.countryLabel.Text = "Zemlja";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "avantura",
            "animacija",
            "akcija",
            "biografski",
            "vestern",
            "dokumentarni",
            "drama",
            "istorijski",
            "komedija",
            "kriminalistički",
            "ljubavni",
            "misterija",
            "mjuzikl",
            "naučno-fantastični",
            "porodični",
            "ratni",
            "sportski",
            "triler",
            "horor"});
            this.genreComboBox.Location = new System.Drawing.Point(110, 87);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(250, 21);
            this.genreComboBox.TabIndex = 2;
            // 
            // screenPlayLabel
            // 
            this.screenPlayLabel.AutoSize = true;
            this.screenPlayLabel.Location = new System.Drawing.Point(10, 210);
            this.screenPlayLabel.Name = "screenPlayLabel";
            this.screenPlayLabel.Size = new System.Drawing.Size(49, 13);
            this.screenPlayLabel.TabIndex = 6;
            this.screenPlayLabel.Text = "Scenario";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(10, 90);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(29, 13);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Žanr";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(10, 120);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(77, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Godina izdanja";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(10, 150);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(45, 13);
            this.runningTimeLabel.TabIndex = 4;
            this.runningTimeLabel.Text = "Trajanje";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(10, 180);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(36, 13);
            this.directorLabel.TabIndex = 5;
            this.directorLabel.Text = "Režija";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(110, 53);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(250, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(10, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(40, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Naslov";
            // 
            // addMovieNoteLabel
            // 
            this.addMovieNoteLabel.AutoSize = true;
            this.addMovieNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieNoteLabel.Location = new System.Drawing.Point(10, 15);
            this.addMovieNoteLabel.Name = "addMovieNoteLabel";
            this.addMovieNoteLabel.Size = new System.Drawing.Size(151, 16);
            this.addMovieNoteLabel.TabIndex = 0;
            this.addMovieNoteLabel.Text = "Unesite podatke o filmu:";
            // 
            // showingsTabPage
            // 
            this.showingsTabPage.Controls.Add(this.showingsNoteLabel);
            this.showingsTabPage.Controls.Add(this.endButton);
            this.showingsTabPage.Controls.Add(this.startButton);
            this.showingsTabPage.Controls.Add(this.endOfShowingsDateTimePicker);
            this.showingsTabPage.Controls.Add(this.startOfShowingsDateTimePicker);
            this.showingsTabPage.Controls.Add(this.endOfShowingsLabel);
            this.showingsTabPage.Controls.Add(this.startOfShowingsLabel);
            this.showingsTabPage.Controls.Add(this.selectMovieComboBox);
            this.showingsTabPage.Controls.Add(this.selectMovieLabel);
            this.showingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.showingsTabPage.Name = "showingsTabPage";
            this.showingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.showingsTabPage.Size = new System.Drawing.Size(456, 394);
            this.showingsTabPage.TabIndex = 1;
            this.showingsTabPage.Text = "Prikazivanja";
            this.showingsTabPage.UseVisualStyleBackColor = true;
            // 
            // showingsNoteLabel
            // 
            this.showingsNoteLabel.AutoSize = true;
            this.showingsNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showingsNoteLabel.Location = new System.Drawing.Point(10, 15);
            this.showingsNoteLabel.Name = "showingsNoteLabel";
            this.showingsNoteLabel.Size = new System.Drawing.Size(206, 16);
            this.showingsNoteLabel.TabIndex = 0;
            this.showingsNoteLabel.Text = "Izaberite film i datum prikazivanja:";
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(243, 176);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(97, 30);
            this.endButton.TabIndex = 5;
            this.endButton.Text = "Otkaži projekciju";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(140, 176);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 30);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Zakaži projekciju";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endOfShowingsDateTimePicker
            // 
            this.endOfShowingsDateTimePicker.Location = new System.Drawing.Point(140, 123);
            this.endOfShowingsDateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.endOfShowingsDateTimePicker.Name = "endOfShowingsDateTimePicker";
            this.endOfShowingsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endOfShowingsDateTimePicker.TabIndex = 3;
            // 
            // startOfShowingsDateTimePicker
            // 
            this.startOfShowingsDateTimePicker.Location = new System.Drawing.Point(140, 88);
            this.startOfShowingsDateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.startOfShowingsDateTimePicker.Name = "startOfShowingsDateTimePicker";
            this.startOfShowingsDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startOfShowingsDateTimePicker.TabIndex = 2;
            // 
            // endOfShowingsLabel
            // 
            this.endOfShowingsLabel.AutoSize = true;
            this.endOfShowingsLabel.Location = new System.Drawing.Point(10, 130);
            this.endOfShowingsLabel.Name = "endOfShowingsLabel";
            this.endOfShowingsLabel.Size = new System.Drawing.Size(84, 13);
            this.endOfShowingsLabel.TabIndex = 3;
            this.endOfShowingsLabel.Text = "Kraj prikazivanja";
            // 
            // startOfShowingsLabel
            // 
            this.startOfShowingsLabel.AutoSize = true;
            this.startOfShowingsLabel.Location = new System.Drawing.Point(10, 95);
            this.startOfShowingsLabel.Name = "startOfShowingsLabel";
            this.startOfShowingsLabel.Size = new System.Drawing.Size(106, 13);
            this.startOfShowingsLabel.TabIndex = 2;
            this.startOfShowingsLabel.Text = "Početak prikazivanja";
            // 
            // selectMovieComboBox
            // 
            this.selectMovieComboBox.DataSource = this.fILMOVIBindingSource;
            this.selectMovieComboBox.DisplayMember = "naslov";
            this.selectMovieComboBox.FormattingEnabled = true;
            this.selectMovieComboBox.Location = new System.Drawing.Point(140, 53);
            this.selectMovieComboBox.Name = "selectMovieComboBox";
            this.selectMovieComboBox.Size = new System.Drawing.Size(200, 21);
            this.selectMovieComboBox.TabIndex = 1;
            // 
            // fILMOVIBindingSource
            // 
            this.fILMOVIBindingSource.DataMember = "FILMOVI";
            this.fILMOVIBindingSource.DataSource = this.bIOSKOPDataSet;
            // 
            // bIOSKOPDataSet
            // 
            this.bIOSKOPDataSet.DataSetName = "BIOSKOPDataSet";
            this.bIOSKOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectMovieLabel
            // 
            this.selectMovieLabel.AutoSize = true;
            this.selectMovieLabel.Location = new System.Drawing.Point(10, 60);
            this.selectMovieLabel.Name = "selectMovieLabel";
            this.selectMovieLabel.Size = new System.Drawing.Size(65, 13);
            this.selectMovieLabel.TabIndex = 1;
            this.selectMovieLabel.Text = "Izaberite film";
            // 
            // addUserTabPage
            // 
            this.addUserTabPage.Controls.Add(this.addUserNoteLabel);
            this.addUserTabPage.Controls.Add(this.addUserButton);
            this.addUserTabPage.Controls.Add(this.repeatPasswordTextBox);
            this.addUserTabPage.Controls.Add(this.passwordTextBox);
            this.addUserTabPage.Controls.Add(this.usernameTextBox);
            this.addUserTabPage.Controls.Add(this.repeatPasswordLabel);
            this.addUserTabPage.Controls.Add(this.passwordLabel);
            this.addUserTabPage.Controls.Add(this.usernameLabel);
            this.addUserTabPage.Location = new System.Drawing.Point(4, 22);
            this.addUserTabPage.Name = "addUserTabPage";
            this.addUserTabPage.Size = new System.Drawing.Size(456, 394);
            this.addUserTabPage.TabIndex = 4;
            this.addUserTabPage.Text = "Registruj radnika";
            this.addUserTabPage.UseVisualStyleBackColor = true;
            // 
            // addUserNoteLabel
            // 
            this.addUserNoteLabel.AutoSize = true;
            this.addUserNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserNoteLabel.Location = new System.Drawing.Point(10, 15);
            this.addUserNoteLabel.Name = "addUserNoteLabel";
            this.addUserNoteLabel.Size = new System.Drawing.Size(177, 16);
            this.addUserNoteLabel.TabIndex = 0;
            this.addUserNoteLabel.Text = "Unesite podatke o korisniku:";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(190, 165);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 30);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Registruj";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(140, 123);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.repeatPasswordTextBox.TabIndex = 3;
            this.repeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(140, 88);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(140, 53);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(10, 130);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(96, 13);
            this.repeatPasswordLabel.TabIndex = 3;
            this.repeatPasswordLabel.Text = "Ponovljena lozinka";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(44, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Lozinka";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(10, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Korisničko ime";
            // 
            // addWorkerTabPage
            // 
            this.addWorkerTabPage.Controls.Add(this.fireWorkerButton);
            this.addWorkerTabPage.Controls.Add(this.workerUsernameTextBox);
            this.addWorkerTabPage.Controls.Add(this.workerUsernameLabel);
            this.addWorkerTabPage.Controls.Add(this.addWorkerButton);
            this.addWorkerTabPage.Controls.Add(this.workStartDateTimePicker);
            this.addWorkerTabPage.Controls.Add(this.workStartLabel);
            this.addWorkerTabPage.Controls.Add(this.dateOfBirthDateTimePicker);
            this.addWorkerTabPage.Controls.Add(this.lastNameTextBox);
            this.addWorkerTabPage.Controls.Add(this.addressTextBox);
            this.addWorkerTabPage.Controls.Add(this.telephoneTextBox);
            this.addWorkerTabPage.Controls.Add(this.lastNameLabel);
            this.addWorkerTabPage.Controls.Add(this.dateOfBirthLabel);
            this.addWorkerTabPage.Controls.Add(this.addressLabel);
            this.addWorkerTabPage.Controls.Add(this.telephoneLabel);
            this.addWorkerTabPage.Controls.Add(this.firstNameTextBox);
            this.addWorkerTabPage.Controls.Add(this.firstNameLabel);
            this.addWorkerTabPage.Controls.Add(this.addWorkerLabel);
            this.addWorkerTabPage.Location = new System.Drawing.Point(4, 22);
            this.addWorkerTabPage.Name = "addWorkerTabPage";
            this.addWorkerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addWorkerTabPage.Size = new System.Drawing.Size(456, 394);
            this.addWorkerTabPage.TabIndex = 2;
            this.addWorkerTabPage.Text = "Dodaj radnika";
            this.addWorkerTabPage.UseVisualStyleBackColor = true;
            // 
            // fireWorkerButton
            // 
            this.fireWorkerButton.Location = new System.Drawing.Point(240, 280);
            this.fireWorkerButton.Name = "fireWorkerButton";
            this.fireWorkerButton.Size = new System.Drawing.Size(90, 35);
            this.fireWorkerButton.TabIndex = 9;
            this.fireWorkerButton.Text = "Otpusti radnika";
            this.fireWorkerButton.UseVisualStyleBackColor = true;
            this.fireWorkerButton.Click += new System.EventHandler(this.fireWorkerButton_Click);
            // 
            // workerUsernameTextBox
            // 
            this.workerUsernameTextBox.Location = new System.Drawing.Point(130, 237);
            this.workerUsernameTextBox.Name = "workerUsernameTextBox";
            this.workerUsernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.workerUsernameTextBox.TabIndex = 7;
            // 
            // workerUsernameLabel
            // 
            this.workerUsernameLabel.AutoSize = true;
            this.workerUsernameLabel.Location = new System.Drawing.Point(10, 240);
            this.workerUsernameLabel.Name = "workerUsernameLabel";
            this.workerUsernameLabel.Size = new System.Drawing.Size(75, 13);
            this.workerUsernameLabel.TabIndex = 7;
            this.workerUsernameLabel.Text = "Korisničko ime";
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(130, 280);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(90, 35);
            this.addWorkerButton.TabIndex = 8;
            this.addWorkerButton.Text = "Dodaj radnika";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // workStartDateTimePicker
            // 
            this.workStartDateTimePicker.Location = new System.Drawing.Point(130, 207);
            this.workStartDateTimePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.workStartDateTimePicker.MinDate = new System.DateTime(2015, 5, 6, 0, 0, 0, 0);
            this.workStartDateTimePicker.Name = "workStartDateTimePicker";
            this.workStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.workStartDateTimePicker.TabIndex = 6;
            this.workStartDateTimePicker.Value = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            // 
            // workStartLabel
            // 
            this.workStartLabel.AutoSize = true;
            this.workStartLabel.Location = new System.Drawing.Point(10, 210);
            this.workStartLabel.Name = "workStartLabel";
            this.workStartLabel.Size = new System.Drawing.Size(91, 13);
            this.workStartLabel.TabIndex = 6;
            this.workStartLabel.Text = "Datum zaposlenja";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(130, 117);
            this.dateOfBirthDateTimePicker.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 3;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 87);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(130, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(130, 177);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telephoneTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 90);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Prezime";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(10, 120);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(77, 13);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Datum rođenja";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(10, 150);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(40, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Adresa";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(10, 180);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(43, 13);
            this.telephoneLabel.TabIndex = 5;
            this.telephoneLabel.Text = "Telefon";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 60);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(24, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Ime";
            // 
            // addWorkerLabel
            // 
            this.addWorkerLabel.AutoSize = true;
            this.addWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkerLabel.Location = new System.Drawing.Point(10, 15);
            this.addWorkerLabel.Name = "addWorkerLabel";
            this.addWorkerLabel.Size = new System.Drawing.Size(168, 16);
            this.addWorkerLabel.TabIndex = 0;
            this.addWorkerLabel.Text = "Unesite podatke o radniku:";
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.loadReportIDLabel);
            this.reportsTabPage.Controls.Add(this.reportIDLabel);
            this.reportsTabPage.Controls.Add(this.noteLabel);
            this.reportsTabPage.Controls.Add(this.deleteReportButton);
            this.reportsTabPage.Controls.Add(this.reportsDataGridView);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Size = new System.Drawing.Size(456, 394);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Greške";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // loadReportIDLabel
            // 
            this.loadReportIDLabel.AutoSize = true;
            this.loadReportIDLabel.Location = new System.Drawing.Point(75, 230);
            this.loadReportIDLabel.Name = "loadReportIDLabel";
            this.loadReportIDLabel.Size = new System.Drawing.Size(45, 13);
            this.loadReportIDLabel.TabIndex = 4;
            this.loadReportIDLabel.Text = "reportID";
            // 
            // reportIDLabel
            // 
            this.reportIDLabel.AutoSize = true;
            this.reportIDLabel.Location = new System.Drawing.Point(10, 230);
            this.reportIDLabel.Name = "reportIDLabel";
            this.reportIDLabel.Size = new System.Drawing.Size(56, 13);
            this.reportIDLabel.TabIndex = 3;
            this.reportIDLabel.Text = "ID greške:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(10, 190);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(254, 16);
            this.noteLabel.TabIndex = 2;
            this.noteLabel.Text = "Kliknite na opis greške koju želite obrisati:";
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.Location = new System.Drawing.Point(75, 270);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(100, 25);
            this.deleteReportButton.TabIndex = 1;
            this.deleteReportButton.Text = "Obriši";
            this.deleteReportButton.UseVisualStyleBackColor = true;
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.AllowUserToAddRows = false;
            this.reportsDataGridView.AllowUserToDeleteRows = false;
            this.reportsDataGridView.AllowUserToResizeRows = false;
            this.reportsDataGridView.AutoGenerateColumns = false;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.greskaidDataGridViewTextBoxColumn,
            this.opisgreskeDataGridViewTextBoxColumn});
            this.reportsDataGridView.DataSource = this.gREŠKEBindingSource;
            this.reportsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.RowHeadersVisible = false;
            this.reportsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportsDataGridView.Size = new System.Drawing.Size(456, 160);
            this.reportsDataGridView.TabIndex = 0;
            this.reportsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsDataGridView_CellContentClick);
            // 
            // greskaidDataGridViewTextBoxColumn
            // 
            this.greskaidDataGridViewTextBoxColumn.DataPropertyName = "greska_id";
            this.greskaidDataGridViewTextBoxColumn.HeaderText = "ID greške";
            this.greskaidDataGridViewTextBoxColumn.Name = "greskaidDataGridViewTextBoxColumn";
            this.greskaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisgreskeDataGridViewTextBoxColumn
            // 
            this.opisgreskeDataGridViewTextBoxColumn.DataPropertyName = "opis_greske";
            this.opisgreskeDataGridViewTextBoxColumn.HeaderText = "Opis greške";
            this.opisgreskeDataGridViewTextBoxColumn.Name = "opisgreskeDataGridViewTextBoxColumn";
            this.opisgreskeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gREŠKEBindingSource
            // 
            this.gREŠKEBindingSource.DataMember = "GREŠKE";
            this.gREŠKEBindingSource.DataSource = this.bIOSKOPDataSet1;
            // 
            // bIOSKOPDataSet1
            // 
            this.bIOSKOPDataSet1.DataSetName = "BIOSKOPDataSet1";
            this.bIOSKOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fILMOVITableAdapter
            // 
            this.fILMOVITableAdapter.ClearBeforeFill = true;
            // 
            // gREŠKETableAdapter
            // 
            this.gREŠKETableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 420);
            this.Controls.Add(this.adminTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRATOR";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.adminTabControl.ResumeLayout(false);
            this.addMovieTabPage.ResumeLayout(false);
            this.addMovieTabPage.PerformLayout();
            this.showingsTabPage.ResumeLayout(false);
            this.showingsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fILMOVIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet)).EndInit();
            this.addUserTabPage.ResumeLayout(false);
            this.addUserTabPage.PerformLayout();
            this.addWorkerTabPage.ResumeLayout(false);
            this.addWorkerTabPage.PerformLayout();
            this.reportsTabPage.ResumeLayout(false);
            this.reportsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gREŠKEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIOSKOPDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage addMovieTabPage;
        private System.Windows.Forms.TabPage showingsTabPage;
        private System.Windows.Forms.TabPage addWorkerTabPage;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox producerTextBox;
        private System.Windows.Forms.TextBox screenPlayTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox runningTimeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label screenPlayLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.DateTimePicker workStartDateTimePicker;
        private System.Windows.Forms.Label workStartLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label addWorkerLabel;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Label addMovieNoteLabel;
        private System.Windows.Forms.Label showingsNoteLabel;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DateTimePicker endOfShowingsDateTimePicker;
        private System.Windows.Forms.DateTimePicker startOfShowingsDateTimePicker;
        private System.Windows.Forms.Label endOfShowingsLabel;
        private System.Windows.Forms.Label startOfShowingsLabel;
        private System.Windows.Forms.ComboBox selectMovieComboBox;
        private System.Windows.Forms.Label selectMovieLabel;
        private System.Windows.Forms.TabPage addUserTabPage;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.Button deleteReportButton;
        private System.Windows.Forms.DataGridView reportsDataGridView;
        private System.Windows.Forms.Label addUserNoteLabel;
        private System.Windows.Forms.Label reportIDLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label loadReportIDLabel;
        private BIOSKOPDataSet bIOSKOPDataSet;
        private System.Windows.Forms.BindingSource fILMOVIBindingSource;
        private BIOSKOPDataSetTableAdapters.FILMOVITableAdapter fILMOVITableAdapter;
        private BIOSKOPDataSet1 bIOSKOPDataSet1;
        private System.Windows.Forms.BindingSource gREŠKEBindingSource;
        private BIOSKOPDataSet1TableAdapters.GREŠKETableAdapter gREŠKETableAdapter;
        private System.Windows.Forms.TextBox workerUsernameTextBox;
        private System.Windows.Forms.Label workerUsernameLabel;
        private System.Windows.Forms.Button fireWorkerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn greskaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisgreskeDataGridViewTextBoxColumn;
    }
}