
namespace WindowsFormsApp1.ChildForms
{
    partial class FrmListOfFlight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucuslarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dbFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Flight = new WindowsFormsApp1.db_Flight();
            this.ucuslarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_FlightDataSet = new WindowsFormsApp1.db_FlightDataSet();
            this.ucuslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucuslarTableAdapter = new WindowsFormsApp1.db_FlightDataSetTableAdapters.UcuslarTableAdapter();
            this.ucuslarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucuslarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ucuslarTableAdapter1 = new WindowsFormsApp1.db_FlightTableAdapters.UcuslarTableAdapter();
            this.pnlListOfFlights = new System.Windows.Forms.Panel();
            this.btnBiletAl = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gridmaster = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.UcusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SirketAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource2)).BeginInit();
            this.pnlListOfFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmaster)).BeginInit();
            this.SuspendLayout();
            // 
            // ucuslarBindingSource4
            // 
            this.ucuslarBindingSource4.DataMember = "Ucuslar";
            this.ucuslarBindingSource4.DataSource = this.dbFlightBindingSource;
            // 
            // dbFlightBindingSource
            // 
            this.dbFlightBindingSource.DataSource = this.db_Flight;
            this.dbFlightBindingSource.Position = 0;
            // 
            // db_Flight
            // 
            this.db_Flight.DataSetName = "db_Flight";
            this.db_Flight.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucuslarBindingSource3
            // 
            this.ucuslarBindingSource3.DataMember = "Ucuslar";
            this.ucuslarBindingSource3.DataSource = this.dbFlightBindingSource;
            // 
            // db_FlightDataSet
            // 
            this.db_FlightDataSet.DataSetName = "db_FlightDataSet";
            this.db_FlightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ucuslarBindingSource
            // 
            this.ucuslarBindingSource.DataMember = "Ucuslar";
            this.ucuslarBindingSource.DataSource = this.db_FlightDataSet;
            // 
            // ucuslarTableAdapter
            // 
            this.ucuslarTableAdapter.ClearBeforeFill = true;
            // 
            // ucuslarBindingSource1
            // 
            this.ucuslarBindingSource1.DataMember = "Ucuslar";
            this.ucuslarBindingSource1.DataSource = this.db_FlightDataSet;
            // 
            // ucuslarBindingSource2
            // 
            this.ucuslarBindingSource2.DataMember = "Ucuslar";
            this.ucuslarBindingSource2.DataSource = this.dbFlightBindingSource;
            // 
            // ucuslarTableAdapter1
            // 
            this.ucuslarTableAdapter1.ClearBeforeFill = true;
            // 
            // pnlListOfFlights
            // 
            this.pnlListOfFlights.Controls.Add(this.btnBiletAl);
            this.pnlListOfFlights.Controls.Add(this.gridmaster);
            this.pnlListOfFlights.Location = new System.Drawing.Point(8, 12);
            this.pnlListOfFlights.Name = "pnlListOfFlights";
            this.pnlListOfFlights.Size = new System.Drawing.Size(1053, 598);
            this.pnlListOfFlights.TabIndex = 0;
            this.pnlListOfFlights.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlListOfFlights_Paint);
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.BorderRadius = 20;
            this.btnBiletAl.CheckedState.Parent = this.btnBiletAl;
            this.btnBiletAl.CustomImages.Parent = this.btnBiletAl;
            this.btnBiletAl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBiletAl.ForeColor = System.Drawing.Color.White;
            this.btnBiletAl.HoverState.Parent = this.btnBiletAl;
            this.btnBiletAl.Location = new System.Drawing.Point(348, 546);
            this.btnBiletAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.ShadowDecoration.Parent = this.btnBiletAl;
            this.btnBiletAl.Size = new System.Drawing.Size(311, 43);
            this.btnBiletAl.TabIndex = 14;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // gridmaster
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridmaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridmaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmaster.ColumnHeadersHeight = 40;
            this.gridmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridmaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UcusID,
            this.SirketAdi,
            this.SehirAdi,
            this.SehirAdi1,
            this.Tarih,
            this.Saat,
            this.Fiyat});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmaster.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridmaster.DoubleBuffered = true;
            this.gridmaster.EnableHeadersVisualStyles = false;
            this.gridmaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.HeaderBgColor = System.Drawing.Color.SlateBlue;
            this.gridmaster.HeaderForeColor = System.Drawing.Color.Snow;
            this.gridmaster.Location = new System.Drawing.Point(0, 3);
            this.gridmaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridmaster.Name = "gridmaster";
            this.gridmaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridmaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaster.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridmaster.RowHeadersVisible = false;
            this.gridmaster.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridmaster.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridmaster.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.gridmaster.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gridmaster.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.gridmaster.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridmaster.RowTemplate.DividerHeight = 3;
            this.gridmaster.RowTemplate.Height = 40;
            this.gridmaster.RowTemplate.ReadOnly = true;
            this.gridmaster.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmaster.Size = new System.Drawing.Size(1036, 537);
            this.gridmaster.TabIndex = 13;
            // 
            // UcusID
            // 
            this.UcusID.DataPropertyName = "UcusID";
            this.UcusID.HeaderText = "UcusID";
            this.UcusID.MinimumWidth = 6;
            this.UcusID.Name = "UcusID";
            this.UcusID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UcusID.Visible = false;
            // 
            // SirketAdi
            // 
            this.SirketAdi.DataPropertyName = "SirketAdi";
            this.SirketAdi.HeaderText = "Firma";
            this.SirketAdi.MinimumWidth = 6;
            this.SirketAdi.Name = "SirketAdi";
            this.SirketAdi.ReadOnly = true;
            this.SirketAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SehirAdi
            // 
            this.SehirAdi.DataPropertyName = "SehirAdi";
            this.SehirAdi.HeaderText = "Nereden";
            this.SehirAdi.MinimumWidth = 6;
            this.SehirAdi.Name = "SehirAdi";
            this.SehirAdi.ReadOnly = true;
            this.SehirAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SehirAdi1
            // 
            this.SehirAdi1.DataPropertyName = "SehirAdi1";
            this.SehirAdi1.HeaderText = "Nereye";
            this.SehirAdi1.MinimumWidth = 6;
            this.SehirAdi1.Name = "SehirAdi1";
            this.SehirAdi1.ReadOnly = true;
            this.SehirAdi1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tarih.FillWeight = 200F;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Saat
            // 
            this.Saat.DataPropertyName = "Saat";
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fiyat
            // 
            this.Fiyat.DataPropertyName = "Fiyat";
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmListOfFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1064, 614);
            this.Controls.Add(this.pnlListOfFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListOfFlight";
            this.Text = "FrmListOfFlight";
            this.Load += new System.EventHandler(this.FrmListOfFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_FlightDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucuslarBindingSource2)).EndInit();
            this.pnlListOfFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_FlightDataSet db_FlightDataSet;
        private System.Windows.Forms.BindingSource ucuslarBindingSource;
        private db_FlightDataSetTableAdapters.UcuslarTableAdapter ucuslarTableAdapter;
        private System.Windows.Forms.BindingSource ucuslarBindingSource1;
        private System.Windows.Forms.BindingSource dbFlightBindingSource;
        private db_Flight db_Flight;
        private System.Windows.Forms.BindingSource ucuslarBindingSource2;
        private db_FlightTableAdapters.UcuslarTableAdapter ucuslarTableAdapter1;
        private System.Windows.Forms.BindingSource ucuslarBindingSource3;
        private System.Windows.Forms.BindingSource ucuslarBindingSource4;
        private System.Windows.Forms.Panel pnlListOfFlights;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnBiletAl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gridmaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn UcusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SirketAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}