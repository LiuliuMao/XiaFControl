   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.2.1.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5   
   J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5   	   G(clr-namespace:XiaFControlDemo.ViewModelsXiaFControlDemo.ViewModels 6;   G(clr-namespace:XiaFControlDemo.ConvertersXiaFControlDemo.Converters 5      &    XiaFControlDemo.Views.TestWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5   
   5local#clr-namespace:XiaFControlDemo.Views     5   	   ?
viewmodels(clr-namespace:XiaFControlDemo.ViewModels     6;   >	converter(clr-namespace:XiaFControlDemo.Converters     5      $	��660��5
   	   $
��1050��6      DefaultForeground#���   5   	     
XiaFWindow#���  5        � WindowStyle$
  None=�5       � AllowsTransparency$
 True��5       � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      :  4XiaFControlDemo.Converters.IsSelectedToIconConverter  IsSelectedToIcon��%   &	         5   
   6.   5      %   XiaFControl.Controls.XiaFWindow   TitleBarContent 5      � 5   
    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��22��5      $��22��6)   $
��10 0q�64   $��Center=�6B   ��5      �� *Icon+ �� RelativeSource ��  �� AncestorType" �5   B   �� 5        PrimaryForeground#��[ 63   ��6   �� *Title+63   5      �� 5       $��1��6   '  !System.Windows.Shell.WindowChrome	   IsHitTestVisibleInChrome$
	 True��6)   $��Right=�6V   $ 
Horizontal=�6r   .+�5!      �� $��亮色��6   �� 5"      $��暗色��6   5#      5$      .��5&      �   BodyBackground#���  6   .+�5'   
   �� $��Center=�6   .+�5(      �� -   5        $��亮色��5(      6"   �� 5)      -   5        $��暗色��5)      6"   5*      5+      5,      