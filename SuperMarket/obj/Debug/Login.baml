   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5   	       SuperMarket.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:SuperMarket  5   	     � 
ResizeMode$  NoResize=�5	   	    � Title$ Login��5
   	   $	��400��6   $	��200��6$    � WindowStartupLocation$ CenterScreen=�61    � WindowStyle$
 None=�6V   ��5      �� 5   
    �� ImageSource$ Images/login.png��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� $��Images/supermarket.png��6   5      ]� 5   
   $��1��6   .+�5      �  � RowDefinitions 5      �� 5      $
��0.7* �6$   �� 5      $
��1.5* �6$   �� 5      $��* �6$   .+�5      ]� $��0��6   .+�5      �� -   5        $
��exit��5      $	��Top=�6V   $��Right=�6�   ��6)   Z� ��6?   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�62   
��� ���$��30��6S   $��30��6^   5       5!      ]� 5"      $��1��6   .+�5#      �  5$      �� 5%      $��* �6/   �� 5&      $��* �6/   .+�5(      ]� $��0��6$   $��Bottom=�64   .+�5)      ��  �� Orientation$ Vertical=�6)   .+�5*   "   �� $��Mã Nhân Viên��6,   $��Center=�6A   $
��0 15q�6^   $��15(�6l   $
��Bold"�6z   �� 5+   "   $��Password��6,   $��Center=�6<   $	��0 5q�6Y   $
��Bold"�6f   $��15(�6x   5,      5-      ]� 5.      $��1��6$   $��Bottom=�64   .+�5/      �� $ Vertical=�6)   .+�50   "   �� -   5        $��txtUser��50   =   $
��Bold"�6+   $��0 5 20 5q�6L   $��15(�6^   6l   G� 51   "   -   5        $��txtPass��51   @   $
��Bold"�6.   $��0 5 20 5q�6O   $��15(�6a   6o   52      53      54      55      ]� 56      $��2��6   .+�57      �� $ 
Horizontal=�6!   $��Center=�6:   $��15q�6U   .+�58      �� -   5        $��checkBP��58   9   $��Bàn Phím Ảo��6#   $
��Bold"�6H   
���   �6[   �� 59      -   5        $��login��59   !   ���	#FF70B7F0$��Login��6E   $
��15 0q�6i   $	��100��6w   	 �� 	IsDefault	 . 6�   5:      5;      5<      5=      5>      5?      