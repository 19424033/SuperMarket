   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5          SuperMarket.TonHang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SuperMarket     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� 
���   �$��1q�6)   ._�5      �� -   5        $��filterCanvas��5      .+�5      �� -   5        $��hintText��5        �� Padding$ 5q�60   $"��Tìm kiếm nhanh theo tên:��6<   $
��Left=�6\   
���   �$
��Bold"�6�   �� 5      -   5        $��keywordTextBox��5   �   $��30��5      
���   �$
��Bold"�6=   $��14(�6O   
������ $�� ��5   �   $��
3, 3, 0, 0q�6�   ��6W   ��  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�5      5      5      5      ]� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $��* �6'   .+�5      ]� $��0��6   .+�5       �� 
���   �$��1q�61   ._�5!      �� -   5        $��dataListLSP��5!   #    �� View 5"      �� 5#   "   .P�5$   &   �� $��Loại Sản Phẩm��65    �� DisplayMemberBinding 6L   �� *	TenLoaiSP+5%   #   5'      5(      5)      ]� 5*      $��1��6   .+�5+      �� 
���   �$��1q�61   ._�5,      �� -   5        $��dataTon��5,   #   $��Disabled=�62   $��Disabled=�5-   #    5.      �� 5/   "   .P�50   &   ��  �� Width$	 180��65   $��Loại Sản Phẩm��6A    6X   �� *	TenLoaiSP+�� 51   &   $	 200��65   $��Mặt Sản Phẩm��6A    6W   �� *TenSP+�� 52   &   $	 200��65   $��Giá mua��6A    6S   �� *	GiaMuaVao+�� 53   &   $	 200��65   $��Số lượng tồn��6A    6X   �� *	SoLuong+54   #   56      57      58      59      5:      5;      5<      