   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      (   "XiaFControlDemo.Views.InputBoxDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68   .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��基础文本框-TextBox��6   $��0 0 0 10q�6.   $��0��6@   $��2��6M   .��5      ��  �� Orientation$ 
Horizontal=�6   $��Stretch=�66   $��5q�6T   .+�5      �� $	��150��6   (   "XiaFControl.Controls.TextBoxHelper   Placeholder$ 默认��6*   �� 5      $	��150��6      LightTextBox#���   6*   $
��10 0q�6Q   $ 亮色��6_   �� 5      $	��150��6     DarkTextBox#���  6*   $
��10 0q�6P   $ 暗色��6^   �� 5      $	��150��6     AccentTextBox#���  6*   $
��10 0q�6R   $ 	强调色��6`   5      5      �� 5      $&�� 带清除按钮文本框-TextBox��6   $��0 0 0 10q�61   $��1��6C   .��5       �� $ 
Horizontal=�6   $��Stretch=�66   $��5q�6T   .+�5!      �� #���  6   $	��150��6F      IsClearable$
 True��6R   $ 	可清除��5"      5#      5$      �� 5%      $��大文本框-TextBox��6   $��1��6-   $��1��6:   $��	10 0 0 10q�6J   .��5&      �� $
��Auto��6   $��50��6'     
BigTextBox#��[ 63   $ 大文本框��5'      5(      �� 5)      $#��验证错误文本框-TextBox��6   $��0��60   $��2��6@   $��	0 0 10 10q�6M   .��5*      �� $��55��6   $	��150��6$   $ 绑定了 int 类型��5+      $
��Left=�6I   $
��5 10q�6d   5,      �� 5-      $,��&带提示文本框-TextBox-PasswordBox��6   $��0 0 0 10q�6;   $��2��6M   $��1��6Z   .��5.      �� $ 
Horizontal=�6   $��Stretch=�66   $��5q�6T   .+�5/      �� $	��150��6   $ 账号��6*   .��6U      
PreContent 50         XiaFControl.Controls.Icon  51         Type$ UserFill=�6/   .��52   @   53      G� 54      $	��150��6"   $ 密码��6.   $
��10 0q�6Y   )   #XiaFControl.Controls.PasswordHelper   ShowSwitchButton True55   "      Password$ xiafcontrol��56   "    57        58      $ LockPasswordFill=�6/   5:      5;      5<      �� 5?      $)��#前置后置内容文本框-TextBox��6   $��0 0 0 10q�62   $��3��6D   $��2��6Q   .��5@      �� $ 
Horizontal=�6   $��Stretch=�66   $��5q�6T   .+�5A      �� $	��150��6   .��6*    5B        5C      $ QqFill=�6/   .��5D   @   5E      �� 5F      $	��200��6   $
��10 0q�6*   $ http://��68   	   PostContent$
	 .com��6g   �� 5G      $	��150��6   .��6*   	 5H      �� 5I        TextMidButton#��[ 6%   $��26��6L   .��5J   "     $ RefreshLine=�63   5K      .��5L   A   5M      5N      5O      5P      5Q      5R      