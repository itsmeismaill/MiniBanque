using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxComptes.DisplayMember = "CompteId";
            comboBoxComptes.DataSource = Operation.GetData().Select(x=>x.CompteID).Distinct().ToList();
            grd.DataSource = Operation.GetData();
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxComptes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupérer le numéro de compte sélectionné dans la ComboBox
            int selectedCompteID = (int)comboBoxComptes.SelectedItem;

            // Filtrer les opérations en fonction du numéro de compte sélectionné
            var operationsForSelectedCompte = Operation.GetData().Where(o => o.CompteID == selectedCompteID).ToList();

            // Mettre à jour la source de données du DataGridView
            grd.DataSource = operationsForSelectedCompte;

            lblSolde.Text = Operation.GetData().Where(x => x.CompteID == selectedCompteID).Select(x => x.MontantType).Sum().ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FilterOperations();
        }

        private void AllButton_CheckedChanged(object sender, EventArgs e)
        {
            FilterOperations();
        }

        private void DebitButton_CheckedChanged(object sender, EventArgs e)
        {
            FilterOperations();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FilterOperations()
        {
            // Récupérer le numéro de compte sélectionné dans la ComboBox
            int selectedCompteID = (int)comboBoxComptes.SelectedItem;

            // Récupérer le type d'opération sélectionné
            EnumType? selectedOperationType = null; // Initialisez-le à null pour inclure toutes les opérations par défaut
            if (CreditButton.Checked)
            {
                selectedOperationType = EnumType.Credit;
            }
            else if (DebitButton.Checked)
            {
                selectedOperationType = EnumType.Debit;
            }

            // Filtrer les opérations en fonction du numéro de compte et du type d'opération sélectionnés
            var filteredOperations = Operation.GetData().Where(o => o.CompteID == selectedCompteID &&
                                                                    (!selectedOperationType.HasValue || o.Type == selectedOperationType)).ToList();

            // Mettre à jour la source de données du DataGridView
            grd.DataSource = filteredOperations;
        }
    }
}
