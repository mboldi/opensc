namespace OpenSC.GUI.UMDs
{
    partial class ImageVideoDisplayUmdEditorForm
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
            connectionGroupBox = new System.Windows.Forms.GroupBox();
            connectionTable = new System.Windows.Forms.TableLayoutPanel();
            screenLabel = new System.Windows.Forms.Label();
            indexLabel = new System.Windows.Forms.Label();
            indexNumericInput = new System.Windows.Forms.NumericUpDown();
            screenDropDown = new System.Windows.Forms.ComboBox();
            mainTabControl.SuspendLayout();
            connectionTabPage.SuspendLayout();
            customElementsPanel.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)indexNumericInput).BeginInit();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Location = new System.Drawing.Point(0, 187);
            mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            mainTabControl.Size = new System.Drawing.Size(684, 149);
            // 
            // textsTabPage
            // 
            textsTabPage.Location = new System.Drawing.Point(4, 24);
            textsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textsTabPage.Size = new System.Drawing.Size(524, 125);
            // 
            // talliesTabPage
            // 
            talliesTabPage.Location = new System.Drawing.Point(4, 24);
            talliesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            talliesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            talliesTabPage.Size = new System.Drawing.Size(524, 125);
            // 
            // fullStaticTextTabPage
            // 
            fullStaticTextTabPage.Location = new System.Drawing.Point(4, 24);
            fullStaticTextTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fullStaticTextTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fullStaticTextTabPage.Size = new System.Drawing.Size(524, 125);
            // 
            // connectionTabPage
            // 
            connectionTabPage.Controls.Add(connectionGroupBox);
            connectionTabPage.Location = new System.Drawing.Point(4, 24);
            connectionTabPage.Size = new System.Drawing.Size(676, 121);
            // 
            // customElementsPanel
            // 
            customElementsPanel.Location = new System.Drawing.Point(8, 7);
            customElementsPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            customElementsPanel.Size = new System.Drawing.Size(684, 336);
            // 
            // mainContainer
            // 
            mainContainer.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            mainContainer.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            mainContainer.Size = new System.Drawing.Size(700, 414);
            // 
            // connectionGroupBox
            // 
            connectionGroupBox.AutoSize = true;
            connectionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionGroupBox.Controls.Add(connectionTable);
            connectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            connectionGroupBox.Location = new System.Drawing.Point(3, 2);
            connectionGroupBox.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            connectionGroupBox.Name = "connectionGroupBox";
            connectionGroupBox.Padding = new System.Windows.Forms.Padding(7, 4, 7, 8);
            connectionGroupBox.Size = new System.Drawing.Size(670, 82);
            connectionGroupBox.TabIndex = 1;
            connectionGroupBox.TabStop = false;
            connectionGroupBox.Text = "Display data";
            // 
            // connectionTable
            // 
            connectionTable.AutoSize = true;
            connectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionTable.ColumnCount = 2;
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            connectionTable.Controls.Add(screenLabel, 0, 0);
            connectionTable.Controls.Add(indexLabel, 0, 1);
            connectionTable.Controls.Add(indexNumericInput, 1, 1);
            connectionTable.Controls.Add(screenDropDown, 1, 0);
            connectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionTable.Location = new System.Drawing.Point(7, 20);
            connectionTable.Name = "connectionTable";
            connectionTable.RowCount = 2;
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.Size = new System.Drawing.Size(656, 54);
            connectionTable.TabIndex = 0;
            // 
            // screenLabel
            // 
            screenLabel.AutoSize = true;
            screenLabel.Dock = System.Windows.Forms.DockStyle.Left;
            screenLabel.Location = new System.Drawing.Point(3, 0);
            screenLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            screenLabel.Name = "screenLabel";
            screenLabel.Size = new System.Drawing.Size(42, 27);
            screenLabel.TabIndex = 0;
            screenLabel.Text = "Screen";
            screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Dock = System.Windows.Forms.DockStyle.Left;
            indexLabel.Location = new System.Drawing.Point(3, 27);
            indexLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new System.Drawing.Size(36, 27);
            indexLabel.TabIndex = 1;
            indexLabel.Text = "Index";
            indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexNumericInput
            // 
            indexNumericInput.Dock = System.Windows.Forms.DockStyle.Left;
            indexNumericInput.Location = new System.Drawing.Point(61, 29);
            indexNumericInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            indexNumericInput.Maximum = new decimal(new int[] { 2048, 0, 0, 0 });
            indexNumericInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            indexNumericInput.Name = "indexNumericInput";
            indexNumericInput.Size = new System.Drawing.Size(131, 23);
            indexNumericInput.TabIndex = 2;
            indexNumericInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // screenDropDown
            // 
            screenDropDown.Dock = System.Windows.Forms.DockStyle.Left;
            screenDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            screenDropDown.FormattingEnabled = true;
            screenDropDown.Location = new System.Drawing.Point(61, 2);
            screenDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            screenDropDown.Name = "screenDropDown";
            screenDropDown.Size = new System.Drawing.Size(267, 23);
            screenDropDown.TabIndex = 3;
            // 
            // ImageVideoDisplayUmdEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 466);
            DeleteButtonVisible = true;
            Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            MinimumSize = new System.Drawing.Size(440, 505);
            Name = "ImageVideoDisplayUmdEditorForm";
            mainTabControl.ResumeLayout(false);
            connectionTabPage.ResumeLayout(false);
            connectionTabPage.PerformLayout();
            customElementsPanel.ResumeLayout(false);
            customElementsPanel.PerformLayout();
            mainContainer.ResumeLayout(false);
            connectionGroupBox.ResumeLayout(false);
            connectionGroupBox.PerformLayout();
            connectionTable.ResumeLayout(false);
            connectionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)indexNumericInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.NumericUpDown indexNumericInput;
        private System.Windows.Forms.ComboBox screenDropDown;
    }
}