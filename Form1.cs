namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool nuevaEntrada = true;
        private string? operacionPendiente;
        private decimal acumulador;
        private string operacionMostrada = "";

        public Form1()
        {
            InitializeComponent();

            btnMulti.Click += new EventHandler(Operador_click);
            btnSuma.Click += new EventHandler(Operador_click);
            btnResta.Click += new EventHandler(Operador_click);
            btnDivision.Click += new EventHandler(Operador_click);
            btnIgual.Click += new EventHandler(igual_Click);
        }

        private void numero_Click(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            agregarAPantalla(button.Text);
        }

        private void agregarAPantalla(string valor)
        {
            if (nuevaEntrada)
            {
                txtPantalla.Text = valor == "." ? "0." : valor;
                nuevaEntrada = false;
                return;
            }

            if (valor == "." && txtPantalla.Text.Contains(".", StringComparison.Ordinal))
            {
                return;
            }

            if ((txtPantalla.Text == "0" || txtPantalla.Text == "-0") && valor != ".")
            {
                txtPantalla.Text = txtPantalla.Text.StartsWith("-", StringComparison.Ordinal)
                    ? $"-{valor}"
                    : valor;

                return;
            }

            txtPantalla.Text += valor;
        }

        private void signo_Click(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "-0";
                return;
            }

            if (txtPantalla.Text == "-0")
            {
                txtPantalla.Text = "0";
                return;
            }

            decimal temp = decimal.Parse(txtPantalla.Text) * -1;
            txtPantalla.Text = temp.ToString();
        }

        private bool obtenerValorPantalla(out decimal valor)
        {
            return decimal.TryParse(txtPantalla.Text, out valor);
        }

        private void Operador_click(object sender, EventArgs e)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (!obtenerValorPantalla(out decimal valorActual))
            {
                return;
            }

            if (operacionPendiente is not null && !nuevaEntrada)
            {
                if (!AplicarOperacionPendiente(valorActual, out decimal resultadoIntermedio))
                {
                    return;
                }

                acumulador = resultadoIntermedio;
                operacionMostrada += $" {valorActual} {button.Text}";
            }
            else
            {
                acumulador = valorActual;
                operacionMostrada = $"{valorActual} {button.Text}";
            }

            operacionPendiente = button.Text switch
            {
                "×" => "*",
                "x" => "*",
                _ => button.Text
            };

            txtPantalla.Clear();
            nuevaEntrada = true;
            lblResultado.Text = operacionMostrada;
        }

        private bool AplicarOperacionPendiente(decimal valorActual, out decimal resultadoIntermedio)
        {
            resultadoIntermedio = acumulador;

            switch (operacionPendiente)
            {
                case "+":
                    resultadoIntermedio = acumulador + valorActual;
                    return true;

                case "-":
                    resultadoIntermedio = acumulador - valorActual;
                    return true;

                case "*":
                    resultadoIntermedio = acumulador * valorActual;
                    return true;

                case "/":
                    if (valorActual == 0)
                    {
                        MessageBox.Show(
                            "No se puede dividir entre cero",
                            "Operación no válida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return false;
                    }

                    resultadoIntermedio = acumulador / valorActual;
                    return true;

                default:
                    return false;
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (operacionPendiente is null)
            {
                return;
            }

            decimal valor;

            if (string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                valor = acumulador;
            }
            else if (!obtenerValorPantalla(out valor))
            {
                return;
            }

            if (!AplicarOperacionPendiente(valor, out decimal resultado))
            {
                return;
            }

            operacionMostrada += $" {valor} =";
            lblResultado.Text = operacionMostrada;
            txtPantalla.Text = resultado.ToString();

            acumulador = resultado;
            operacionPendiente = null;
            nuevaEntrada = true;
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            operacionPendiente = null;
            txtPantalla.Text = "0";
            lblResultado.Text = "";
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (nuevaEntrada)
            {
                return;
            }
            if (txtPantalla.Text.Length <= 1 || (txtPantalla.Text.Length == 2 && txtPantalla.Text.StartsWith('-')))
            {
                txtPantalla.Text = "0";
                return;
            }
            txtPantalla.Text = txtPantalla.Text[..^1];
        }
    }
}
