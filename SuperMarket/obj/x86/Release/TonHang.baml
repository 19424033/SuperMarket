   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.TonHang   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:SuperMarket     .���   � RowDefinitions  �� $��30 ��� $��* �.+�]� $��0��.+��� 
���   �$��1q�._��� -   $��filterCanvas��.+��� -   $��hintText�� �� Padding$ 5q�$"��Tìm kiếm nhanh theo tên:��$
��Left=�
���   �$
��Bold"��� -   $��keywordTextBox��$��30��
���   �$
��Bold"�$��14(�
������ $�� ��$��
3, 3, 0, 0q�����  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�]� $��1��.+��  � ColumnDefinitions �� $	��150 ��� $��* �.+�]� $��0��.+��� 
���   �$��1q�._��� -   $��dataListLSP�� �� View �� .P��� $��Loại Sản Phẩm�� �� DisplayMemberBinding �� *	TenLoaiSP+]� $��1��.+��� 
���   �$��1q�._��� -   $��dataTon��$��Disabled=�$��Disabled=� �� .P���  �� Width$	 180��$��Loại Sản Phẩm�� �� *	TenLoaiSP+�� $	 200��$��Mặt Sản Phẩm�� �� *TenSP+�� $	 200��$��Giá mua�� �� *	GiaMuaVao+�� $	 200��$��Số lượng tồn�� �� *	SoLuong+