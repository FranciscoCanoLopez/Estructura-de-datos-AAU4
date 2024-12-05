namespace Estructura_de_datos_AAU4
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol;
        private Grafo grafo;

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            grafo = new Grafo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Insertar(valor);
                MessageBox.Show($"Valor {valor} insertado correctamente.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Eliminar(valor);
                MessageBox.Show($"Valor {valor} eliminado correctamente.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                bool encontrado = arbol.Buscar(valor);
                if (encontrado)
                    MessageBox.Show($"Valor {valor} encontrado en el árbol.");
                else
                    MessageBox.Show($"Valor {valor} no encontrado.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstValores.Items.Clear();
            List<int> valores = arbol.InOrden();
            foreach (int valor in valores)
            {
                lstValores.Items.Add(valor);
            }
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNodo.Text;
                grafo.AgregarNodo(nombre);
                MessageBox.Show($"Nodo {nombre} agregado correctamente.");
                txtNodo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            try
            {
                string origen = txtOrigen.Text;
                string destino = txtDestino.Text;
                int peso = int.Parse(txtPeso.Text);

                grafo.AgregarArista(origen, destino, peso);
                MessageBox.Show($"Arista de {origen} a {destino} con peso {peso} agregada correctamente.");
                txtOrigen.Clear();
                txtDestino.Clear();
                txtPeso.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            try
            {
                string inicio = txtInicio.Text;
                var recorrido = grafo.RecorridoDFS(inicio);

                lstResultados.Items.Clear();
                foreach (var nodo in recorrido)
                {
                    lstResultados.Items.Add(nodo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
