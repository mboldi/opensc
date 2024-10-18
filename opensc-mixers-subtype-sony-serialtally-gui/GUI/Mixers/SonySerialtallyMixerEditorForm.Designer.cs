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
            matrixSizeComboBox = new System.Windows.Forms.ComboBox();
            matrixSizeLabel = new System.Windows.Forms.Label();
            portLabel = new System.Windows.Forms.Label();
            serialPortComboBox = new System.Windows.Forms.ComboBox();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionPanel.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            connectionTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // baseDataTabPage
            // 
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
            connectionPanel.Size = new System.Drawing.Size(698, 97);
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
            connectionGroupBox.Size = new System.Drawing.Size(698, 90);
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
            connectionTable.Size = new System.Drawing.Size(684, 58);
            connectionTable.TabIndex = 0;
            // 
            // connectionTableLayout
            // 
            connectionTableLayout.ColumnCount = 2;
            connectionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.241888F));
            connectionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.75811F));
            connectionTableLayout.Controls.Add(matrixSizeComboBox, 1, 1);
            connectionTableLayout.Controls.Add(matrixSizeLabel, 0, 1);
            connectionTableLayout.Controls.Add(portLabel, 0, 0);
            connectionTableLayout.Controls.Add(serialPortComboBox, 1, 0);
            connectionTableLayout.Location = new System.Drawing.Point(3, 3);
            connectionTableLayout.Name = "connectionTableLayout";
            connectionTableLayout.RowCount = 2;
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            connectionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            connectionTableLayout.Size = new System.Drawing.Size(678, 52);
            connectionTableLayout.TabIndex = 1;
            // 
            // matrixSizeComboBox
            // 
            matrixSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            matrixSizeComboBox.FormattingEnabled = true;
            matrixSizeComboBox.Location = new System.Drawing.Point(86, 29);
            matrixSizeComboBox.Name = "matrixSizeComboBox";
            matrixSizeComboBox.Size = new System.Drawing.Size(291, 23);
            matrixSizeComboBox.TabIndex = 3;
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
            // serialPortComboBox
            // 
            serialPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            serialPortComboBox.FormattingEnabled = true;
            serialPortComboBox.Location = new System.Drawing.Point(86, 3);
            serialPortComboBox.Name = "serialPortComboBox";
            serialPortComboBox.Size = new System.Drawing.Size(291, 23);
            serialPortComboBox.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.TableLayoutPanel connectionTableLayout;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.ComboBox matrixSizeComboBox;
        private System.Windows.Forms.Label matrixSizeLabel;
    }
}