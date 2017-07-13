using System.ComponentModel;

namespace ClanScape.Services.Data.Player
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
        }
    }
}
