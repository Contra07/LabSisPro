using App.Views.Interfaces;
using App.Models.Interfaces;
using System.Linq;

namespace App.Presenters
{
    internal class LoggerPresenter
    {
        private readonly ILogger _logger;
        private readonly ILoggerView _loggerView;

        public LoggerPresenter(ILogger logger, ILoggerView loggerView)
        {
            _logger = logger;
            _loggerView = loggerView;
            _logger.NewMassage += NewMassage;
            _logger.Log = "Логгер запущен";
        }

        private void NewMassage()
        {
            _loggerView.Log = _logger.Log;
        }
    }
}
