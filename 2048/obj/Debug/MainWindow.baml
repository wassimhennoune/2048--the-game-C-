   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   ? ;2048, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_2048_2048 5   	      _2048.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   NControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:_2048     5   	   -   5          � Title$  
MainWindow��5	   	   $��526.41��6   $��402.333��6,      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   6=    � WindowStartupLocation$ CenterScreen=�5       � 	Resources 5        BoolToVisConverter��%   &	       �� 5   
   6'   5      .��5      � $��0q�6   .+�5   
   � -   5         �Name$ ws��5      $	��400��6   $	��400��6(   $
��Left=�64   $��	0,100,0,0q�6O   $	��Top=�6b    J� RenderTransformOrigin$	 0,0&�6z    � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $	��100 �6#   �� 5      $	��100 �6#   �� 5      $	��100 �6#    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $	��100 �6    �� 5      $	��100 �6    �� 5      $	��100 �6    5      �� 5    
   -   5         ��Name$ button_Copy��5       $��New Game��6&   $��247,4,18,460q�69   $��Roboto)�6Z   $��16(�6n   
����������	#FF7674746�   � 5!   
   -   5        $ ws_Copy��5!      $	��400��6    $	��400��6-   $
��Left=�69   $��	0,100,0,0q�6T   $	��Top=�6g   $	 0,0&�6   .+�5"      � -   5        $ ws_Copy1��5"      $	��500��6%   $	��400��62   $
��Left=�6>   $��
0,0,0,-100q�6Y   $	��Top=�6m   $	 0,0&�6�   
�������	 J� Opacity$		 0.5Q�6�   �� 5$      -   5        $ button��5$      $��Play Again ��6%   $��138,182,136,167q�6;   $��Roboto)�6_   $��20(�6s   
����������	#FF7674746�   5%      �� 5&   
   -   5        
 ��Name$
 label��5&      $��Score :��6   $
��Left=�61   $��	10,16,0,0q�6L   $	��Top=�6_   $��92��5'   ^   $��Roboto)�6i   $��16(�6}   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   $��Medium"�6�   ���	#FF686767y�6
   �� *BorderVisible+ �� 	Converter# [ 6�   �� 5(   
   -   5        $
 score_l��5(      $�� ��6!   $
��Left=�6,   $��
140,17,0,0q�6G   $	��Top=�6[   $��94��6s   $��Roboto)�6~   $��16(�6�   $ Display=�6�   $��Medium"�6�   ���	#FF6867676�   �� 5)   
   -	   5        $
 	b_score_l��5)      $�� ��6#   $
��Left=�6.   $��
140,47,0,0q�6I   $	��Top=�6]   $��94��6u   $��Roboto)�6�   $��16(�6�   $ Display=�6�   $��Medium"�6�   ���	#FF6867676�   �� 5*   
   -
   5        $ backb��5*        MetroCircleButtonStyle#���  6    $�� ��6Q   $
��Left=�6\   $��
307,45,0,0q�6w   $	��Top=�6�   $��50��6�   $��50��6�   $��3,1,1,1q�6�   ��5+      �� 5,       �� ImageSource$ refresh.png��6   5.      �� 5/   
   -   5        $
 
label_Copy��5/      $��Best Score :��6$   $
��Left=�6;   $��	10,47,0,0q�6V   $	��Top=�6i   $	��125��50   ^   $��Roboto)�6j   $��16(�6~   $ Display=�6�   $��Medium"�6�   ���	#FF686767y�6
   �� *BorderVisible+# [ 6�   �� 51   
   -   5        $
 label_Copy1��51      $��undo ��6%   $
��Left=�65   $��
259,44,0,0q�6P   $	��Top=�6d   $��50��52   ^   $��Roboto)�6i   $��16(�6}   $ Display=�6�   $��Medium"�6�   ���	#FF686767$ 0.5,0.5&�6�   y�6
   �� *BorderVisible+# [ z�53      V� 54      .~�55      �� �� 56      �� 57       �� Angle$ -0.509Q�6&   T� 58      59      5;      �� 5<   
   -   5        $
 nb��5<      $��undo ��6   $
��Left=�6,   $��
260,65,0,0q�6G   $	��Top=�6[   $��42��5=   ^   $��Roboto)�6i   $��16(�6}   $ Display=�6�   $��Medium"�6�   ���	#FF686767y�6
   �� *BorderVisible+# [ 6�   5?      5@      