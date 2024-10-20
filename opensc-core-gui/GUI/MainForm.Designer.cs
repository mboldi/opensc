using OpenSC.GUI.GeneralComponents.Menus;

namespace OpenSC.GUI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new CustomMenuStrip();
            fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showGlobalIdInTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            tileWindowsHorizontallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tileWindowsVerticallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cascadeWindowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            globalSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusStripEmptySpace = new System.Windows.Forms.ToolStripStatusLabel();
            statusStripClock = new System.Windows.Forms.ToolStripStatusLabel();
            statusStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            clockUpdateTimer = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.AssociatedMenuItem = null;
            menuStrip.DynamicChildrenInsertPosition = 0;
            menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileMenu, windowsMenu, settingsToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1297, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tablesToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new System.Drawing.Size(37, 20);
            fileMenu.Text = "File";
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showGlobalIdInTablesToolStripMenuItem });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // showGlobalIdInTablesToolStripMenuItem
            // 
            showGlobalIdInTablesToolStripMenuItem.Name = "showGlobalIdInTablesToolStripMenuItem";
            showGlobalIdInTablesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            showGlobalIdInTablesToolStripMenuItem.Text = "Show GlobalID";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(103, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // windowsMenu
            // 
            windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tileWindowsHorizontallyMenuItem, tileWindowsVerticallyMenuItem, cascadeWindowsMenuItem, toolStripSeparator1 });
            windowsMenu.Name = "windowsMenu";
            windowsMenu.Size = new System.Drawing.Size(68, 20);
            windowsMenu.Text = "Windows";
            // 
            // tileWindowsHorizontallyMenuItem
            // 
            tileWindowsHorizontallyMenuItem.Image = GuiIcons._32_tile_horizontally;
            tileWindowsHorizontallyMenuItem.Name = "tileWindowsHorizontallyMenuItem";
            tileWindowsHorizontallyMenuItem.Size = new System.Drawing.Size(207, 22);
            tileWindowsHorizontallyMenuItem.Text = "Tile windows horizontally";
            tileWindowsHorizontallyMenuItem.Click += arrangeWindowsMenuItemClickHandler;
            // 
            // tileWindowsVerticallyMenuItem
            // 
            tileWindowsVerticallyMenuItem.Image = GuiIcons._32_tile_vertically;
            tileWindowsVerticallyMenuItem.Name = "tileWindowsVerticallyMenuItem";
            tileWindowsVerticallyMenuItem.Size = new System.Drawing.Size(207, 22);
            tileWindowsVerticallyMenuItem.Text = "Tile windows vertically";
            tileWindowsVerticallyMenuItem.Click += arrangeWindowsMenuItemClickHandler;
            // 
            // cascadeWindowsMenuItem
            // 
            cascadeWindowsMenuItem.Name = "cascadeWindowsMenuItem";
            cascadeWindowsMenuItem.Size = new System.Drawing.Size(207, 22);
            cascadeWindowsMenuItem.Text = "Cascade windows";
            cascadeWindowsMenuItem.Click += arrangeWindowsMenuItemClickHandler;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { globalSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // globalSettingsToolStripMenuItem
            // 
            globalSettingsToolStripMenuItem.Name = "globalSettingsToolStripMenuItem";
            globalSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            globalSettingsToolStripMenuItem.Text = "Global settings";
            globalSettingsToolStripMenuItem.Click += globalSettingsToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStripEmptySpace, statusStripClock, statusStripVersion, toolStripStatusLabel2, toolStripStatusLabel1 });
            statusStrip.Location = new System.Drawing.Point(0, 684);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            statusStrip.Size = new System.Drawing.Size(1297, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // statusStripEmptySpace
            // 
            statusStripEmptySpace.Name = "statusStripEmptySpace";
            statusStripEmptySpace.Size = new System.Drawing.Size(1078, 17);
            statusStripEmptySpace.Spring = true;
            // 
            // statusStripClock
            // 
            statusStripClock.Name = "statusStripClock";
            statusStripClock.Size = new System.Drawing.Size(109, 17);
            statusStripClock.Text = "1970.01.01. 12:00:00";
            // 
            // statusStripVersion
            // 
            statusStripVersion.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            statusStripVersion.Name = "statusStripVersion";
            statusStripVersion.Size = new System.Drawing.Size(68, 17);
            statusStripVersion.Text = "OpenSC 1.1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            toolStripStatusLabel1.Text = "    ";
            // 
            // clockUpdateTimer
            // 
            clockUpdateTimer.Enabled = true;
            clockUpdateTimer.Interval = 500;
            clockUpdateTimer.Tick += clockUpdateTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1297, 706);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "OpenSC";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripEmptySpace;
        private System.Windows.Forms.ToolStripStatusLabel statusStripClock;
        private System.Windows.Forms.Timer clockUpdateTimer;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusStripVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem tileWindowsHorizontallyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileWindowsVerticallyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGlobalIdInTablesToolStripMenuItem;
    }
}

