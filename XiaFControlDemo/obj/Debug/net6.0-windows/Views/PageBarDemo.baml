   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      '   !XiaFControlDemo.Views.PageBarDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68      XiaFSmallScrollViewer#��[  5      .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��页码条-PageBar��6   $��0 0 0 10q�6,   .��5      �� $	��650��6   .+�5      �� $��Center=�6@   $��10q�6]   ��6    �� *PageBarMessage+6]   "   XiaFControl.Controls.PageBar  5      -   5        $��10q�5   `     DefaultBackground#���  5   %     DefaultForeground#���  5   %    	 Light   CurrentBackground# �  5   %     LightForeground   CurrentForeground# �  5    %      Total 5   *   �� *Total+   PageSize 6B   �� *
PageSize+   PageIndexChangedCommand 5   %   �� *PageIndexChanged+   PageSizeChangedCommand 5   %   �� *PageSizeChanged+5    %     5!      -   5           	PageIndex$ 3��5!   `      IsShowPageSize$
 True��5"   %   $��10q�6<   #���  5%   %   #���  5&   %     Primary# �  5'   %     PrimaryForeground# �  5(   %    5!   *   �� *Total+ 6B   �� *
PageSize+ 5#   %   �� *PageIndexChanged+ 5$   %   �� *PageSizeChanged+5*   %     5+      -   5        $ 5��5+   `   	   IsShowTotal$
	 True��5,   %   $��10q�68   #���  51   %   #���  52   %    
 Accent# �  53   %     AccentForeground# �  54   %    5+   *   �� *Total+ 6B   �� *
PageSize+ 5-   %   �� *PageIndexChanged+ 5.   %   �� *PageSizeChanged+54   %     55      -   5        $ 7��55   `   $
 True��56   %   $
	 True��6;   $��10q�6N   #���  59   %   #���  5:   %    55   *   �� *Total+ 6B   �� *
PageSize+ 57   %   �� *PageIndexChanged+ 58   %   �� *PageSizeChanged+5<   %     5=       	 TextPageBarItem#��[	 6*   #���  5?   %   # �  5@   %   $ 7��5A   %   $
 True��63   $
	 True��6I   $��10q�6\    5>   %   �� *Total+ 6=   �� *
PageSize+ 5B   %   �� *PageIndexChanged+ 5C   %   �� *PageSizeChanged+5D      5F      5G      5H      5I      