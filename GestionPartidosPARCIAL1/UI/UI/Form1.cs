using BLL;
using ENTITY;

namespace UI
{
    public partial class Form1 : Form
    {
        private DeporteBusiness deporteBusiness;
        private PartidoBusiness partidoBusiness;

        public Form1()
        {
            InitializeComponent();
            deporteBusiness = new DeporteBusiness();
            partidoBusiness = new PartidoBusiness();
            updateDgv();
            cmbDeporte.DataSource = null;
            cmbDeporte.DataSource = deporteBusiness.obtenerDeportes();
            cmbDeporte.ValueMember = "IdDeporte";
            cmbDeporte.DisplayMember = "Descripcion";
        }
        private void updateDgv()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = partidoBusiness.obtenerPartidos();
        }       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = new Partido();
                partido.EquipoLocal = txtEquipoLocal.Text;
                partido.EquipoVisitante = txtEquipoVisitante.Text;
                partido.FechaPartido = tpFechaPartido.Value;
                partido.IdDeporte = Convert.ToInt32(cmbDeporte.SelectedValue);
                partidoBusiness.savePartido(partido);
                updateDgv();
                MessageBox.Show("Se ha salvado el partido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cmbDeporte.SelectedIndex);
                partidoBusiness.eliminarPartido(Convert.ToInt32(txtDelete.Text));
                MessageBox.Show("Partido eliminado");
                updateDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                Partido partido = new Partido();
                int id = Convert.ToInt32(txtUpdate.Text);
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {                                            
                        int idPartido = Convert.ToInt32(fila.Cells[0].Value);                        
                        if (idPartido == id)
                        {                            
                            fila.Selected = true;
                            dataGridView1.CurrentCell = fila.Cells[0];
                            partido = (Partido)dataGridView1.CurrentRow.DataBoundItem;
                            break;
                        }
                    }
                
                
                    DateTime fecha = partido.FechaPartido;                    
                    int local = Convert.ToInt32(txtMarcadorLocal.Text);
                    int visitante = Convert.ToInt32(txtMarcadorVisitante.Text);

                    partidoBusiness.modificarPartido(id, fecha, local, visitante);
                    MessageBox.Show("Partido modificado");
                    updateDgv();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
