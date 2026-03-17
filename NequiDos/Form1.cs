namespace NequiDos
{
    public partial class FormPrincipal : Form
    {

        List<CuentaNequi2> listaCuentasNequi2 = new List<CuentaNequi2>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            string nombreBox = DueñoBox.Text;
            if (string.IsNullOrEmpty(nombreBox))
            {
                MessageBox.Show($"Dejaste el campo vacío!!");
            }
            else
            {
                CuentaNequi2 cuentaNueva = new CuentaNequi2(nombreBox);
                listaCuentasNequi2.Add(cuentaNueva);
                MessageBox.Show($"La cuenta de banco de {nombreBox} fue creada");
                RefrescarDatos();
                DueñoBox.Text = null;
            }

        }

        public void RefrescarDatos()
        {
            CuentasData.DataSource = null;
            CuentasData.DataSource = listaCuentasNequi2;
        }

        private void DepositarButton_Click(object sender, EventArgs e)
        {
            if (CuentasData.SelectedRows.Count == 1)
            {
                decimal cantidad = CantidadBox.Value;
                CuentaNequi2 cuentaSeleccionada = CuentasData.SelectedRows[0].DataBoundItem as CuentaNequi2;
                string mensaje = cuentaSeleccionada.Depositar(cantidad);
                MessageBox.Show(mensaje);
                RefrescarDatos();
                CantidadBox.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecciona solo una cuenta!!!");
            }
            ;
        }

        private void RetirarButton_Click(object sender, EventArgs e)
        {
            if (CuentasData.SelectedRows.Count == 1)
            {
                decimal cantidad = CantidadBox.Value;
                CuentaNequi2 cuentaSeleccionada = CuentasData.SelectedRows[0].DataBoundItem as CuentaNequi2;
                cuentaSeleccionada.Retirar(cantidad);
                RefrescarDatos();
                CantidadBox.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecciona solo una cuenta!!!");
            }
            ;
        }
    }
}
