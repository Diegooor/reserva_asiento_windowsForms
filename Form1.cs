using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reserva_puesto_avion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        // Este método viene enlazado a btnAsiento1 desde el diseñador
        private void button1_Click_2(object sender, EventArgs e)
        {
            SeatButton_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Registrar el manejador común para los botones que no tenían evento asignado en el diseñador
            btnAsiento3.Click += SeatButton_Click;
            btnAsiento4.Click += SeatButton_Click;
            btnAsiento5.Click += SeatButton_Click;
            btnAsiento6.Click += SeatButton_Click;
            btnAsiento7.Click += SeatButton_Click;
            btnAsiento8.Click += SeatButton_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Este método viene enlazado a btnAsiento2 desde el diseñador
        private void button2_Click(object sender, EventArgs e)
        {
            SeatButton_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Manejador común para todos los botones de asiento
        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            // Si ya está ocupado (color rojo) mostramos detalles y opción para cancelar reserva
            if (btn.BackColor == Color.Red)
            {
                string nombre = btn.Tag as string ?? "Desconocido";

                using (Form details = new Form())
                {
                    details.Width = 360;
                    details.Height = 160;
                    details.Text = $"Reserva";
                    details.FormBorderStyle = FormBorderStyle.FixedDialog;
                    details.StartPosition = FormStartPosition.CenterParent;
                    details.MinimizeBox = false;
                    details.MaximizeBox = false;
                    details.ShowInTaskbar = false;

                    Label lbl = new Label()
                    {
                        Left = 12,
                        Top = 12,
                        AutoSize = true,
                        Text = $"Asiento: {btn.AccessibleName}"
                    };

                    Label lblNombre = new Label()
                    {
                        Left = 12,
                        Top = 36,
                        AutoSize = true,
                        Text = $"Reservado por: {nombre}"
                    };

                    Button btnCancelar = new Button()
                    {
                        Text = "Cancelar reserva",
                        Left = 40,
                        Top = 72,
                        Width = 140,
                        DialogResult = DialogResult.Yes
                    };

                    Button btnCerrar = new Button()
                    {
                        Text = "Cerrar",
                        Left = 200,
                        Top = 72,
                        Width = 80,
                        DialogResult = DialogResult.No
                    };

                    details.Controls.Add(lbl);
                    details.Controls.Add(lblNombre);
                    details.Controls.Add(btnCancelar);
                    details.Controls.Add(btnCerrar);

                    details.AcceptButton = btnCerrar;
                    details.CancelButton = btnCerrar;

                    DialogResult dr = details.ShowDialog(this);
                    if (dr == DialogResult.Yes)
                    {
                        // Cancelar la reserva: volver a estado disponible
                        btn.BackColor = Color.ForestGreen;
                        btn.ForeColor = Color.CornflowerBlue;
                        btn.Tag = null;
                        btn.Text = "";
                        //Opcional: mostrar confirmación
                        MessageBox.Show("Reserva cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                return;
            }

            // Si está libre, pedir nombre y reservar
            string nombreNuevo = PromptForName($"Reservar Asiento : {btn.AccessibleName}");
            if (!string.IsNullOrWhiteSpace(nombreNuevo))
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.White;
                btn.Tag = nombreNuevo; // guarda el nombre asociado al asiento
                btn.Text = "";
            }
        }

        // Diálogo modal simple para solicitar el nombre
        private string PromptForName(string title)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 320;
                prompt.Height = 150;
                prompt.Text = title;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;
                prompt.ShowInTaskbar = false;

                Label textLabel = new Label() { Left = 10, Top = 10, Text = "Nombre:", AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 10, Top = 30, Width = 280 };

                Button okButton = new Button() { Text = "Reservar", Left = 120, Width = 80, Top = 60, DialogResult = DialogResult.OK };
                Button cancelButton = new Button() { Text = "Cancelar", Left = 210, Width = 80, Top = 60, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(okButton);
                prompt.Controls.Add(cancelButton);

                prompt.AcceptButton = okButton;
                prompt.CancelButton = cancelButton;

                DialogResult result = prompt.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    return inputBox.Text.Trim();
                }
                return null;
            }
        }
    }
}