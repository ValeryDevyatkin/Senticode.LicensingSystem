﻿using System;
using Senticode.LicensingSystem.Application.Extensions;
using Senticode.WPF.Tools.Core;
using Senticode.WPF.Tools.MVVM;
using Unity;

namespace Senticode.LicensingSystem.Application.ViewModels
{
    internal class MenuItemViewModel : ViewModelBase<AppCommandsBase>
    {
        public string Title { get; }
        public Type Type { get; }

        public MenuItemViewModel(IUnityContainer container, Type type) : base(container)
        {
            Title = type.Name.L();
            Type = type;
        }
    }
}
