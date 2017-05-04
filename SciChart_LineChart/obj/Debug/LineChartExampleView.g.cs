﻿#pragma checksum "..\..\LineChartExampleView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AFC19E1016878B13CCA8090D04F9B20E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using SciChart.Charting;
using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Common;
using SciChart.Charting.Common.AttachedProperties;
using SciChart.Charting.Common.Databinding;
using SciChart.Charting.Common.Extensions;
using SciChart.Charting.Common.Helpers;
using SciChart.Charting.Common.MarkupExtensions;
using SciChart.Charting.HistoryManagers;
using SciChart.Charting.Model;
using SciChart.Charting.Model.ChartData;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Numerics;
using SciChart.Charting.Numerics.CoordinateCalculators;
using SciChart.Charting.Numerics.CoordinateProviders;
using SciChart.Charting.Numerics.DeltaCalculators;
using SciChart.Charting.Numerics.TickProviders;
using SciChart.Charting.Themes;
using SciChart.Charting.ViewportManagers;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.Axes.LabelProviders;
using SciChart.Charting.Visuals.Axes.LogarithmicAxis;
using SciChart.Charting.Visuals.PointMarkers;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Charting.Visuals.Shapes;
using SciChart.Charting.Visuals.TradeChart;
using SciChart.Core.AttachedProperties;
using SciChart.Core.MarkupExtensions;
using SciChart.Core.Utility.Mouse;
using SciChart.Data.Model;
using SciChart.Data.Numerics;
using SciChart.Drawing;
using SciChart.Drawing.Common;
using SciChart.Drawing.Extensions;
using SciChart.Drawing.HighQualityRasterizer;
using SciChart.Drawing.HighSpeedRasterizer;
using SciChart.Examples.Examples.CreateSimpleChart;
using SciChart.Examples.ExternalDependencies.Behaviors;
using SciChart.Examples.ExternalDependencies.Common;
using SciChart.Examples.ExternalDependencies.Controls.SciChart3DInteractionToolbar;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.Converters;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.CustomModifiers;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.Extension;
using SciChart.Examples.ExternalDependencies.Data;
using SciChart.Examples.ExternalDependencies.Helpers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SciChart.Examples.Examples.CreateSimpleChart {
    
    
    /// <summary>
    /// LineChartExampleView
    /// </summary>
    public partial class LineChartExampleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\LineChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.SciChartSurface sciChart;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\LineChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries lineRenderSeries;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SciChart_LineChart;component/linechartexampleview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LineChartExampleView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\LineChartExampleView.xaml"
            ((SciChart.Examples.Examples.CreateSimpleChart.LineChartExampleView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.LineChartExampleView_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sciChart = ((SciChart.Charting.Visuals.SciChartSurface)(target));
            return;
            case 3:
            this.lineRenderSeries = ((SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

