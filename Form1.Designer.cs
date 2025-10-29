namespace EstacionamientoAutos;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.lblPlate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.btnRegisterEntry = new System.Windows.Forms.Button();
            this.btnRegisterExit = new System.Windows.Forms.Button();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(12, 15);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(44, 15);
            this.lblPlate.TabIndex = 0;
            this.lblPlate.Text = "Placas:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(88, 12);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(100, 23);
            this.txtPlate.TabIndex = 1;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(12, 44);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(70, 15);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Propietario:";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(88, 41);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(100, 23);
            this.txtOwner.TabIndex = 3;
            // 
            // btnRegisterEntry
            // 
            this.btnRegisterEntry.Location = new System.Drawing.Point(12, 70);
            this.btnRegisterEntry.Name = "btnRegisterEntry";
            this.btnRegisterEntry.Size = new System.Drawing.Size(176, 23);
            this.btnRegisterEntry.TabIndex = 4;
            this.btnRegisterEntry.Text = "Registrar Entrada";
            this.btnRegisterEntry.UseVisualStyleBackColor = true;
            this.btnRegisterEntry.Click += new System.EventHandler(this.btnRegisterEntry_Click);
            // 
            // btnRegisterExit
            // 
            this.btnRegisterExit.Location = new System.Drawing.Point(12, 99);
            this.btnRegisterExit.Name = "btnRegisterExit";
            this.btnRegisterExit.Size = new System.Drawing.Size(176, 23);
            this.btnRegisterExit.TabIndex = 5;
            this.btnRegisterExit.Text = "Registrar Salida";
            this.btnRegisterExit.UseVisualStyleBackColor = true;
            this.btnRegisterExit.Click += new System.EventHandler(this.btnRegisterExit_Click);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 15;
            this.lstCars.Location = new System.Drawing.Point(214, 12);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(574, 184);
            this.lstCars.TabIndex = 6;
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Location = new System.Drawing.Point(12, 140);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(133, 15);
            this.lblCarInfo.TabIndex = 7;
            this.lblCarInfo.Text = "Información del Vehículo:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(12, 168);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 15);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Costo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnRegisterExit);
            this.Controls.Add(this.btnRegisterEntry);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.lblPlate);
            this.Name = "Form1";
            this.Text = "Estacionamiento de Autos";
            this.ResumeLayout(false);
            this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblPlate;
    private System.Windows.Forms.TextBox txtPlate;
    private System.Windows.Forms.Label lblOwner;
    private System.Windows.Forms.TextBox txtOwner;
    private System.Windows.Forms.Button btnRegisterEntry;
    private System.Windows.Forms.Button btnRegisterExit;
    private System.Windows.Forms.ListBox lstCars;
    private System.Windows.Forms.Label lblCarInfo;
    private System.Windows.Forms.Label lblCost;
}
