using AlgorimsFindPath.SearchPath;

namespace AlgorimsFindPath.Froms
{
    partial class FindPathForm
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
            components = new System.ComponentModel.Container();
            pictureMap = new PictureBox();
            startAction = new Button();
            setStartPos = new Button();
            setEndPos = new Button();
            Clear = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            byStep = new CheckBox();
            drawMod = new CheckBox();
            setDefault = new Button();
            stopAction = new Button();
            disposeAction = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureMap).BeginInit();
            SuspendLayout();
            // 
            // pictureMap
            // 
            pictureMap.Location = new Point(12, 12);
            pictureMap.Name = "pictureMap";
            pictureMap.Size = new Size(500, 500);
            pictureMap.TabIndex = 0;
            pictureMap.TabStop = false;
            pictureMap.MouseDown += pictureMap_MouseDown;
            pictureMap.MouseMove += pictureMap_MouseMove;
            pictureMap.MouseUp += pictureMap_MouseUp;
            // 
            // startAction
            // 
            startAction.Location = new Point(532, 19);
            startAction.Name = "startAction";
            startAction.Size = new Size(75, 23);
            startAction.TabIndex = 1;
            startAction.Text = "Start";
            startAction.UseVisualStyleBackColor = true;
            startAction.Click += startAction_Click;
            // 
            // setStartPos
            // 
            setStartPos.Location = new Point(537, 213);
            setStartPos.Name = "setStartPos";
            setStartPos.Size = new Size(75, 48);
            setStartPos.TabIndex = 2;
            setStartPos.Text = "Set start pos";
            setStartPos.UseVisualStyleBackColor = true;
            setStartPos.Click += setStartPos_Click;
            // 
            // setEndPos
            // 
            setEndPos.Location = new Point(537, 267);
            setEndPos.Name = "setEndPos";
            setEndPos.Size = new Size(75, 48);
            setEndPos.TabIndex = 3;
            setEndPos.Text = "Set end pos";
            setEndPos.UseVisualStyleBackColor = true;
            setEndPos.Click += setEndPos_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(537, 459);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 4;
            Clear.Text = "Clear wall";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // byStep
            // 
            byStep.AutoSize = true;
            byStep.Checked = true;
            byStep.CheckState = CheckState.Checked;
            byStep.Location = new Point(16, 525);
            byStep.Name = "byStep";
            byStep.Size = new Size(64, 19);
            byStep.TabIndex = 5;
            byStep.Text = "By step";
            byStep.UseVisualStyleBackColor = true;
            // 
            // drawMod
            // 
            drawMod.AutoSize = true;
            drawMod.Checked = true;
            drawMod.CheckState = CheckState.Checked;
            drawMod.Location = new Point(101, 525);
            drawMod.Name = "drawMod";
            drawMod.Size = new Size(139, 19);
            drawMod.TabIndex = 6;
            drawMod.Text = "Draw wall / Clear wall";
            drawMod.UseVisualStyleBackColor = true;
            // 
            // setDefault
            // 
            setDefault.Location = new Point(537, 488);
            setDefault.Name = "setDefault";
            setDefault.Size = new Size(75, 23);
            setDefault.TabIndex = 7;
            setDefault.Text = "Set default";
            setDefault.UseVisualStyleBackColor = true;
            setDefault.Click += setDefault_Click;
            // 
            // stopAction
            // 
            stopAction.Location = new Point(532, 48);
            stopAction.Name = "stopAction";
            stopAction.Size = new Size(75, 23);
            stopAction.TabIndex = 8;
            stopAction.Text = "Stop";
            stopAction.UseVisualStyleBackColor = true;
            stopAction.Click += stopAction_Click;
            // 
            // disposeAction
            // 
            disposeAction.Location = new Point(532, 77);
            disposeAction.Name = "disposeAction";
            disposeAction.Size = new Size(75, 43);
            disposeAction.TabIndex = 9;
            disposeAction.Text = "Dispose Find Path";
            disposeAction.UseVisualStyleBackColor = true;
            disposeAction.Click += disposeAction_Click;
            // 
            // FindPathForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 558);
            Controls.Add(disposeAction);
            Controls.Add(stopAction);
            Controls.Add(setDefault);
            Controls.Add(drawMod);
            Controls.Add(byStep);
            Controls.Add(Clear);
            Controls.Add(setEndPos);
            Controls.Add(setStartPos);
            Controls.Add(startAction);
            Controls.Add(pictureMap);
            Name = "FindPathForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureMap;
        private Button startAction;
        private Button setStartPos;
        private Button setEndPos;
        private Button Clear;
        private System.Windows.Forms.Timer timer1;
        private CheckBox byStep;
        private CheckBox drawMod;
        private Button setDefault;
        private Button stopAction;
        private Button disposeAction;
    }
}
