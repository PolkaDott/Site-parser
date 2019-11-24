namespace Parser_Smotretanime.ru
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.textBoxNck = new System.Windows.Forms.TextBox();
            this.labelProfileShk = new System.Windows.Forms.Label();
            this.textBoxShk = new System.Windows.Forms.TextBox();
            this.labelProfileVk = new System.Windows.Forms.Label();
            this.textBoxVk = new System.Windows.Forms.TextBox();
            this.startPage = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.lableParsed = new System.Windows.Forms.Label();
            this.labelBeginPage = new System.Windows.Forms.Label();
            this.lableSpeedParsing = new System.Windows.Forms.Label();
            this.lableLastPage = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.TextBox();
            this.labelTimeLost = new System.Windows.Forms.Label();
            this.choiceCountThreads = new System.Windows.Forms.ComboBox();
            this.labelWithChoiceThreads = new System.Windows.Forms.Label();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.RunParser);
            // 
            // groupBoxSearch
            // 
            resources.ApplyResources(this.groupBoxSearch, "groupBoxSearch");
            this.groupBoxSearch.Controls.Add(this.labelNick);
            this.groupBoxSearch.Controls.Add(this.textBoxNck);
            this.groupBoxSearch.Controls.Add(this.labelProfileShk);
            this.groupBoxSearch.Controls.Add(this.textBoxShk);
            this.groupBoxSearch.Controls.Add(this.labelProfileVk);
            this.groupBoxSearch.Controls.Add(this.textBoxVk);
            this.groupBoxSearch.Controls.Add(this.startPage);
            this.groupBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.TabStop = false;
            // 
            // labelNick
            // 
            resources.ApplyResources(this.labelNick, "labelNick");
            this.labelNick.Name = "labelNick";
            // 
            // textBoxNck
            // 
            resources.ApplyResources(this.textBoxNck, "textBoxNck");
            this.textBoxNck.Name = "textBoxNck";
            this.textBoxNck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // labelProfileShk
            // 
            resources.ApplyResources(this.labelProfileShk, "labelProfileShk");
            this.labelProfileShk.Name = "labelProfileShk";
            // 
            // textBoxShk
            // 
            resources.ApplyResources(this.textBoxShk, "textBoxShk");
            this.textBoxShk.Name = "textBoxShk";
            this.textBoxShk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // labelProfileVk
            // 
            resources.ApplyResources(this.labelProfileVk, "labelProfileVk");
            this.labelProfileVk.Name = "labelProfileVk";
            // 
            // textBoxVk
            // 
            resources.ApplyResources(this.textBoxVk, "textBoxVk");
            this.textBoxVk.Name = "textBoxVk";
            this.textBoxVk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // startPage
            // 
            resources.ApplyResources(this.startPage, "startPage");
            this.startPage.Name = "startPage";
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.AbortParser);
            // 
            // lableParsed
            // 
            resources.ApplyResources(this.lableParsed, "lableParsed");
            this.lableParsed.Name = "lableParsed";
            // 
            // labelBeginPage
            // 
            resources.ApplyResources(this.labelBeginPage, "labelBeginPage");
            this.labelBeginPage.Name = "labelBeginPage";
            this.labelBeginPage.Click += new System.EventHandler(this.label1_Click);
            // 
            // lableSpeedParsing
            // 
            resources.ApplyResources(this.lableSpeedParsing, "lableSpeedParsing");
            this.lableSpeedParsing.Name = "lableSpeedParsing";
            // 
            // lableLastPage
            // 
            resources.ApplyResources(this.lableLastPage, "lableLastPage");
            this.lableLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lableLastPage.Name = "lableLastPage";
            // 
            // informationLabel
            // 
            this.informationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.informationLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.informationLabel, "informationLabel");
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.ReadOnly = true;
            this.informationLabel.TabStop = false;
            // 
            // labelTimeLost
            // 
            resources.ApplyResources(this.labelTimeLost, "labelTimeLost");
            this.labelTimeLost.Name = "labelTimeLost";
            // 
            // choiceCountThreads
            // 
            this.choiceCountThreads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceCountThreads.FormattingEnabled = true;
            this.choiceCountThreads.Items.AddRange(new object[] {
            resources.GetString("choiceCountThreads.Items"),
            resources.GetString("choiceCountThreads.Items1"),
            resources.GetString("choiceCountThreads.Items2"),
            resources.GetString("choiceCountThreads.Items3"),
            resources.GetString("choiceCountThreads.Items4"),
            resources.GetString("choiceCountThreads.Items5"),
            resources.GetString("choiceCountThreads.Items6"),
            resources.GetString("choiceCountThreads.Items7"),
            resources.GetString("choiceCountThreads.Items8"),
            resources.GetString("choiceCountThreads.Items9"),
            resources.GetString("choiceCountThreads.Items10"),
            resources.GetString("choiceCountThreads.Items11"),
            resources.GetString("choiceCountThreads.Items12"),
            resources.GetString("choiceCountThreads.Items13"),
            resources.GetString("choiceCountThreads.Items14"),
            resources.GetString("choiceCountThreads.Items15"),
            resources.GetString("choiceCountThreads.Items16"),
            resources.GetString("choiceCountThreads.Items17"),
            resources.GetString("choiceCountThreads.Items18"),
            resources.GetString("choiceCountThreads.Items19"),
            resources.GetString("choiceCountThreads.Items20"),
            resources.GetString("choiceCountThreads.Items21"),
            resources.GetString("choiceCountThreads.Items22"),
            resources.GetString("choiceCountThreads.Items23"),
            resources.GetString("choiceCountThreads.Items24"),
            resources.GetString("choiceCountThreads.Items25"),
            resources.GetString("choiceCountThreads.Items26"),
            resources.GetString("choiceCountThreads.Items27"),
            resources.GetString("choiceCountThreads.Items28"),
            resources.GetString("choiceCountThreads.Items29"),
            resources.GetString("choiceCountThreads.Items30"),
            resources.GetString("choiceCountThreads.Items31"),
            resources.GetString("choiceCountThreads.Items32"),
            resources.GetString("choiceCountThreads.Items33"),
            resources.GetString("choiceCountThreads.Items34"),
            resources.GetString("choiceCountThreads.Items35"),
            resources.GetString("choiceCountThreads.Items36"),
            resources.GetString("choiceCountThreads.Items37"),
            resources.GetString("choiceCountThreads.Items38"),
            resources.GetString("choiceCountThreads.Items39"),
            resources.GetString("choiceCountThreads.Items40"),
            resources.GetString("choiceCountThreads.Items41"),
            resources.GetString("choiceCountThreads.Items42"),
            resources.GetString("choiceCountThreads.Items43"),
            resources.GetString("choiceCountThreads.Items44"),
            resources.GetString("choiceCountThreads.Items45"),
            resources.GetString("choiceCountThreads.Items46"),
            resources.GetString("choiceCountThreads.Items47"),
            resources.GetString("choiceCountThreads.Items48"),
            resources.GetString("choiceCountThreads.Items49"),
            resources.GetString("choiceCountThreads.Items50"),
            resources.GetString("choiceCountThreads.Items51"),
            resources.GetString("choiceCountThreads.Items52"),
            resources.GetString("choiceCountThreads.Items53"),
            resources.GetString("choiceCountThreads.Items54"),
            resources.GetString("choiceCountThreads.Items55"),
            resources.GetString("choiceCountThreads.Items56"),
            resources.GetString("choiceCountThreads.Items57"),
            resources.GetString("choiceCountThreads.Items58"),
            resources.GetString("choiceCountThreads.Items59"),
            resources.GetString("choiceCountThreads.Items60"),
            resources.GetString("choiceCountThreads.Items61"),
            resources.GetString("choiceCountThreads.Items62"),
            resources.GetString("choiceCountThreads.Items63"),
            resources.GetString("choiceCountThreads.Items64"),
            resources.GetString("choiceCountThreads.Items65"),
            resources.GetString("choiceCountThreads.Items66"),
            resources.GetString("choiceCountThreads.Items67"),
            resources.GetString("choiceCountThreads.Items68"),
            resources.GetString("choiceCountThreads.Items69"),
            resources.GetString("choiceCountThreads.Items70"),
            resources.GetString("choiceCountThreads.Items71"),
            resources.GetString("choiceCountThreads.Items72"),
            resources.GetString("choiceCountThreads.Items73"),
            resources.GetString("choiceCountThreads.Items74"),
            resources.GetString("choiceCountThreads.Items75"),
            resources.GetString("choiceCountThreads.Items76"),
            resources.GetString("choiceCountThreads.Items77"),
            resources.GetString("choiceCountThreads.Items78"),
            resources.GetString("choiceCountThreads.Items79"),
            resources.GetString("choiceCountThreads.Items80"),
            resources.GetString("choiceCountThreads.Items81"),
            resources.GetString("choiceCountThreads.Items82"),
            resources.GetString("choiceCountThreads.Items83"),
            resources.GetString("choiceCountThreads.Items84"),
            resources.GetString("choiceCountThreads.Items85"),
            resources.GetString("choiceCountThreads.Items86"),
            resources.GetString("choiceCountThreads.Items87"),
            resources.GetString("choiceCountThreads.Items88"),
            resources.GetString("choiceCountThreads.Items89"),
            resources.GetString("choiceCountThreads.Items90"),
            resources.GetString("choiceCountThreads.Items91"),
            resources.GetString("choiceCountThreads.Items92"),
            resources.GetString("choiceCountThreads.Items93"),
            resources.GetString("choiceCountThreads.Items94"),
            resources.GetString("choiceCountThreads.Items95"),
            resources.GetString("choiceCountThreads.Items96"),
            resources.GetString("choiceCountThreads.Items97"),
            resources.GetString("choiceCountThreads.Items98"),
            resources.GetString("choiceCountThreads.Items99"),
            resources.GetString("choiceCountThreads.Items100"),
            resources.GetString("choiceCountThreads.Items101"),
            resources.GetString("choiceCountThreads.Items102"),
            resources.GetString("choiceCountThreads.Items103"),
            resources.GetString("choiceCountThreads.Items104"),
            resources.GetString("choiceCountThreads.Items105"),
            resources.GetString("choiceCountThreads.Items106"),
            resources.GetString("choiceCountThreads.Items107"),
            resources.GetString("choiceCountThreads.Items108"),
            resources.GetString("choiceCountThreads.Items109"),
            resources.GetString("choiceCountThreads.Items110"),
            resources.GetString("choiceCountThreads.Items111"),
            resources.GetString("choiceCountThreads.Items112"),
            resources.GetString("choiceCountThreads.Items113"),
            resources.GetString("choiceCountThreads.Items114"),
            resources.GetString("choiceCountThreads.Items115"),
            resources.GetString("choiceCountThreads.Items116"),
            resources.GetString("choiceCountThreads.Items117"),
            resources.GetString("choiceCountThreads.Items118"),
            resources.GetString("choiceCountThreads.Items119"),
            resources.GetString("choiceCountThreads.Items120"),
            resources.GetString("choiceCountThreads.Items121"),
            resources.GetString("choiceCountThreads.Items122"),
            resources.GetString("choiceCountThreads.Items123"),
            resources.GetString("choiceCountThreads.Items124"),
            resources.GetString("choiceCountThreads.Items125"),
            resources.GetString("choiceCountThreads.Items126"),
            resources.GetString("choiceCountThreads.Items127"),
            resources.GetString("choiceCountThreads.Items128"),
            resources.GetString("choiceCountThreads.Items129"),
            resources.GetString("choiceCountThreads.Items130"),
            resources.GetString("choiceCountThreads.Items131"),
            resources.GetString("choiceCountThreads.Items132"),
            resources.GetString("choiceCountThreads.Items133"),
            resources.GetString("choiceCountThreads.Items134"),
            resources.GetString("choiceCountThreads.Items135"),
            resources.GetString("choiceCountThreads.Items136"),
            resources.GetString("choiceCountThreads.Items137"),
            resources.GetString("choiceCountThreads.Items138"),
            resources.GetString("choiceCountThreads.Items139"),
            resources.GetString("choiceCountThreads.Items140"),
            resources.GetString("choiceCountThreads.Items141"),
            resources.GetString("choiceCountThreads.Items142"),
            resources.GetString("choiceCountThreads.Items143"),
            resources.GetString("choiceCountThreads.Items144"),
            resources.GetString("choiceCountThreads.Items145"),
            resources.GetString("choiceCountThreads.Items146"),
            resources.GetString("choiceCountThreads.Items147"),
            resources.GetString("choiceCountThreads.Items148"),
            resources.GetString("choiceCountThreads.Items149")});
            resources.ApplyResources(this.choiceCountThreads, "choiceCountThreads");
            this.choiceCountThreads.Name = "choiceCountThreads";
            this.choiceCountThreads.TabStop = false;
            this.choiceCountThreads.Tag = "";
            // 
            // labelWithChoiceThreads
            // 
            resources.ApplyResources(this.labelWithChoiceThreads, "labelWithChoiceThreads");
            this.labelWithChoiceThreads.Name = "labelWithChoiceThreads";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWithChoiceThreads);
            this.Controls.Add(this.choiceCountThreads);
            this.Controls.Add(this.labelTimeLost);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.lableLastPage);
            this.Controls.Add(this.lableSpeedParsing);
            this.Controls.Add(this.labelBeginPage);
            this.Controls.Add(this.lableParsed);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.TextBox textBoxNck;
        private System.Windows.Forms.Label labelProfileShk;
        private System.Windows.Forms.TextBox textBoxShk;
        private System.Windows.Forms.Label labelProfileVk;
        private System.Windows.Forms.TextBox textBoxVk;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lableParsed;
        private System.Windows.Forms.Label labelBeginPage;
        private System.Windows.Forms.TextBox startPage;
        private System.Windows.Forms.Label lableSpeedParsing;
        private System.Windows.Forms.Label lableLastPage;
        private System.Windows.Forms.TextBox informationLabel;
        private System.Windows.Forms.Label labelTimeLost;
        private System.Windows.Forms.ComboBox choiceCountThreads;
        private System.Windows.Forms.Label labelWithChoiceThreads;
    }
}

