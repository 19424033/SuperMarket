   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5   	       SuperMarket.NhapHang   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:SuperMarket  5   	     � Title$  Nhập Hàng��5	   	   $	��500��6   $
��1080��6(    � WindowStartupLocation$ CenterScreen=�65   .��5
      ]� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��1080��5      $��Bottom=�5      $��35��6%      WarningBrush#��[  5      .+�5      �� $��Tổng Tiền : ��6   $��Center=�6+   
�������$
��Bold"�6^   $��	650 0 0 0q�6p   $��15(�6�   �� 5      -   5        $��TTien��5      $	��0đ��6!   $��Center=�6.   
�������$
��Bold"�6a   $��30 0 0 0q�6s   $��15(�6�   �� 5      -   5         ��Name$	 mua��5      $��Nhập Hàng��6"   $	��130��67   $��
30, 0, 0 0q�6U   5      �� 5      
���   �$��1q�6)   ._�5      �� -   5        $��	LVMaPhieu��5       �� View 5      �� 5      .P�5      ��  �� Width$	 130��6-   $��Mã Phiếu Nhập��69    �� DisplayMemberBinding 6P   �� *MaPhieuNhapHang+5      5      5      �� 5   
   
���   �$��1q�6%   ._�5      �� -   5        $��orderListView��5       5      �� 5      .P�5       �� $	 100��6)   $��Số Thứ Tự��65    6H   �� *STT+�� 5!      $	 150��6)   $��Mã sản phẩm��65    6K   �� *MaSP+�� 5"      $	 230��6)   $��Tên sản phẩm��65    6L   �� *TenSP+�� 5#      $	 150��6)   $��Số lượng��65    6H   �� *	SoLuong+�� 5$      $	 150��6)   $��
Đơn Giá��65    6F   �� *DonGia+�� 5%      $��Thành Tiền��6)    6>   �� *	ThanhTien+5&      5(      5)      5*      5+      