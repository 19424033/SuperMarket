   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  !    SuperMarket.TaoPhieuNhapKho   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  %localclr-namespace:SuperMarket  .���   � RowDefinitions  �� $��3* ��� $��8* ��� $��* �.+�]� $��0��.+��  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* �.+�]� $��0��.+��� $��45��$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Right=�$��Center=�.+��� $��Center=�
���   �$
��Bold"�$��Nhà Cung Cấp: ��$
��0 10q��� -   $��txtMaNCC��$��Center=�
���   �$
��Bold"�$	��100��$
��0 10q��� -   $��btnNCC��$��Center=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=����	#FFED1D1D�� $��45��$��Bottom=�.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��10 0q�.+��� 
���   �$
��Bold"�$��Tên Nhà C.Cấp: ��$
��0 10q��� -   $��	txtTenNCC��
���   �$��Center=�$
��Bold"�$	��140��$
��5 10q�{�.  ]� $��1��.+��� $��45��$	��Top=�.+��� $ 
Horizontal=�$��Right=�$��Center=�.+��� $��Center=�
���   �$
��Bold"�$��Mã Sản Phẩm: ���� -   $��txtMaH��{�.  $��Center=�
���   �$
��Bold"�$	��100��$
��0 10q��� -   $��btnSP��{�.  $��Center=���Z� ��Z� .��  $ Search=����	#FFED1D1D�� $��45��$	��Top=�.+��� $ 
Horizontal=�$��Center=�$��Right=�.+��� 
���   �$��Center=�$
��Bold"�$��Tên Sản Phẩm: ��$
��0 10q��� -   $��txtTenH��
���   �$��Center=�$
��Bold"�$	��140��$
��5 10q�{�.  ]� $��2��.+��� $��45��$	��Top=�.+��� $ 
Horizontal=�$��Center=�$��Right=�$
��10 0q�.+��� 
���   �$��Center=�$
��Bold"�$
��SL: ��$
��0 10q��� -   $��txtSL��{�.  
���   �$��Center=�$
��Bold"�$��50��$
��5 10q��� 
���   �$��Center=�$
��Bold"�$��Đơn Giá: ��$
��0 10q��� -   $��txtDG��{�.  
���   �$��Center=�$
��Bold"�$��90��$
��0 10q��� $��45��$��Bottom=�.+��� $ 
Horizontal=�$��Center=�$��Right=�$
��10 0q�.+��� 
���   �$��Center=�$
��Bold"�$��Thành Tiền: ��$
��0 10q��� -	   $��txtTT��
���   �$��Center=�$
��Bold"�$	��150��$
��0 10q�{�.  ]� $��3��.+��� $��45��$��30 20q�.+��� $ 
Horizontal=�$��Center=�.+��� -
   $��btnThem��$��Thêm��$	��100��]� $��1��.+��� -   $��orderListView�� � ContextMenu �� .@�m� -   $��deleteSP��$��Delete�� m� Icon �� $��16��$��16��$��Images/xoa.png�� �� View �� .P���  �� Width$	 100��$��Số Thứ Tự�� �� DisplayMemberBinding �� *STT+�� $	 150��$��Mã sản phẩm�� �� *MaSP+�� $	 350��$��Tên sản phẩm�� �� *TenSP+�� $	 150��$��Số lượng�� �� *	SoLuong+�� $	 150��$��
Đơn Giá�� �� *DonGia+�� $��Thành Tiền�� �� *	ThanhTien+]� $��2��.+��� $ 
Horizontal=�   WarningBrush#��[  .+��� $��Tổng Tiền : ��$��Center=�
�������$
��Bold"�$��	700 0 0 0q�$��15(��� -   $��TTien��$	��0đ��$��Center=�
�������$
��Bold"�$��30 0 0 0q�$��15(��� -   $��btnMua��$��Tạo Phiếu��$	��100��$��
40, 0, 0 0q�