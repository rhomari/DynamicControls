using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DynamicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView.EnsureCoreWebView2Async(null);
            fillColors();
            createButtons();
        }
        private void fillColors()
        {
            foreach (System.Reflection.PropertyInfo propriete in typeof(Color).GetProperties())
            {
                if (propriete.PropertyType.FullName == "System.Drawing.Color")
                {
                    cbxCOLOR.Items.Add(propriete.Name);
                   
                }
                    
                    
            }
        }

       
        private void createButtons()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(Application.StartupPath + "\\Buttons.xml");
            DataTable dataTable = dataSet.Tables[0];
            int top = 10;
            ButtonsPanel.Controls.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                //dynamically creating Buttons from XML file
                Button button = new Button();
                button.Text = dataRow["TEXT"].ToString();
                button.BackColor = Color.FromName(dataRow["COLOR"].ToString());
                button.ForeColor = Color.White;
                this.ButtonsPanel.Controls.Add(button);
                button.Location = new System.Drawing.Point(20, top);
                button.Size = new System.Drawing.Size(130, 30);
                button.Click += new EventHandler((obj, Event) =>
                {
                    webView.CoreWebView2.Navigate(dataRow["URL"].ToString());
                });
                top += 30;
            }
            
            


        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTEXT.Text!=string.Empty && txtURL.Text != string.Empty && cbxCOLOR.SelectedItem != null)
            {
                try
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(Application.StartupPath + "\\Buttons.xml");
                    XmlNode xmlNode = xmldoc.DocumentElement;
                    XmlElement xmlElement = xmldoc.CreateElement("button");
                    xmlElement.InnerXml = string.Format("<URL>{0}</URL><TEXT>{1}</TEXT><COLOR>{2}</COLOR>", txtURL.Text, txtTEXT.Text, cbxCOLOR.SelectedItem.ToString());
                    xmlNode.AppendChild(xmlElement);
                    xmldoc.Save(Application.StartupPath + "\\Buttons.xml");
                    MessageBox.Show("Shortcut Added.");
                    createButtons();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


                return;

            }
            MessageBox.Show("There was an error please check inputs.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromName(cbxCOLOR.SelectedItem.ToString());
        }
    }
}
