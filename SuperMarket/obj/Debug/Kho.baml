   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5          SuperMarket.Kho   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SuperMarket     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   ]� $��0��6   
�������.+�5      �� $
��Bold"�6   $��Quản Lý Kho Hàng��6*   $��Center=�6B   $��Center=�6_   $��24(�6z   5      ]� 5   
   $��1��6   .+�5      �� -   5        $��filterCanvas��5      .+�5      �� -   5        $��hintText��5       �� Padding$ 5q�6,   $"��Tìm kiếm nhanh theo tên:��68   $
��Left=�6X   
���   �$
��Bold"�6�   �� 5      -   5        $��keywordTextBox��5   �   $��30��5      
���   �$
��Bold"�69   $��14(�6K   
������ $�� ��5   �   $��
3, 3, 0, 0q�6�   ��6W   ��  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�5      5      5      ]� 5   
   $��2��6   .+�5      �  � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5       $��* �6'   .+�5"      ]� $��0��6   .+�5#      �� 
���   �$��1q�61   ._�5$      �� -   5        $��dataListLSP��5$   #    �� View 5%      �� 5&   "   .P�5'   &   �� $��Loại Sản Phẩm��65    �� DisplayMemberBinding 6L   �� *	TenLoaiSP+5(   #   5*      5+      5,      ]� 5-      $��1��6   .+�5.      �� 
���   �$��1q�61   ._�5/      �� -   5        $��dataTon��5/   #   $��Disabled=�6_   $��Disabled=�50   #    51      �� 52   "   .P�53   &   ��  �� Width$	 180��65   $��Loại Sản Phẩm��6A    6X   �� *	TenLoaiSP+�� 54   &   $	 180��65   $��Mặt Sản Phẩm��6A    6W   �� *TenSP+�� 55   &   $	 150��65   $��Giá mua��6A    6S   �� *	GiaMuaVao+�� 56   &   $	 100��65   $��Số lượng��6A    6T   �� *	SoLuong+�� 57   &   $	 150��65   $��Số lượng kiểm kê��6A    6[   �� *SLKK+�� 58   &   $!��Số lượng chênh lệch��65    6R   �� *SLCL+59   #   5;      5<      5=      5>      5?      �� 5@   
    �� Orientation$ 
Horizontal=�6   $
��1080��5A      $��3��5B         WarningBrush#��[  5C      .+�5D      �� -   5        $��btnNhap��5D      $��Nhập Hàng��6$   $��	650 0 0 0q�68   $	��160��6a   �� 5E      -   5        $��
btnCapNhat��5E      $ ��Cập Nhật Số Lượng��6'   $
��50 0q�6C   $	��160��6Q   6]   5F      5G      5H      