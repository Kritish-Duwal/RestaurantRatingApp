
namespace RestaurantRatingApp
{
    partial class FeedbackForm
    {

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCustEmail = new System.Windows.Forms.Label();
            this.feedbackData = new System.Windows.Forms.DataGridView();
            this.Dissatisfied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Excellent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(533, 29);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(609, 91);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Feedback Form";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.Location = new System.Drawing.Point(4, 26);
            this.labelCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(219, 31);
            this.labelCustName.TabIndex = 1;
            this.labelCustName.Text = "Customer Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBoxMsg);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.labelCustPhone);
            this.panel1.Controls.Add(this.textBoxCustName);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelCustEmail);
            this.panel1.Controls.Add(this.labelCustName);
            this.panel1.Location = new System.Drawing.Point(29, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 309);
            this.panel1.TabIndex = 2;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(252, 194);
            this.textBoxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(307, 90);
            this.textBoxMsg.TabIndex = 8;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(4, 194);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(196, 31);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "Your Message:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(252, 80);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(307, 37);
            this.textBoxPhone.TabIndex = 6;
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustPhone.Location = new System.Drawing.Point(4, 80);
            this.labelCustPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(100, 31);
            this.labelCustPhone.TabIndex = 5;
            this.labelCustPhone.Text = "Phone:";
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustName.Location = new System.Drawing.Point(252, 26);
            this.textBoxCustName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(307, 37);
            this.textBoxCustName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(252, 134);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(307, 37);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelCustEmail
            // 
            this.labelCustEmail.AutoSize = true;
            this.labelCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustEmail.Location = new System.Drawing.Point(4, 135);
            this.labelCustEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustEmail.Name = "labelCustEmail";
            this.labelCustEmail.Size = new System.Drawing.Size(89, 31);
            this.labelCustEmail.TabIndex = 3;
            this.labelCustEmail.Text = "Email:";
            // 
            // feedbackData
            // 
            this.feedbackData.AllowUserToResizeColumns = false;
            this.feedbackData.AllowUserToResizeRows = false;
            this.feedbackData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feedbackData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feedbackData.ColumnHeadersHeight = 29;
            this.feedbackData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.feedbackData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dissatisfied,
            this.Average,
            this.Good,
            this.Excellent});
            this.feedbackData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.feedbackData.Location = new System.Drawing.Point(612, 127);
            this.feedbackData.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackData.MultiSelect = false;
            this.feedbackData.Name = "feedbackData";
            this.feedbackData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.feedbackData.RowHeadersWidth = 51;
            this.feedbackData.ShowCellErrors = false;
            this.feedbackData.ShowCellToolTips = false;
            this.feedbackData.ShowEditingIcon = false;
            this.feedbackData.ShowRowErrors = false;
            this.feedbackData.Size = new System.Drawing.Size(724, 404);
            this.feedbackData.TabIndex = 4;
            this.feedbackData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedbackData_CellContentClick);
            // 
            // Dissatisfied
            // 
            this.Dissatisfied.HeaderText = "Dissatisfied";
            this.Dissatisfied.MinimumWidth = 6;
            this.Dissatisfied.Name = "Dissatisfied";
            this.Dissatisfied.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.MinimumWidth = 6;
            this.Average.Name = "Average";
            // 
            // Good
            // 
            this.Good.HeaderText = "Good";
            this.Good.MinimumWidth = 6;
            this.Good.Name = "Good";
            // 
            // Excellent
            // 
            this.Excellent.HeaderText = "Excellent";
            this.Excellent.MinimumWidth = 6;
            this.Excellent.Name = "Excellent";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(281, 444);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(166, 55);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(29, 447);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(160, 55);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1301, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 55;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 55;
            this.bunifuElipse3.TargetControl = this.buttonSubmit;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 55;
            this.bunifuElipse4.TargetControl = this.buttonBack;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.textBoxCustName;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 30;
            this.bunifuElipse6.TargetControl = this.textBoxEmail;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 30;
            this.bunifuElipse7.TargetControl = this.textBoxPhone;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 30;
            this.bunifuElipse8.TargetControl = this.textBoxMsg;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 544);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.feedbackData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Form";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelCustEmail;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.DataGridView feedbackData;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dissatisfied;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Average;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Good;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excellent;
    }
}