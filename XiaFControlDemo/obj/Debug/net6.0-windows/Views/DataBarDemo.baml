   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      '   !XiaFControlDemo.Views.DataBarDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Kcontrol7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��进度条-ProgressBar��6   $��0 0 0 10q�60   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��Center=�6%   .+�5      �  � Value$ 70Q�6*   $	��150��65   $��5q�6A   ,   &XiaFControl.Controls.ProgressBarHelper   	Thickness$ 5Q�5   1      IsShowPercent$
 True��5   1   � 5      $	��150��6*   $��10q�66    � IsIndeterminate$
 True��6B   $ 5Q�5   1   5      � 5      $ 70Q�6&   $	��150��61    � Orientation$ Vertical=�6>   $��10q�6U   $ 5Q�5   "   $
 True��5    "   � 5!      $��5��6&   $	��150��60   $ Vertical=�6=   $��10q�6T   $
 True��6`   $ 5Q�5"   "   � 5#         CircularProgressBar#��[  6&     Primary#���  6S   $��40��6z   $��40��6�   $
 True��6�   56      57      58      �� 59      $��滑块-Slider��6   $��1��6*   .��5:      �� $ 
Horizontal=�6   .+�5<      �� $	��500��6!   $��10q�6-   .+�5=      �� $ 30Q�6!    � Minimum$ 0Q�6,    � Maximum$	 100Q�68   	 �� TickFrequency$	 5Q�6F   
 �� IsSelectionRangeEnabled$

 True��6X    �� TickPlacement$
 Both=�5>      $
��0 10q�6.    �� IsSnapToTickEnabled$
 True��6<   �� 5?      $ 80Q�6!   $ 0Q�6,   $	 100Q�68   $	 5Q�6F   $

 True��6X   $ TopLeft=�5@      $
��0 10q�61     Dark#���  6?   �� 5A      $ 50Q�6!   $ 0Q�6,   $	 100Q�68   $	 5Q�6F   $

 True��6X   $ BottomRight=�5B      $
��0 10q�65    
 Accent#���  6C   5C      �� 5E      $ 
Horizontal=�6!   $��20 0 0 0q�6:   .+�5F      �� $ 20Q�6!   $ 0Q�6,   $	 100Q�68   $	 20Q�6F   $

 True��6Y    �� Orientation$ Vertical=�5G      $	��120��60   $
��10 0q�6=    	 Light#���  6K   �� 5H      $ 60Q�6!   $ 0Q�6,   $	 100Q�68   $	 20Q�6F   $

 True��6Y   $ Vertical=�5I      $	��120��60   $
 Both=�6=   $
��10 0q�6R   �� 5J      $ 40Q�6!   $ 0Q�6,   $	 100Q�68   $	 20Q�6F   $

 True��6Y   $ Vertical=�5K      $	��120��60   $ TopLeft=�6=   $
��10 0q�6U   #���  6c   �� 5L      $ 80Q�6!   $ 0Q�6,   $	 100Q�68   $	 20Q�6F   $

 True��6Y   $ Vertical=�5M      $	��120��60   $ BottomRight=�6=   $
��10 0q�6Y   #���  6g   5N      5O      5P      �� 5Q      $��加载按钮��6   $��2��6%   .��5R      �� $��5q�6   $ 
Horizontal=�6(   .+�5S      �� -   5         ��Name$ loadingButton��5S      $	��100��5T   !   $
��10 0q�5U   !   '   !XiaFControl.Controls.ButtonHelper   Loading$ False��5V   !      LoadingContent$ 	加载中��5W   !   $��点我��5Y   !   �� 5Z        AccentButton#���  6   $
��10 0q�5[   !   $	��100��60   $
 True��5\   !   $ 强调按钮��5]   !      Shape$ Round=�5^   !   $��强调按钮��5_   !   �� 5`      $
��10 0q�6   $	��100��6+     
InfoButton#��[ 67   $
 True��5a   !   $ Circle=�5b   !   �� 5c        TextDarkButton#��[ 6   $
��10 0q�5d   !   $	��120��60   $
 True��5e   !   $ Circle=�5f   !   5g      5h      5i      5j      5k      