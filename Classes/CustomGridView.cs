using System.Windows.Forms;

namespace Library_Management_System.Classes
{
    class CustomGridView
    {
        public DataGridView CustomView = new DataGridView();

        public CustomGridView()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle culumnsCellStyle = new DataGridViewCellStyle();

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            culumnsCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            culumnsCellStyle.Font = new System.Drawing.Font("Tahoma", 11, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            culumnsCellStyle.WrapMode = DataGridViewTriState.True;

            CustomView.AllowUserToAddRows = false;
            CustomView.AllowUserToDeleteRows = false;
            CustomView.AllowUserToResizeRows = false;
            CustomView.BorderStyle = BorderStyle.FixedSingle;
            CustomView.ColumnHeadersDefaultCellStyle = culumnsCellStyle;
            CustomView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            CustomView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            CustomView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            CustomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomView.DefaultCellStyle = dataGridViewCellStyle2;
            CustomView.GridColor = System.Drawing.Color.Gray;
            CustomView.ReadOnly = true;
            CustomView.RowHeadersVisible = false;
            CustomView.RowTemplate.Height = 23;
            CustomView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        public void CloneGridViewStyle(DataGridView sourceDataGridView)
        {
            sourceDataGridView.AllowUserToAddRows = CustomView.AllowUserToAddRows;
            sourceDataGridView.AllowUserToDeleteRows = CustomView.AllowUserToDeleteRows;
            sourceDataGridView.AllowUserToResizeRows = CustomView.AllowUserToResizeRows;
            sourceDataGridView.BorderStyle = CustomView.BorderStyle;

            sourceDataGridView.AlternatingRowsDefaultCellStyle = CustomView.AlternatingRowsDefaultCellStyle;
            sourceDataGridView.AutoSizeColumnsMode = CustomView.AutoSizeColumnsMode;
            sourceDataGridView.BackgroundColor = CustomView.BackgroundColor;
            sourceDataGridView.CellBorderStyle = CustomView.CellBorderStyle;
            sourceDataGridView.ColumnHeadersHeightSizeMode = CustomView.ColumnHeadersHeightSizeMode;

            sourceDataGridView.ColumnHeadersDefaultCellStyle = CustomView.ColumnHeadersDefaultCellStyle;

            sourceDataGridView.DefaultCellStyle = CustomView.DefaultCellStyle;
            sourceDataGridView.GridColor = CustomView.GridColor;
            sourceDataGridView.ReadOnly = CustomView.ReadOnly;
            sourceDataGridView.RowHeadersVisible = CustomView.RowHeadersVisible;
            sourceDataGridView.RowTemplate.Height = CustomView.RowTemplate.Height;
            sourceDataGridView.SelectionMode = CustomView.SelectionMode;
        }
    }
}
