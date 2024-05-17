namespace OpenSC.GUI.Routers
{
    partial class Swp08EditorForm
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
            headerPanel = new System.Windows.Forms.Panel();
            titleLabel = new System.Windows.Forms.Label();
            footerPanel = new System.Windows.Forms.Panel();
            cancelButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            saveAndCloseButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            customElementsPanel = new System.Windows.Forms.Panel();
            dataTabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            connTypeGroup = new System.Windows.Forms.GroupBox();
            ethernetControlRadioButton = new System.Windows.Forms.RadioButton();
            serialControlRadioButton = new System.Windows.Forms.RadioButton();
            tabPage2 = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            addInputButton = new System.Windows.Forms.Button();
            inputNamesSplitButton = new GeneralComponents.SplitButton();
            inputsDataGrid = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            outputDataGrid = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            addOutputButton = new System.Windows.Forms.Button();
            outputNamesSplitButton = new GeneralComponents.SplitButton();
            identifiersGroup = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idUpdown = new System.Windows.Forms.NumericUpDown();
            nameTextbox = new System.Windows.Forms.TextBox();
            headerPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            customElementsPanel.SuspendLayout();
            dataTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputsDataGrid).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outputDataGrid).BeginInit();
            panel2.SuspendLayout();
            identifiersGroup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idUpdown).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(849, 52);
            headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleLabel.Location = new System.Drawing.Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(132, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "New router";
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(cancelButton);
            footerPanel.Controls.Add(saveButton);
            footerPanel.Controls.Add(saveAndCloseButton);
            footerPanel.Controls.Add(deleteButton);
            footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            footerPanel.Location = new System.Drawing.Point(0, 614);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new System.Drawing.Size(849, 58);
            footerPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cancelButton.Location = new System.Drawing.Point(577, 13);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(66, 33);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            saveButton.Location = new System.Drawing.Point(649, 13);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(66, 33);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            saveAndCloseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            saveAndCloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            saveAndCloseButton.Location = new System.Drawing.Point(721, 13);
            saveAndCloseButton.Name = "saveAndCloseButton";
            saveAndCloseButton.Size = new System.Drawing.Size(118, 33);
            saveAndCloseButton.TabIndex = 3;
            saveAndCloseButton.Text = "Save and close";
            saveAndCloseButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            deleteButton.Location = new System.Drawing.Point(9, 13);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(73, 33);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // customElementsPanel
            // 
            customElementsPanel.Controls.Add(dataTabControl);
            customElementsPanel.Controls.Add(identifiersGroup);
            customElementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            customElementsPanel.Location = new System.Drawing.Point(0, 52);
            customElementsPanel.Name = "customElementsPanel";
            customElementsPanel.Size = new System.Drawing.Size(849, 562);
            customElementsPanel.TabIndex = 2;
            // 
            // dataTabControl
            // 
            dataTabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataTabControl.Controls.Add(tabPage1);
            dataTabControl.Controls.Add(tabPage2);
            dataTabControl.Controls.Add(tabPage3);
            dataTabControl.Location = new System.Drawing.Point(6, 107);
            dataTabControl.Name = "dataTabControl";
            dataTabControl.SelectedIndex = 0;
            dataTabControl.Size = new System.Drawing.Size(837, 449);
            dataTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.SystemColors.Control;
            tabPage1.Controls.Add(matrixPropertiesGroupBox);
            tabPage1.Controls.Add(ethernetGroup);
            tabPage1.Controls.Add(serialGroup);
            tabPage1.Controls.Add(connTypeGroup);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(829, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Base data";
            // 
            // matrixPropertiesGroupBox
            // 
            matrixPropertiesGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            matrixPropertiesGroupBox.Controls.Add(tableLayoutPanel4);
            matrixPropertiesGroupBox.Location = new System.Drawing.Point(6, 266);
            matrixPropertiesGroupBox.Name = "matrixPropertiesGroupBox";
            matrixPropertiesGroupBox.Size = new System.Drawing.Size(817, 74);
            matrixPropertiesGroupBox.TabIndex = 4;
            matrixPropertiesGroupBox.TabStop = false;
            matrixPropertiesGroupBox.Text = "Matrix properties";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.2456131F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.7543869F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 524F));
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
            tableLayoutPanel4.Size = new System.Drawing.Size(811, 52);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(112, 3);
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
            numericUpDown3.Location = new System.Drawing.Point(112, 29);
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
            ethernetGroup.Size = new System.Drawing.Size(815, 136);
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
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 525F));
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
            tableLayoutPanel2.Size = new System.Drawing.Size(809, 114);
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
            connectButton.Location = new System.Drawing.Point(113, 63);
            connectButton.Name = "connectButton";
            connectButton.Size = new System.Drawing.Size(75, 23);
            connectButton.TabIndex = 3;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            disconnectButton.Location = new System.Drawing.Point(202, 63);
            disconnectButton.Name = "disconnectButton";
            disconnectButton.Size = new System.Drawing.Size(75, 23);
            disconnectButton.TabIndex = 4;
            disconnectButton.Text = "Disconnect";
            disconnectButton.UseVisualStyleBackColor = true;
            // 
            // autoReconnectCheckBox
            // 
            autoReconnectCheckBox.AutoSize = true;
            autoReconnectCheckBox.Location = new System.Drawing.Point(113, 93);
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
            iPv4AddressControl1.Location = new System.Drawing.Point(113, 3);
            iPv4AddressControl1.Name = "iPv4AddressControl1";
            iPv4AddressControl1.ReadOnly = false;
            iPv4AddressControl1.Size = new System.Drawing.Size(167, 23);
            iPv4AddressControl1.TabIndex = 6;
            iPv4AddressControl1.Text = "...";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(113, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(83, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // serialGroup
            // 
            serialGroup.BackColor = System.Drawing.SystemColors.Control;
            serialGroup.Controls.Add(tableLayoutPanel3);
            serialGroup.Location = new System.Drawing.Point(6, 63);
            serialGroup.Name = "serialGroup";
            serialGroup.Size = new System.Drawing.Size(815, 56);
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
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(809, 34);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(113, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(168, 23);
            comboBox1.TabIndex = 9;
            // 
            // connTypeGroup
            // 
            connTypeGroup.Controls.Add(ethernetControlRadioButton);
            connTypeGroup.Controls.Add(serialControlRadioButton);
            connTypeGroup.Location = new System.Drawing.Point(6, 6);
            connTypeGroup.Name = "connTypeGroup";
            connTypeGroup.Size = new System.Drawing.Size(815, 51);
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
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.SystemColors.Control;
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(inputsDataGrid);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(829, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inputs";
            // 
            // panel1
            // 
            panel1.Controls.Add(addInputButton);
            panel1.Controls.Add(inputNamesSplitButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(3, 376);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(823, 42);
            panel1.TabIndex = 1;
            // 
            // addInputButton
            // 
            addInputButton.Location = new System.Drawing.Point(3, 10);
            addInputButton.Name = "addInputButton";
            addInputButton.Size = new System.Drawing.Size(106, 23);
            addInputButton.TabIndex = 1;
            addInputButton.Text = "Add input";
            addInputButton.UseVisualStyleBackColor = true;
            // 
            // inputNamesSplitButton
            // 
            inputNamesSplitButton.Location = new System.Drawing.Point(115, 10);
            inputNamesSplitButton.Name = "inputNamesSplitButton";
            inputNamesSplitButton.Size = new System.Drawing.Size(110, 23);
            inputNamesSplitButton.TabIndex = 0;
            inputNamesSplitButton.Text = "Names";
            inputNamesSplitButton.UseVisualStyleBackColor = true;
            // 
            // inputsDataGrid
            // 
            inputsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inputsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            inputsDataGrid.Location = new System.Drawing.Point(3, 3);
            inputsDataGrid.Name = "inputsDataGrid";
            inputsDataGrid.RowTemplate.Height = 25;
            inputsDataGrid.Size = new System.Drawing.Size(823, 415);
            inputsDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.SystemColors.Control;
            tabPage3.Controls.Add(outputDataGrid);
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(829, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Outputs";
            // 
            // outputDataGrid
            // 
            outputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            outputDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            outputDataGrid.Location = new System.Drawing.Point(3, 3);
            outputDataGrid.Name = "outputDataGrid";
            outputDataGrid.RowTemplate.Height = 25;
            outputDataGrid.Size = new System.Drawing.Size(823, 373);
            outputDataGrid.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(addOutputButton);
            panel2.Controls.Add(outputNamesSplitButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(3, 376);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(823, 42);
            panel2.TabIndex = 2;
            // 
            // addOutputButton
            // 
            addOutputButton.Location = new System.Drawing.Point(3, 10);
            addOutputButton.Name = "addOutputButton";
            addOutputButton.Size = new System.Drawing.Size(106, 23);
            addOutputButton.TabIndex = 1;
            addOutputButton.Text = "Add output";
            addOutputButton.UseVisualStyleBackColor = true;
            // 
            // outputNamesSplitButton
            // 
            outputNamesSplitButton.Location = new System.Drawing.Point(115, 10);
            outputNamesSplitButton.Name = "outputNamesSplitButton";
            outputNamesSplitButton.Size = new System.Drawing.Size(110, 23);
            outputNamesSplitButton.TabIndex = 0;
            outputNamesSplitButton.Text = "Names";
            outputNamesSplitButton.UseVisualStyleBackColor = true;
            // 
            // identifiersGroup
            // 
            identifiersGroup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            identifiersGroup.Controls.Add(tableLayoutPanel1);
            identifiersGroup.Location = new System.Drawing.Point(3, 17);
            identifiersGroup.Name = "identifiersGroup";
            identifiersGroup.Size = new System.Drawing.Size(840, 84);
            identifiersGroup.TabIndex = 0;
            identifiersGroup.TabStop = false;
            identifiersGroup.Text = "Identifiers";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.77512F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.224884F));
            tableLayoutPanel1.Controls.Add(idLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(idUpdown, 1, 0);
            tableLayoutPanel1.Controls.Add(nameTextbox, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.7741928F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.2258072F));
            tableLayoutPanel1.Size = new System.Drawing.Size(834, 62);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // idUpdown
            // 
            idUpdown.Location = new System.Drawing.Point(67, 3);
            idUpdown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            idUpdown.Name = "idUpdown";
            idUpdown.Size = new System.Drawing.Size(120, 23);
            idUpdown.TabIndex = 2;
            // 
            // nameTextbox
            // 
            nameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nameTextbox.Location = new System.Drawing.Point(67, 32);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new System.Drawing.Size(764, 23);
            nameTextbox.TabIndex = 3;
            // 
            // Swp08EditorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(849, 672);
            Controls.Add(customElementsPanel);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            Name = "Swp08EditorForm";
            Text = "New router";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            footerPanel.ResumeLayout(false);
            customElementsPanel.ResumeLayout(false);
            dataTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
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
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputsDataGrid).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)outputDataGrid).EndInit();
            panel2.ResumeLayout(false);
            identifiersGroup.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idUpdown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel customElementsPanel;
        private System.Windows.Forms.GroupBox identifiersGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown idUpdown;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TabControl dataTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox matrixPropertiesGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.DataGridView inputsDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addInputButton;
        private GeneralComponents.SplitButton inputNamesSplitButton;
        private System.Windows.Forms.DataGridView outputDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addOutputButton;
        private GeneralComponents.SplitButton outputNamesSplitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button cancelButton;
    }
}