
namespace RestaurantRatingApp
{
    partial class Criteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criteria));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCriteiraName = new System.Windows.Forms.Label();
            this.textBoxCriteriaName = new System.Windows.Forms.TextBox();
            this.buttonAddCriteira = new System.Windows.Forms.Button();
            this.buttonClearCriteira = new System.Windows.Forms.Button();
            this.buttonBackCriterira = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(139, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(298, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Review Criteria";
            // 
            // labelCriteiraName
            // 
            this.labelCriteiraName.AutoSize = true;
            this.labelCriteiraName.BackColor = System.Drawing.Color.Transparent;
            this.labelCriteiraName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCriteiraName.Location = new System.Drawing.Point(17, 75);
            this.labelCriteiraName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCriteiraName.Name = "labelCriteiraName";
            this.labelCriteiraName.Size = new System.Drawing.Size(203, 31);
            this.labelCriteiraName.TabIndex = 1;
            this.labelCriteiraName.Text = "Criteria Name:";
            // 
            // textBoxCriteriaName
            // 
            this.textBoxCriteriaName.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBoxCriteriaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCriteriaName.Location = new System.Drawing.Point(243, 75);
            this.textBoxCriteriaName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCriteriaName.Name = "textBoxCriteriaName";
            this.textBoxCriteriaName.Size = new System.Drawing.Size(324, 37);
            this.textBoxCriteriaName.TabIndex = 2;
            // 
            // buttonAddCriteira
            // 
            this.buttonAddCriteira.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddCriteira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCriteira.FlatAppearance.BorderSize = 0;
            this.buttonAddCriteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCriteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCriteira.Location = new System.Drawing.Point(243, 120);
            this.buttonAddCriteira.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCriteira.Name = "buttonAddCriteira";
            this.buttonAddCriteira.Size = new System.Drawing.Size(198, 54);
            this.buttonAddCriteira.TabIndex = 3;
            this.buttonAddCriteira.Text = "Add Criteira";
            this.buttonAddCriteira.UseVisualStyleBackColor = false;
            this.buttonAddCriteira.Click += new System.EventHandler(this.addCriteria_Click);
            // 
            // buttonClearCriteira
            // 
            this.buttonClearCriteira.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonClearCriteira.FlatAppearance.BorderSize = 0;
            this.buttonClearCriteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearCriteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearCriteira.Location = new System.Drawing.Point(243, 182);
            this.buttonClearCriteira.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearCriteira.Name = "buttonClearCriteira";
            this.buttonClearCriteira.Size = new System.Drawing.Size(131, 54);
            this.buttonClearCriteira.TabIndex = 4;
            this.buttonClearCriteira.Text = "Clear";
            this.buttonClearCriteira.UseVisualStyleBackColor = false;
            this.buttonClearCriteira.Click += new System.EventHandler(this.buttonClearCriteira_Click);
            // 
            // buttonBackCriterira
            // 
            this.buttonBackCriterira.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonBackCriterira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackCriterira.FlatAppearance.BorderSize = 0;
            this.buttonBackCriterira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackCriterira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackCriterira.Location = new System.Drawing.Point(23, 255);
            this.buttonBackCriterira.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackCriterira.Name = "buttonBackCriterira";
            this.buttonBackCriterira.Size = new System.Drawing.Size(118, 54);
            this.buttonBackCriterira.TabIndex = 5;
            this.buttonBackCriterira.Text = "Back";
            this.buttonBackCriterira.UseVisualStyleBackColor = false;
            this.buttonBackCriterira.Click += new System.EventHandler(this.buttonBackCriterira_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(545, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 8;
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
            this.bunifuElipse2.TargetControl = this.buttonAddCriteira;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 55;
            this.bunifuElipse3.TargetControl = this.buttonClearCriteira;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 55;
            this.bunifuElipse4.TargetControl = this.buttonBackCriterira;
            // 
            // Criteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(580, 322);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.buttonBackCriterira);
            this.Controls.Add(this.buttonClearCriteira);
            this.Controls.Add(this.buttonAddCriteira);
            this.Controls.Add(this.textBoxCriteriaName);
            this.Controls.Add(this.labelCriteiraName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Criteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Criteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCriteiraName;
        private System.Windows.Forms.TextBox textBoxCriteriaName;
        private System.Windows.Forms.Button buttonAddCriteira;
        private System.Windows.Forms.Button buttonClearCriteira;
        private System.Windows.Forms.Button buttonBackCriterira;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}