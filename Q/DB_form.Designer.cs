namespace hw_2
{
    partial class DB_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_form));
            this.TblDataGridView = new System.Windows.Forms.DataGridView();
            this.TblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.TblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.q2 = new System.Windows.Forms.Button();
            this.q3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblBindingNavigator)).BeginInit();
            this.TblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TblDataGridView
            // 
            this.TblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblDataGridView.Location = new System.Drawing.Point(62, 42);
            this.TblDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TblDataGridView.Name = "TblDataGridView";
            this.TblDataGridView.RowHeadersWidth = 51;
            this.TblDataGridView.RowTemplate.Height = 24;
            this.TblDataGridView.Size = new System.Drawing.Size(593, 288);
            this.TblDataGridView.TabIndex = 0;
            this.TblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblDataGridView_CellContentClick);
            // 
            // TblBindingNavigator
            // 
            this.TblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.TblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.TblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.TblBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.TblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.TblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.TblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.TblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.TblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.TblBindingNavigator.Name = "TblBindingNavigator";
            this.TblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.TblBindingNavigator.Size = new System.Drawing.Size(917, 27);
            this.TblBindingNavigator.TabIndex = 1;
            this.TblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Q1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.q1Button);
            // 
            // q2
            // 
            this.q2.Location = new System.Drawing.Point(697, 137);
            this.q2.Margin = new System.Windows.Forms.Padding(2);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(189, 67);
            this.q2.TabIndex = 3;
            this.q2.Text = "Q2";
            this.q2.UseVisualStyleBackColor = true;
            this.q2.Click += new System.EventHandler(this.q2Button);
            // 
            // q3
            // 
            this.q3.Location = new System.Drawing.Point(697, 236);
            this.q3.Margin = new System.Windows.Forms.Padding(2);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(189, 67);
            this.q3.TabIndex = 4;
            this.q3.Text = "Q3";
            this.q3.UseVisualStyleBackColor = true;
            this.q3.Click += new System.EventHandler(this.q3Button);
            // 
            // DB_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 427);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TblBindingNavigator);
            this.Controls.Add(this.TblDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DB_form";
            this.Text = "hw2_db_form";
            this.Load += new System.EventHandler(this.DB_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblBindingNavigator)).EndInit();
            this.TblBindingNavigator.ResumeLayout(false);
            this.TblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TblDataGridView;
        private System.Windows.Forms.BindingNavigator TblBindingNavigator;
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
        private System.Windows.Forms.BindingSource TblBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button q2;
        private System.Windows.Forms.Button q3;
    }
}

