﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppPreziCalc.Model;

namespace AppPreziCalc.ViewModel
{
    public class IntroViewModel : BaseViewModel
    {
        public Command WHOCommand { get; }
        public Command BrasilCommand { get; }

        public IntroViewModel()
        {
            WHOCommand = new Command(ExecuteWHOCommand);
            BrasilCommand = new Command(ExecuteBrasilCommand);
        }

        private async void ExecuteBrasilCommand()
        {
            await PushAsync<MainViewModel>();
        }

        private async void ExecuteWHOCommand()
        {
            await PushAsync<MedicineViewModel>(CalcMedicine.Type.WHO);
        }
    }
}

