namespace if_eles_login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tuser = new TextBox();
            tpwd = new TextBox();
            blogin = new Button();
            cview = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 21);
            label1.Name = "label1";
            label1.Size = new Size(355, 69);
            label1.TabIndex = 0;
            label1.Text = "Member Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Text", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(93, 137);
            label2.Name = "label2";
            label2.Size = new Size(196, 53);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Text", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 187);
            label3.Name = "label3";
            label3.Size = new Size(189, 53);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tuser
            // 
            tuser.BackColor = Color.LightCoral;
            tuser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tuser.Location = new Point(323, 143);
            tuser.Name = "tuser";
            tuser.Size = new Size(100, 35);
            tuser.TabIndex = 0;
            // 
            // tpwd
            // 
            tpwd.BackColor = Color.LightCoral;
            tpwd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tpwd.Location = new Point(323, 193);
            tpwd.Name = "tpwd";
            tpwd.Size = new Size(100, 35);
            tpwd.TabIndex = 1;
            tpwd.UseSystemPasswordChar = true;
            // 
            // blogin
            // 
            blogin.BackColor = Color.IndianRed;
            blogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            blogin.ForeColor = Color.Black;
            blogin.Location = new Point(323, 250);
            blogin.Name = "blogin";
            blogin.Size = new Size(104, 49);
            blogin.TabIndex = 2;
            blogin.Text = "Log in";
            blogin.UseVisualStyleBackColor = false;
            blogin.Click += blogin_Click;
            // 
            // cview
            // 
            cview.AutoSize = true;
            cview.BackColor = Color.Transparent;
            cview.Location = new Point(429, 201);
            cview.Name = "cview";
            cview.Size = new Size(48, 19);
            cview.TabIndex = 6;
            cview.Text = "Vive";
            cview.UseVisualStyleBackColor = false;
            cview.CheckedChanged += cview_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = Properties.Resources.d093f295d2f081c2a98cfa8061cf2e82_t;
            ClientSize = new Size(510, 349);
            Controls.Add(cview);
            Controls.Add(blogin);
            Controls.Add(tpwd);
            Controls.Add(tuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tuser;
        private TextBox tpwd;
        private Button blogin;
        private CheckBox cview;
    }
}
