   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      *   $XiaFControlDemo.Views.TabControlDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $ ��默认选项卡-TabControl��6   $��0 0 0 10q�61   .��5      �   5      �� 5      $��* �6(   �� 5      $
��Auto �6(    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      ��  �� TabStripPlacement$	 Top=�5   !   $��0��69   $��1��6F   $	��170��6V   ��5   !   �� *
Poetries+ �� SelectedItem 6B   �� *SelectedPoetry+��5       �� 5!      .R�5"   "   �� ��6,   �� *Title+5#       �� ContentTemplate 5%      �� 5&      .R�5'   "   �� $��Center=�6E   ��6,   �� *	Content+6E   5(      5*      �� 5-      $ Bottom=�5.   !   $��1��6<   $��1��6I    
  Accent+   %XiaFControl.Controls.TabControlHelper   FocusedBrush# �   5/   !      IsClearable$
 True��50   !   ��5-   !   �� *
Poetries+ 6B   �� *SelectedPoetry+��51      �� 52      .R�53   "   �� ��6,   �� *Title+54       56      �� 57      58      5:      �� 5=      $
 Left=�5>   !   $��0��6:   $��0��6G   $��Center=�6W   ��5=   !   �� *
Poetries+ 6B   �� *SelectedPoetry+��5?      �� 5@      .R�5A   "   �� ��6,   �� *Title+5B       5D      �� 5E      5F      5H      �� 5K      $ Right=�5L   !   $��0��6;   $��2��6H   $��Center=�6X   ��5K   !   �� *
Poetries+ 6B   �� *SelectedPoetry+��5M      �� 5N      .R�5O   "   �� ��6,   �� *Title+5P       5R      �� 5S      5T      5V      5W      5X      �� 5Y      $ ��卡片选项卡-TabControl��6   $��0 0 0 10q�61   $��1��6C   .��5Z      �   5[      �� 5\      $��* �6(   �� 5]      $
��Auto �6(    5_      �� 5`      $
��Auto �6+   �� 5a      $��* �6+   �� 5b      $
��Auto �6+   .+�5f      �� $
 True��6B   $	 Top=�5g   !   $��0��69   $��1��6F   $	��170��6V   $��0 1 0 0q�6c     
BorderGray#���  6}     CardTabControl2#��[ 5h   !   ��5f   !   �� *
Poetries+��5i      �� 5j      .R�5k   "   �� ��6,   �� *Title+��6C   Z� 5l       5n      �� 5o      .R�5p   "   �� $��Center=�6E   ��6,   �� *	Content+6E   5q      5s      �� 5v      $
 True��6B   $ Bottom=�5w   !   $��1��6<   $��1��6I      FocusedForegroundBrush$ Yellow��5x   !   # �   5y   !     CardTabControl#��[ 6f   ��5v   !   �� *
Poetries+��5z      �� 5{      .R�5|   "   �� ��6,   �� *Title+��6C   Z� 5}       5      �� 5�      5�      5�      �� 5�      $
 Left=�5�   !   $��0��6:   $��0��6G   $��Center=�5�   !   #��[ 6<   ��5�   !   �� *
Poetries+��5�      �� 5�      .R�5�   "   �� ��6,   �� *Title+5�       5�      �� 5�      5�      5�      �� 5�      $ Right=�5�   !   $��0��6;   $��2��6H   $��Center=�5�   !   #��[ 6<   ��5�   !   �� *
Poetries+��5�      �� 5�      .R�5�   "   �� ��6,   �� *Title+5�       5�      �� 5�      5�      5�      5�      5�      5�      5�      5�      