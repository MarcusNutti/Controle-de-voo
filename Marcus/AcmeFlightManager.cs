using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Marcus
{
    public partial class AcmeFlightManager : Form
    {
        public AcmeFlightManager()
        {
            InitializeComponent();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false) {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void txtPainLevel_TextChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled == false && btnCancel.Enabled == false)
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDate.Text != null) {
                txtDate.Text = null;
            }

            if (txtCost.Text != null) {
                txtCost.Text = null;
            }

            if (txtDistance.Text != null) {
                txtDistance.Text = null;
            }

            if (rbNo.Checked) {
                rbNo.Checked = false;
            }

            if (rbYes.Checked) {
                rbYes.Checked = false;
            }

            if (txtPainLevel.Text != null) {
                txtPainLevel.Text = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            double cost = 0;
            int distance = 0, painLevel = 0;
            Boolean dateValidation = false;
            Boolean costValidation = false;
            Boolean distanceValidation = false;
            Boolean painLevelValidation = false;
            char capture;

            try {
                date = Convert.ToDateTime(txtDate.Text);
                dateValidation = true;
            }

            catch {
                MessageBox.Show("Digite a data no formato DD/MM/AAAA.");
            }

            try {
                cost = Convert.ToDouble(txtCost.Text);

                if (cost < 0)
                    MessageBox.Show("O custo não pode ser menor que zero. Digite novamente");
                else
                    costValidation = true;
            }

            catch {
                MessageBox.Show("Valor inválido para custo. Digite corretamente.");
            }

            try {
                distance = Convert.ToInt32(txtDistance.Text);

                if (distance < 0)
                    MessageBox.Show("A distância não pode ser menor que zero. Digite novamente");
                else
                    distanceValidation = true;
            }

            catch {
                MessageBox.Show("Valor inválido para distância. Digite um número inteiro.");
            }

            try {
                painLevel = Convert.ToInt32(txtPainLevel.Text);

                if (painLevel < 0 || painLevel > 10)
                    MessageBox.Show("O valor do nível de dor precisa estar entre 0 e 10. Digite novamente");
                else
                    painLevelValidation = true;
            }

            catch {
                MessageBox.Show("Valor inválido para nível de dor. Digite um número inteiro.");
            }

            if (rbYes.Checked)
                capture = 'S';
            else
                capture = 'N';

            if (dateValidation == true && costValidation == true
                && distanceValidation == true && painLevelValidation == true) {
                // Chamada para o método de inserção no banco de dados

                InsertValues(date, cost, distance, capture, painLevel);
            }

        }

        public void InsertValues(DateTime date, double cost, int distance, char capture, int painLevel) {

            SQLiteConnection connection = new SQLiteConnection("Data Source=acme.sqlite");           


            try {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand();

                command.Connection = connection;

                command.CommandText = "INSERT INTO TB_VOO (ID_VOO, DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR)" +
                    " VALUES ( " + 1 + ", " + date.ToShortDateString() + ", " + cost + ", " + distance+ ", '"+ capture +"', " + painLevel + " )";

                command.ExecuteNonQuery();

                MessageBox.Show("Dados inseridos com sucesso no banco de dados.");

                command.Dispose();
            }

            catch {
                MessageBox.Show("Não foi possível realizar a operação no banco de dados.");
            }

            finally {
                connection.Close();
            }
        }
    }
}
