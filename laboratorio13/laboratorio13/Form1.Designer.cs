namespace laboratorio13
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.Items = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "C#",
            "C++",
            "JavaScript",
            "Html",
            "css",
            "Pythom"});
            this.listBox1.Location = new System.Drawing.Point(6, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(381, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(381, 27);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(381, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(229, 34);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.ReadOnly = true;
            this.txtSelected.Size = new System.Drawing.Size(112, 20);
            this.txtSelected.TabIndex = 4;
            // 
            // Items
            // 
            this.Items.Location = new System.Drawing.Point(229, 81);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(112, 20);
            this.Items.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(229, 125);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 20);
            this.Search.TabIndex = 6;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(148, 37);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(75, 13);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Item Selected:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(188, 84);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(35, 13);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Items:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(164, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Utilizando listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.TextBox Items;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblSearch;
    }
}

