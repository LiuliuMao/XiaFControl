   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      +   %XiaFControlDemo.Views.MessageInfoDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68      XiaFSmallScrollViewer#��[  5      .��5   
   � .+�5      �� $��消息-Message��6   $��0 0 0 10q�6+   .��5      � .+�5      �� $��5q�6!   .+�5      ��   �� Orientation$  
Horizontal=�6%   .+�5      �� $��全局弹出��6(   $	��100��64   $��10q�6@   $��Center=�6L   �� 5      $��指定容器弹出��6(   $	��100��66   $��10q�6B   $��Center=�6N   5      �� 5      $  
Horizontal=�6%   .+�5      �� -   5         ��Name$ 
MessageBtn��5   %   $��基础消息��69   $	��100��6H   $��10q�6T     LightButton#��[ 5   !   6F   �� 5      -   5        $ MessageContainerBtn��5   %   $��基础消息��6B   $	��100��6Q   $��10q�6]   #��[ 5   !   6F   &    XiaFControl.Controls.MessageCard  5      $��message��66      IsClearable$
 True��6H   5      �� 5      $  
Horizontal=�6%   .+�5      �� -   5        $ InfoBtn��5   %   $��提示消息��66   $	��100��6E   $��10q�6Q     	InfoBrush#��[ 5   !   6I   �� 5      -   5        $ InfoContainerBtn��5   %   $��提示消息��6?   $	��100��6N   $��10q�6Z   #��[ 5   !   6I     5       $
��info��66     InfoMessage#��[ 6E   $
 True��6j   5!      �� 5"      $  
Horizontal=�6%   .+�5#      �� -   5        $ 	WaringBtn��5#   %   $��警告消息��68   $	��100��6G   $��10q�6S     WarningBrush#��[ 5$   !   6L   �� 5%      -   5        $ WaringContainerBtn��5%   %   $��警告消息��6A   $	��100��6P   $��10q�6\   #��[ 5&   !   6L     5'      $��warning��66     WarningMessage#��[ 6H   $
 True��6p   5(      �� 5)      $  
Horizontal=�6%   .+�5*      �� -   5        $ 
SuccessBtn��5*   %   $��成功消息��69   $	��100��6H   $��10q�6T     SuccessBrush#��[ 5+   !   6L   �� 5,      -   5        $ SuccessContainerBtn��5,   %   $��成功消息��6B   $	��100��6Q   $��10q�6]   #��[ 5-   !   6L     5.      $��success��66     SuccessMessage#��[ 6H   $
 True��6p   5/      �� 50      $  
Horizontal=�6%   .+�51      �� -	   5        $ ErrorBtn��51   %   $��错误消息��67   $	��100��6F   $��10q�6R     
ErrorBrush#��[ 52   !   6J   �� 53      -
   5        $ ErrorContaionBtn��53   %   $��错误消息��6?   $	��100��6N   $��10q�6Z   #��[ 54   !   6J     55      $��error��66    	 ErrorMessage#��[	 6F   $
 True��6l   56      �� 57      $  
Horizontal=�6%   .+�58      �� -   5        $ 
ControlBtn��58   %   $��	自定义��69   $	��100��6G   $��10q�6S   6_   �� 59      -   5        $ ControlContaionBtn��59   %   $��	自定义��6A   $	��100��6O   $��10q�6[   6g     5:      $
 True��66   .��5;   "   �� -   5         ��Name$ CustomContent��5;   8   $��5q�6-   .+�5<   &   ��  
 Head4TextBlock#��[
 60   $��标题��6X   �� 5=   &   $��自定义控件内容��60   5>   #   5?      5@      5A      5B      5C      5D      5E      5F      