﻿#pragma checksum "C:\Users\Fiap\Desktop\FoodTruckShow\FoodTruckShow\FoodTruckShow\SouFoodTruck.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B78B207946C7E1F86BF3189280507D66"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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
    
    
    public partial class SouFoodTruck : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock txt_proprietario;
        
        internal System.Windows.Controls.TextBlock txt_telefone;
        
        internal System.Windows.Controls.TextBlock txt_email;
        
        internal System.Windows.Controls.TextBlock txt_foodtruck;
        
        internal System.Windows.Controls.TextBlock txt_horario;
        
        internal System.Windows.Controls.TextBlock txt_preco;
        
        internal System.Windows.Controls.TextBlock txt_segmento;
        
        internal System.Windows.Controls.TextBlock txt_localizacao;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FoodTruckShow;component/SouFoodTruck.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txt_proprietario = ((System.Windows.Controls.TextBlock)(this.FindName("txt_proprietario")));
            this.txt_telefone = ((System.Windows.Controls.TextBlock)(this.FindName("txt_telefone")));
            this.txt_email = ((System.Windows.Controls.TextBlock)(this.FindName("txt_email")));
            this.txt_foodtruck = ((System.Windows.Controls.TextBlock)(this.FindName("txt_foodtruck")));
            this.txt_horario = ((System.Windows.Controls.TextBlock)(this.FindName("txt_horario")));
            this.txt_preco = ((System.Windows.Controls.TextBlock)(this.FindName("txt_preco")));
            this.txt_segmento = ((System.Windows.Controls.TextBlock)(this.FindName("txt_segmento")));
            this.txt_localizacao = ((System.Windows.Controls.TextBlock)(this.FindName("txt_localizacao")));
            this.btnCadastrar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCadastrar")));
        }
    }
}

