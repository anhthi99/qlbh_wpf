   M S B A M L   `   `   `  ����A  =common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA-clr-namespace:common.Controls;assembly=commoncommon.Controls  5	   	   C ?QLBH_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QLBH_WPFQLBH_WPF 5
   	   9!clr-namespace:QLBH_WPF.ViewModelsQLBH_WPF.ViewModels 5   	   9!clr-namespace:QLBH_WPF.ViewModelsQLBH_WPF.ViewModels 5   	      QLBH_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   :common-clr-namespace:common.Controls;assembly=common  5	   	   "localclr-namespace:QLBH_WPF  5
   	   )c!clr-namespace:QLBH_WPF.ViewModels  5   	   1	viewmodel!clr-namespace:QLBH_WPF.ViewModels  5   	   -   5          �Name$  
mainWindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)    
 MainVM � DataContext# [ 5   	   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadedWindow+	   CommandParameter	 6E   �� 
 �� ElementName$
 
mainWindow��5      .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � 	Resources 5!   
   ��%    5$      .+�5'   
   &   System.Windows.Controls.DataGrid  $��0 8 0 0q�5(         AutoGenerateColumns .     CanUserSortColumns .    CanUserAddRows .  $��1��5-      ��5)      �� *Users+   Columns 5/      1  +MaterialDesignThemes.Wpf.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Width5	  /System.Windows.Controls.DataGridLengthConverter$	 200	 64      Header$ Tên đăng nhập��6@      
IsReadOnly . 1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 51   4   �� *
UserName+6S   53      54      55      