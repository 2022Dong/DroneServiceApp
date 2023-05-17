namespace DroneServiceApp
{
    partial class DroneServiceForm
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
            this.lvRegularQueue = new System.Windows.Forms.ListView();
            this.colServiceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDroneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbFinishedList = new System.Windows.Forms.ListBox();
            this.gbServicePriority = new System.Windows.Forms.GroupBox();
            this.rdoExpressService = new System.Windows.Forms.RadioButton();
            this.rdoRegularService = new System.Windows.Forms.RadioButton();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtDroneModel = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblDroneModel = new System.Windows.Forms.Label();
            this.lblServiceProblem = new System.Windows.Forms.Label();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.lblServiceTag = new System.Windows.Forms.Label();
            this.txtServiceProblem = new System.Windows.Forms.TextBox();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.AddNewItem = new System.Windows.Forms.Button();
            this.lblRegularQueue = new System.Windows.Forms.Label();
            this.lblExpressQueue = new System.Windows.Forms.Label();
            this.lvExpressQueue = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDequeueReg = new System.Windows.Forms.Button();
            this.btnDequeueExp = new System.Windows.Forms.Button();
            this.serviceTagInput = new System.Windows.Forms.NumericUpDown();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.gbServicePriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTagInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lvRegularQueue
            // 
            this.lvRegularQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceTag,
            this.colClientName,
            this.colDroneModel,
            this.colServiceProblem,
            this.colServiceCost});
            this.lvRegularQueue.HideSelection = false;
            this.lvRegularQueue.Location = new System.Drawing.Point(216, 26);
            this.lvRegularQueue.Margin = new System.Windows.Forms.Padding(4);
            this.lvRegularQueue.Name = "lvRegularQueue";
            this.lvRegularQueue.Size = new System.Drawing.Size(716, 131);
            this.lvRegularQueue.TabIndex = 0;
            this.lvRegularQueue.UseCompatibleStateImageBehavior = false;
            this.lvRegularQueue.View = System.Windows.Forms.View.Details;
            this.lvRegularQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvRegularQueue_MouseClick);
            // 
            // colServiceTag
            // 
            this.colServiceTag.Text = "Service Tag";
            this.colServiceTag.Width = 110;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Client Name";
            this.colClientName.Width = 98;
            // 
            // colDroneModel
            // 
            this.colDroneModel.Text = "Drone Model";
            this.colDroneModel.Width = 107;
            // 
            // colServiceProblem
            // 
            this.colServiceProblem.Text = "Service Problem";
            this.colServiceProblem.Width = 125;
            // 
            // colServiceCost
            // 
            this.colServiceCost.Text = "Service Cost ";
            this.colServiceCost.Width = 92;
            // 
            // lbFinishedList
            // 
            this.lbFinishedList.FormattingEnabled = true;
            this.lbFinishedList.ItemHeight = 16;
            this.lbFinishedList.Location = new System.Drawing.Point(851, 352);
            this.lbFinishedList.Margin = new System.Windows.Forms.Padding(4);
            this.lbFinishedList.Name = "lbFinishedList";
            this.lbFinishedList.Size = new System.Drawing.Size(177, 196);
            this.lbFinishedList.TabIndex = 2;
            this.lbFinishedList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFinishedList_MouseDoubleClick);
            // 
            // gbServicePriority
            // 
            this.gbServicePriority.Controls.Add(this.rdoExpressService);
            this.gbServicePriority.Controls.Add(this.rdoRegularService);
            this.gbServicePriority.Location = new System.Drawing.Point(19, 21);
            this.gbServicePriority.Margin = new System.Windows.Forms.Padding(4);
            this.gbServicePriority.Name = "gbServicePriority";
            this.gbServicePriority.Padding = new System.Windows.Forms.Padding(4);
            this.gbServicePriority.Size = new System.Drawing.Size(184, 110);
            this.gbServicePriority.TabIndex = 3;
            this.gbServicePriority.TabStop = false;
            this.gbServicePriority.Text = "Priority";
            // 
            // rdoExpressService
            // 
            this.rdoExpressService.AutoSize = true;
            this.rdoExpressService.Location = new System.Drawing.Point(27, 70);
            this.rdoExpressService.Margin = new System.Windows.Forms.Padding(4);
            this.rdoExpressService.Name = "rdoExpressService";
            this.rdoExpressService.Size = new System.Drawing.Size(126, 20);
            this.rdoExpressService.TabIndex = 1;
            this.rdoExpressService.TabStop = true;
            this.rdoExpressService.Text = "Express Service";
            this.rdoExpressService.UseVisualStyleBackColor = true;
            // 
            // rdoRegularService
            // 
            this.rdoRegularService.AutoSize = true;
            this.rdoRegularService.Location = new System.Drawing.Point(27, 30);
            this.rdoRegularService.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRegularService.Name = "rdoRegularService";
            this.rdoRegularService.Size = new System.Drawing.Size(125, 20);
            this.rdoRegularService.TabIndex = 0;
            this.rdoRegularService.TabStop = true;
            this.rdoRegularService.Text = "Regular Service";
            this.rdoRegularService.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(25, 178);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(132, 22);
            this.txtClientName.TabIndex = 4;
            // 
            // txtDroneModel
            // 
            this.txtDroneModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDroneModel.Location = new System.Drawing.Point(25, 251);
            this.txtDroneModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtDroneModel.Name = "txtDroneModel";
            this.txtDroneModel.Size = new System.Drawing.Size(132, 22);
            this.txtDroneModel.TabIndex = 5;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(25, 159);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(80, 16);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "Client Name";
            // 
            // lblDroneModel
            // 
            this.lblDroneModel.AutoSize = true;
            this.lblDroneModel.Location = new System.Drawing.Point(25, 228);
            this.lblDroneModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDroneModel.Name = "lblDroneModel";
            this.lblDroneModel.Size = new System.Drawing.Size(85, 16);
            this.lblDroneModel.TabIndex = 7;
            this.lblDroneModel.Text = "Drone Model";
            // 
            // lblServiceProblem
            // 
            this.lblServiceProblem.AutoSize = true;
            this.lblServiceProblem.Location = new System.Drawing.Point(23, 313);
            this.lblServiceProblem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceProblem.Name = "lblServiceProblem";
            this.lblServiceProblem.Size = new System.Drawing.Size(107, 16);
            this.lblServiceProblem.TabIndex = 8;
            this.lblServiceProblem.Text = "Service Problem";
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(23, 430);
            this.lblServiceCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(86, 16);
            this.lblServiceCost.TabIndex = 9;
            this.lblServiceCost.Text = "Service Cost ";
            // 
            // lblServiceTag
            // 
            this.lblServiceTag.AutoSize = true;
            this.lblServiceTag.Location = new System.Drawing.Point(23, 490);
            this.lblServiceTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceTag.Name = "lblServiceTag";
            this.lblServiceTag.Size = new System.Drawing.Size(81, 16);
            this.lblServiceTag.TabIndex = 10;
            this.lblServiceTag.Text = "Service Tag";
            // 
            // txtServiceProblem
            // 
            this.txtServiceProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceProblem.Location = new System.Drawing.Point(23, 336);
            this.txtServiceProblem.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceProblem.Multiline = true;
            this.txtServiceProblem.Name = "txtServiceProblem";
            this.txtServiceProblem.Size = new System.Drawing.Size(303, 73);
            this.txtServiceProblem.TabIndex = 11;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCost.Location = new System.Drawing.Point(23, 454);
            this.txtServiceCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(132, 22);
            this.txtServiceCost.TabIndex = 12;
            this.txtServiceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceCost_KeyPress);
            // 
            // AddNewItem
            // 
            this.AddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItem.Location = new System.Drawing.Point(412, 385);
            this.AddNewItem.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(267, 84);
            this.AddNewItem.TabIndex = 14;
            this.AddNewItem.Text = "ADD A NEW SERVICE ITEM";
            this.AddNewItem.UseVisualStyleBackColor = true;
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // lblRegularQueue
            // 
            this.lblRegularQueue.AutoSize = true;
            this.lblRegularQueue.Location = new System.Drawing.Point(539, 6);
            this.lblRegularQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegularQueue.Name = "lblRegularQueue";
            this.lblRegularQueue.Size = new System.Drawing.Size(98, 16);
            this.lblRegularQueue.TabIndex = 15;
            this.lblRegularQueue.Text = "Regular Queue";
            // 
            // lblExpressQueue
            // 
            this.lblExpressQueue.AutoSize = true;
            this.lblExpressQueue.Location = new System.Drawing.Point(539, 172);
            this.lblExpressQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpressQueue.Name = "lblExpressQueue";
            this.lblExpressQueue.Size = new System.Drawing.Size(99, 16);
            this.lblExpressQueue.TabIndex = 16;
            this.lblExpressQueue.Text = "Express Queue";
            // 
            // lvExpressQueue
            // 
            this.lvExpressQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader9});
            this.lvExpressQueue.HideSelection = false;
            this.lvExpressQueue.Location = new System.Drawing.Point(216, 194);
            this.lvExpressQueue.Margin = new System.Windows.Forms.Padding(4);
            this.lvExpressQueue.Name = "lvExpressQueue";
            this.lvExpressQueue.Size = new System.Drawing.Size(716, 131);
            this.lvExpressQueue.TabIndex = 18;
            this.lvExpressQueue.UseCompatibleStateImageBehavior = false;
            this.lvExpressQueue.View = System.Windows.Forms.View.Details;
            this.lvExpressQueue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvExpressQueue_MouseClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Service Tag";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Client Name";
            this.columnHeader7.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Drone Model";
            this.columnHeader8.Width = 107;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Service Problem";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Service Cost";
            this.columnHeader9.Width = 92;
            // 
            // btnDequeueReg
            // 
            this.btnDequeueReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeueReg.Location = new System.Drawing.Point(951, 57);
            this.btnDequeueReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnDequeueReg.Name = "btnDequeueReg";
            this.btnDequeueReg.Size = new System.Drawing.Size(104, 69);
            this.btnDequeueReg.TabIndex = 19;
            this.btnDequeueReg.Text = "Done";
            this.btnDequeueReg.UseVisualStyleBackColor = true;
            this.btnDequeueReg.Click += new System.EventHandler(this.btnDequeueReg_Click);
            // 
            // btnDequeueExp
            // 
            this.btnDequeueExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeueExp.Location = new System.Drawing.Point(951, 228);
            this.btnDequeueExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDequeueExp.Name = "btnDequeueExp";
            this.btnDequeueExp.Size = new System.Drawing.Size(104, 69);
            this.btnDequeueExp.TabIndex = 19;
            this.btnDequeueExp.Text = "Done";
            this.btnDequeueExp.UseVisualStyleBackColor = true;
            this.btnDequeueExp.Click += new System.EventHandler(this.btnDequeueExp_Click);
            // 
            // serviceTagInput
            // 
            this.serviceTagInput.Enabled = false;
            this.serviceTagInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.serviceTagInput.Location = new System.Drawing.Point(23, 514);
            this.serviceTagInput.Margin = new System.Windows.Forms.Padding(4);
            this.serviceTagInput.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.serviceTagInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.serviceTagInput.Name = "serviceTagInput";
            this.serviceTagInput.Size = new System.Drawing.Size(160, 22);
            this.serviceTagInput.TabIndex = 20;
            this.serviceTagInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(851, 332);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(76, 16);
            this.lblCompleted.TabIndex = 21;
            this.lblCompleted.Text = "Completed:";
            // 
            // DroneServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.serviceTagInput);
            this.Controls.Add(this.btnDequeueExp);
            this.Controls.Add(this.btnDequeueReg);
            this.Controls.Add(this.lvExpressQueue);
            this.Controls.Add(this.lblExpressQueue);
            this.Controls.Add(this.lblRegularQueue);
            this.Controls.Add(this.AddNewItem);
            this.Controls.Add(this.txtServiceCost);
            this.Controls.Add(this.txtServiceProblem);
            this.Controls.Add(this.lblServiceTag);
            this.Controls.Add(this.lblServiceCost);
            this.Controls.Add(this.lblServiceProblem);
            this.Controls.Add(this.lblDroneModel);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.txtDroneModel);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.gbServicePriority);
            this.Controls.Add(this.lbFinishedList);
            this.Controls.Add(this.lvRegularQueue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DroneServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneServiceForm";
            this.gbServicePriority.ResumeLayout(false);
            this.gbServicePriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTagInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRegularQueue;
        private System.Windows.Forms.ListBox lbFinishedList;
        private System.Windows.Forms.GroupBox gbServicePriority;
        private System.Windows.Forms.RadioButton rdoExpressService;
        private System.Windows.Forms.RadioButton rdoRegularService;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtDroneModel;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblDroneModel;
        private System.Windows.Forms.Label lblServiceProblem;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.Label lblServiceTag;
        private System.Windows.Forms.TextBox txtServiceProblem;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Label lblRegularQueue;
        private System.Windows.Forms.Label lblExpressQueue;
        private System.Windows.Forms.ColumnHeader colServiceTag;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colDroneModel;
        private System.Windows.Forms.ColumnHeader colServiceCost;
        private System.Windows.Forms.ColumnHeader colServiceProblem;
        private System.Windows.Forms.ListView lvExpressQueue;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDequeueReg;
        private System.Windows.Forms.Button btnDequeueExp;
        private System.Windows.Forms.NumericUpDown serviceTagInput;
        private System.Windows.Forms.Label lblCompleted;
    }
}

