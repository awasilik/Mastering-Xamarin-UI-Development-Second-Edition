﻿//
//  BaseViewModel.cs
//  BaseView Model Class that each of our ViewModels will inherit from
//
//  Created by Steven F. Daniel on 5/06/2018
//  Copyright © 2018 GENIESOFT STUDIOS. All rights reserved.
//
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TrackMyWalks.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public const string PageTitlePropertyName = "PageTitle";

        string pageTitle;
        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; OnPropertyChanged(); }
        }

        protected BaseViewModel()
        {
        }

        public abstract Task Init();
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public abstract class BaseViewModel<TParam> : BaseViewModel
    {
        protected BaseViewModel()
        {
        }
    }
}