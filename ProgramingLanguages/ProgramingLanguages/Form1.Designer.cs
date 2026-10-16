namespace ProgramingLanguages
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Heading = new System.Windows.Forms.Label();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.textBoxEnterLanguage = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Heading.AutoSize = true;
            this.Heading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(249, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(564, 38);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "My Favourite Programming Languages";
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxLanguages.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.ItemHeight = 16;
            this.listBoxLanguages.Items.AddRange(new object[] {
            "C#",
            "Java",
            "JavaScript",
            "C++"});
            this.listBoxLanguages.Location = new System.Drawing.Point(162, 69);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(714, 244);
            this.listBoxLanguages.TabIndex = 1;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // textBoxEnterLanguage
            // 
            this.textBoxEnterLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEnterLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterLanguage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEnterLanguage.Location = new System.Drawing.Point(162, 341);
            this.textBoxEnterLanguage.Name = "textBoxEnterLanguage";
            this.textBoxEnterLanguage.Size = new System.Drawing.Size(714, 27);
            this.textBoxEnterLanguage.TabIndex = 2;
            this.textBoxEnterLanguage.TextChanged += new System.EventHandler(this.textBoxEnterLanguage_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAdd.Location = new System.Drawing.Point(162, 389);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 48);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemove.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemove.Location = new System.Drawing.Point(746, 389);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(130, 48);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labOutput
            // 
            this.labOutput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labOutput.AutoSize = true;
            this.labOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOutput.Location = new System.Drawing.Point(157, 481);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(71, 25);
            this.labOutput.TabIndex = 5;
            this.labOutput.Text = "Output";
            this.labOutput.Click += new System.EventHandler(this.labOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 642);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxEnterLanguage);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.Heading);
            this.Name = "Form1";
            this.Text = "Favourite Programming Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.TextBox textBoxEnterLanguage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labOutput;
    }
}

