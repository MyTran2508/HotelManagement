﻿namespace HotelManage.Forms
{
    partial class ServiceForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GridViewService = new System.Windows.Forms.DataGridView();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(22, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 36);
            this.button4.TabIndex = 47;
            this.button4.Text = "Trở lại";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(22, 331);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(132, 36);
            this.BtnRemove.TabIndex = 46;
            this.BtnRemove.Text = "Xóa";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(169, 277);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(132, 36);
            this.BtnEdit.TabIndex = 45;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(22, 277);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(132, 36);
            this.BtnAdd.TabIndex = 44;
            this.BtnAdd.Text = "Thêm";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GridViewService
            // 
            this.GridViewService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewService.Location = new System.Drawing.Point(358, 153);
            this.GridViewService.Name = "GridViewService";
            this.GridViewService.RowHeadersWidth = 51;
            this.GridViewService.RowTemplate.Height = 24;
            this.GridViewService.Size = new System.Drawing.Size(458, 291);
            this.GridViewService.TabIndex = 43;
            this.GridViewService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridService_CellClick);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(17, 222);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(279, 35);
            this.TextBoxPrice.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "Đơn Giá";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(17, 166);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(279, 35);
            this.TextBoxName.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên Dịch Vụ";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(17, 108);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(279, 35);
            this.TextBoxId.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(315, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "Quản Lý Dịch Vụ";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(169, 331);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(132, 36);
            this.BtnRefresh.TabIndex = 48;
            this.BtnRefresh.Text = "Tải Lại";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(358, 108);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(198, 35);
            this.TBSearch.TabIndex = 49;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(690, 107);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(126, 26);
            this.BtnReset.TabIndex = 50;
            this.BtnReset.Text = "Trở Lại";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(562, 107);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(122, 26);
            this.BtnSearch.TabIndex = 51;
            this.BtnSearch.Text = "Tìm Kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 484);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GridViewService);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView GridViewService;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSearch;
    }
}