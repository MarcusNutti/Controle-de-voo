namespace Marcus
{
    partial class AcmeFlightManager
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
            this.lista = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPainLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPainLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colCapture,
            this.colPainLevel});
            this.lista.GridLines = true;
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(39, 38);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(225, 377);
            this.lista.TabIndex = 0;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Data";
            // 
            // colCapture
            // 
            this.colCapture.Text = "Captura";
            // 
            // colPainLevel
            // 
            this.colPainLevel.Text = "Nível de dor";
            this.colPainLevel.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(372, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(141, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Excluir";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Incluir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtPainLevel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbYes);
            this.groupBox2.Controls.Add(this.rbNo);
            this.groupBox2.Controls.Add(this.txtDistance);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(372, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(138, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(24, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPainLevel
            // 
            this.txtPainLevel.Location = new System.Drawing.Point(92, 215);
            this.txtPainLevel.Name = "txtPainLevel";
            this.txtPainLevel.Size = new System.Drawing.Size(121, 20);
            this.txtPainLevel.TabIndex = 10;
            this.txtPainLevel.TextChanged += new System.EventHandler(this.txtPainLevel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nível de dor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Captura";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(171, 176);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(42, 17);
            this.rbYes.TabIndex = 7;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Sim";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(92, 176);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(45, 17);
            this.rbNo.TabIndex = 6;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Não";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(92, 132);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(121, 20);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distância";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(92, 82);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(121, 20);
            this.txtCost.TabIndex = 3;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Custo";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(92, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // AcmeFlightManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lista);
            this.Name = "AcmeFlightManager";
            this.Text = "Acme Flight Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPainLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colCapture;
        private System.Windows.Forms.ColumnHeader colPainLevel;
    }
}