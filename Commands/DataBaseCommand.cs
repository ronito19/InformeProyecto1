﻿using InformeProyecto.Services.DataSet;
using InformeProyecto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InformeProyecto.Commands
{
    class DataBaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DataSetHandler.insertaDpto(resumenViewModel.txtDpto);
        }


        public ResumenViewModel resumenViewModel { set; get; }

        public DataBaseCommand(ResumenViewModel resumenViewModel)
        {
            this.resumenViewModel = resumenViewModel;
        }


    }
}
