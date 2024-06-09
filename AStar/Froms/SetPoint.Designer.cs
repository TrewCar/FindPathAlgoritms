namespace AlgorimsFindPath.Froms
{
    partial class SetPoint
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
            labelX = new Label();
            labelY = new Label();
            button1 = new Button();
            trackX = new TrackBar();
            trackY = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackY).BeginInit();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(18, 21);
            labelX.Name = "labelX";
            labelX.Size = new Size(17, 15);
            labelX.TabIndex = 0;
            labelX.Text = "X:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(18, 74);
            labelY.Name = "labelY";
            labelY.Size = new Size(17, 15);
            labelY.TabIndex = 1;
            labelY.Text = "Y:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 110);
            button1.Name = "button1";
            button1.Size = new Size(376, 23);
            button1.TabIndex = 2;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackX
            // 
            trackX.Location = new Point(67, 12);
            trackX.Name = "trackX";
            trackX.Size = new Size(310, 45);
            trackX.TabIndex = 3;
            trackX.Scroll += trackX_Scroll;
            // 
            // trackY
            // 
            trackY.Location = new Point(67, 63);
            trackY.Name = "trackY";
            trackY.Size = new Size(310, 45);
            trackY.TabIndex = 4;
            trackY.Scroll += trackY_Scroll;
            // 
            // SetPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(400, 145);
            Controls.Add(trackY);
            Controls.Add(trackX);
            Controls.Add(button1);
            Controls.Add(labelY);
            Controls.Add(labelX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SetPoint";
            Text = "SetPoint";
            ((System.ComponentModel.ISupportInitialize)trackX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private Label labelY;
        private Button button1;
        private TrackBar trackX;
        private TrackBar trackY;
    }
}