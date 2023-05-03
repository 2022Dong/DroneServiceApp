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
            this.lbFinishedList = new System.Windows.Forms.ListBox();
            this.gbServicePriority = new System.Windows.Forms.GroupBox();
            this.rdoRegularService = new System.Windows.Forms.RadioButton();
            this.rdoExpressService = new System.Windows.Forms.RadioButton();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtDroneModel = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblDroneModel = new System.Windows.Forms.Label();
            this.lblServiceProblem = new System.Windows.Forms.Label();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.lblServiceTag = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AddNewItem = new System.Windows.Forms.Button();
            this.lblRegularQueue = new System.Windows.Forms.Label();
            this.lblExpressQueue = new System.Windows.Forms.Label();
            this.colServiceCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDroneModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServiceProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvExpressQueue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbServicePriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRegularQueue
            // 
            this.lvRegularQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colServiceTag,
            this.colClientName,
            this.colDroneModel,
            this.colServiceCost,
            this.colServiceProblem});
            this.lvRegularQueue.HideSelection = false;
            this.lvRegularQueue.Location = new System.Drawing.Point(185, 21);
            this.lvRegularQueue.Name = "lvRegularQueue";
            this.lvRegularQueue.Size = new System.Drawing.Size(587, 107);
            this.lvRegularQueue.TabIndex = 0;
            this.lvRegularQueue.UseCompatibleStateImageBehavior = false;
            this.lvRegularQueue.View = System.Windows.Forms.View.Details;
            // 
            // lbFinishedList
            // 
            this.lbFinishedList.FormattingEnabled = true;
            this.lbFinishedList.Location = new System.Drawing.Point(638, 273);
            this.lbFinishedList.Name = "lbFinishedList";
            this.lbFinishedList.Size = new System.Drawing.Size(134, 173);
            this.lbFinishedList.TabIndex = 2;
            // 
            // gbServicePriority
            // 
            this.gbServicePriority.Controls.Add(this.rdoExpressService);
            this.gbServicePriority.Controls.Add(this.rdoRegularService);
            this.gbServicePriority.Location = new System.Drawing.Point(14, 17);
            this.gbServicePriority.Name = "gbServicePriority";
            this.gbServicePriority.Size = new System.Drawing.Size(138, 89);
            this.gbServicePriority.TabIndex = 3;
            this.gbServicePriority.TabStop = false;
            this.gbServicePriority.Text = "Priority";
            // 
            // rdoRegularService
            // 
            this.rdoRegularService.AutoSize = true;
            this.rdoRegularService.Location = new System.Drawing.Point(20, 24);
            this.rdoRegularService.Name = "rdoRegularService";
            this.rdoRegularService.Size = new System.Drawing.Size(101, 17);
            this.rdoRegularService.TabIndex = 0;
            this.rdoRegularService.TabStop = true;
            this.rdoRegularService.Text = "Regular Service";
            this.rdoRegularService.UseVisualStyleBackColor = true;
            // 
            // rdoExpressService
            // 
            this.rdoExpressService.AutoSize = true;
            this.rdoExpressService.Location = new System.Drawing.Point(20, 57);
            this.rdoExpressService.Name = "rdoExpressService";
            this.rdoExpressService.Size = new System.Drawing.Size(101, 17);
            this.rdoExpressService.TabIndex = 1;
            this.rdoExpressService.TabStop = true;
            this.rdoExpressService.Text = "Express Service";
            this.rdoExpressService.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(19, 145);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 20);
            this.txtClientName.TabIndex = 4;
            // 
            // txtDroneModel
            // 
            this.txtDroneModel.Location = new System.Drawing.Point(19, 204);
            this.txtDroneModel.Name = "txtDroneModel";
            this.txtDroneModel.Size = new System.Drawing.Size(100, 20);
            this.txtDroneModel.TabIndex = 5;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(19, 129);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "Client Name";
            // 
            // lblDroneModel
            // 
            this.lblDroneModel.AutoSize = true;
            this.lblDroneModel.Location = new System.Drawing.Point(19, 185);
            this.lblDroneModel.Name = "lblDroneModel";
            this.lblDroneModel.Size = new System.Drawing.Size(68, 13);
            this.lblDroneModel.TabIndex = 7;
            this.lblDroneModel.Text = "Drone Model";
            // 
            // lblServiceProblem
            // 
            this.lblServiceProblem.AutoSize = true;
            this.lblServiceProblem.Location = new System.Drawing.Point(17, 254);
            this.lblServiceProblem.Name = "lblServiceProblem";
            this.lblServiceProblem.Size = new System.Drawing.Size(84, 13);
            this.lblServiceProblem.TabIndex = 8;
            this.lblServiceProblem.Text = "Service Problem";
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(17, 349);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(70, 13);
            this.lblServiceCost.TabIndex = 9;
            this.lblServiceCost.Text = "Service Cost ";
            // 
            // lblServiceTag
            // 
            this.lblServiceTag.AutoSize = true;
            this.lblServiceTag.Location = new System.Drawing.Point(17, 398);
            this.lblServiceTag.Name = "lblServiceTag";
            this.lblServiceTag.Size = new System.Drawing.Size(65, 13);
            this.lblServiceTag.TabIndex = 10;
            this.lblServiceTag.Text = "Service Tag";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 273);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 60);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(17, 369);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 417);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // AddNewItem
            // 
            this.AddNewItem.Location = new System.Drawing.Point(309, 313);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(200, 68);
            this.AddNewItem.TabIndex = 14;
            this.AddNewItem.Text = "ADD A NEW SERVICE ITEM";
            this.AddNewItem.UseVisualStyleBackColor = true;
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // lblRegularQueue
            // 
            this.lblRegularQueue.AutoSize = true;
            this.lblRegularQueue.Location = new System.Drawing.Point(427, 5);
            this.lblRegularQueue.Name = "lblRegularQueue";
            this.lblRegularQueue.Size = new System.Drawing.Size(79, 13);
            this.lblRegularQueue.TabIndex = 15;
            this.lblRegularQueue.Text = "Regular Queue";
            // 
            // lblExpressQueue
            // 
            this.lblExpressQueue.AutoSize = true;
            this.lblExpressQueue.Location = new System.Drawing.Point(427, 140);
            this.lblExpressQueue.Name = "lblExpressQueue";
            this.lblExpressQueue.Size = new System.Drawing.Size(79, 13);
            this.lblExpressQueue.TabIndex = 16;
            this.lblExpressQueue.Text = "Express Queue";
            // 
            // colServiceCost
            // 
            this.colServiceCost.DisplayIndex = 0;
            this.colServiceCost.Text = "Service Cost ";
            this.colServiceCost.Width = 92;
            // 
            // colServiceTag
            // 
            this.colServiceTag.DisplayIndex = 1;
            this.colServiceTag.Text = "Service Tag";
            this.colServiceTag.Width = 110;
            // 
            // colClientName
            // 
            this.colClientName.DisplayIndex = 2;
            this.colClientName.Text = "Client Name";
            this.colClientName.Width = 98;
            // 
            // colDroneModel
            // 
            this.colDroneModel.DisplayIndex = 3;
            this.colDroneModel.Text = "Drone Model";
            this.colDroneModel.Width = 107;
            // 
            // colServiceProblem
            // 
            this.colServiceProblem.Text = "Service Problem";
            this.colServiceProblem.Width = 125;
            // 
            // lvExpressQueue
            // 
            this.lvExpressQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvExpressQueue.HideSelection = false;
            this.lvExpressQueue.Location = new System.Drawing.Point(185, 160);
            this.lvExpressQueue.Name = "lvExpressQueue";
            this.lvExpressQueue.Size = new System.Drawing.Size(587, 107);
            this.lvExpressQueue.TabIndex = 17;
            this.lvExpressQueue.UseCompatibleStateImageBehavior = false;
            this.lvExpressQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Service Tag";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Client Name";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Drone Model";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "Service Cost ";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Service Problem";
            this.columnHeader5.Width = 125;
            // 
            // DroneServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvExpressQueue);
            this.Controls.Add(this.lblExpressQueue);
            this.Controls.Add(this.lblRegularQueue);
            this.Controls.Add(this.AddNewItem);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
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
            this.Name = "DroneServiceForm";
            this.Text = "DroneServiceForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbServicePriority.ResumeLayout(false);
            this.gbServicePriority.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Label lblRegularQueue;
        private System.Windows.Forms.Label lblExpressQueue;
        private System.Windows.Forms.ColumnHeader colServiceTag;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colDroneModel;
        private System.Windows.Forms.ColumnHeader colServiceCost;
        private System.Windows.Forms.ColumnHeader colServiceProblem;
        private System.Windows.Forms.ListView lvExpressQueue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

