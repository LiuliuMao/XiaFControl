   M S B A M L   `   `   `  ����F  BXiaFControl, Version=2.1.3.0, Culture=neutral, PublicKeyToken=nullP7clr-namespace:XiaFControl.Controls;assembly=XiaFControlXiaFControl.Controls  5      J FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views 5      '   !XiaFControlDemo.Views.MenuBarDemo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      OxiaFControl7clr-namespace:XiaFControl.Controls;assembly=XiaFControl     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5
      �� $
��Auto=�6   $
��Auto=�68      XiaFSmallScrollViewer#��[  5      .��5   
   �   � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Menu-菜单��6   $��0 0 0 10q�6(   .��5      �� $��5q�6   .+�5      o� .@�5      m� $��文件��6#   .@�5      m� $��新建��6'   .@�5   "   m� $��文件��6+    m� InputGestureText$ Ctrl+N��68   m� 5   "   $��项目��6+   5      m� 5      $��打开��6'   5      m� 5      $��编辑��6#   .@�5      m� $��查找和替换��6'    m� IsCheckable$
 True��66    m� 	IsChecked$
 True��6I   �� 5      m� 5       $��剪切��6'    m� Command$	 Cut��63    m� Icon 5!   "      XiaFControl.Controls.Icon  5"   &      Type$ Scissors2Line=�67   5$      m� 5%      $��复制��6'   $
 Copy��63    5&   "     5'   &   $ FileCopyLine=�67   5)      m� 5*      $��粘贴��6'   $ Paste��63    5+   "     5,   &   $ 
SurveyLine=�67   5.      5/      �� 50      m� 51      $��视图��6#   .@�52      m� $��	工具栏��6'   .@�53   "   m� $��文本编辑器��6+   $
 True��6:   $
 True��6M   m� 54   "   $��查看设计器��6+   $
 true��6:   m� 55   "   $��布局��6+   $
 true��67   $
 True��6J   m� 56   "   $��调试��6+   $
 true��67   57      58      59      �� 5:        
BigTextBox#��[ 6   $��75��6B   $
��0 10q�6N   $4��.这是一段测试文字,右击调出菜单。��6\   .��6t    � ContextMenu 5;      �� 5<        DefaultBackground#���  6*   .@�5=   "   m� $
 Copy��6+   m� 5>   "   $	 Cut��6+   m� 5?   "   $ Paste��6+   5@      .��5A   /   5B      5C      5D      �� 5F      $��ToolBar-工具栏��6   $��0 0 0 10q�6,   $��1��6>   .��5G      �� $��5q�6   .+�5H      `� .�5I      c� .@�5J      ��  � ToolTip$ 向后导航(Ctrl+-)��6%     Primary#���  6<   .��5K   "     $ ArrowLeftCircleFill=�63   5L      �� 5M      $  向前导航(Ctrl+Shift+-)��6%   #���  6B   .��5N   "     $ ArrowRightCircleFill=�63   5O      �� 5P      $  新建项目(Ctrl+Shift+N)��6%   .��5Q   "     $ FileAddFill=�63   5R      �� 5S      $ 打开文件(Ctrl+O)��6%   ���#FB8C00.��5T   "     $ FolderOpenFill=�63   5U      �� 5V      $ 保存(Ctrl+S)��6%   #���  6:   .��5W   "     $ 	Save2Fill=�63   5X      5Y      c� 5Z        Dark#���  6#   .@�5[      	� -   5        	 	� 	GroupName$	 Align��5[   *   

 � Tag$

 left��6Z   .��5\   "     $ 	AlignLeft=�63   5]      	� 5^      -   5        $	 Align��5^   *   $
 center��6Z   .��5_   "     $ AlignCenter=�63   5`      	� 5a      -   5        $	 Align��5a   *   $
 right��6Z   .��5b   "     $ 
AlignRight=�63   5c      5d      c� 5e      .@�5f      d� -   5         d�Name$ ItalicToggle��5f   +    d� 	IsChecked$ FalseY�6A   .��5g   "     $ Italic=�63   5h      d� 5i      -   5        $ UnderlineToggle��5i   +   $ FalseY�6D   .��5j   "     $ 	Underline=�63   5k      d� 5l      -   5        $ 
BoldToggle��5l   +   $ FalseY�6?   .��5m   "     $
 Bold=�63   5n      5o      c� 5p      .@�5q      �� $	��150��6&   (   "XiaFControl.Controls.TextBoxHelper   Placeholder$ 搜索��62      IsClearable$
 True��6]   .��6�      
PreContent 5r   "     5s   &   $ 
SearchLine=�67   .��5t   H   5u      5v      5w      �� 5x      -   5         ��Name$ TestText��5x      #��[ 60   $��75��6T   $
��0 10q�6`   $3��-这是一段测试文字，右击调出菜单��6n   .��6�    5y      �� 5z      #���  6*   .@�5{   "   m� $
 Copy��6+   m� 5|   "   $	 Cut��6+   m� 5}   "   $ Paste��6+   �� 5~   "   m� 5   "   $��斜体��6+   $
 True��67    6J   �� *
IsItalic+m� 5�   "   $��	下划线��6+   $
 True��68    6K   �� *IsUnderline+m� 5�   "   $��加粗��6+   $
 True��67    6J   �� *IsBold+5�      .��5�   /   5�      5�      5�      �� 5�      $��StatusBar-状态栏��6   $��0 0 0 10q�6.   $��2��6@   .��5�      �� #���  6     PrimaryForeground#��[ 6C   .@�5�      �� $
��Left=�6$   .��5�        $ TerminalBoxLine=�6+   5�      �� 5�      $��就绪��6$   $
��Left=�61   �� 5�      $��Right=�6$   .��5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�        $ 
UploadLine=�6/   $	��5 0q�6A   �� 5�      $��添加到源代码管理��6(   $	��5 0q�68     5�      $ Notification3Fill=�6/   $	��5 0q�6H   5�      5�      5�      5�      5�      5�      5�      