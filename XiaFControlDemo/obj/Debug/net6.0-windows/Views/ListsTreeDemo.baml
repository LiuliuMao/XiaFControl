   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:XiaFControlDemo.ViewModelsXiaFControlDemo.ViewModels 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      =#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5
      )   #XiaFControlDemo.Views.ListsTreeDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors 	 5      1vm(clr-namespace:XiaFControlDemo.ViewModels 	 5      1core&clr-namespace:System;assembly=mscorlib 	 5	      /local#clr-namespace:XiaFControlDemo.Views 	 5
        � 	Resources  5         GenderTypeEnum S� 
MethodName S� 
ObjectTypeU
 QSystem.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a 
 System.Enum S� MethodParameters M� Type+  %XiaFControlDemo.ViewModels.GenderType��%e   &	        S� 5   
   $ 	GetValues��64   "  6L    5      M� 5      "  6   5      5      .��5      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5       $��* �6#   .+�5"      �� $��列表框-ListBox��6   $��	0 0 10 10q�6,   $��2��6?   .��5#      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5$      �� -   5         ��Name$ listBox��5$      $	��150��6/   $��0 0 20 0q�6;   .@�5%      �� $��西瓜��6&   �� 5&      $��香蕉��6&   �� 5'      $��苹果��6&   5(      �� 5)      -   5        $ listBox1��5)      $	��150��60   $��0q�6<     PopularListBox#��[ 6P     Primary(   "XiaFControl.Controls.ControlHelper	   FocusedBrush#	 �  5*        BackgroundGray
   MouseOverBrush#
 �  5+        DefaultForeground   FocusedForegroundBrush# �  5,      .@�5-      �� .��5.      �� $ 
Horizontal=�6)   .+�5/   "      XiaFControl.Controls.Icon     Type$ QqFill=�63   $��0 0 5 0q�6A   $��26��6R   $��26��6^   �� 50   "   $��QQ��6,   $��26(�66   51      52      �� 53      .��54      �� $ 
Horizontal=�6)   .+�55   "     $ 
WechatFill=�63   $��0 0 5 0q�6E   $��19��6V   $��19��6b   �� 56   "   $��微信��6,   $��19(�66   57      58      �� 59      .��5:      �� $ 
Horizontal=�6)   .+�5;   "     $ 	WeiboFill=�63   $��0 0 5 0q�6D   �� 5<   "   $��微博��6,   5=      5>      5?      5@      5A      �� 5B      $��列表视图-ListView��6   $��0 0 0 10q�6.   $��1��6@   .��5C      �� $ 
Horizontal=�6   $��5q�66   .+�5D      �� $	��130��6?   )   #XiaFControl.Controls.ListViewHelper   HeadBackground# �  5E        PrimaryForeground   HeadForeground# �  5F      ��5D      �� *	Persons+ �� View 5G      �� 5H      .P�5I   "   �� $��序号��61    �� Width$ 60��6a    �� DisplayMemberBinding 6=   �� *Id+6a   �� 5J   "   $��名字��61   $ 80��6c    6=   �� *Name+6c   �� 5K   "   $��年龄��61   $ 70��6b    6=   �� *Age+6b   �� 5L   "   $��进化��61   $ 70��6=    �� CellTemplate 5M   &   �� 5N   *   .R�5O   .   ��  d� 	IsChecked 67   �� *IsEvolution+5P   +   5R   #   5S      5U      5V      5W      �� 5X      $��树状视图-TreeView��6   $��
10 0 10 10q�6.   $��1��6B   $��1��6O   .��5Y      �� $ 
Horizontal=�6   $��6q�66   .+�5Z      R� $	��200��6@   ��6   �� *
Catalogs+��5[      �� 5\       �� ItemsSource 67   �� *Items+.R�5]   "   �� ��6,   �� *Name+5^      5`      5a      5b      �� 5c      $��数据表格-DataGrid��6   $��	0 0 10 10q�6.   $��2��6A   $��0��6N   $��2��6^   .��5d      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6      CanUserAddRows$ False��67   $��5q�5e   ;   $	��200��6F      GridLinesVisibility$
 None=�6S     DefaultFontSize)   #XiaFControl.Controls.DataGridHelper   HeadFontSize# �  5f         HeadBackground# �  5g         HeadForeground# �  5h      ��5e      �� *	Persons+   Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ 序号��6-    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$ 60
 6P     XiaFDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   EditingElementStyle# [ 5k   -      Binding 5j   9   �� *Id+5k   -     5l      $ 姓名��6-   $ 70
 6R   # [ 5m   -    5l   9   �� *Name+5m   -     5n      $ 年龄��6-   $ 60
 6Q   # [ 5o   -    5n   9   �� *Age+5o   -   4  .System.Windows.Controls.DataGridCheckBoxColumn  5p      $ 进化��61   $ 60
 6]     XiaFDataGridCheckBoxColumn    ElementStyle#  [ 5q   1   # [ 5r   1    5p   =   �� *IsEvolution+5r   1   4  .System.Windows.Controls.DataGridComboBoxColumn  5s      $ 性别��61   $ 80
 5t   X    	 XiaFDataGridComboBoxColumn!   ElementStyle#! [	 5u   1   "   EditingElementStyle#" [	 5v   1   #   ItemsSource# 5s   =   �� $ �� Source#$ [  %   SelectedItemBinding% 5t   1   �� *Gender+5v   1   4  .System.Windows.Controls.DataGridTemplateColumn  5w      $ 操作��61   $ 80
 6=   &   CellTemplate& 5x      �� 5y   "   .R�5z   &   �� $ 
Horizontal=�61   .+�5{   *   �� .��5|   .     $ 
PencilLine=�6?   5}   +   �� 5~   *    
 AccentButton#��[
 61   .��5   .     $ DeleteBinLine=�6?   5�   +   5�   '   5�   #   5�      5�      5�      �� 5�      $��隔行换色-DataGrid��6   $��	0 0 10 10q�6.   $��3��6A   $��0��6N   $��2��6^   .��5�        $ False��6   $ False��67   ' �� AlternationCount$' 1��5�        AlternatingRowBackground(   AlternatingRowBackground#( �  5�      $��5q�5�   ;   $	��200��6F   $
 None=�6S   # �  5�      # �  5�      # �  5�      ��5�      �� *	Persons+ 5�        5�      $ 序号��6-   $ 60
 6P   # [ 5�   -    5�   9   �� *Id+5�   -     5�      $ 姓名��6-   $ 70
 6R   # [ 5�   -    5�   9   �� *Name+5�   -     5�      $ 年龄��6-   $ 60
 6Q   # [ 5�   -    5�   9   �� *Age+5�   -     5�      $ 进化��61   $ 60
 6]   #  [ 5�   1   # [ 5�   1    5�   =   �� *IsEvolution+5�   1     5�      $ 性别��61   $ 80
 5�   X   #! [	 5�   1   #" [	 5�   1   # 5�   =   �� #$ [  % 5�   1   �� *Gender+5�   1     5�      $ 操作��61   $ 80
 6=   & 5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� .��5�   .     $ 
PencilLine=�6?   5�   +   �� 5�   *   #��[
 61   .��5�   .     $ DeleteBinLine=�6?   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      