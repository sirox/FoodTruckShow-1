﻿#pragma checksum "C:\Users\sirox\Documents\Visual Studio 2015\Projects\FoodTruckShow\FoodTruckShow\FoodTruckShow\Cadastro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B2B4318E3D181DE0D5B954EF56BA784A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FoodTruckShow {
    
    
    public partial class Cadastro : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txt_nome;
        
        internal System.Windows.Controls.TextBox txt_email;
        
        internal System.Windows.Controls.CheckBox chk_foodtruck;
        
        internal System.Windows.Controls.PasswordBox txt_senha;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnCadastrar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnCancelar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FoodTruckShow;component/Cadastro.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txt_nome = ((System.Windows.Controls.TextBox)(this.FindName("txt_nome")));
            this.txt_email = ((System.Windows.Controls.TextBox)(this.FindName("txt_email")));
            this.chk_foodtruck = ((System.Windows.Controls.CheckBox)(this.FindName("chk_foodtruck")));
            this.txt_senha = ((System.Windows.Controls.PasswordBox)(this.FindName("txt_senha")));
            this.btnCadastrar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCadastrar")));
            this.btnCancelar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCancelar")));
        }
    }
}

