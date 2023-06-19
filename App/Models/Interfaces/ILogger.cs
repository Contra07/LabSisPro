using System;

namespace App.Models.Interfaces
{
    internal interface ILogger
    {
        string Log { set; get; }

        event Action NewMassage;
    }
}
