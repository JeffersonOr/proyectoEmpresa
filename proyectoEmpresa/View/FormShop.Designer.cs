﻿namespace proyectoEmpresa.View
{
    partial class FormShop
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.btShowProducts = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbpruebaTotal = new System.Windows.Forms.Label();
            this.btAddToCar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(214, 23);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(544, 304);
            this.dgvProducts.TabIndex = 0;
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.Location = new System.Drawing.Point(85, 148);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btSearchProduct.TabIndex = 21;
            this.btSearchProduct.Text = "Buscar";
            this.btSearchProduct.UseVisualStyleBackColor = true;
            this.btSearchProduct.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // btShowProducts
            // 
            this.btShowProducts.Location = new System.Drawing.Point(64, 233);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(116, 23);
            this.btShowProducts.TabIndex = 20;
            this.btShowProducts.Text = "Mostrar";
            this.btShowProducts.UseVisualStyleBackColor = true;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(72, 122);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.tbSearchProduct.TabIndex = 14;
            this.tbSearchProduct.Text = "Buscar Producto";
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Location = new System.Drawing.Point(66, 206);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(114, 21);
            this.cbSelectCategory.TabIndex = 13;
            this.cbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cbSelectCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categorias";
            // 
            // lbpruebaTotal
            // 
            this.lbpruebaTotal.AutoSize = true;
            this.lbpruebaTotal.Location = new System.Drawing.Point(647, 380);
            this.lbpruebaTotal.Name = "lbpruebaTotal";
            this.lbpruebaTotal.Size = new System.Drawing.Size(31, 13);
            this.lbpruebaTotal.TabIndex = 26;
            this.lbpruebaTotal.Text = "Total";
            // 
            // btAddToCar
            // 
            this.btAddToCar.Location = new System.Drawing.Point(625, 334);
            this.btAddToCar.Name = "btAddToCar";
            this.btAddToCar.Size = new System.Drawing.Size(75, 23);
            this.btAddToCar.TabIndex = 27;
            this.btAddToCar.Text = "Agregar";
            this.btAddToCar.UseVisualStyleBackColor = true;
            this.btAddToCar.Click += new System.EventHandler(this.btAddToCar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(238, 405);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(35, 13);
            this.lbPrueba.TabIndex = 29;
            this.lbPrueba.Text = "label2";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrueba);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAddToCar);
            this.Controls.Add(this.lbpruebaTotal);
            this.Controls.Add(this.btSearchProduct);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.cbSelectCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Button btShowProducts;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbpruebaTotal;
        private System.Windows.Forms.Button btAddToCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPrueba;
    }
}