   M S B A M L   `   `   `  ����J  FXiaFControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:XiaFControlDemo.ViewsXiaFControlDemo.Views  5      /    )XiaFControlDemo.Views.MultiSelectComboBox   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:XiaFControlDemo.Views     5      .��5	      �� -   5          ��Name$  MultiSelectCombo��5
   	    J� SnapsToDevicePixels$
 True��5   	    � OverridesDefaultStyle$
 True��5   	   $
��Auto=�5   	   $
��Auto=�5   	   $
��True��5   	   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   	   ��5   
   �� 5      .R�5      �� -   5        ��5      �� *Title+ d� 	IsChecked 5      ��  �� Path$ 
IsSelected� �� Mode$ TwoWay=�
 � Tag 5      �� *FindAncestor+ �� AncestorType" ��5      5      ��5   
   �� 5      	 �� 
TargetType"	 ��6   .R�5      � .+�5      d� 
 d�Name$
 ToggleButton��5      $��2��5      $|�false��5        �� 	ClickMode$ Press=�5!      $
��Left=�6+    5   (   �� $ IsDropDownOpen�$ TwoWay=� �� RelativeSource �� *TemplatedParent+��5"      �� 5#      .R�5$   "   �  � ColumnDefinitions 5%   &   �� 5&   *   $��* �6;   �� 5'   *   $��18 �6;   .+�5)   &   ��  ��Name$ Border��5*      $��2��5+       �� CornerRadius$ 2��5,      
�������
���   �$��1,1,1,1q�5/      �� 50   &   $ 
BorderComp��51      $��0��52      $ 2��53      $��1q�54      
�������
���   �$��0,0,0,0q�57      ._�58   *   �� $����                                         {Binding Path=Text,RelativeSource=                                         {RelativeSource Mode=FindAncestor,                                          AncestorType=UserControl}}��64   
������� �� Padding$ 3q�5=   0   5>   '   F� 5?   &    F�Name$ Arrow��5@      $��1��5A      
���   �$��Center=�5C      $��Center=�5D      "����        � 	=  	= � z     	5E      5F   #   5G      5I      � 5J      $��Popup��5L       �� IsDropDownOpen#��z 5J      $��Slide=�5K      $��Bottom=�5M       � AllowsTransparency$
 True��5N       � ActualWidth#��z 6'    �� MaxDropDownHeight#��z 5O      $|�False��5P      .��5Q      � $��DropDown��5R      $
 True��5S      .+�5T      �� $ DropDownBorder��5U      $��1q�5V      
�������
���   �5W   "   �� 5X      $��4,6,4,6q�6+   $
 True��5Y       � DataContext 5Z      �� .��5[   "   ��  K� IsItemsHost$
 True��6-   -  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation$ 	Contained=�5\      5^      5_      5`      5a       �� Triggers 5b      P� 5c       P� Property �@��HasItems P� Value$ false��62   . �5d      ��  �� 
TargetName$ DropDownBorder��6!    �� Property � �� �� Value$ 95��5e      5f      P� 5g       P� 
SourceName$ Popup��6    �@�AllowsTransparency$
 true��5h   %   . �5i      �� $ DropDownBorder��6!    �@��CornerRadius$ 4��5j      �� 5k      $ DropDownBorder��6!    � ��$ 0,2,0,0q�5l      5m      5o      5q      5s      