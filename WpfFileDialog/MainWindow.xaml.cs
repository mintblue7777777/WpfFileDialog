﻿using Microsoft.Win32;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFileDialog {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnFileOpen_Click(object sender, RoutedEventArgs e) {
            var dialog = new OpenFileDialog();
            dialog.Title = "ファイルを開く";
            dialog.Filter = "すべてのファイル(*.*)|*.*";
            if (dialog.ShowDialog() == true) {
                this.textBlockFileName.Text = dialog.FileName;
            } else {
                this.textBlockFileName.Text = "キャンセルされました";
            }
        }
        private void btnFileClose_Click(object sender, RoutedEventArgs e) {
            var dialog = new SaveFileDialog();
            dialog.Title = "ファイル保存";
            dialog.Filter = "テキストファイル|*.txt";
            if (dialog.ShowDialog() == true) {
                this.textBlockFileName.Text = dialog.FileName;
            } else {
                this.textBlockFileName.Text = "キャンセルされました";
            }
        }
    }
}
