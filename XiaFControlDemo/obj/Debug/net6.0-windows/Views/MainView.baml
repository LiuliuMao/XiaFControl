   M S B A M L   `   `   `  ����J  FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views  5   	   F BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls 5
   	   G(clr-namespace:XiaFControlDemo.ConvertersXiaFControlDemo.Converters  5      $    XiaFControlDemo.Views.MainView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^ ZICSharpCode.AvalonEdit, Version=6.3.0.90, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonEdit.http://icsharpcode.net/sharpdevelop/avalonedit  5   	   /local#clr-namespace:XiaFControlDemo.Views  5   	   IxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl  5
   	   8	converter(clr-namespace:XiaFControlDemo.Converters  5         
XiaFWindow#���   5        � WindowState$  	Maximized=�5	        DefaultForeground#���  5   *    � Title$ MainView��5   	   $	��680��6   $
��1120��6'    � Icon$% /Resources/Images/小女孩.ico��64    � 	Resources 5      :   4XiaFControlDemo.Converters.IsSelectedToIconConverter  IsSelectedToIcon��%   &	         5   
   6.   5      %  XiaFControl.Controls.XiaFWindow   TitleBarContent 5      � 5   
    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��22��5      $��22��6)   $
��10 0q�64   $��Center=�6B   ��5      �� *Icon+ �� RelativeSource ��  �� AncestorType" �5   B   �� 5        PrimaryForeground#��[ 63   ��6   �� *Title+63   �� 5      -   5        	 ��Name$	 version��5   -   $��5 0 0 0q�6   #���  6>   �� 5      $ 
Horizontal=�6   $��Center=�66   $��Center=�6Q   $��20 0 0 0q�6n   .+�5        XiaFControl.Controls.Icon  
   Type$
 QqFill=�6'     WhiteForeground#���  66   �� 5      $��群：��6    #���  6+   �� 5      $��	371769310��6    #���  62   $
��Bold"�6a   5       5!      �� 5"      $ 
Horizontal=�6   $��Right=�62   $��1��6N   .+�5#      o� '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome$
 True��6   #���  5$      .@�5%      m� ��5&      �� 5'      $ 
Horizontal=�6)   .+�5(   "   �� $��帮助��6,   ���#FFFFFF66     5)   "   $
 QuestionFill=�63   ���#FFFFFF$��5 0 0 0q�6\   5*      .@�5,      m� $��关于��6#    m� Command 6/   �� *AboutCommand+5-      5.      o� 5/      $
 True��6   #���  6D   .@�50      m� ��51      �� 52      $ 
Horizontal=�6)   .+�53   "   �� $��Language��6,   ���#FFFFFF6<     54   "   $
 CharacterRecognitionFill=�63   ���#FFFFFF$��5 0 0 0q�6h   55      .@�57      m� $��中文简体��6#    m� CommandParameter$ 中文简体��6U    61   �� *LanguageCommand+6U   m� 58      $��English��6#   $ English��6X    64   �� *LanguageCommand+6X   59      5:      5;      5<      .��5>      �  5?   
   �� 5@      $
��auto �6   �� 5A      .+�5C   
     XiaFControl.Controls.Card  $��20 20 10 20q�6      CornerRadius$ 8��60   .��5D      �� -   5         �� SelectedIndex$ 0��5D   a   $��20q�5E   F   (  "XiaFControl.Controls.ListBoxHelper   IsShowLittleBar$
 true��5F        Primary(  "XiaFControl.Controls.ControlHelper   FocusedBrush# �  5G         FocusedForegroundBrush# �  5H      ��5D      �� *	MenuItems+ �� SelectedItem 68   �� *CurrentMenuItem+��5I      �� 5J      .R�5K      �� $	��120��6%   $ 
Horizontal=�64   .+�5L        $��18��6E   $��18��6Q   
 6/   �� *Icon+6Q   �� 5M      $��Center=�6(   $	��8 5q�6�   $��CharacterEllipsis=�5N   ,   ��5M   E   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���5N   M   Z� 5O      5P      5R      5S        5T   
   $��1��6   $��
0 20 20 20q�6+   $ 8��6?   .��5U      �� -   5         ��Name$	 Tab��5U      .@�5V      �� $	��200��6   ��5W      �� 5X      $��14(�6J   ��6$   �� *CurrentMenuItem.Name+6J   .��5Z      �� $��20q�6%   $��Stretch=�6]   $��Stretch=�6{   ��61   �� *CurrentMenuItem.Content+6{   5[      �� 5\      $	��100��6   ��5]      �� 5^      $ 
Horizontal=�6%   $��0q�6>   .+�5_        $
 CodeSSlashFill=�6/   $��0 0 8 0q�6E   $��14(�6V   �� 5`      $
��Xaml��6(   $��14(�64   5a      .��5c      � .+�5d      '  !ICSharpCode.AvalonEdit.TextEditor  -   5          Name$ 
textEditor��5d   0      ShowLineNumbers$
 True��6D   $��Consolas)�6[   $
��10pt(�6q   "   VerticalScrollBarVisibility$
 Auto=�5e   0   $   HorizontalScrollBarVisibility$
 Auto=�6S     DefaultBackground#���  6x   #���  6�      Text. 6�   5f      5g      5h      5i      5k      +	  %XiaFControl.Controls.MessageContainer	  5m   
    	  
Identifier$ MessageContainer��6'   $��2��6E   .
  (XiaFControl.Controls.MessageBoxContainer
  5n   
    
  
Identifier$ DialogContaioner��6*   $��2��6H   $  XiaFControl.Controls.DialogBox  5o   
      
Identifier$ 
MainDialog��6       Title$ 主对话框��68   $��2��6E   5p      5q      