   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.NhapHang   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  %localclr-namespace:SuperMarket    � Title$  Nhập Hàng��$	��500��$
��1080�� � WindowStartupLocation$ CenterScreen=�.��]� .+���  �� Orientation$ 
Horizontal=�$
��1080��$��Bottom=�$��35��   WarningBrush#��[  .+��� $��Tổng Tiền : ��$��Center=�
�������$
��Bold"�$��	650 0 0 0q�$��15(��� -   $��TTien��$	��0đ��$��Center=�
�������$
��Bold"�$��30 0 0 0q�$��15(��� -    ��Name$	 mua��$��Nhập Hàng��$	��130��$��
30, 0, 0 0q��� 
���   �$��1q�._��� -   $��	LVMaPhieu�� �� View �� .P���  �� Width$	 130��$��Mã Phiếu Nhập�� �� DisplayMemberBinding �� *MaPhieuNhapHang+�� 
���   �$��1q�._��� -   $��orderListView�� �� .P��� $	 100��$��Số Thứ Tự�� �� *STT+�� $	 150��$��Mã sản phẩm�� �� *MaSP+�� $	 230��$��Tên sản phẩm�� �� *TenSP+�� $	 150��$��Số lượng�� �� *	SoLuong+�� $	 150��$��
Đơn Giá�� �� *DonGia+�� $��Thành Tiền�� �� *	ThanhTien+