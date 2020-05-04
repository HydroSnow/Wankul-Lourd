using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wankul
{
    public partial class MainWindow : Form
    {
        private VueModeleFromage vmFromage = new VueModeleFromage();
        private VueModeleLait vmLait = new VueModeleLait();
        private VueModeleType vmType = new VueModeleType();
        private VueModeleUtilisateur vmUtilisateur = new VueModeleUtilisateur();
        private LoginService loginService = LoginService.SingleInstance;
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
            System.Reflection.PropertyInfo[] currentClassProperties = null;
            switch (activeVue)
            {
                case "Fromage":
                    currentClassProperties = typeof(Fromage).GetProperties();
                    break;
                case "Lait":
                    currentClassProperties = typeof(Lait).GetProperties();
                    break;
                case "Type":
                    currentClassProperties = typeof(Type).GetProperties();
                    break;
                case "Client":
                    currentClassProperties = typeof(Utilisateur).GetProperties();
                    break;
                case "Fournisseur":
                    currentClassProperties = typeof(Utilisateur).GetProperties();
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
                Control textBox = GetControl(this, "textBox" + i.ToString());
                textBox.Hide();
                textBox.ResetText();
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
                MessageBox.Show(responseFromage.error, "API Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            backupListEntity = responseFromage.result;
            RefreshEntityList(backupListEntity);
            AdaptUIFromVue();
        }

        private void VueLait()
        {
            activeVue = Properties.Resources.LaitVue;
            ResponseLait responseLait = vmLait.ReadAll();
            if (!responseLait.valid)
            {
                MessageBox.Show(responseLait.error, "API Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            backupListEntity = responseLait.result;
            RefreshEntityList(backupListEntity);
            AdaptUIFromVue();
        }

        private void VueType()
        {
            activeVue = Properties.Resources.TypeVue;
            ResponseType responseType = vmType.ReadAll();
            if (!responseType.valid)
            {
                MessageBox.Show(responseType.error, "API Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            backupListEntity = responseType.result;
            RefreshEntityList(backupListEntity);
            AdaptUIFromVue();
        }

        private void VueClient()
        {
            activeVue = Properties.Resources.ClientVue;
            ResponseUtilisateur responseUtilisateur = vmUtilisateur.ReadAll();
            if (!responseUtilisateur.valid)
            {
                MessageBox.Show(responseUtilisateur.error, "API Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            backupListEntity = responseUtilisateur.result.Where(user => user.role == 3).ToArray();
            RefreshEntityList(backupListEntity);
            AdaptUIFromVue();
        }

        private void VueFournisseur()
        {
            activeVue = Properties.Resources.FournisseurVue;
            ResponseUtilisateur responseUtilisateur = vmUtilisateur.ReadAll();
            if (!responseUtilisateur.valid)
            {
                MessageBox.Show(responseUtilisateur.error, "API Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            backupListEntity = responseUtilisateur.result.Where(user => user.role == 2).ToArray();
            RefreshEntityList(backupListEntity);
            AdaptUIFromVue();
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
            if (textBox1.Text.Length == 0 && label1.Text == "id")
            {
                MessageBox.Show("Veuillez sélectionner un élement a supprimer", "Network Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = null;
            switch (activeVue)
            {
                case "Fromage":
                    result = vmFromage.Delete(int.Parse(textBox1.Text));
                    VueFromage();
                    break;
                case "Lait":
                    result = vmLait.Delete(int.Parse(textBox1.Text));
                    VueLait();
                    break;
                case "Type":
                    result = vmType.Delete(int.Parse(textBox1.Text));
                    VueType();
                    break;
                case "Client":
                    result = vmUtilisateur.Delete(int.Parse(textBox1.Text));
                    VueClient();
                    break;
                case "Fournisseur":
                    result = vmUtilisateur.Delete(int.Parse(textBox1.Text));
                    VueFournisseur();
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            if (result != null)
            {
                MessageBox.Show(result);
            }
            ResetTextBoxs();
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (IsAnEmptyBox())
            {
                MessageBox.Show("Certains champs sont incomplets", "Network Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = null;
            switch (activeVue)
            {
                case "Fromage":
                    result = vmFromage.Update(new Fromage(GetEntityData(typeof(Fromage).GetProperties())));
                    VueFromage();
                    break;
                case "Lait":
                    result = vmLait.Update(new Lait(GetEntityData(typeof(Lait).GetProperties())));
                    VueLait();
                    break;
                case "Type":
                    result = vmType.Update(new Type(GetEntityData(typeof(Type).GetProperties())));
                    VueType();
                    break;
                case "Client":
                    result = vmUtilisateur.Update(new Utilisateur(GetEntityData(typeof(Utilisateur).GetProperties())));
                    VueClient();
                    break;
                case "Fournisseur":
                    result = vmUtilisateur.Update(new Utilisateur(GetEntityData(typeof(Utilisateur).GetProperties())));
                    VueFournisseur();
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            if (result != null)
            {
                MessageBox.Show(result);
            }
            ResetTextBoxs();
        }

        private bool IsAnEmptyBox()
        {
            bool emptyBox = false;
            for (int i = 1; i <= short.Parse(Properties.Resources.NumberBoxs); i++)
            {
                Control textBox = GetControl(this, "textBox" + i.ToString());
                if (textBox.Text.Length < 1 && textBox.Visible && ((TextBox)textBox).ReadOnly == false)
                    return true;
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
                MessageBox.Show("Certains champs sont incomplets", "Network Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = null;
            switch (activeVue)
            {
                case "Fromage":
                    result = vmFromage.Create(new Fromage(GetEntityData(typeof(Fromage).GetProperties())));
                    VueFromage();
                    break;
                case "Lait":
                    result = vmLait.Create(new Lait(GetEntityData(typeof(Lait).GetProperties())));
                    VueLait();
                    break;
                case "Type":
                    result = vmType.Create(new Type(GetEntityData(typeof(Type).GetProperties())));
                    VueType();
                    break;
                case "Client":
                    Utilisateur client = new Utilisateur(GetEntityData(typeof(Utilisateur).GetProperties()));
                    client.role = 3;
                    result = vmUtilisateur.Create(client);
                    VueClient();
                    break;
                case "Fournisseur":
                    Utilisateur fournisseur = new Utilisateur(GetEntityData(typeof(Utilisateur).GetProperties()));
                    fournisseur.role = 2;
                    result = vmUtilisateur.Create(fournisseur);
                    VueFournisseur();
                    break;
                default:
                    MessageBox.Show("Error with the current vue ");
                    break;
            }
            if (result != null)
            {
                MessageBox.Show(result);
            }

            ResetTextBoxs();
        }

        private void LaitMenu_Click(object sender, EventArgs e)
        {
            VueLait();
        }

        private void FromageMenu_Click(object sender, EventArgs e)
        {
            VueFromage();
        }

        private void TypeMenu_Click(object sender, EventArgs e)
        {
            VueType();
        }

        private void ClientMenu_Click(object sender, EventArgs e)
        {
            VueClient();
        }

        private void FournisseurMenu_Click(object sender, EventArgs e)
        {
            VueFournisseur();
        }
    }
}
