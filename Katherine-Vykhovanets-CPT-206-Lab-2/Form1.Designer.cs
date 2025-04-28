namespace Katherine_Vykhovanets_CPT_206_Lab_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cityTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataSet = new Katherine_Vykhovanets_CPT_206_Lab_2.CityDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cityTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPopAsc = new System.Windows.Forms.Button();
            this.btnPopDesc = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.cityTableTableAdapter = new Katherine_Vykhovanets_CPT_206_Lab_2.CityDataSetTableAdapters.CityTableTableAdapter();
            this.tableAdapterManager = new Katherine_Vykhovanets_CPT_206_Lab_2.CityDataSetTableAdapters.TableAdapterManager();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAvgPop = new System.Windows.Forms.Button();
            this.btnTotalPop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingNavigator)).BeginInit();
            this.cityTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityTableBindingNavigator
            // 
            this.cityTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityTableBindingNavigator.BindingSource = this.cityTableBindingSource;
            this.cityTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityTableBindingNavigatorSaveItem});
            this.cityTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityTableBindingNavigator.Name = "cityTableBindingNavigator";
            this.cityTableBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cityTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityTableBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.cityTableBindingNavigator.TabIndex = 0;
            this.cityTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // cityTableBindingSource
            // 
            this.cityTableBindingSource.DataMember = "CityTable";
            this.cityTableBindingSource.DataSource = this.cityDataSet;
            // 
            // cityDataSet
            // 
            this.cityDataSet.DataSetName = "CityDataSet";
            this.cityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 15);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cityTableBindingNavigatorSaveItem
            // 
            this.cityTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityTableBindingNavigatorSaveItem.Image")));
            this.cityTableBindingNavigatorSaveItem.Name = "cityTableBindingNavigatorSaveItem";
            this.cityTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityTableBindingNavigatorSaveItem.Text = "Save Data";
            this.cityTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityTableBindingNavigatorSaveItem_Click);
            // 
            // cityTableDataGridView
            // 
            this.cityTableDataGridView.AutoGenerateColumns = false;
            this.cityTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityTableDataGridView.DataSource = this.cityTableBindingSource;
            this.cityTableDataGridView.Location = new System.Drawing.Point(146, 68);
            this.cityTableDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cityTableDataGridView.Name = "cityTableDataGridView";
            this.cityTableDataGridView.Size = new System.Drawing.Size(444, 203);
            this.cityTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(122, 315);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(100, 49);
            this.btnShowDetails.TabIndex = 1;
            this.btnShowDetails.Text = "&Show Details";
            this.toolTip1.SetToolTip(this.btnShowDetails, "Show city details");
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(575, 381);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPopAsc
            // 
            this.btnPopAsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPopAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopAsc.Location = new System.Drawing.Point(252, 315);
            this.btnPopAsc.Margin = new System.Windows.Forms.Padding(4);
            this.btnPopAsc.Name = "btnPopAsc";
            this.btnPopAsc.Size = new System.Drawing.Size(100, 49);
            this.btnPopAsc.TabIndex = 2;
            this.btnPopAsc.Text = "Population &Ascending";
            this.toolTip1.SetToolTip(this.btnPopAsc, "Sort data by ascending population");
            this.btnPopAsc.UseVisualStyleBackColor = true;
            this.btnPopAsc.Click += new System.EventHandler(this.btnPopAsc_Click);
            // 
            // btnPopDesc
            // 
            this.btnPopDesc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPopDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopDesc.Location = new System.Drawing.Point(382, 315);
            this.btnPopDesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnPopDesc.Name = "btnPopDesc";
            this.btnPopDesc.Size = new System.Drawing.Size(100, 49);
            this.btnPopDesc.TabIndex = 3;
            this.btnPopDesc.Text = "Population &Descending";
            this.toolTip1.SetToolTip(this.btnPopDesc, "Sort data by descending population");
            this.btnPopDesc.UseVisualStyleBackColor = true;
            this.btnPopDesc.Click += new System.EventHandler(this.btnPopDesc_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.Location = new System.Drawing.Point(511, 315);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(100, 49);
            this.btnSortName.TabIndex = 4;
            this.btnSortName.Text = "Sort by &City Name";
            this.toolTip1.SetToolTip(this.btnSortName, "Sort alphabetically by city names");
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityTableTableAdapter
            // 
            this.cityTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableTableAdapter = this.cityTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Katherine_Vykhovanets_CPT_206_Lab_2.CityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnMax
            // 
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(58, 381);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(100, 49);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Highest Population";
            this.toolTip1.SetToolTip(this.btnMax, "Show the highest population");
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(187, 381);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(100, 49);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Lowest Population";
            this.toolTip1.SetToolTip(this.btnMin, "Show the lowest population");
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAvgPop
            // 
            this.btnAvgPop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAvgPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgPop.Location = new System.Drawing.Point(317, 381);
            this.btnAvgPop.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvgPop.Name = "btnAvgPop";
            this.btnAvgPop.Size = new System.Drawing.Size(100, 49);
            this.btnAvgPop.TabIndex = 7;
            this.btnAvgPop.Text = "Average Population";
            this.toolTip1.SetToolTip(this.btnAvgPop, "Calculate the average of all the populations");
            this.btnAvgPop.UseVisualStyleBackColor = true;
            this.btnAvgPop.Click += new System.EventHandler(this.btnAvgPop_Click);
            // 
            // btnTotalPop
            // 
            this.btnTotalPop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTotalPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPop.Location = new System.Drawing.Point(447, 381);
            this.btnTotalPop.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalPop.Name = "btnTotalPop";
            this.btnTotalPop.Size = new System.Drawing.Size(100, 49);
            this.btnTotalPop.TabIndex = 8;
            this.btnTotalPop.Text = "Total Population";
            this.toolTip1.SetToolTip(this.btnTotalPop, "Calculate the total of all the populations");
            this.btnTotalPop.UseVisualStyleBackColor = true;
            this.btnTotalPop.Click += new System.EventHandler(this.btnTotalPop_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShowDetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(732, 493);
            this.Controls.Add(this.btnTotalPop);
            this.Controls.Add(this.btnAvgPop);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnPopDesc);
            this.Controls.Add(this.btnPopAsc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.cityTableDataGridView);
            this.Controls.Add(this.cityTableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingNavigator)).EndInit();
            this.cityTableBindingNavigator.ResumeLayout(false);
            this.cityTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDataSet cityDataSet;
        private System.Windows.Forms.BindingSource cityTableBindingSource;
        private CityDataSetTableAdapters.CityTableTableAdapter cityTableTableAdapter;
        private CityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPopAsc;
        private System.Windows.Forms.Button btnPopDesc;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAvgPop;
        private System.Windows.Forms.Button btnTotalPop;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

