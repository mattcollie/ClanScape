using System.ServiceProcess;
using ClanScape.Services.Data.Player.Interfaces;
using ClanScape.Services.Data.Player.Logging;

namespace ClanScape.Services.Data.Player
{
    public partial class Service : ServiceBase
    {
        private ILogger _logger { get; }

        public Service()
        {
            InitializeComponent();
            
            _logger = new EventLogger();
        }

        protected override void OnStart(string[] args)
        {
            _logger.Log("OnStart");
        }

        protected override void OnStop()
        {
            _logger.Log("OnStop");
        }

        protected override void OnContinue()
        {
            _logger.Log("OnContinue");
        }
    }
}
