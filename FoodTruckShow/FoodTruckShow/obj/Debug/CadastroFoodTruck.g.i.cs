﻿#pragma checksum "C:\Users\sirox\Documents\Visual Studio 2015\Projects\FoodTruckShow\FoodTruckShow\FoodTruckShow\CadastroFoodTruck.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B9FF27E7F7EB46A3EE06F45E5F0564D1"
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
    
    
    public partial class CadastroFoodTruck : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ScrollViewer ContentPanel;
        
        internal System.Windows.Controls.TextBox txt_foodtruck_nome;
        
        internal Microsoft.Phone.Controls.TimePicker time_abre;
        
        internal Microsoft.Phone.Controls.TimePicker time_fecha;
        
        internal System.Windows.Controls.TextBox txt_preco;
        
        internal System.Windows.Controls.TextBox txt_telefone;
        
        internal System.Windows.Controls.TextBlock textBlock;
        
        internal System.Windows.Controls.TextBox txt_local;
        
        internal Microsoft.Phone.Controls.ListPicker lst_segmento;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnCadastrar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FoodTruckShow;component/CadastroFoodTruck.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.ScrollViewer)(this.FindName("ContentPanel")));
            this.txt_foodtruck_nome = ((System.Windows.Controls.TextBox)(this.FindName("txt_foodtruck_nome")));
            this.time_abre = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("time_abre")));
            this.time_fecha = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("time_fecha")));
            this.txt_preco = ((System.Windows.Controls.TextBox)(this.FindName("txt_preco")));
            this.txt_telefone = ((System.Windows.Controls.TextBox)(this.FindName("txt_telefone")));
            this.textBlock = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock")));
            this.txt_local = ((System.Windows.Controls.TextBox)(this.FindName("txt_local")));
            this.lst_segmento = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lst_segmento")));
            this.btnCadastrar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCadastrar")));
        }
    }
}

