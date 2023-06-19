using System;
using App.Views.Interfaces;
using App.Models.Interfaces;

namespace App.Presenters
{
    internal class CompilerPresenter
    {
        private readonly ICompiler _compilerModel;
        private readonly ICompilerView _compilerView;
        private readonly ILogger _logger;
        public CompilerPresenter(ICompiler compilerModel, ICompilerView compilerView, ILogger logger)
        {
            _compilerModel = compilerModel;
            _compilerView = compilerView;
            _logger = logger;
            _compilerView.Compile += Compile;
            _logger.Log = "Анализатор запущен";
        }

        private void Compile() 
        {
            _logger.Log = "Компиляция кода";
            try
            {
                _compilerView.Result = _compilerModel.CountForCycle(_compilerView.Code);
                _logger.Log = "Компиляция прошла успешно";
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }


    }
}
