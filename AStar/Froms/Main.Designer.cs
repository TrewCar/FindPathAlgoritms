namespace AlgorimsFindPath.Froms
{
    partial class Main
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
            startBreadthFS = new Button();
            startAStar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Neighbor8RB = new RadioButton();
            Neighbor4RB = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // startBreadthFS
            // 
            startBreadthFS.Location = new Point(6, 22);
            startBreadthFS.Name = "startBreadthFS";
            startBreadthFS.Size = new Size(124, 23);
            startBreadthFS.TabIndex = 0;
            startBreadthFS.Text = "Breadth-First Search";
            startBreadthFS.UseVisualStyleBackColor = true;
            startBreadthFS.Click += startBreadthFS_Click;
            // 
            // startAStar
            // 
            startAStar.Location = new Point(136, 22);
            startAStar.Name = "startAStar";
            startAStar.Size = new Size(75, 23);
            startAStar.TabIndex = 1;
            startAStar.Text = "AStar";
            startAStar.UseVisualStyleBackColor = true;
            startAStar.Click += startAStar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(startBreadthFS);
            groupBox1.Controls.Add(startAStar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 87);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Algoritms";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Neighbor8RB);
            groupBox2.Controls.Add(Neighbor4RB);
            groupBox2.Location = new Point(12, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(96, 87);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Neighbor";
            // 
            // Neighbor8RB
            // 
            Neighbor8RB.AutoSize = true;
            Neighbor8RB.Location = new Point(6, 45);
            Neighbor8RB.Name = "Neighbor8RB";
            Neighbor8RB.Size = new Size(87, 19);
            Neighbor8RB.TabIndex = 1;
            Neighbor8RB.Text = "8 neighbors";
            Neighbor8RB.UseVisualStyleBackColor = true;
            // 
            // Neighbor4RB
            // 
            Neighbor4RB.AutoSize = true;
            Neighbor4RB.Checked = true;
            Neighbor4RB.Location = new Point(7, 20);
            Neighbor4RB.Name = "Neighbor4RB";
            Neighbor4RB.Size = new Size(87, 19);
            Neighbor4RB.TabIndex = 0;
            Neighbor4RB.TabStop = true;
            Neighbor4RB.Text = "4 neighbors";
            Neighbor4RB.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 198);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button startBreadthFS;
        private Button startAStar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton Neighbor8RB;
        private RadioButton Neighbor4RB;
    }
}