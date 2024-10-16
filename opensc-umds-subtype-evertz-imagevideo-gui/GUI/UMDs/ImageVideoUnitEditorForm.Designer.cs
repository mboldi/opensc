namespace OpenSC.GUI.UMDs
{
    partial class ImageVideoUnitEditorForm
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
            portNumericInput = new System.Windows.Forms.NumericUpDown();
            portLabel = new System.Windows.Forms.Label();
            ipAddressLabel = new System.Windows.Forms.Label();
            indexLabel = new System.Windows.Forms.Label();
            indexNumericInput = new System.Windows.Forms.NumericUpDown();
            ipAddressInput = new GeneralComponents.IPAddressControl.IPv4AddressControl();
            customElementsPanel.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)portNumericInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indexNumericInput).BeginInit();
            SuspendLayout();
            // 
            // customElementsPanel
            // 
            customElementsPanel.Controls.Add(connectionGroupBox);
            customElementsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            customElementsPanel.Padding = new System.Windows.Forms.Padding(9, 11, 9, 0);
            customElementsPanel.Size = new System.Drawing.Size(424, 306);
            customElementsPanel.Controls.SetChildIndex(connectionGroupBox, 0);
            // 
            // mainContainer
            // 
            mainContainer.Size = new System.Drawing.Size(424, 370);
            // 
            // connectionGroupBox
            // 
            connectionGroupBox.AutoSize = true;
            connectionGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            connectionGroupBox.Controls.Add(connectionTable);
            connectionGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            connectionGroupBox.Location = new System.Drawing.Point(9, 93);
            connectionGroupBox.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            connectionGroupBox.Name = "connectionGroupBox";
            connectionGroupBox.Padding = new System.Windows.Forms.Padding(7, 4, 7, 8);
            connectionGroupBox.Size = new System.Drawing.Size(406, 109);
            connectionGroupBox.TabIndex = 4;
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
            connectionTable.Controls.Add(portNumericInput, 1, 1);
            connectionTable.Controls.Add(portLabel, 0, 1);
            connectionTable.Controls.Add(ipAddressLabel, 0, 0);
            connectionTable.Controls.Add(indexLabel, 0, 2);
            connectionTable.Controls.Add(indexNumericInput, 1, 2);
            connectionTable.Controls.Add(ipAddressInput, 1, 0);
            connectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionTable.Location = new System.Drawing.Point(7, 20);
            connectionTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            connectionTable.Name = "connectionTable";
            connectionTable.RowCount = 3;
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.Size = new System.Drawing.Size(392, 81);
            connectionTable.TabIndex = 0;
            // 
            // portNumericInput
            // 
            portNumericInput.Dock = System.Windows.Forms.DockStyle.Left;
            portNumericInput.Location = new System.Drawing.Point(79, 29);
            portNumericInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            portNumericInput.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            portNumericInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            portNumericInput.Name = "portNumericInput";
            portNumericInput.Size = new System.Drawing.Size(132, 23);
            portNumericInput.TabIndex = 6;
            portNumericInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Dock = System.Windows.Forms.DockStyle.Left;
            portLabel.Location = new System.Drawing.Point(3, 27);
            portLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(29, 27);
            portLabel.TabIndex = 5;
            portLabel.Text = "Port";
            portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Dock = System.Windows.Forms.DockStyle.Left;
            ipAddressLabel.Location = new System.Drawing.Point(3, 0);
            ipAddressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new System.Drawing.Size(60, 27);
            ipAddressLabel.TabIndex = 0;
            ipAddressLabel.Text = "IP address";
            ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexLabel
            // 
            indexLabel.AutoSize = true;
            indexLabel.Dock = System.Windows.Forms.DockStyle.Left;
            indexLabel.Location = new System.Drawing.Point(3, 54);
            indexLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            indexLabel.Name = "indexLabel";
            indexLabel.Size = new System.Drawing.Size(36, 27);
            indexLabel.TabIndex = 2;
            indexLabel.Text = "Index";
            indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexNumericInput
            // 
            indexNumericInput.Dock = System.Windows.Forms.DockStyle.Left;
            indexNumericInput.Location = new System.Drawing.Point(79, 56);
            indexNumericInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            indexNumericInput.Maximum = new decimal(new int[] { 65534, 0, 0, 0 });
            indexNumericInput.Name = "indexNumericInput";
            indexNumericInput.Size = new System.Drawing.Size(132, 23);
            indexNumericInput.TabIndex = 3;
            // 
            // ipAddressInput
            // 
            ipAddressInput.AllowInternalTab = false;
            ipAddressInput.AutoHeight = true;
            ipAddressInput.BackColor = System.Drawing.SystemColors.Window;
            ipAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ipAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            ipAddressInput.Dock = System.Windows.Forms.DockStyle.Left;
            ipAddressInput.Location = new System.Drawing.Point(81, 3);
            ipAddressInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ipAddressInput.Name = "ipAddressInput";
            ipAddressInput.ReadOnly = false;
            ipAddressInput.Size = new System.Drawing.Size(186, 23);
            ipAddressInput.TabIndex = 7;
            ipAddressInput.Text = "...";
            // 
            // ImageVideoScreenEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(424, 422);
            DeleteButtonVisible = true;
            HeaderText = "New TSL 5.0 screen";
            Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            MinimumSize = new System.Drawing.Size(440, 224);
            Name = "ImageVideoScreenEditorForm";
            SubjectPlural = "TSL 5.0 screens";
            SubjectSingular = "TSL 5.0 screen";
            Text = "New TSL 5.0 screen";
            customElementsPanel.ResumeLayout(false);
            customElementsPanel.PerformLayout();
            mainContainer.ResumeLayout(false);
            connectionGroupBox.ResumeLayout(false);
            connectionGroupBox.PerformLayout();
            connectionTable.ResumeLayout(false);
            connectionTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)portNumericInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)indexNumericInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.NumericUpDown indexNumericInput;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown portNumericInput;
        private GeneralComponents.IPAddressControl.IPv4AddressControl ipAddressInput;
    }
}