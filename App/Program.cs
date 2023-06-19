using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;
using App.Presenters;
using App.Models.Interfaces;
using App.Views;
using App.Views.Interfaces;

namespace App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainView = new MainForm();
            var fileModel = new FileManager();
            var recordView = new AddRecordForm();
            var logger = new Logger();
            var compiler = new Compiler("For");
            var asmModel = new AsmFunc();
            var dbModel = new DataBaseManager();
            var logPresenter = new LoggerPresenter(logger, mainView);
            var asmPresenter = new AsmFuncPresenter(asmModel, mainView, logger);
            var compilerPresenter = new CompilerPresenter(compiler, mainView, logger);
            var filePresenter = new FileManagerPresenter(fileModel, mainView, recordView, logger);
            var dbPresenter = new DataBasePresenter(dbModel, mainView, logger, recordView);
            Application.Run(mainView);
        }
    }
}
