   M S B A M L   `   `   `  ����  Eastman_Code_Challenge%    Eastman_Code_Challenge.winAbout   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � AllowsTransparency  . 
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � SizeToContent$ WidthAndHeight=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ About This Software��5   	    +� FocusedElement 5   	   ��  �� ElementName$ txtUserName�� � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   shadowEffect	   Color
   Opacity   ShadowDepth �� 
TargetType �� Property �� Value��%  &	        '�� G     '�� �     '�� 0    '�� �      5   
   $
	 Gray��5      $	
 .50Q�5      $ 10Q�5      �� 5   
   " ��6   .�5      ��  � ��$ 4q�5      5      �� 5   
   " ��6   .�5      ��  � ��$ 4q�5      �� 5       � ��$	 200��5      �� 5       � ��$
 Left=�5      5      �� 5   
   " ��6   .�5      ��  � ��$ 6q�5      �� 5        � ��$ 4q�5!      �� 5"       � ��$ 50��5#      5$      �� 5%   
   " ��6   6*   5&      .��5'      ��  �� CornerRadius$ 10��6   
�������$��3q�5)      
�������$��24q�5+       �� Padding$ 4q�5,       J� Effect# [  5-      ._�5.   
   �  � RowDefinitions 50      �� 51      �� 52      .+�55      �� $��0��6   .+�56      �� $
��6,12q�6   $#��Alan Eastman coding challenge��57      �� 58      $��4q�6   $��April 23, 2017��59      5:      �� 5;      $��2��6   $��3��5<      $��10q�5=      $��Center=�5>       �� Orientation$ 
Horizontal=�5?      .+�5@      �� -   5        $��btnClose��5@       �� 	IsDefault . $��Close��5B      # [  5C      5D      5E      5F      5G      5H      