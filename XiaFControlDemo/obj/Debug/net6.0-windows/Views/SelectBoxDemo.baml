   M S B A M L   `   `   `  ����J  FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views  5      F BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls 5      )    #XiaFControlDemo.Views.SelectBoxDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:XiaFControlDemo.Views     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      .��5      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��单选按钮-RadioButton��6   $��0 0 0 10q�61   .��5      ��  �� Orientation$ 
Horizontal=�6   $��10q�66   .+�5      	� -   5         	�Name$	 day��5   "    	� 	GroupName$ selete��6/   ��5      �� 5      $ 
Horizontal=�6)   .+�5   "     XiaFControl.Controls.Icon     Type$ SunFill=�63   �� 5   "   $��白天��6,   5      5      	� 5      -   5        $ night��5   "   $ selete��61   $
��10 0q�6D   ��5       �� 5!      $ 
Horizontal=�6)   .+�5"   "     $ MoonFill=�63   �� 5#   "   $��黑夜��6,   5$      5&      	� 5'      ${�False��6"   $ selete��64   .��6G   	不可用5)      	� 5*         
LightRadio#��[  6"   $
��10 0q�6F   $��亮色��6T   	� 5+        	DarkRadio#��[ 6"   $
��10 0q�6E   $��暗色��6S   	� 5,        AccentRadio#��[ 6"   $
��10 0q�6G   $��	强调色��6U   5-      5.      �� 5/      $��切换按钮-ToggleButton��6   $��0 0 0 10q�62   $��1��6D   .��50      �� .+�51      �� $ 
Horizontal=�6!   $��10q�6:   .+�52      d� $��默认��6'   $	��100��64    d� 	IsChecked$
 TrueY�6@   $
��10 0q�6Q   d� 53        LightToggleButton#���  6'   $��亮色��6S   $	��100��6`   $
��10 0q�6l   d� 54        DarkToggleButton#���  6'   $��暗色��6R   $	��100��6_   $
��10 0q�6k   d� 55        AccentToggleButton#���  6'   $��	强调色��6T   $	��100��6b   $
��10 0q�6n   56      �� 58      $ 
Horizontal=�6!   $��10q�6:   .+�59      d�   CircleMidToggleButton#���  6'   $��默认��6W   '  !XiaFControl.Controls.ButtonHelper   CircleDiameter$ 50Q�6d   $
��10 0q�6�   $
 TrueY�6�   d� 5:        CircleLightToggleButton#���  6'   $��亮色��6Y   $ 50Q�6f   $
��10 0q�6�   $
 TrueY�6�   d� 5;        CircleDarkToggleButton#���  6'   $��暗色��6X   $ 50Q�6e   $
��10 0q�6�   $
 TrueY�6�   d� 5<       	 CircleAccentToggleButton#��� 	 6'   $��强调��6Z   $ 50Q�6g   $
��10 0q�6�   $
 TrueY�6�   5=      �� 5>      $ 
Horizontal=�6!   $��10q�6:   .+�5?      d�  
 SwitchMidToggle#��� 
 6'   $
��10 0q�6Q   .��5@      �� $ 
Horizontal=�6)   .+�5A   "     $ WifiFill=�63   �� 5B   "   $
��Wifi��6,   5C      5D      d� 5E        SwitchLightToggle#���  6'   $
��10 0q�6S   $
 TrueY�6a   .��5F      �� $ 
Horizontal=�6)   .+�5G   "     $ BluetoothFill=�63   �� 5H   "   $��蓝牙��6,   5I      5J      d� 5K        SwitchDarkToggle#���  6'   $
��10 5q�6R   $	��NFC��6`   $
 TrueY�6n   d� 5L        SwitchAccentToggle#���  6'   $
��10 0q�6T   $��夜间模式��6b   $
 TrueY�6q   5M      5N      5O      �� 5P      $��多选框-CheckBox��6   $��0 0 0 10q�6-   $��2��6?   .��5Q      �  � ColumnDefinitions 5R      �� 5S      $
��Auto �6+   �� 5T      $
��Auto �6+   .+�5V      �� $��10q�6!   .+�5W      �� $��	选项一��6#   �� 5X      $��	选项二��6#   �� 5Y      $��	选项三��6#   �� 5Z      $��	未选择��6#    61   Z� �� 5[      $��	不可用��6#   ${�False��61   5\      �� 5]      $��20 10q�6!   $��1��60   .+�5^      �� $��默认��6#   $
 TrueY�60   $��25��6A   �� 5_        LightCheckBox#���  6#   $��亮色��6K   $
 TrueY�6X   �� 5`        DarkCheckBox#���  6#   $��暗色��6J   $
 TrueY�6W   �� 5a        AccentCheckBox#���  6#   $��	强调色��6L   $
 TrueY�6Z   5b      5c      5d      5e      5f      5g      