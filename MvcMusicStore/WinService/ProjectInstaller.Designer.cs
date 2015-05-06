namespace WinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallTest = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerTest = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallTest
            // 
            this.serviceProcessInstallTest.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallTest.Password = null;
            this.serviceProcessInstallTest.Username = null;
            // 
            // serviceInstallerTest
            // 
            this.serviceInstallerTest.Description = "A test service with VS 2013";
            this.serviceInstallerTest.DisplayName = "TestService";
            this.serviceInstallerTest.ServiceName = "TestService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallTest,
            this.serviceInstallerTest});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallTest;
        private System.ServiceProcess.ServiceInstaller serviceInstallerTest;
    }
}