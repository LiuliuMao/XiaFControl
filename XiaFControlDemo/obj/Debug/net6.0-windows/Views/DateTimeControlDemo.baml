   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      /   )XiaFControlDemo.Views.DateTimeControlDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kcontrol7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��日历-Calendar��6   $��	0 0 10 10q�6,   $
��Auto��6?   .��5      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5      &   System.Windows.Controls.Calendar  5      5      �� 5      $��时钟-Clock��6   $��0 0 0 10q�6)   $
��Auto��6;   $��1��6H   .��5      �� $ 
Horizontal=�6   $��5q�66   .+�5          XiaFControl.Controls.Clock  -   5        5   $   5      5      �� 5      $ ��日期选择框-DatePicker��6   $��0 0 0 10q�61   $
��Auto��6C   $��1��6P   .��5       �� $ 
Horizontal=�6   $��5q�66   .+�5!      (  "System.Windows.Controls.DatePicker  $	��140��6!   5"      5#      �� 5$      $ ��时间选择框-TimePicker��6   $��	10 0 0 10q�61   $
��Auto��6D   $��1��6Q   $��1��6^   .��5%      �� $ 
Horizontal=�6   $��5q�66   .+�5&      %   XiaFControl.Controls.TimePicker  $	��140��6)   5'      5(      �� 5)      $*��$日期时间选择框-DateTimePicker��6   $��	10 0 0 10q�67   $
��Auto��6J   $��1��6W   $��2��6d   .��5*      �� $ 
Horizontal=�6   $��5q�66   .+�5+      )   #XiaFControl.Controls.DateTimePicker  $	��140��6-   5,      5-      5.      5/      50      