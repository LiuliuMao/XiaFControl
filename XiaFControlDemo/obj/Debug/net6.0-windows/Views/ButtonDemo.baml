   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5       XiaFControlDemo&    XiaFControlDemo.Views.ButtonDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kcontrol7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      .��5	      �� $
��Auto=�6   $
��Auto=�68   .��5
   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��普通按钮-Button��6   $��0 0 0 10q�6,   .��5      �  � Orientation$ 
Horizontal=�6   $��5q�65   $	��500��6@   $
��Left=�6L   .+�5      �� $	��100��6      DefaultButton#���   6)   $��5q�6Q   .��6\   普通按钮5      �� 5      -   5         ��Name$ button��5      $	��100��6-    � ToolTip$ hello��69   $��5q�6I   .��6T   默认按钮5      �� 5      $	��100��6     LightButton#���  6)   $��5q�6O   .��6Z   亮色按钮6`   �� 5      $	��100��6     
DarkButton#���  6)   $��5q�6N   .��6Y   暗色按钮6_   �� 5      $	��100��6     
InfoButton#���  6)   $��5q�6N   .��6Y   消息按钮6_   �� 5      $	��100��6     WaringButton#���  6)   $��5q�6P   .��6[   警告按钮6a   �� 5       $	��100��6     SuccessButton#���  6)   $��5q�6Q   .��6\   成功按钮6b   �� 5!      $	��100��6     ErrorButton#���  6)   $��5q�6O   .��6Z   错误按钮6`   5"      5#      �� 5$      $��圆角按钮-Button��6   $��0 0 0 10q�6,   $��1��6>   .��5%      ��  �� Orientation$ 
Horizontal=�6   $��5q�66   .+�5&      �� $	��100��6   (   "XiaFControl.Controls.ControlHelper   CornerRadius$ 14��6)   $��6q�6Q   .��6\   普通按钮6b   �� 5'      $	��100��6   #���  6)   $ 14��6O   $��6q�6w   .��6�   亮色按钮6�   �� 5(      $	��100��6   #���  6)   $ 14��6O   $��6q�6w   .��6�   暗色按钮6�   �� 5)      $	��100��6     AccentButton#���  6)   $ 14��6Q   $��6q�6y   .��6�   强调按钮6�   5*      5+      �� 5,      $��文字按钮-Button��6   $��0 0 0 10q�6,   $��2��6>   .��5-      �� $ 
Horizontal=�6   $��5q�66   .+�5.      �� $	��100��6     TextMidButton#���  6)   $��6q�6Q   .��6\   文字按钮6b   �� 5/      $	��100��6    	 TextLightButton#��� 	 6)   $��6q�6S   .��6^   文字按钮6d   �� 50      $	��100��6    
 TextDarkButton#��� 
 6)   $��6q�6R   .��6]   文字按钮6c   �� 51      $	��100��6     TextAccentButton#���  6)   $��6q�6T   .��6_   文字按钮6e   52      53      �� 54      $��圆型按钮-Button��6   $��0 0 0 10q�6,   $��3��6>   .��55      �� $ 
Horizontal=�6   $��5q�66   .+�56      �� '   !XiaFControl.Controls.ButtonHelper   CircleDiameter$ 30Q�6     Primary#���  6F      Shape$ Circle=�57   !   $
��10 0q�6E   .��58         XiaFControl.Controls.Icon     Type$ QqFill=�6'   59      �� 5:      $ 40Q�6    
 Accent#���  6F   $ Circle=�5;   !   $
��10 0q�6E   .��5<        $ 
WechatFill=�6'   $��30��69   $��30��6E   5=      �� 5>      $ 50Q�6    	 Light#���  6G   $ Circle=�5?   !   $
��10 0q�6E   .��5@        $ 	WeiboFill=�6'   $��40��68   $��40��6D   5A      �� 5B      $ 60Q�6     Dark#���  6F   $ Circle=�5C   !   $
��10 0q�6E   .��5D        $ 
GithubFill=�6'   $��50��69   $��50��6E   5E      5F      5G      �� 5H      $��图标按钮-Button��6   $��0 0 0 10q�6,   $��4��6>   .��5I      �� $ 
Horizontal=�6   $��5q�66   .+�5J      �� #���  6   .��5K        $ MinimizeLine=�6'   5L      �� 5M      #���  6   .��5N        $ MaximizeLine=�6'   5O      �� 5P      #���  6   .��5Q        $ RestoreLine=�6'   5R      �� 5S      #���  6   .��5T        $ 	CloseLine=�6'   5U      5V      5W      5X      5Y      5Z      