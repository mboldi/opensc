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
            disconnectButton = new System.Windows.Forms.Button();
            ipAddressLabel = new System.Windows.Forms.Label();
            autoReconnectCheckbox = new System.Windows.Forms.CheckBox();
            autoReconnectLabel = new System.Windows.Forms.Label();
            connectButton = new System.Windows.Forms.Button();
            ipAddressInput = new GeneralComponents.IPAddressControl.IPv4AddressControl();
            baseDataTabPage.SuspendLayout();
            mainContainer.SuspendLayout();
            connectionPanel.SuspendLayout();
            connectionGroupBox.SuspendLayout();
            connectionTable.SuspendLayout();
            SuspendLayout();
            // 
            // baseDataTabPage
            // 
            baseDataTabPage.Controls.Add(connectionPanel);
            baseDataTabPage.Location = new System.Drawing.Point(4, 24);
            baseDataTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            baseDataTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            baseDataTabPage.Size = new System.Drawing.Size(704, 297);
            // 
            // inputsButtonsPanel
            // 
            inputsButtonsPanel.Location = new System.Drawing.Point(3, 254);
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
            connectionPanel.Size = new System.Drawing.Size(698, 116);
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
            connectionGroupBox.Size = new System.Drawing.Size(698, 109);
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
            connectionTable.Controls.Add(disconnectButton, 2, 1);
            connectionTable.Controls.Add(ipAddressLabel, 0, 0);
            connectionTable.Controls.Add(autoReconnectCheckbox, 1, 2);
            connectionTable.Controls.Add(autoReconnectLabel, 0, 2);
            connectionTable.Controls.Add(connectButton, 1, 1);
            connectionTable.Controls.Add(ipAddressInput, 1, 0);
            connectionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            connectionTable.Location = new System.Drawing.Point(7, 24);
            connectionTable.Name = "connectionTable";
            connectionTable.RowCount = 3;
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            connectionTable.Size = new System.Drawing.Size(684, 77);
            connectionTable.TabIndex = 0;
            // 
            // disconnectButton
            // 
            disconnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            disconnectButton.Location = new System.Drawing.Point(205, 30);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new System.Drawing.Size(88, 24);
            disconnectButton.TabIndex = 1;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            disconnectButton.Click += disconnectButton_Click;
            // 
            // ipAddressLabel
            // 
            ipAddressLabel.AutoSize = true;
            ipAddressLabel.Dock = System.Windows.Forms.DockStyle.Left;
            ipAddressLabel.Location = new System.Drawing.Point(3, 0);
            ipAddressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            ipAddressLabel.Name = "ipAddressLabel";
            ipAddressLabel.Size = new System.Drawing.Size(63, 27);
            ipAddressLabel.TabIndex = 0;
            ipAddressLabel.Text = "IP address:";
            ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoReconnectCheckbox
            // 
            autoReconnectCheckbox.AutoSize = true;
            autoReconnectCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            autoReconnectCheckbox.Location = new System.Drawing.Point(111, 60);
            autoReconnectCheckbox.Name = "autoReconnectCheckbox";
            autoReconnectCheckbox.Size = new System.Drawing.Size(15, 14);
            autoReconnectCheckbox.TabIndex = 3;
            autoReconnectCheckbox.UseVisualStyleBackColor = true;
            // 
            // autoReconnectLabel
            // 
            autoReconnectLabel.AutoSize = true;
            autoReconnectLabel.Dock = System.Windows.Forms.DockStyle.Left;
            autoReconnectLabel.Location = new System.Drawing.Point(3, 57);
            autoReconnectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 13, 0);
            autoReconnectLabel.Name = "autoReconnectLabel";
            autoReconnectLabel.Size = new System.Drawing.Size(92, 20);
            autoReconnectLabel.TabIndex = 4;
            autoReconnectLabel.Text = "Auto reconnect:";
            autoReconnectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // connectButton
            // 
            connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            connectButton.Location = new System.Drawing.Point(111, 30);
            connectButton.Name = "connectButton";
            connectButton.Size = new System.Drawing.Size(88, 24);
            connectButton.TabIndex = 0;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // ipAddressInput
            // 
            ipAddressInput.AllowInternalTab = false;
            ipAddressInput.AutoHeight = true;
            ipAddressInput.BackColor = System.Drawing.SystemColors.Window;
            ipAddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            connectionTable.SetColumnSpan(ipAddressInput, 2);
            ipAddressInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            ipAddressInput.Dock = System.Windows.Forms.DockStyle.Fill;
            ipAddressInput.Location = new System.Drawing.Point(113, 3);
            ipAddressInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ipAddressInput.Name = "ipAddressInput";
            ipAddressInput.ReadOnly = false;
            ipAddressInput.Size = new System.Drawing.Size(182, 19);
            ipAddressInput.TabIndex = 5;
            ipAddressInput.Text = "...";
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
            connectionTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel connectionTable;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.CheckBox autoReconnectCheckbox;
        private System.Windows.Forms.Label autoReconnectLabel;
        private GeneralComponents.IPAddressControl.IPv4AddressControl ipAddressInput;
    }
}