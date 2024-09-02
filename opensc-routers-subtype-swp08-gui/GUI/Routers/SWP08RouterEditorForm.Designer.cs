namespace OpenSC.GUI.Routers
{
    partial class SWP08RouterEditorForm
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
            matrixPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            matrixNumeric = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            levelNumeric = new System.Windows.Forms.NumericUpDown();
            ethernetGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            connectButton = new System.Windows.Forms.Button();
            disconnectButton = new System.Windows.Forms.Button();
            autoReconnectCheckBox = new System.Windows.Forms.CheckBox();
            ipAddressInput = new GeneralComponents.IPAddressControl.IPv4AddressControl();
            ipPortNumeric = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            serialGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            serialPortLabel = new System.Windows.Forms.Label();
            serialPortDropDown = new System.Windows.Forms.ComboBox();
            connTypeGroup = new System.Windows.Forms.GroupBox();
            ethernetControlRadioButton = new System.Windows.Forms.RadioButton();
            serialControlRadioButton = new System.Windows.Forms.RadioButton();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            matrixPropertiesGroupBox.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matrixNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)levelNumeric).BeginInit();
            ethernetGroup.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipPortNumeric).BeginInit();
            serialGroup.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            connTypeGroup.SuspendLayout();
            SuspendLayout();
            // 
            // baseDataTabPage
            // 
            baseDataTabPage.Controls.Add(connTypeGroup);
            baseDataTabPage.Controls.Add(matrixPropertiesGroupBox);
            baseDataTabPage.Controls.Add(serialGroup);
            baseDataTabPage.Controls.Add(ethernetGroup);
            baseDataTabPage.Location = new System.Drawing.Point(4, 24);
            baseDataTabPage.Size = new System.Drawing.Size(835, 379);
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
            customElementsPanel.Size = new System.Drawing.Size(861, 502);
            // 
            // mainContainer
            // 
            mainContainer.Size = new System.Drawing.Size(861, 566);
            // 
            // matrixPropertiesGroupBox
            // 
            matrixPropertiesGroupBox.Controls.Add(tableLayoutPanel4);
            matrixPropertiesGroupBox.Location = new System.Drawing.Point(6, 266);
            matrixPropertiesGroupBox.Name = "matrixPropertiesGroupBox";
            matrixPropertiesGroupBox.Size = new System.Drawing.Size(823, 74);
            matrixPropertiesGroupBox.TabIndex = 4;
            matrixPropertiesGroupBox.TabStop = false;
            matrixPropertiesGroupBox.Text = "Matrix properties";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.92228F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.07772F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 670F));
            tableLayoutPanel4.Controls.Add(matrixNumeric, 1, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(levelNumeric, 1, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(817, 52);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // matrixNumeric
            // 
            matrixNumeric.Location = new System.Drawing.Point(83, 3);
            matrixNumeric.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            matrixNumeric.Name = "matrixNumeric";
            matrixNumeric.Size = new System.Drawing.Size(60, 23);
            matrixNumeric.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Matrix";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 26);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Level";
            // 
            // levelNumeric
            // 
            levelNumeric.Location = new System.Drawing.Point(83, 29);
            levelNumeric.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            levelNumeric.Name = "levelNumeric";
            levelNumeric.Size = new System.Drawing.Size(60, 23);
            levelNumeric.TabIndex = 10;
            // 
            // ethernetGroup
            // 
            ethernetGroup.BackColor = System.Drawing.SystemColors.Control;
            ethernetGroup.Controls.Add(tableLayoutPanel2);
            ethernetGroup.Location = new System.Drawing.Point(6, 122);
            ethernetGroup.Name = "ethernetGroup";
            ethernetGroup.Size = new System.Drawing.Size(823, 136);
            ethernetGroup.TabIndex = 3;
            ethernetGroup.TabStop = false;
            ethernetGroup.Text = "Ethernet control properties";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0264549F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.9735451F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 544F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(connectButton, 1, 2);
            tableLayoutPanel2.Controls.Add(disconnectButton, 2, 2);
            tableLayoutPanel2.Controls.Add(autoReconnectCheckBox, 1, 3);
            tableLayoutPanel2.Controls.Add(ipAddressInput, 1, 0);
            tableLayoutPanel2.Controls.Add(ipPortNumeric, 1, 1);
            tableLayoutPanel2.Controls.Add(label6, 3, 2);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel2.Size = new System.Drawing.Size(817, 114);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "IP address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Auto reconnect";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Port";
            // 
            // connectButton
            // 
            connectButton.Location = new System.Drawing.Point(107, 63);
            connectButton.Name = "connectButton";
            connectButton.Size = new System.Drawing.Size(75, 23);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // disconnectButton
            // 
            disconnectButton.Location = new System.Drawing.Point(192, 63);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new System.Drawing.Size(75, 23);
            disconnectButton.TabIndex = 4;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // autoReconnectCheckBox
            // 
            autoReconnectCheckBox.AutoSize = true;
            autoReconnectCheckBox.Location = new System.Drawing.Point(107, 93);
            autoReconnectCheckBox.Name = "autoReconnectCheckBox";
            autoReconnectCheckBox.Size = new System.Drawing.Size(15, 14);
            autoReconnectCheckBox.TabIndex = 5;
            autoReconnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // ipAddressInput
            // 
            ipAddressInput.AllowInternalTab = false;
            ipAddressInput.AutoHeight = true;
            ipAddressInput.BackColor = System.Drawing.SystemColors.Window;
            ipAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(ipAddressInput, 2);
            ipAddressInput.Location = new System.Drawing.Point(107, 3);
            ipAddressInput.Name = "ipAddressInput";
            ipAddressInput.ReadOnly = false;
            ipAddressInput.Size = new System.Drawing.Size(163, 23);
            ipAddressInput.TabIndex = 6;
            ipAddressInput.Text = "...";
            // 
            // ipPortNumeric
            // 
            ipPortNumeric.Location = new System.Drawing.Point(107, 33);
            ipPortNumeric.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            ipPortNumeric.Name = "ipPortNumeric";
            ipPortNumeric.Size = new System.Drawing.Size(79, 23);
            ipPortNumeric.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Left;
            label6.ForeColor = System.Drawing.Color.IndianRed;
            label6.Location = new System.Drawing.Point(276, 60);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(257, 30);
            label6.TabIndex = 8;
            label6.Text = "Router has to be saved before you can connect!";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialGroup
            // 
            serialGroup.BackColor = System.Drawing.SystemColors.Control;
            serialGroup.Controls.Add(tableLayoutPanel3);
            serialGroup.Location = new System.Drawing.Point(6, 63);
            serialGroup.Name = "serialGroup";
            serialGroup.Size = new System.Drawing.Size(826, 56);
            serialGroup.TabIndex = 2;
            serialGroup.TabStop = false;
            serialGroup.Text = "Serial control properties";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5970335F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.40297F));
            tableLayoutPanel3.Controls.Add(serialPortLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(serialPortDropDown, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(820, 34);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // serialPortLabel
            // 
            serialPortLabel.AutoSize = true;
            serialPortLabel.Location = new System.Drawing.Point(3, 0);
            serialPortLabel.Name = "serialPortLabel";
            serialPortLabel.Size = new System.Drawing.Size(29, 15);
            serialPortLabel.TabIndex = 8;
            serialPortLabel.Text = "Port";
            // 
            // serialPortDropDown
            // 
            serialPortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            serialPortDropDown.FormattingEnabled = true;
            serialPortDropDown.Location = new System.Drawing.Point(114, 3);
            serialPortDropDown.Name = "serialPortDropDown";
            serialPortDropDown.Size = new System.Drawing.Size(166, 23);
            serialPortDropDown.TabIndex = 10;
            // 
            // connTypeGroup
            // 
            connTypeGroup.Controls.Add(ethernetControlRadioButton);
            connTypeGroup.Controls.Add(serialControlRadioButton);
            connTypeGroup.Location = new System.Drawing.Point(6, 6);
            connTypeGroup.Name = "connTypeGroup";
            connTypeGroup.Size = new System.Drawing.Size(826, 51);
            connTypeGroup.TabIndex = 0;
            connTypeGroup.TabStop = false;
            connTypeGroup.Text = "Connection type";
            // 
            // ethernetControlRadioButton
            // 
            ethernetControlRadioButton.AutoSize = true;
            ethernetControlRadioButton.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            ethernetControlRadioButton.Location = new System.Drawing.Point(77, 22);
            ethernetControlRadioButton.Name = "ethernetControlRadioButton";
            ethernetControlRadioButton.Size = new System.Drawing.Size(100, 19);
            ethernetControlRadioButton.TabIndex = 1;
            ethernetControlRadioButton.TabStop = true;
            ethernetControlRadioButton.Text = "Ethernet (TCP)";
            ethernetControlRadioButton.UseVisualStyleBackColor = false;
            // 
            // serialControlRadioButton
            // 
            serialControlRadioButton.AutoSize = true;
            serialControlRadioButton.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            serialControlRadioButton.Checked = true;
            serialControlRadioButton.Location = new System.Drawing.Point(15, 22);
            serialControlRadioButton.Name = "serialControlRadioButton";
            serialControlRadioButton.Size = new System.Drawing.Size(53, 19);
            serialControlRadioButton.TabIndex = 0;
            serialControlRadioButton.TabStop = true;
            serialControlRadioButton.Text = "Serial";
            serialControlRadioButton.UseVisualStyleBackColor = false;
            // 
            // SWP08RouterEditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(861, 618);
            DeleteButtonVisible = true;
            Name = "SWP08RouterEditorForm";
            baseDataTabPage.ResumeLayout(false);
            mainContainer.ResumeLayout(false);
            matrixPropertiesGroupBox.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matrixNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)levelNumeric).EndInit();
            ethernetGroup.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipPortNumeric).EndInit();
            serialGroup.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            connTypeGroup.ResumeLayout(false);
            connTypeGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox connTypeGroup;
        private System.Windows.Forms.RadioButton ethernetControlRadioButton;
        private System.Windows.Forms.RadioButton serialControlRadioButton;
        private System.Windows.Forms.GroupBox serialGroup;
        private System.Windows.Forms.GroupBox ethernetGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.CheckBox autoReconnectCheckBox;
        private GeneralComponents.IPAddressControl.IPv4AddressControl ipAddressInput;
        private System.Windows.Forms.NumericUpDown ipPortNumeric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label serialPortLabel;
        private System.Windows.Forms.GroupBox matrixPropertiesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown matrixNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown levelNumeric;
        private System.Windows.Forms.ComboBox serialPortDropDown;
        private System.Windows.Forms.Label label6;
    }
}