﻿namespace OpenSC.GUI.Routers
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
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ethernetGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            connectButton = new System.Windows.Forms.Button();
            disconnectButton = new System.Windows.Forms.Button();
            autoReconnectCheckBox = new System.Windows.Forms.CheckBox();
            iPv4AddressControl1 = new GeneralComponents.IPAddressControl.IPv4AddressControl();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            serialGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            serialPortLabel = new System.Windows.Forms.Label();
            serialPortDropdown = new System.Windows.Forms.ComboBox();
            connTypeGroup = new System.Windows.Forms.GroupBox();
            ethernetControlRadioButton = new System.Windows.Forms.RadioButton();
            serialControlRadioButton = new System.Windows.Forms.RadioButton();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            matrixPropertiesGroupBox.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ethernetGroup.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            inputsButtonsPanel.Location = new System.Drawing.Point(3, 335);
            inputsButtonsPanel.Size = new System.Drawing.Size(829, 41);
            // 
            // outputsButtonsPanel
            // 
            outputsButtonsPanel.Location = new System.Drawing.Point(3, 335);
            outputsButtonsPanel.Size = new System.Drawing.Size(829, 41);
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
            matrixPropertiesGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.2456131F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.7543869F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            tableLayoutPanel4.Controls.Add(numericUpDown2, 1, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(numericUpDown3, 1, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(817, 52);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(114, 3);
            numericUpDown2.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(84, 23);
            numericUpDown2.TabIndex = 8;
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
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(114, 29);
            numericUpDown3.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(84, 23);
            numericUpDown3.TabIndex = 10;
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
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(connectButton, 1, 2);
            tableLayoutPanel2.Controls.Add(disconnectButton, 2, 2);
            tableLayoutPanel2.Controls.Add(autoReconnectCheckBox, 1, 3);
            tableLayoutPanel2.Controls.Add(iPv4AddressControl1, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDown1, 1, 1);
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
            connectButton.Location = new System.Drawing.Point(115, 63);
            connectButton.Name = "connectButton";
            connectButton.Size = new System.Drawing.Size(75, 23);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            disconnectButton.Location = new System.Drawing.Point(206, 63);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new System.Drawing.Size(75, 23);
            disconnectButton.TabIndex = 4;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            // 
            // autoReconnectCheckBox
            // 
            autoReconnectCheckBox.AutoSize = true;
            autoReconnectCheckBox.Location = new System.Drawing.Point(115, 93);
            autoReconnectCheckBox.Name = "autoReconnectCheckBox";
            autoReconnectCheckBox.Size = new System.Drawing.Size(15, 14);
            autoReconnectCheckBox.TabIndex = 5;
            autoReconnectCheckBox.UseVisualStyleBackColor = true;
            // 
            // iPv4AddressControl1
            // 
            iPv4AddressControl1.AllowInternalTab = false;
            iPv4AddressControl1.AutoHeight = true;
            iPv4AddressControl1.BackColor = System.Drawing.SystemColors.Window;
            iPv4AddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(iPv4AddressControl1, 2);
            iPv4AddressControl1.Location = new System.Drawing.Point(115, 3);
            iPv4AddressControl1.Name = "iPv4AddressControl1";
            iPv4AddressControl1.ReadOnly = false;
            iPv4AddressControl1.Size = new System.Drawing.Size(166, 23);
            iPv4AddressControl1.TabIndex = 6;
            iPv4AddressControl1.Text = "...";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(115, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(82, 23);
            numericUpDown1.TabIndex = 7;
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
            tableLayoutPanel3.Controls.Add(serialPortDropdown, 1, 0);
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
            // serialPortDropdown
            // 
            serialPortDropdown.FormattingEnabled = true;
            serialPortDropdown.Location = new System.Drawing.Point(114, 3);
            serialPortDropdown.Name = "serialPortDropdown";
            serialPortDropdown.Size = new System.Drawing.Size(168, 23);
            serialPortDropdown.TabIndex = 9;
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
            ethernetControlRadioButton.Location = new System.Drawing.Point(77, 22);
            ethernetControlRadioButton.Name = "ethernetControlRadioButton";
            ethernetControlRadioButton.Size = new System.Drawing.Size(100, 19);
            ethernetControlRadioButton.TabIndex = 1;
            ethernetControlRadioButton.TabStop = true;
            ethernetControlRadioButton.Text = "Ethernet (TCP)";
            ethernetControlRadioButton.UseVisualStyleBackColor = true;
            // 
            // serialControlRadioButton
            // 
            serialControlRadioButton.AutoSize = true;
            serialControlRadioButton.Location = new System.Drawing.Point(15, 22);
            serialControlRadioButton.Name = "serialControlRadioButton";
            serialControlRadioButton.Size = new System.Drawing.Size(53, 19);
            serialControlRadioButton.TabIndex = 0;
            serialControlRadioButton.TabStop = true;
            serialControlRadioButton.Text = "Serial";
            serialControlRadioButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ethernetGroup.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private GeneralComponents.IPAddressControl.IPv4AddressControl iPv4AddressControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label serialPortLabel;
        private System.Windows.Forms.ComboBox serialPortDropdown;
        private System.Windows.Forms.GroupBox matrixPropertiesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}