namespace OpenSC.GUI.Mixers
{
    partial class SonySerialtallyMixerEditorForm
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
            connectionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            matrixSizeLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            serialPortDropdown = new System.Windows.Forms.ComboBox();
            tallySizeDropdown = new System.Windows.Forms.ComboBox();
            matrixSizeDropdown = new System.Windows.Forms.ComboBox();
            tallyGroupSelectionGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            redTallySelectorLabel = new System.Windows.Forms.Label();
            redTallyGroupSelectorNumeric = new System.Windows.Forms.NumericUpDown();
            redTallySelectorDropdown = new System.Windows.Forms.ComboBox();
            greenTallySelectorDropdown = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            greenTallyGroupSelectorNumeric = new System.Windows.Forms.NumericUpDown();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionPanel.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            connectionTableLayout.SuspendLayout();
            tallyGroupSelectionGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)redTallyGroupSelectorNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTallyGroupSelectorNumeric).BeginInit();
            SuspendLayout();
            // 
            // baseDataTabPage
            // 
            baseDataTabPage.Controls.Add(tallyGroupSelectionGroup);
            baseDataTabPage.Controls.Add(connectionPanel);
            baseDataTabPage.Location = new System.Drawing.Point(4, 24);
            baseDataTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            baseDataTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            baseDataTabPage.Size = new System.Drawing.Size(704, 295);
            // 
            // inputsButtonsPanel
            // 
            inputsButtonsPanel.Location = new System.Drawing.Point(3, 155);
            inputsButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            inputsButtonsPanel.Size = new System.Drawing.Size(698, 41);
            // 
            // customElementsPanel
            // 
            customElementsPanel.Padding = new System.Windows.Forms.Padding(9, 14, 9, 0);
            customElementsPanel.Size = new System.Drawing.Size(730, 421);
            // 
            // mainContainer
            // 
            mainContainer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            mainContainer.Size = new System.Drawing.Size(730, 485);
            // 
            // connectionPanel
            // 
            connectionPanel.AutoSize = true;
            connectionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionPanel.Controls.Add(connectionGroupBox);
            connectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            connectionPanel.Location = new System.Drawing.Point(3, 4);
            connectionPanel.Name = "connectionPanel";
            connectionPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            connectionPanel.Size = new System.Drawing.Size(698, 123);
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
            connectionGroupBox.Size = new System.Drawing.Size(698, 116);
            connectionGroupBox.TabIndex = 0;
            connectionGroupBox.TabStop = false;
            connectionGroupBox.Text = "Connection";
            // 
            // connectionTable
            // 
            connectionTable.AutoSize = true;
            connectionTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionTable.ColumnCount = 4;
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            connectionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            connectionTable.Controls.Add(connectionTableLayout, 3, 2);
            connectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionTable.Location = new System.Drawing.Point(7, 24);
            connectionTable.Name = "connectionTable";
            connectionTable.RowCount = 3;
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.Size = new System.Drawing.Size(684, 84);
            connectionTable.TabIndex = 0;
            // 
            // connectionTableLayout
            // 
            connectionTableLayout.ColumnCount = 2;
            connectionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.24189F));
            connectionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.75811F));
            connectionTableLayout.Controls.Add(label6, 0, 2);
            connectionTableLayout.Controls.Add(matrixSizeLabel, 0, 1);
            connectionTableLayout.Controls.Add(portLabel, 0, 0);
            connectionTableLayout.Controls.Add(serialPortDropdown, 1, 0);
            connectionTableLayout.Controls.Add(tallySizeDropdown, 1, 2);
            connectionTableLayout.Controls.Add(matrixSizeDropdown, 1, 1);
            connectionTableLayout.Location = new System.Drawing.Point(3, 3);
            connectionTableLayout.Name = "connectionTableLayout";
            connectionTableLayout.RowCount = 3;
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            connectionTableLayout.Size = new System.Drawing.Size(678, 78);
            connectionTableLayout.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Left;
            label6.Location = new System.Drawing.Point(3, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 26);
            label6.TabIndex = 4;
            label6.Text = "Tally size:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matrixSizeLabel
            // 
            matrixSizeLabel.AutoSize = true;
            matrixSizeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            matrixSizeLabel.Location = new System.Drawing.Point(3, 26);
            matrixSizeLabel.Name = "matrixSizeLabel";
            matrixSizeLabel.Size = new System.Drawing.Size(66, 26);
            matrixSizeLabel.TabIndex = 2;
            matrixSizeLabel.Text = "Matrix size:";
            matrixSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = System.Windows.Forms.DockStyle.Left;
            portLabel.Location = new System.Drawing.Point(3, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(32, 26);
            portLabel.TabIndex = 0;
            portLabel.Text = "Port:";
            portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialPortDropdown
            // 
            serialPortDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            serialPortDropdown.FormattingEnabled = true;
            serialPortDropdown.Location = new System.Drawing.Point(86, 3);
            serialPortDropdown.Name = "serialPortDropdown";
            serialPortDropdown.Size = new System.Drawing.Size(291, 23);
            serialPortDropdown.TabIndex = 1;
            // 
            // tallySizeDropdown
            // 
            tallySizeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            tallySizeDropdown.FormattingEnabled = true;
            tallySizeDropdown.Location = new System.Drawing.Point(86, 55);
            tallySizeDropdown.Name = "tallySizeDropdown";
            tallySizeDropdown.Size = new System.Drawing.Size(291, 23);
            tallySizeDropdown.TabIndex = 3;
            // 
            // matrixSizeDropdown
            // 
            matrixSizeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            matrixSizeDropdown.FormattingEnabled = true;
            matrixSizeDropdown.Location = new System.Drawing.Point(86, 29);
            matrixSizeDropdown.Name = "matrixSizeDropdown";
            matrixSizeDropdown.Size = new System.Drawing.Size(291, 23);
            matrixSizeDropdown.TabIndex = 5;
            // 
            // tallyGroupSelectionGroup
            // 
            tallyGroupSelectionGroup.AutoSize = true;
            tallyGroupSelectionGroup.Controls.Add(tableLayoutPanel1);
            tallyGroupSelectionGroup.Dock = System.Windows.Forms.DockStyle.Top;
            tallyGroupSelectionGroup.Location = new System.Drawing.Point(3, 127);
            tallyGroupSelectionGroup.Name = "tallyGroupSelectionGroup";
            tallyGroupSelectionGroup.Size = new System.Drawing.Size(698, 148);
            tallyGroupSelectionGroup.TabIndex = 3;
            tallyGroupSelectionGroup.TabStop = false;
            tallyGroupSelectionGroup.Text = "Sony tally groups to use as source for red and green tally";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4816446F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.9779739F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.39354F));
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(redTallySelectorLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(redTallyGroupSelectorNumeric, 2, 0);
            tableLayoutPanel1.Controls.Add(redTallySelectorDropdown, 2, 1);
            tableLayoutPanel1.Controls.Add(greenTallySelectorDropdown, 2, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(greenTallyGroupSelectorNumeric, 2, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(681, 104);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.Location = new System.Drawing.Point(88, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 26);
            label3.TabIndex = 10;
            label3.Text = "Sony tally color:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(88, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 26);
            label1.TabIndex = 8;
            label1.Text = "Sony group:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redTallySelectorLabel
            // 
            redTallySelectorLabel.AutoSize = true;
            redTallySelectorLabel.Dock = System.Windows.Forms.DockStyle.Left;
            redTallySelectorLabel.Location = new System.Drawing.Point(3, 0);
            redTallySelectorLabel.Name = "redTallySelectorLabel";
            redTallySelectorLabel.Size = new System.Drawing.Size(55, 26);
            redTallySelectorLabel.TabIndex = 0;
            redTallySelectorLabel.Text = "Red tally:";
            redTallySelectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redTallyGroupSelectorNumeric
            // 
            redTallyGroupSelectorNumeric.Location = new System.Drawing.Point(190, 3);
            redTallyGroupSelectorNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            redTallyGroupSelectorNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            redTallyGroupSelectorNumeric.Name = "redTallyGroupSelectorNumeric";
            redTallyGroupSelectorNumeric.Size = new System.Drawing.Size(117, 23);
            redTallyGroupSelectorNumeric.TabIndex = 7;
            redTallyGroupSelectorNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // redTallySelectorDropdown
            // 
            redTallySelectorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            redTallySelectorDropdown.FormattingEnabled = true;
            redTallySelectorDropdown.Location = new System.Drawing.Point(190, 29);
            redTallySelectorDropdown.Name = "redTallySelectorDropdown";
            redTallySelectorDropdown.Size = new System.Drawing.Size(190, 23);
            redTallySelectorDropdown.TabIndex = 4;
            // 
            // greenTallySelectorDropdown
            // 
            greenTallySelectorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            greenTallySelectorDropdown.FormattingEnabled = true;
            greenTallySelectorDropdown.Location = new System.Drawing.Point(190, 81);
            greenTallySelectorDropdown.Name = "greenTallySelectorDropdown";
            greenTallySelectorDropdown.Size = new System.Drawing.Size(190, 23);
            greenTallySelectorDropdown.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Left;
            label5.Location = new System.Drawing.Point(3, 52);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 26);
            label5.TabIndex = 13;
            label5.Text = "Green tally:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Left;
            label2.Location = new System.Drawing.Point(88, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 26);
            label2.TabIndex = 14;
            label2.Text = "Sony tally color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Left;
            label4.Location = new System.Drawing.Point(88, 52);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 26);
            label4.TabIndex = 15;
            label4.Text = "Sony group:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greenTallyGroupSelectorNumeric
            // 
            greenTallyGroupSelectorNumeric.Location = new System.Drawing.Point(190, 55);
            greenTallyGroupSelectorNumeric.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            greenTallyGroupSelectorNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            greenTallyGroupSelectorNumeric.Name = "greenTallyGroupSelectorNumeric";
            greenTallyGroupSelectorNumeric.Size = new System.Drawing.Size(117, 23);
            greenTallyGroupSelectorNumeric.TabIndex = 16;
            greenTallyGroupSelectorNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SonySerialtallyMixerEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(730, 537);
            DeleteButtonVisible = true;
            Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            MinimumSize = new System.Drawing.Size(746, 576);
            Name = "SonySerialtallyMixerEditorForm";
            baseDataTabPage.ResumeLayout(false);
            baseDataTabPage.PerformLayout();
            mainContainer.ResumeLayout(false);
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            connectionGroupBox.ResumeLayout(false);
            connectionGroupBox.PerformLayout();
            connectionTable.ResumeLayout(false);
            connectionTableLayout.ResumeLayout(false);
            connectionTableLayout.PerformLayout();
            tallyGroupSelectionGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)redTallyGroupSelectorNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTallyGroupSelectorNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.TableLayoutPanel connectionTableLayout;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ComboBox serialPortDropdown;
        private System.Windows.Forms.ComboBox tallySizeDropdown;
        private System.Windows.Forms.Label matrixSizeLabel;
        private System.Windows.Forms.GroupBox tallyGroupSelectionGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label redTallySelectorLabel;
        private System.Windows.Forms.ComboBox redTallySelectorDropdown;
        private System.Windows.Forms.ComboBox greenTallySelectorDropdown;
        private System.Windows.Forms.NumericUpDown redTallyGroupSelectorNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown greenTallyGroupSelectorNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox matrixSizeDropdown;
    }
}