using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = "";
          
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        internal void changeDescriptionColor(Color c)
        {
            Console.WriteLine("prev color: " + this.textBoxDescription.ForeColor);
            this.textBoxDescription.ForeColor = c;
            Console.WriteLine("new color: " + this.textBoxDescription.ForeColor);
        }

        internal void changeDescriptionFont(Font font)
        {
            Console.WriteLine("prev font: " + this.textBoxDescription.Font);
            this.textBoxDescription.Font = font;   
            Console.WriteLine("new font: " + this.textBoxDescription.Font);
        }

        internal void changeDescriptionText(string desc)
        {
            Console.WriteLine("prev text: " + this.textBoxDescription.Text);
            this.textBoxDescription.Text = desc;
            Console.WriteLine("new text: " + this.textBoxDescription.Text);
        }
  
        public void S1()
        {
            this.changeDescriptionText("Print1");
            this.changeDescriptionFont(new Font("Arial", 20));
            this.changeDescriptionColor(Color.Blue);
        }
        public void S2()
        {
            this.changeDescriptionText("Print2");
            this.changeDescriptionFont(new Font("david", 36));
            this.changeDescriptionColor(Color.Red);

        }
        public void S3()
        {
            this.changeDescriptionText("Print3");
            this.changeDescriptionFont(new Font("roman", 48));
            this.changeDescriptionColor(Color.Green);

        }

        internal void changeDescription(S_delegate s)
        {
            s();
        }

        public delegate void S_delegate();

        #endregion
    }

}
