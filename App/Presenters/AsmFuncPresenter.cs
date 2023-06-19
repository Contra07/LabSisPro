using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Views;
using App.Models;
using App.Views.Interfaces;
using App.Models.Interfaces;

namespace App.Presenters
{
    internal class AsmFuncPresenter
    {
        private readonly IAsmFunc _asmModel;
        private readonly IAsmFuncView _asmView;
        private readonly ILogger _logger;
        public AsmFuncPresenter(IAsmFunc asmModel, IAsmFuncView asmView, ILogger logger)
        {
            _asmModel = asmModel;
            _asmView = asmView;
            _logger = logger;
            _asmView.AssemblyMethod += AssemblyMethod;
            _logger.Log = "Низкоуровневая функция готова";
        }

        private void AssemblyMethod() 
        {
            _logger.Log = "Вызов низкоуровневой функции";
            try
            {
                _asmView.AssemblyMethodResult = _asmModel.Method(_asmView.FirstOperand, _asmView.SecondOperand);
                _logger.Log = "Функция выполенена успешно";
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }
    }
}
