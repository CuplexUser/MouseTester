
namespace MouseTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.picBoxMain = new System.Windows.Forms.PictureBox();
            this.ctMenuMouseArea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTriggerTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drpBoxValues = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblThreshhold = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrLeft = new System.Windows.Forms.Label();
            this.lblErrRight = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXpos = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.grpBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).BeginInit();
            this.ctMenuMouseArea.SuspendLayout();
            this.drpBoxValues.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMain.Controls.Add(this.picBoxMain);
            this.grpBoxMain.Location = new System.Drawing.Point(12, 134);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Padding = new System.Windows.Forms.Padding(5);
            this.grpBoxMain.Size = new System.Drawing.Size(430, 265);
            this.grpBoxMain.TabIndex = 0;
            this.grpBoxMain.TabStop = false;
            this.grpBoxMain.Text = "Mouse Area";
            // 
            // picBoxMain
            // 
            this.picBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxMain.Location = new System.Drawing.Point(5, 18);
            this.picBoxMain.Margin = new System.Windows.Forms.Padding(5);
            this.picBoxMain.Name = "picBoxMain";
            this.picBoxMain.Size = new System.Drawing.Size(420, 242);
            this.picBoxMain.TabIndex = 0;
            this.picBoxMain.TabStop = false;
            this.picBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseClick);
            this.picBoxMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseDoubleClick);
            this.picBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseDown);
            this.picBoxMain.MouseEnter += new System.EventHandler(this.picBoxMain_MouseEnter);
            this.picBoxMain.MouseLeave += new System.EventHandler(this.picBoxMain_MouseLeave);
            this.picBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseMove);
            this.picBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxMain_MouseUp);
            // 
            // ctMenuMouseArea
            // 
            this.ctMenuMouseArea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearErrorsToolStripMenuItem,
            this.setTriggerTimeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.ctMenuMouseArea.Name = "ctMenuMouseArea";
            this.ctMenuMouseArea.Size = new System.Drawing.Size(157, 76);
            // 
            // clearErrorsToolStripMenuItem
            // 
            this.clearErrorsToolStripMenuItem.Name = "clearErrorsToolStripMenuItem";
            this.clearErrorsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearErrorsToolStripMenuItem.Text = "Clear errors";
            this.clearErrorsToolStripMenuItem.Click += new System.EventHandler(this.clearErrorsToolStripMenuItem_Click);
            // 
            // setTriggerTimeToolStripMenuItem
            // 
            this.setTriggerTimeToolStripMenuItem.Name = "setTriggerTimeToolStripMenuItem";
            this.setTriggerTimeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.setTriggerTimeToolStripMenuItem.Text = "Set Trigger time";
            this.setTriggerTimeToolStripMenuItem.Click += new System.EventHandler(this.setTriggerTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // drpBoxValues
            // 
            this.drpBoxValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drpBoxValues.ContextMenuStrip = this.ctMenuMouseArea;
            this.drpBoxValues.Controls.Add(this.tableLayoutPanel3);
            this.drpBoxValues.Controls.Add(this.tableLayoutPanel2);
            this.drpBoxValues.Controls.Add(this.tableLayoutPanel1);
            this.drpBoxValues.Location = new System.Drawing.Point(12, 12);
            this.drpBoxValues.Name = "drpBoxValues";
            this.drpBoxValues.Size = new System.Drawing.Size(429, 116);
            this.drpBoxValues.TabIndex = 5;
            this.drpBoxValues.TabStop = false;
            this.drpBoxValues.Text = "Stats";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.lblThreshhold, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblErrLeft, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblErrRight, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(162, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 41);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblThreshhold
            // 
            this.lblThreshhold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThreshhold.AutoSize = true;
            this.lblThreshhold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshhold.Location = new System.Drawing.Point(3, 24);
            this.lblThreshhold.Name = "lblThreshhold";
            this.lblThreshhold.Size = new System.Drawing.Size(86, 13);
            this.lblThreshhold.TabIndex = 5;
            this.lblThreshhold.Text = "Trigger: 1000 ms";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Left";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Errors";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Right";
            // 
            // lblErrLeft
            // 
            this.lblErrLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrLeft.AutoSize = true;
            this.lblErrLeft.Location = new System.Drawing.Point(105, 24);
            this.lblErrLeft.Name = "lblErrLeft";
            this.lblErrLeft.Size = new System.Drawing.Size(38, 13);
            this.lblErrLeft.TabIndex = 2;
            this.lblErrLeft.Text = "ErrLeft";
            // 
            // lblErrRight
            // 
            this.lblErrRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrRight.AutoSize = true;
            this.lblErrRight.Location = new System.Drawing.Point(182, 24);
            this.lblErrRight.Name = "lblErrRight";
            this.lblErrRight.Size = new System.Drawing.Size(45, 13);
            this.lblErrRight.TabIndex = 4;
            this.lblErrRight.Text = "ErrRight";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblXpos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblYPos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 66);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 41);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Y";
            // 
            // lblXpos
            // 
            this.lblXpos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblXpos.AutoSize = true;
            this.lblXpos.Location = new System.Drawing.Point(3, 24);
            this.lblXpos.Name = "lblXpos";
            this.lblXpos.Size = new System.Drawing.Size(30, 13);
            this.lblXpos.TabIndex = 3;
            this.lblXpos.Text = "xPos";
            // 
            // lblYPos
            // 
            this.lblYPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(78, 24);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(31, 13);
            this.lblYPos.TabIndex = 2;
            this.lblYPos.Text = "Ypos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMiddle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLeft, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRight, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Right";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Middle";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buttons";
            // 
            // lblMiddle
            // 
            this.lblMiddle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(190, 24);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(37, 13);
            this.lblMiddle.TabIndex = 2;
            this.lblMiddle.Text = "middle";
            // 
            // lblLeft
            // 
            this.lblLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(78, 24);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(21, 13);
            this.lblLeft.TabIndex = 4;
            this.lblLeft.Text = "left";
            // 
            // lblRight
            // 
            this.lblRight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(302, 24);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(27, 13);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "right";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 411);
            this.Controls.Add(this.drpBoxValues);
            this.Controls.Add(this.grpBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Tester";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMain)).EndInit();
            this.ctMenuMouseArea.ResumeLayout(false);
            this.drpBoxValues.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMain;
        private System.Windows.Forms.PictureBox picBoxMain;
        private System.Windows.Forms.ContextMenuStrip ctMenuMouseArea;
        private System.Windows.Forms.ToolStripMenuItem clearErrorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTriggerTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox drpBoxValues;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblThreshhold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrLeft;
        private System.Windows.Forms.Label lblErrRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblXpos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
    }
}

