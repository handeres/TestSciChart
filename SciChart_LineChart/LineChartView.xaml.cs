// *************************************************************************************
// SCICHART® Copyright SciChart Ltd. 2011-2017. All rights reserved.
//  
// Web: http://www.scichart.com
//   Support: support@scichart.com
//   Sales:   sales@scichart.com
// 
// LineChartExampleView.xaml.cs is part of the SCICHART® Examples. Permission is hereby granted
// to modify, create derivative works, distribute and publish any part of this source
// code whether for commercial, private or personal use. 
// 
// The SCICHART® examples are distributed in the hope that they will be useful, but
// without any warranty. It is provided "AS IS" without warranty of any kind, either
// expressed or implied. 
// *************************************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Data;
using System.Windows.Media;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Data.Model;
using SciChart.Core;
using SciChart.Examples.ExternalDependencies.Data;
using SciChart.Examples.ExternalDependencies.Common;

namespace SciChart.Examples.Examples.CreateSimpleChart
{
   public partial class LineChartExampleView : UserControl
    {
        public LineChartExampleView()
        {
            InitializeComponent();
        }

        private void LineChartExampleView_OnLoaded(object sender, RoutedEventArgs e)
        {
            
            // Create a DataSeries of type X=double, Y=double
            var dataSeries0 = new XyDataSeries<DateTime, double>();
            var dataSeries1 = new XyDataSeries<DateTime, double>();

            lineRenderSeries.DataSeries = dataSeries0;
            lineRenderSeries2.DataSeries = dataSeries1;

            //sciChart.RenderableSeries[0].DataSeries = dataSeries0;
           // sciChart.RenderableSeries[1].DataSeries = dataSeries1;
            // sciChart.RenderableSeries[0].DataSeries = dataSeries;

            var data = DataManager.Instance.GetFourierSeries(1.0, 0.1);

            // Prices are in the format Time, Open, High, Low, Close (all IList)
            var prices = DataManager.Instance.GetPriceData(Instrument.Indu.Value, TimeFrame.Daily);

            // Append data to series. 
            // First series is rendered as a Candlestick Chart so we append OHLC data
            dataSeries0.Append(prices.TimeData, prices.OpenData);
            // Append data to series. SciChart automatically redraws
           // dataSeries.Append(DateTime.Now, data.XData);
            
            sciChart.ZoomExtents();
        }

        private void ExportToXPS(object sender, RoutedEventArgs e)
        {
            string filePath;
            if (GetAndCheckPath("XPS | *.xps", out filePath))
            {
                sciChart.ExportToFile(filePath, ExportType.Xps, true);
            }
        }

        private void ExportToXPSBig(object sender, RoutedEventArgs e)
        {
            string filePath;
            if (GetAndCheckPath("XPS | *.xps", out filePath))
            {
                sciChart.ExportToFile(filePath, ExportType.Xps, true, new Size(2000, 2000));
            }
        }

        private void ExportToPng(object sender, RoutedEventArgs e)
        {
            string filePath;
            if (GetAndCheckPath("PNG | *.png", out filePath))
            {
                sciChart.ExportToFile(filePath, ExportType.Png, false);
            }
        }

        private void ExportPngInMemory(object sender, RoutedEventArgs e)
        {
            string filePath;
            if (GetAndCheckPath("PNG | *.png", out filePath))
            {
                sciChart.ExportToFile(filePath, ExportType.Png, false, new Size(2000, 1500));
            }
        }

        public SaveFileDialog CreateFileDialog(string filter)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            return saveFileDialog;
        }

        private void OnPrintClick(object sender, RoutedEventArgs e)
        {
            sciChart.Print();
        }

        private bool GetAndCheckPath(string filter, out string path)
        {
            var ret = false;
            var isGoodPath = false;
            var saveFileDialog = CreateFileDialog(filter);
            path = null;

            while (!isGoodPath)
            {
                if (saveFileDialog.ShowDialog() == true)
                {
                    if (IsFileGoodForWriting(saveFileDialog.FileName))
                    {
                        path = saveFileDialog.FileName;
                        isGoodPath = true;
                        ret = true;
                    }
                    else
                    {
                        MessageBox.Show(
                            "File is inaccesible for writing or you can not create file in this location, please choose another one.");
                    }
                }
                else
                {
                    isGoodPath = true;
                }
            }

            return ret;
        }

        /// <summary>
        /// Check if file is Good for writing
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns></returns>
        public static bool IsFileGoodForWriting(string filePath)
        {
            FileStream stream = null;
            FileInfo file = new FileInfo(filePath);

            try
            {
                stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            }
            catch (Exception)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return false;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return true;
        }
    }
}
