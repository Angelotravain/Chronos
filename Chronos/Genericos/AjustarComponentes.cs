namespace Chronos.Genericos
{
    public class AjustarComponentes
    {
        public void ajustarGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Dock = DockStyle.Fill;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            grid.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.BackgroundColor = SystemColors.Window;
            grid.BorderStyle = BorderStyle.None;
        }
    }
}
