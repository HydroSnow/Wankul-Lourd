using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wankul
{
    public partial class MainWindow : Form
    {
        private VueModeleFromage vmFromage = new VueModeleFromage();
        private dynamic[] listEntity;
        private dynamic[] backupListEntity;

        private string activeVue = Properties.Resources.FromageVue;

        private void RefreshEntityList(dynamic[] entitys)
        {
            listBoxEntity.Clear();
            listEntity = entitys;
            foreach (dynamic entity in entitys)
            {
                listBoxEntity.Items.Add(entity.id + " " + entity.nom);
            }
        }

        private void AdaptUIFromVue()
        {
            System.Reflection.PropertyInfo[] currentClassProperties = typeof(Fromage).GetProperties();
            switch (activeVue)
            {
                case "Fromage":
                    // Initalize by default at Fromage properties
                    break;
                case "Lait":
                    // CurrentClassProperties = typeof(Lait).GetProperties();
                    MessageBox.Show("Not implemented");
                    break;
                case "Categorie":
                    MessageBox.Show("Not implemented");
                    break;
                case "Client":
                    MessageBox.Show("Not implemented");
                    break;
                case "Fournisseur":
                    MessageBox.Show("Not implemented");
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            HideAllBoxs();
            for (int i = 0; i < currentClassProperties.Length; i++)
            {
                GetControl(this, "textBox" + (i + 1).ToString()).Visible = true;
                GetControl(this, "label" + (i + 1).ToString()).Visible = true;
                GetControl(this, "label" + (i + 1).ToString()).Text = currentClassProperties[i].Name;
            }
        }

        private void HideAllBoxs()
        {
            comboBox1.Hide();
            comboBox2.Hide();
            for (int i = 1; i <= Int16.Parse(Properties.Resources.NumberBoxs); i++)
            {
                Control ctrlTextBox = GetControl(this, "textBox" + i.ToString());
                ctrlTextBox.Hide();
                ctrlTextBox.ResetText();
                GetControl(this, "label" + i.ToString()).Hide();
            }
        }

        private void ResetTextBoxs()
        {
            for (int i = 1; i <= Int16.Parse(Properties.Resources.NumberBoxs); i++)
                GetControl(this, "textBox" + i.ToString()).ResetText();
        }

        private Control GetControl(Control container, string name)
        {
            return container.Controls.Find(name, false).First();
        }

        private void VueFromage()
        {
            activeVue = Properties.Resources.FromageVue;
            ResponseFromage responseFromage = vmFromage.ReadAll();
            if (!responseFromage.valid)
            {
                MessageBox.Show(responseFromage.error);
                return;
            }
            backupListEntity = responseFromage.result;
            RefreshEntityList(responseFromage.result);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            AdaptUIFromVue();
            VueFromage();
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            if (filterBox.Text != Properties.Resources.PlaceHodlerFilterBox)
                RefreshEntityList(backupListEntity.Where(entity => entity.nom.ToLower().Contains(filterBox.Text.ToLower())).ToArray());
        }

        private void filterBox_Enter(object sender, EventArgs e)
        {
            if (filterBox.Text == Properties.Resources.PlaceHodlerFilterBox)
                filterBox.Text = "";
        }

        private void filterBox_Leave(object sender, EventArgs e)
        {
            if (filterBox.Text.Length == 0)
                filterBox.Text = Properties.Resources.PlaceHodlerFilterBox;
        }

        private void listEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEntity.SelectedItems.Count < 1) return;

            dynamic selectedEntity = listEntity.Where(f => f.id.ToString() == listBoxEntity.SelectedItems[0].Text.Split(' ')[0]).Single();
            System.Reflection.PropertyInfo[] propertiesInfo = selectedEntity.GetType().GetProperties();
            for (int i = 0; i < propertiesInfo.Length; i++)
            {
                GetControl(this, "textBox" + (i + 1).ToString()).Text = propertiesInfo[i].GetValue(selectedEntity, null).ToString();
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            ResetTextBoxs();
        }

        private void buttonSuppr_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élement a supprimer");
                return;
            }
            switch (activeVue)
            {
                case "Fromage":
                    vmFromage.Delete(int.Parse(textBox1.Text));
                    VueFromage();
                    break;
                case "Lait":
                    MessageBox.Show("Not implemented");
                    break;
                case "Categorie":
                    MessageBox.Show("Not implemented");
                    break;
                case "Client":
                    MessageBox.Show("Not implemented");
                    break;
                case "Fournisseur":
                    MessageBox.Show("Not implemented");
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            ResetTextBoxs();
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (IsAnEmptyBox())
            {
                MessageBox.Show("Certains champs sont incomplets");
                return;
            }
            switch (activeVue)
            {
                case "Fromage":
                    vmFromage.Update(new Fromage(GetEntityData(typeof(Fromage).GetProperties())));
                    VueFromage();
                    break;
                case "Lait":
                    MessageBox.Show("Not implemented");
                    break;
                case "Categorie":
                    MessageBox.Show("Not implemented");
                    break;
                case "Client":
                    MessageBox.Show("Not implemented");
                    break;
                case "Fournisseur":
                    MessageBox.Show("Not implemented");
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            ResetTextBoxs();
        }

        private bool IsAnEmptyBox()
        {
            bool emptyBox = false;
            for (int i = 1; i <= Int16.Parse(Properties.Resources.NumberBoxs); i++)
            {
                Control textBox = GetControl(this, "textBox" + i.ToString());
                if (textBox.Text.Length < 1 && textBox.Visible)
                    emptyBox = true;
            }
            return emptyBox;
        }

        private Dictionary<string, string> GetEntityData(System.Reflection.PropertyInfo[] propertiesInfo)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for (int i = 0; i < propertiesInfo.Length; i++)
                dictionary[propertiesInfo[i].Name] = GetControl(this, "textBox" + (i + 1).ToString()).Text;
            return dictionary;
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (IsAnEmptyBox())
            {
                MessageBox.Show("Certains champs sont incomplets");
                return;
            }
            switch (activeVue)
            {
                case "Fromage":
                    vmFromage.Create(new Fromage(GetEntityData(typeof(Fromage).GetProperties())));
                    VueFromage();
                    break;
                case "Lait":
                    MessageBox.Show("Not implemented");
                    break;
                case "Categorie":
                    MessageBox.Show("Not implemented");
                    break;
                case "Client":
                    MessageBox.Show("Not implemented");
                    break;
                case "Fournisseur":
                    MessageBox.Show("Not implemented");
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            ResetTextBoxs();
        }
    }
}
