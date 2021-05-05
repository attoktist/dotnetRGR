namespace dotnetRGR
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label latNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label homeLandLabel;
            System.Windows.Forms.Label familyLabel;
            System.Windows.Forms.Label formLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.buttonLoad = new System.Windows.Forms.Button();
            this.plantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.plantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plantsDataGridView = new System.Windows.Forms.DataGridView();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dotnetRGRDataSet = new dotnetRGR.dotnetRGRDataSet();
            this.plantsTableAdapter = new dotnetRGR.dotnetRGRDataSetTableAdapters.PlantsTableAdapter();
            this.tableAdapterManager = new dotnetRGR.dotnetRGRDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.latNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.homeLandTextBox = new System.Windows.Forms.TextBox();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.formTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            latNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            homeLandLabel = new System.Windows.Forms.Label();
            familyLabel = new System.Windows.Forms.Label();
            formLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).BeginInit();
            this.plantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotnetRGRDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 339);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(180, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить данные в таблицу";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // plantsBindingNavigator
            // 
            this.plantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plantsBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plantsBindingNavigator.BindingSource = this.plantsBindingSource;
            this.plantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plantsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.plantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.plantsBindingNavigatorSaveItem});
            this.plantsBindingNavigator.Location = new System.Drawing.Point(9, 23);
            this.plantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantsBindingNavigator.Name = "plantsBindingNavigator";
            this.plantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantsBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.plantsBindingNavigator.TabIndex = 3;
            this.plantsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // plantsBindingNavigatorSaveItem
            // 
            this.plantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plantsBindingNavigatorSaveItem.Image")));
            this.plantsBindingNavigatorSaveItem.Name = "plantsBindingNavigatorSaveItem";
            this.plantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plantsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.plantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.plantsBindingNavigatorSaveItem_Click_2);
            // 
            // plantsDataGridView
            // 
            this.plantsDataGridView.AutoGenerateColumns = false;
            this.plantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.plantsDataGridView.DataSource = this.plantsBindingSource;
            this.plantsDataGridView.Location = new System.Drawing.Point(9, 51);
            this.plantsDataGridView.Name = "plantsDataGridView";
            this.plantsDataGridView.Size = new System.Drawing.Size(851, 282);
            this.plantsDataGridView.TabIndex = 3;
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.dotnetRGRDataSet;
            // 
            // dotnetRGRDataSet
            // 
            this.dotnetRGRDataSet.DataSetName = "dotnetRGRDataSet";
            this.dotnetRGRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlantsTableAdapter = this.plantsTableAdapter;
            this.tableAdapterManager.UpdateOrder = dotnetRGR.dotnetRGRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(894, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(938, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // latNameLabel
            // 
            latNameLabel.AutoSize = true;
            latNameLabel.Location = new System.Drawing.Point(876, 125);
            latNameLabel.Name = "latNameLabel";
            latNameLabel.Size = new System.Drawing.Size(56, 13);
            latNameLabel.TabIndex = 5;
            latNameLabel.Text = "Lat Name:";
            // 
            // latNameTextBox
            // 
            this.latNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "LatName", true));
            this.latNameTextBox.Location = new System.Drawing.Point(938, 122);
            this.latNameTextBox.Name = "latNameTextBox";
            this.latNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.latNameTextBox.TabIndex = 6;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(880, 158);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(938, 155);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 8;
            // 
            // homeLandLabel
            // 
            homeLandLabel.AutoSize = true;
            homeLandLabel.Location = new System.Drawing.Point(866, 193);
            homeLandLabel.Name = "homeLandLabel";
            homeLandLabel.Size = new System.Drawing.Size(65, 13);
            homeLandLabel.TabIndex = 9;
            homeLandLabel.Text = "Home Land:";
            // 
            // homeLandTextBox
            // 
            this.homeLandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "HomeLand", true));
            this.homeLandTextBox.Location = new System.Drawing.Point(937, 190);
            this.homeLandTextBox.Name = "homeLandTextBox";
            this.homeLandTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeLandTextBox.TabIndex = 10;
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Location = new System.Drawing.Point(892, 227);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new System.Drawing.Size(39, 13);
            familyLabel.TabIndex = 11;
            familyLabel.Text = "Family:";
            // 
            // familyTextBox
            // 
            this.familyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Family", true));
            this.familyTextBox.Location = new System.Drawing.Point(937, 224);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(100, 20);
            this.familyTextBox.TabIndex = 12;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Location = new System.Drawing.Point(899, 261);
            formLabel.Name = "formLabel";
            formLabel.Size = new System.Drawing.Size(33, 13);
            formLabel.TabIndex = 13;
            formLabel.Text = "Form:";
            // 
            // formTextBox
            // 
            this.formTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Form", true));
            this.formTextBox.Location = new System.Drawing.Point(938, 258);
            this.formTextBox.Name = "formTextBox";
            this.formTextBox.Size = new System.Drawing.Size(100, 20);
            this.formTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(869, 297);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(938, 294);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Location = new System.Drawing.Point(226, 339);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(137, 23);
            this.buttonLoadTable.TabIndex = 17;
            this.buttonLoadTable.Text = "Обновить таблицу";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.buttonLoadTable_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LatName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LatName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HomeLand";
            this.dataGridViewTextBoxColumn5.HeaderText = "HomeLand";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Family";
            this.dataGridViewTextBoxColumn6.HeaderText = "Family";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Form";
            this.dataGridViewTextBoxColumn7.HeaderText = "Form";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1137, 384);
            this.Controls.Add(this.buttonLoadTable);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(formLabel);
            this.Controls.Add(this.formTextBox);
            this.Controls.Add(familyLabel);
            this.Controls.Add(this.familyTextBox);
            this.Controls.Add(homeLandLabel);
            this.Controls.Add(this.homeLandTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(latNameLabel);
            this.Controls.Add(this.latNameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.plantsDataGridView);
            this.Controls.Add(this.plantsBindingNavigator);
            this.Controls.Add(this.buttonLoad);
            this.Name = "FormMain";
            this.Text = "Справочник о растениях";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).EndInit();
            this.plantsBindingNavigator.ResumeLayout(false);
            this.plantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotnetRGRDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLoad;
        private dotnetRGRDataSet dotnetRGRDataSet;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private dotnetRGRDataSetTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private dotnetRGRDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton plantsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView plantsDataGridView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox latNameTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox homeLandTextBox;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.TextBox formTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

