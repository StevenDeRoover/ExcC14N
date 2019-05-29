using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExcC14NTransform.Shell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCanonicalize_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = "";
                XmlDocument document = new XmlDocument();
                document.LoadXml(txtInput.Text);
                Transform transform = GetTransformation();
                transform.LoadInput(document);
                var output = (Stream)transform.GetOutput(typeof(Stream));
                txtOutput.Text = new StreamReader(output).ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDigest_Click(object sender, EventArgs e)
        {
            try
            {
                txtDigest.Text = "";
                SHA1 sha = new SHA1Managed();
                Transform transform = GetTransformation();
                transform.LoadInput(new MemoryStream(Encoding.UTF8.GetBytes(txtOutput.Text)));
                var hash = transform.GetDigestedOutput(sha);
                txtDigest.Text = Convert.ToBase64String(hash);

                txtDigest.Text = Convert.ToBase64String(transform.GetDigestedOutput(sha));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal Transform GetTransformation()
        {
            if (rbExcC14N.Checked)
            {
                return new XmlDsigExcC14NTransform("wsu");
            }
            else if (rbC14N.Checked)
            {
                return new XmlDsigC14NTransform();
            }
            return null;
        }

        private void btnComputeHash_Click(object sender, EventArgs e)
        {
            try
            {
                txtHash.Text = "";
                SHA1 sha = new SHA1Managed();
                txtHash.Text = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(txtOutput.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
