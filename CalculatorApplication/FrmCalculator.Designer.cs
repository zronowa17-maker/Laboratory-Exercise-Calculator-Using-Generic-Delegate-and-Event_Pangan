namespace CalculatorApplication
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            lblDisplayTotal = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(226, 151);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 33);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(201, 277);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(294, 33);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(254, 388);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 33);
            label3.TabIndex = 2;
            label3.Text = "Text Answer:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.BackColor = Color.Azure;
            txtBoxInput1.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput1.Location = new Point(515, 141);
            txtBoxInput1.Multiline = true;
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(250, 68);
            txtBoxInput1.TabIndex = 3;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.BackColor = Color.Azure;
            txtBoxInput2.BorderStyle = BorderStyle.FixedSingle;
            txtBoxInput2.Location = new Point(515, 260);
            txtBoxInput2.Multiline = true;
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(250, 68);
            txtBoxInput2.TabIndex = 4;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.BackColor = Color.Azure;
            lblDisplayTotal.BorderStyle = BorderStyle.FixedSingle;
            lblDisplayTotal.Location = new Point(515, 373);
            lblDisplayTotal.Multiline = true;
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(250, 68);
            lblDisplayTotal.TabIndex = 5;
            // 
            // cbOperator
            // 
            cbOperator.BackColor = Color.Azure;
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(581, 215);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 39);
            cbOperator.TabIndex = 6;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Transparent;
            btnEqual.BackgroundImage = (Image)resources.GetObject("btnEqual.BackgroundImage");
            btnEqual.BackgroundImageLayout = ImageLayout.Stretch;
            btnEqual.Font = new Font("Rockwell", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = Color.Black;
            btnEqual.Location = new Point(393, 459);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(143, 38);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1061);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(lblDisplayTotal);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "FrmCalculator";
            Text = "form 1";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private TextBox lblDisplayTotal;
        private ComboBox cbOperator;
        private Button btnEqual;
    }
}
