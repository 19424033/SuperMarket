   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.Kho   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:SuperMarket     .���   � RowDefinitions  �� $��50 ��� $��30 ��� $��* ��� $��40 �.+�]� $��0��
�������.+��� $
��Bold"�$��Quản Lý Kho Hàng��$��Center=�$��Center=�$��24(�]� $��1��.+��� -   $��filterCanvas��.+��� -   $��hintText�� �� Padding$ 5q�$"��Tìm kiếm nhanh theo tên:��$
��Left=�
���   �$
��Bold"��� -   $��keywordTextBox��$��30��
���   �$
��Bold"�$��14(�
������ $�� ��$��
3, 3, 0, 0q�����  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�]� $��2��.+��  � ColumnDefinitions �� $	��150 ��� $��* �.+�]� $��0��.+��� 
���   �$��1q�._��� -   $��dataListLSP�� �� View �� .P��� $��Loại Sản Phẩm�� �� DisplayMemberBinding �� *	TenLoaiSP+]� $��1��.+��� 
���   �$��1q�._��� -   $��dataTon��$��Disabled=�$��Disabled=� �� .P���  �� Width$	 180��$��Loại Sản Phẩm�� �� *	TenLoaiSP+�� $	 180��$��Mặt Sản Phẩm�� �� *TenSP+�� $	 150��$��Giá mua�� �� *	GiaMuaVao+�� $	 100��$��Số lượng�� �� *	SoLuong+�� $	 150��$��Số lượng kiểm kê�� �� *SLKK+�� $!��Số lượng chênh lệch�� �� *SLCL+��  �� Orientation$ 
Horizontal=�$
��1080��$��3��   WarningBrush#��[  .+��� -   $��btnNhap��$��Nhập Hàng��$��	650 0 0 0q�$	��160���� -   $��
btnCapNhat��$ ��Cập Nhật Số Lượng��$
��50 0q�$	��160��