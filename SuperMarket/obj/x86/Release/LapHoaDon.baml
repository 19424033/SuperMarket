   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.LapHoaDon   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  %localclr-namespace:SuperMarket  .���   � RowDefinitions  �� $��* ��� $��4* �.+�]� $��0��.+��� $��Lập Hóa Đơn��
���   �$	��5 0q�$
��Bold"���Z� .���  � ColumnDefinitions �� $
��0.5* ��� $
��0.7* ��� $
��0.5* ��� $
��0.7* ��� $
��0.5* ��� $
��0.7* ��� $
��0.5* �.+�]� $��0��.+��� $��50��$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� 
���   �$��Center=�$
��Bold"�$��Mã Khách Hàng:��$��0 10 0 0q��� $��50��$��Bottom=�.+��� $ 
Horizontal=�$��Right=�$��Center=�.+��� 
���   �$��Center=�$
��Bold"�$��Tên Khách Hàng:��]� $��1��.+��� $��50��$	��Top=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$
��10 0q�.+��� -   $��txtKH��
���   �$��Center=�$
��Bold"�$	��100���� -   $��btnKH��$��50����Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=����	#FFED1D1D�� $��50��$��Bottom=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$
��10 0q�.+��� -   $��txtTenKH��$��Khách Vãng Lai��
���   �$��Center=�$
��Bold"�$	��150��{�.  ]� $��2��.+��� $��50��$	��Top=�.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��0 10q�.+��� 
���   �$��Center=�$
��Bold"�$��Mã Sản Phẩm:���� $��50��$��Bottom=�.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��0 10q�.+��� 
���   �$��Center=�$
��Bold"�$��Tên Sản Phẩm:��]� $��3��.+��� $��50��$	��Top=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$
��10 0q�.+��� -   $��txtMaSP��
���   �$��Center=�$
��Bold"�$	��100���� -   $��btnMaSP��$��50����Z� ��Z� .��  $ Search=����	#FFED1D1D�� $��50��$��Bottom=�.+��� $ 
Horizontal=�$
��Left=�$��Center=�$
��10 0q�.+��� -   $��txtTenSP��
���   �$��Center=�$
��Bold"�$	��150��{�.  ]� $��4��.+��� $��50��$	��Top=�.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��0 10q�.+��� 
���   �$��Center=�$
��Bold"�$��Số Lượng:���� $��50��$��Bottom=�.+��� $ 
Horizontal=�$��Right=�$��Center=�$
��0 10q�.+��� 
���   �$��Center=�$
��Bold"�$��Đơn Giá:��]� $��5��.+��� $��50��$	��Top=�.+��� $ 
Horizontal=�$��Center=�$��Center=�$
��10 0q�.+��� -   $��txtQuan��{�.  
���   �$��Center=�$
��Bold"�$	��150���� $��50��$��Bottom=�.+��� $ 
Horizontal=�$��Center=�$��Center=�$
��10 0q�.+��� -   $��txtPrice��
���   �$��Center=�$
��Bold"�$	��150��{�.  ]� $��6��.+��� -	   $��btnThem��$��Thêm��$	��100��$��Center=�]� $��1��.+��  �� $��5* ��� $��* �.+�]� $��0��.+��� 
���   �$��1q�$��5q� �� CornerRadius$ 4��._��� -
   $��orderListView�� � ContextMenu �� .@�m� -   $��deleteSP��$��Delete�� m� Icon �� $��16��$��16��$��Images/xoa.png�� �� View �� .P���  �� Width$	 150��$��Số Thứ Tự��	 �� DisplayMemberBinding	 �� *STT+�� $	 250��$��Tên Sản Phẩm��	 �� *tenSP+�� $	 150��$��
Đơn Giá��	 �� *donGia+�� $	 150��$��Số lượng��	 �� *	soLuong+�� $��Thành tiền��	 �� *	thanhTien+�� $��2��$��Center=�$��5q�.+��� $ 
Horizontal=�.+��� 
���   �$
��Bold"�$�� Tổng tiền:    ��$
��5 10q��� -   $��txtTongTien��
���   �$
��Bold"�$��10q�$��0���� $ 
Horizontal=�.+��� 
���   �$
��Bold"�$��Chiết khấu:    ��$
��5 10q��� -   $��txtChietKhau��
���   �$
��Bold"�$��10q�$��0���� $ 
Horizontal=�.+��� 
���   �$
��Bold"�$��Thanh Toán:  ��$
��5 10q��� -   $��txtThanhToan��
���   �$
��Bold"�$��10q�$��0���� -   $��btnTM��$��Tiền Mặt��$
��5 15q�$	��100���� -   $��btnThe��$��Visa/MasterCard��$
��5 15q�$	��150��