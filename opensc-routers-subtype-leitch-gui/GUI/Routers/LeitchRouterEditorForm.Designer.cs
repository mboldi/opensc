namespace OpenSC.GUI.Routers
{
    partial class LeitchRouterEditorForm
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
            connectionPanel = new System.Windows.Forms.Panel();
            connectionGroupBox = new System.Windows.Forms.GroupBox();
            connectionTable = new System.Windows.Forms.TableLayoutPanel();
            levelLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            levelNumericField = new System.Windows.Forms.NumericUpDown();
            portDropDown = new System.Windows.Forms.ComboBox();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionPanel.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelNumericField).BeginInit();
            SuspendLayout();
            // 
            // baseDataTabPage
            // 
            baseDataTabPage.Controls.Add(connectionPanel);
            baseDataTabPage.Location = new System.Drawing.Point(4, 24);
            baseDataTabPage.Size = new System.Drawing.Size(835, 280);
            // 
            // inputsButtonsPanel
            // 
            inputsButtonsPanel.Location = new System.Drawing.Point(3, 241);
            inputsButtonsPanel.Size = new System.Drawing.Size(915, 41);
            // 
            // outputsButtonsPanel
            // 
            outputsButtonsPanel.Location = new System.Drawing.Point(3, 241);
            outputsButtonsPanel.Size = new System.Drawing.Size(915, 41);
            // 
            // customElementsPanel
            // 
            customElementsPanel.Padding = new System.Windows.Forms.Padding(8, 10, 8, 0);
            customElementsPanel.Size = new System.Drawing.Size(859, 402);
            // 
            // mainContainer
            // 
            mainContainer.Size = new System.Drawing.Size(859, 466);
            // 
            // connectionPanel
            // 
            connectionPanel.AutoSize = true;
            connectionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionPanel.Controls.Add(connectionGroupBox);
            connectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            connectionPanel.Location = new System.Drawing.Point(3, 3);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            connectionPanel.Size = new System.Drawing.Size(829, 97);
            connectionPanel.TabIndex = 2;
            // 
            // connectionGroupBox
            // 
            connectionGroupBox.AutoSize = true;
            connectionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionGroupBox.Controls.Add(connectionTable);
            connectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionGroupBox.Location = new System.Drawing.Point(0, 0);
            connectionGroupBox.Name = "connectionGroupBox";
            connectionGroupBox.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            connectionGroupBox.Size = new System.Drawing.Size(829, 90);
            connectionGroupBox.TabIndex = 0;
            connectionGroupBox.TabStop = false;
            connectionGroupBox.Text = "Connection";
            // 
            // connectionTable
            // 
            connectionTable.AutoSize = true;
            connectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionTable.ColumnCount = 2;
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            connectionTable.Controls.Add(levelLabel, 0, 1);
            connectionTable.Controls.Add(portLabel, 0, 0);
            connectionTable.Controls.Add(levelNumericField, 1, 1);
            connectionTable.Controls.Add(portDropDown, 1, 0);
            connectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionTable.Location = new System.Drawing.Point(7, 24);
            connectionTable.Name = "connectionTable";
            connectionTable.RowCount = 2;
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.Size = new System.Drawing.Size(815, 58);
            connectionTable.TabIndex = 0;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Dock = System.Windows.Forms.DockStyle.Left;
            levelLabel.Location = new System.Drawing.Point(3, 29);
            levelLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(37, 29);
            levelLabel.TabIndex = 3;
            levelLabel.Text = "Level:";
            levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = System.Windows.Forms.DockStyle.Left;
            portLabel.Location = new System.Drawing.Point(3, 0);
            portLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(32, 29);
            portLabel.TabIndex = 0;
            portLabel.Text = "Port:";
            portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // levelNumericField
            // 
            levelNumericField.Location = new System.Drawing.Point(56, 32);
            levelNumericField.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            levelNumericField.Name = "levelNumericField";
            levelNumericField.Size = new System.Drawing.Size(105, 23);
            levelNumericField.TabIndex = 2;
            // 
            // portDropDown
            // 
            portDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            portDropDown.FormattingEnabled = true;
            portDropDown.Location = new System.Drawing.Point(56, 3);
            portDropDown.Name = "portDropDown";
            portDropDown.Size = new System.Drawing.Size(300, 23);
            portDropDown.TabIndex = 4;
            // 
            // LeitchRouterEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 518);
            DeleteButtonVisible = true;
            MinimumSize = new System.Drawing.Size(769, 530);
            Name = "LeitchRouterEditorForm";
            baseDataTabPage.ResumeLayout(false);
            baseDataTabPage.PerformLayout();
            mainContainer.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            connectionGroupBox.ResumeLayout(false);
            connectionGroupBox.PerformLayout();
            connectionTable.ResumeLayout(false);
            connectionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelNumericField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.NumericUpDown levelNumericField;
        private System.Windows.Forms.ComboBox portDropDown;
    }
}