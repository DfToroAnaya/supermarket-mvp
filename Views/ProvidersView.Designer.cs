namespace Supermarket_mvp.Views
{
    partial class ProvidersView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            BtnProviderClose = new Button();
            BtnProviderDelete = new Button();
            BtnProviderEdit = new Button();
            BtnProviderNew = new Button();
            DgProviders = new DataGridView();
            BtnProviderSearch = new Button();
            TxtProviderSearch = new TextBox();
            label5 = new Label();
            tabPageProvidersDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtObservation = new TextBox();
            label4 = new Label();
            TxtName = new TextBox();
            label3 = new Label();
            TxtId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 43);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnProviderClose);
            tabPageProvidersList.Controls.Add(BtnProviderDelete);
            tabPageProvidersList.Controls.Add(BtnProviderEdit);
            tabPageProvidersList.Controls.Add(BtnProviderNew);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnProviderSearch);
            tabPageProvidersList.Controls.Add(TxtProviderSearch);
            tabPageProvidersList.Controls.Add(label5);
            tabPageProvidersList.Location = new Point(4, 29);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 292);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnProviderClose
            // 
            BtnProviderClose.Image = Properties.Resources.cerrar;
            BtnProviderClose.Location = new Point(638, 219);
            BtnProviderClose.Name = "BtnProviderClose";
            BtnProviderClose.Size = new Size(81, 59);
            BtnProviderClose.TabIndex = 7;
            BtnProviderClose.UseVisualStyleBackColor = true;
            // 
            // BtnProviderDelete
            // 
            BtnProviderDelete.Image = Properties.Resources.delete;
            BtnProviderDelete.Location = new Point(638, 154);
            BtnProviderDelete.Name = "BtnProviderDelete";
            BtnProviderDelete.Size = new Size(81, 59);
            BtnProviderDelete.TabIndex = 6;
            BtnProviderDelete.UseVisualStyleBackColor = true;
            // 
            // BtnProviderEdit
            // 
            BtnProviderEdit.Image = Properties.Resources.edit;
            BtnProviderEdit.Location = new Point(638, 89);
            BtnProviderEdit.Name = "BtnProviderEdit";
            BtnProviderEdit.Size = new Size(81, 59);
            BtnProviderEdit.TabIndex = 5;
            BtnProviderEdit.UseVisualStyleBackColor = true;
            // 
            // BtnProviderNew
            // 
            BtnProviderNew.Image = Properties.Resources._new;
            BtnProviderNew.Location = new Point(638, 24);
            BtnProviderNew.Name = "BtnProviderNew";
            BtnProviderNew.Size = new Size(81, 59);
            BtnProviderNew.TabIndex = 4;
            BtnProviderNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(17, 73);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.Size = new Size(485, 211);
            DgProviders.TabIndex = 3;
            // 
            // BtnProviderSearch
            // 
            BtnProviderSearch.Image = Properties.Resources.search_small;
            BtnProviderSearch.Location = new Point(426, 9);
            BtnProviderSearch.Name = "BtnProviderSearch";
            BtnProviderSearch.Size = new Size(56, 58);
            BtnProviderSearch.TabIndex = 2;
            BtnProviderSearch.UseVisualStyleBackColor = true;
            // 
            // TxtProviderSearch
            // 
            TxtProviderSearch.Location = new Point(17, 40);
            TxtProviderSearch.Name = "TxtProviderSearch";
            TxtProviderSearch.PlaceholderText = "Data to search";
            TxtProviderSearch.Size = new Size(384, 27);
            TxtProviderSearch.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 17);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 0;
            label5.Text = "Search Provider";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Controls.Add(TxtObservation);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtName);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(TxtId);
            tabPageProvidersDetail.Controls.Add(label2);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 292);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(206, 233);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 51);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(27, 234);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 50);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtObservation
            // 
            TxtObservation.Location = new Point(17, 170);
            TxtObservation.Multiline = true;
            TxtObservation.Name = "TxtObservation";
            TxtObservation.PlaceholderText = "Provider Observation";
            TxtObservation.Size = new Size(350, 52);
            TxtObservation.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 147);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 4;
            label4.Text = "Provider Observation";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(17, 106);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "Provider Name";
            TxtName.Size = new Size(190, 27);
            TxtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 83);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Provider Name";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(17, 39);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(125, 27);
            TxtId.TabIndex = 1;
            TxtId.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Provider Id";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private TextBox TxtId;
        private Label label2;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtObservation;
        private Label label4;
        private TextBox TxtName;
        private Label label3;
        private DataGridView DgProviders;
        private Button BtnProviderSearch;
        private TextBox TxtProviderSearch;
        private Button BtnProviderClose;
        private Button BtnProviderDelete;
        private Button BtnProviderEdit;
        private Button BtnProviderNew;
    }
}