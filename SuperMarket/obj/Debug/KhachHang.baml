   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5          SuperMarket.KhachHang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SuperMarket     5      .��5	      � $	��540��6   $��Bottom=�6     � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   ]� $��0��6   $��Center=�6!   $��Center=�6>   .+�5      �   5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5      ]� $��0��6   .+�5      �� $��Họ Tên: ��6    $��18(�60   $��80��6>   $��10 5 5 0q�6I   �� 5      -   5        $��txtName��5      $	��180��6-   $��18(�69   �� 5      $��
Số ĐT: ��6    $��18(�6/   $��80��6=   $��10 5 5 0q�6H   �� 5      -   5        $��txtDT��5      $	��110��6+   $��18(�67   �� 5      $��Địa Chỉ: ��6    $��18(�61   $��80��6?   $��10 5 5 0q�6J   �� 5      -   5        $��	txtDiaChi��5      $	��180��60   $��18(�6<   5      ]� 5      $��1��6   .+�5      � $
��0 10q�6    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5       $��* �6/   �� 5!      $��* �6/   .+�5#      ]� $��0��6$   .+�5$      �� -   5        $��btnAddKH��5$   %   $��Thêm��6L   $	��100��6[   {�. $��32��6x   $��Bottom=�6�   5%      ]� 5&      $��1��6$   .+�5'      �� -   5        $��btnUpdateKH��5'   %   $��Cập Nhật��68   $	��100��6K   {�.  6i   5(      ]� 5)      $��2��6$   .+�5*      �� -   5        $��btnCancelKH��5*   %   $��Hủy��68   $	��100��6F   {�.  
���  ��6u   5+      5,      5-      5.      5/      ]� 50   
   $��1��6   .+�51      ��  �� Orientation$ Vertical=�6   .+�52      �� -   5        $��filterCanvas��52      $��30��61   .+�53      �� -   5        $��hintText��53   $    �� Padding$ 5q�64   $"��Tìm kiếm nhanh theo tên:��6@   $
��Left=�6`   
���   �$
��Bold"�6�   $��15(�6�   �� 54      -	   5        $��keywordTextBox��56   q   $��30��54   "   
���   �$
��Bold"�6B   $��15(�6T   
������ $�� ��56   �   $��
3, 0, 0, 0q�6�   ��64   ��  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�6�   57      &   System.Windows.Controls.DataGrid  58      -
   5        $��DataKH��58         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   	   Columns	 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn
   Width$	
 130 61      Header$ Mã KH��6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� $
 MaKH�  5<      $	
 230 61   $ 	Họ tên��6=    6M   �� $ TenKH�  5=      $	
 190 61   $ Số Điện Thoại��6=    6T   �� $ SoDienThoai�  5>      $	
 200 61   $ Địa Chỉ��6=    6N   �� $ DiaChi�  5?      $	
 150 61   $ Ngày Lập Thẻ��6=    6S   �� $ 
NgayLapThe� �� StringFormat$ 
dd-MM-yyyy��  5@      $	
 150 61   $ Điểm Tích Lũy��6=    6T   �� $ DiemThuongTichLuy�5C      5D      5F      5G      5H      