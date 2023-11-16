namespace PracticaDivisasGuillermoDeCarlos
{
    partial class Divisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Divisas));
            panel1 = new Panel();
            panel2 = new Panel();
            historialLabel = new Label();
            historialListBox = new ListBox();
            nombreMainLabel = new Label();
            panel3 = new Panel();
            imagenFlechas = new PictureBox();
            Cambiobutton = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            importeTextBox = new TextBox();
            aLabel = new Label();
            deLabel = new Label();
            importeLabel = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenFlechas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 0);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(historialLabel);
            panel2.Controls.Add(historialListBox);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 423);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 215);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // historialLabel
            // 
            historialLabel.AutoSize = true;
            historialLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            historialLabel.Location = new Point(18, 5);
            historialLabel.Name = "historialLabel";
            historialLabel.Size = new Size(84, 18);
            historialLabel.TabIndex = 2;
            historialLabel.Text = "HISTORIAL";
            // 
            // historialListBox
            // 
            historialListBox.BackColor = SystemColors.InactiveCaption;
            historialListBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            historialListBox.FormattingEnabled = true;
            historialListBox.ItemHeight = 15;
            historialListBox.Location = new Point(12, 26);
            historialListBox.Name = "historialListBox";
            historialListBox.Size = new Size(870, 154);
            historialListBox.TabIndex = 1;
            // 
            // nombreMainLabel
            // 
            nombreMainLabel.Anchor = AnchorStyles.Top;
            nombreMainLabel.AutoSize = true;
            nombreMainLabel.BackColor = SystemColors.ActiveCaption;
            nombreMainLabel.Font = new Font("Snap ITC", 48F, FontStyle.Bold, GraphicsUnit.Point);
            nombreMainLabel.Image = (Image)resources.GetObject("nombreMainLabel.Image");
            nombreMainLabel.Location = new Point(32, 9);
            nombreMainLabel.Name = "nombreMainLabel";
            nombreMainLabel.Size = new Size(869, 82);
            nombreMainLabel.TabIndex = 0;
            nombreMainLabel.Text = "DIVISAS GUILLEDCM";
            nombreMainLabel.TextAlign = ContentAlignment.TopCenter;
            nombreMainLabel.Click += nombreMainLabel_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(imagenFlechas);
            panel3.Controls.Add(Cambiobutton);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(importeTextBox);
            panel3.Controls.Add(aLabel);
            panel3.Controls.Add(deLabel);
            panel3.Controls.Add(importeLabel);
            panel3.Location = new Point(0, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 302);
            panel3.TabIndex = 2;
            // 
            // imagenFlechas
            // 
            imagenFlechas.ImageLocation = "flechas.png";
            imagenFlechas.Location = new Point(497, 102);
            imagenFlechas.Name = "imagenFlechas";
            imagenFlechas.Size = new Size(90, 48);
            imagenFlechas.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenFlechas.TabIndex = 7;
            imagenFlechas.TabStop = false;
            imagenFlechas.Click += imagenFlechas_Click;
            // 
            // Cambiobutton
            // 
            Cambiobutton.BackColor = SystemColors.InactiveCaption;
            Cambiobutton.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            Cambiobutton.Location = new Point(635, 209);
            Cambiobutton.Name = "Cambiobutton";
            Cambiobutton.Size = new Size(193, 81);
            Cambiobutton.TabIndex = 6;
            Cambiobutton.Text = "CAMBIO!!";
            Cambiobutton.UseVisualStyleBackColor = false;
            Cambiobutton.Click += Cambiobutton_Click;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "EUROS", "LIBRAS", "DOLLARS" });
            comboBox2.BackColor = SystemColors.InactiveCaption;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(635, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "EUROS", "LIBRAS", "DOLLARS" });
            comboBox1.BackColor = SystemColors.InactiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 4;
            // 
            // importeTextBox
            // 
            importeTextBox.BackColor = SystemColors.InactiveCaption;
            importeTextBox.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            importeTextBox.Location = new Point(26, 115);
            importeTextBox.Name = "importeTextBox";
            importeTextBox.Size = new Size(149, 31);
            importeTextBox.TabIndex = 3;
            importeTextBox.TextChanged += importeTextBox_TextChanged;
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Font = new Font("Mistral", 18F, FontStyle.Regular, GraphicsUnit.Point);
            aLabel.Location = new Point(669, 24);
            aLabel.Name = "aLabel";
            aLabel.Size = new Size(29, 29);
            aLabel.TabIndex = 2;
            aLabel.Text = "A:";
            aLabel.Click += aLabel_Click;
            // 
            // deLabel
            // 
            deLabel.AutoSize = true;
            deLabel.Font = new Font("Mistral", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deLabel.Location = new Point(353, 24);
            deLabel.Name = "deLabel";
            deLabel.Size = new Size(40, 29);
            deLabel.TabIndex = 1;
            deLabel.Text = "DE:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new Font("Mistral", 18F, FontStyle.Regular, GraphicsUnit.Point);
            importeLabel.Location = new Point(26, 24);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new Size(85, 29);
            importeLabel.TabIndex = 0;
            importeLabel.Text = "IMPORTE";
            importeLabel.Click += label1_Click_1;
            // 
            // Divisas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(916, 638);
            Controls.Add(panel3);
            Controls.Add(nombreMainLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Divisas";
            Text = "Divisas";
            Load += Divisas_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenFlechas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label nombreMainLabel;
        private Panel panel3;
        private Label importeLabel;
        private Label aLabel;
        private Label deLabel;
        private TextBox importeTextBox;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private PictureBox imagenFlechas;
        private Button Cambiobutton;
        private ListBox historialListBox;
        private Label historialLabel;
    }
}