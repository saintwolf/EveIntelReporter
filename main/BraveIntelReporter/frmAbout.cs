﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BraveIntelReporter
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            labelCompanyName.Text = "Brave Collective";
            lblDevelopers.Text = "Developed by: Serinus Gareth for use with Kiu Nakamura's intel map.";

            if (ApplicationDeployment.IsNetworkDeployed)
                labelVersion.Text = "Version " + ApplicationDeployment.CurrentDeployment.CurrentVersion;
            else labelVersion.Text = "Development Version";

            txtDescription.Text = string.Empty;
            txtDescription.AppendText("Version 1.0.0.5 - Added settings dialog on first run.");
            txtDescription.AppendText("\r\n");
            txtDescription.AppendText("Version 1.0.0.4 - When EVE process appears, recheck for new log files.");
            txtDescription.AppendText("\r\n");
            txtDescription.AppendText("Version 1.0.0.3 - Added local settings.  Now checks for EVE process.  Auth Token implemented.");
            txtDescription.AppendText("\r\n");
            txtDescription.AppendText("Version 1.0.0.2 - Changed to JSON format (breaking change, old clients will no longer work). ");
            txtDescription.AppendText("\r\n");
            txtDescription.AppendText("Version 1.0.0.1 - Added check for new log file if no new intel reported for 5 minutes.  Added about dialog.  Displayed Monitored Files.");
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
        #endregion

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }

    }
}