namespace DesktopClient
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonAS = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonARB = new System.Windows.Forms.Button();
            this.buttonMRB = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonARA = new System.Windows.Forms.Button();
            this.buttonMRA = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.buttonMS);
            this.panelMain.Controls.Add(this.buttonAS);
            this.panelMain.Controls.Add(this.textBoxResult);
            this.panelMain.Controls.Add(this.comboBoxOperation);
            this.panelMain.Controls.Add(this.buttonEquals);
            this.panelMain.Controls.Add(this.buttonARB);
            this.panelMain.Controls.Add(this.buttonMRB);
            this.panelMain.Controls.Add(this.textBoxB);
            this.panelMain.Controls.Add(this.buttonARA);
            this.panelMain.Controls.Add(this.buttonMRA);
            this.panelMain.Controls.Add(this.textBoxA);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(360, 337);
            this.panelMain.TabIndex = 0;
            // 
            // buttonMS
            // 
            this.buttonMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMS.ForeColor = System.Drawing.Color.White;
            this.buttonMS.Location = new System.Drawing.Point(44, 259);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(44, 27);
            this.buttonMS.TabIndex = 10;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = false;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonAS
            // 
            this.buttonAS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAS.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAS.ForeColor = System.Drawing.Color.White;
            this.buttonAS.Location = new System.Drawing.Point(94, 259);
            this.buttonAS.Name = "buttonAS";
            this.buttonAS.Size = new System.Drawing.Size(44, 27);
            this.buttonAS.TabIndex = 9;
            this.buttonAS.Text = "AS";
            this.buttonAS.UseVisualStyleBackColor = false;
            this.buttonAS.Click += new System.EventHandler(this.buttonAS_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxResult.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.ForeColor = System.Drawing.Color.White;
            this.textBoxResult.Location = new System.Drawing.Point(144, 259);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(170, 27);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOperation.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOperation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOperation.ForeColor = System.Drawing.Color.White;
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "−",
            "×"});
            this.comboBoxOperation.Location = new System.Drawing.Point(44, 109);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(270, 27);
            this.comboBoxOperation.TabIndex = 7;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEquals.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquals.ForeColor = System.Drawing.Color.White;
            this.buttonEquals.Location = new System.Drawing.Point(44, 209);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(270, 27);
            this.buttonEquals.TabIndex = 6;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonARB
            // 
            this.buttonARB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonARB.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonARB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonARB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonARB.ForeColor = System.Drawing.Color.White;
            this.buttonARB.Location = new System.Drawing.Point(94, 159);
            this.buttonARB.Name = "buttonARB";
            this.buttonARB.Size = new System.Drawing.Size(44, 27);
            this.buttonARB.TabIndex = 5;
            this.buttonARB.Text = "AR";
            this.buttonARB.UseVisualStyleBackColor = false;
            this.buttonARB.Click += new System.EventHandler(this.buttonARB_Click);
            // 
            // buttonMRB
            // 
            this.buttonMRB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMRB.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonMRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMRB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMRB.ForeColor = System.Drawing.Color.White;
            this.buttonMRB.Location = new System.Drawing.Point(44, 159);
            this.buttonMRB.Name = "buttonMRB";
            this.buttonMRB.Size = new System.Drawing.Size(44, 27);
            this.buttonMRB.TabIndex = 4;
            this.buttonMRB.Text = "MR";
            this.buttonMRB.UseVisualStyleBackColor = false;
            this.buttonMRB.Click += new System.EventHandler(this.buttonMRB_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxB.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.Color.White;
            this.textBoxB.Location = new System.Drawing.Point(144, 159);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(170, 27);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonARA
            // 
            this.buttonARA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonARA.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonARA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonARA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonARA.ForeColor = System.Drawing.Color.White;
            this.buttonARA.Location = new System.Drawing.Point(94, 59);
            this.buttonARA.Name = "buttonARA";
            this.buttonARA.Size = new System.Drawing.Size(44, 27);
            this.buttonARA.TabIndex = 2;
            this.buttonARA.Text = "AR";
            this.buttonARA.UseVisualStyleBackColor = false;
            this.buttonARA.Click += new System.EventHandler(this.buttonARA_Click);
            // 
            // buttonMRA
            // 
            this.buttonMRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMRA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonMRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMRA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMRA.ForeColor = System.Drawing.Color.White;
            this.buttonMRA.Location = new System.Drawing.Point(44, 59);
            this.buttonMRA.Name = "buttonMRA";
            this.buttonMRA.Size = new System.Drawing.Size(44, 27);
            this.buttonMRA.TabIndex = 1;
            this.buttonMRA.Text = "MR";
            this.buttonMRA.UseVisualStyleBackColor = false;
            this.buttonMRA.Click += new System.EventHandler(this.buttonMRA_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxA.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ForeColor = System.Drawing.Color.White;
            this.textBoxA.Location = new System.Drawing.Point(144, 59);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(170, 27);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestService DesktopClient";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonARB;
        private System.Windows.Forms.Button buttonMRB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button buttonARA;
        private System.Windows.Forms.Button buttonMRA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonAS;
    }
}

