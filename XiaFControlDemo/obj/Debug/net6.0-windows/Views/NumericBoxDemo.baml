   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.2.1.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      *   $XiaFControlDemo.Views.NumericBoxDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      9system&clr-namespace:System;assembly=mscorlib     5      .��5      �� .��5   
   �   � RowDefinitions  5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      .+�5      �� $B��<数值框会自动限制数值外的字符输入和粘贴等��6   $��0q�65   $��10q�6I   .��5      �� &    XiaFControl.Controls.PanelHelper   Spacing$ 10Q�6    �� Orientation$ 
Horizontal=�6B   $��Center=�6[   .+�5      %   XiaFControl.Controls.NumericBox  $	��120��6-      Value 169      XiaFNumericBox#��[  6C     5      $	��120��6)      NumericType$ Double=�65    0.16J   5      5      �� 5      $��1��6   $����通过 MaxValue 和 MinValue 设置最大最小值  通过 Interval 设置加减间隔  通过 ShowButton 设置加减按钮显示��6$   $��0q�5      $��Center=�6,   $��10q�6G   .��5      �� $ 10Q�6   $ 
Horizontal=�6B   .+�5      �� $��	-10 ~ 10:��6     5       $	��120��6-     SuccessBrush(   "XiaFControl.Controls.ControlHelper   FocusBorderBrush# �  69      MouseOverBrush# �  6�      MaxValue$ 10Q�6�      MinValue$	 -10Q�6�    16�   �� 5!      $��加减间隔 2:��6     5#      $	��120��6-   	   Text$	 1��69   (   "XiaFControl.Controls.TextBoxHelper
   Placeholder$
 
Interval=2��6B      Interval$ 2Q�6u    06�   �� 5$      $��不显示按钮:��6     5%      $	��120��6-      IsClearable$
 True��69      
ShowButton$ False��6f    16y   5&      5'      �� 5(      $ 10Q�6   $ 
Horizontal=�6>   $��2��6W   $��10q�6d   .+�5)        $	��120��6)    165   �� 5*      $��	int 值:1��6     5+      $	��120��6)   $	 0.1Q�68   $ Double=�6G      
TextFormat$ F2��6\    0.16l   �� 5,      $��double 值: 0.1��6   5-      �� 5.      $ 10Q�6   $ 
Horizontal=�6>   $��3��6W   $��10q�6d   .+�5/        $	��150��6)   $ E2��68    16H     50      $	��120��6)     
BorderGray   PreContentForeground# [ 51   -      
PreContent$ 身高��52   -   $	 0cm��6W    1776h   53      �� 54      $ 10Q�6   $ 
Horizontal=�6>   $��4��6W   $��10q�6d   .+�55          FilledNumericBox#��[ 6)   $	��120��6S    16b     56      $	��120��6)    168   
 �  ��
 �  ��58   -   59      5:      5;      5<      