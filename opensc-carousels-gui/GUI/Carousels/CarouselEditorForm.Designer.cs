namespace OpenSC.GUI.Carousels
{
    partial class CarouselEditorForm
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
            this.labelsGroupBox = new System.Windows.Forms.GroupBox();
            this.labelsTableContainerPanel = new System.Windows.Forms.Panel();
            this.elementsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addElementButton = new System.Windows.Forms.Button();
            this.customElementsPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.labelsGroupBox.SuspendLayout();
            this.labelsTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customElementsPanel
            // 
            this.customElementsPanel.Controls.Add(this.labelsGroupBox);
            this.customElementsPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customElementsPanel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.customElementsPanel.Size = new System.Drawing.Size(982, 535);
            this.customElementsPanel.Controls.SetChildIndex(this.labelsGroupBox, 0);
            // 
            // mainContainer
            // 
            this.mainContainer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.mainContainer.Size = new System.Drawing.Size(982, 621);
            // 
            // labelsGroupBox
            // 
            this.labelsGroupBox.AutoSize = true;
            this.labelsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelsGroupBox.Controls.Add(this.labelsTableContainerPanel);
            this.labelsGroupBox.Controls.Add(this.panel1);
            this.labelsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsGroupBox.Location = new System.Drawing.Point(10, 120);
            this.labelsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelsGroupBox.Name = "labelsGroupBox";
            this.labelsGroupBox.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.labelsGroupBox.Size = new System.Drawing.Size(962, 415);
            this.labelsGroupBox.TabIndex = 0;
            this.labelsGroupBox.TabStop = false;
            this.labelsGroupBox.Text = "Labels";
            // 
            // labelsTableContainerPanel
            // 
            this.labelsTableContainerPanel.Controls.Add(this.elementsTable);
            this.labelsTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelsTableContainerPanel.Location = new System.Drawing.Point(8, 30);
            this.labelsTableContainerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelsTableContainerPanel.Name = "labelsTableContainerPanel";
            this.labelsTableContainerPanel.Size = new System.Drawing.Size(946, 326);
            this.labelsTableContainerPanel.TabIndex = 1;
            // 
            // elementsTable
            // 
            this.elementsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementsTable.Location = new System.Drawing.Point(0, 0);
            this.elementsTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementsTable.Name = "elementsTable";
            this.elementsTable.RowHeadersWidth = 51;
            this.elementsTable.RowTemplate.Height = 24;
            this.elementsTable.Size = new System.Drawing.Size(946, 326);
            this.elementsTable.TabIndex = 0;
            this.elementsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elementsTable_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addElementButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 49);
            this.panel1.TabIndex = 1;
            // 
            // addElementButton
            // 
            this.addElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addElementButton.AutoSize = true;
            this.addElementButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addElementButton.Location = new System.Drawing.Point(3, 16);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(105, 30);
            this.addElementButton.TabIndex = 0;
            this.addElementButton.Text = "Add element";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // CarouselEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 691);
            this.DeleteButtonVisible = true;
            this.HeaderText = "New carousel";
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.MinimumSize = new System.Drawing.Size(1000, 738);
            this.Name = "CarouselEditorForm";
            this.SubjectPlural = "carousels";
            this.SubjectSingular = "carousel";
            this.Text = "New carousel";
            this.customElementsPanel.ResumeLayout(false);
            this.customElementsPanel.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.labelsGroupBox.ResumeLayout(false);
            this.labelsTableContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox labelsGroupBox;
        private System.Windows.Forms.DataGridView elementsTable;
        private System.Windows.Forms.Panel labelsTableContainerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addElementButton;
    }
}