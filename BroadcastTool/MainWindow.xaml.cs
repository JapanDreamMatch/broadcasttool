﻿using BroadcastTool.Initializer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BroadcastTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string RunningPath = Directory.GetParent(System.Windows.Forms.Application.ExecutablePath).FullName;

        public MainWindow()
        {
            InitializeComponent();

            ButtleTab.Initialize(this);
        }

        private void cmbMaps_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtleTab.LoadMap(this);
        }

        private void cmbTeamA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtleTab.LoadTeamA(this);
        }

        private void cmbTeamB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtleTab.LoadTeamB(this);
        }

        private void cmbRoomName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtleTab.LoadRoom(this);

        }
    }
}
