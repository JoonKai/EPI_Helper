﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EPI_Helper.EPI_View
{
    /// <summary>
    /// Hellsys.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Hellsys : Window
    {
        public Hellsys()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var accentBrush = TryFindResource("AccentColorBrush") as SolidColorBrush;
            if (accentBrush != null) accentBrush.Color.CreateAccentColors();
        }
    }
}
