   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.KhachHang   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:SuperMarket     .��� $	��540��$��Bottom=�  � RowDefinitions  �� $��* ��� $��3* �.+�]� $��0��$��Center=�$��Center=�.+��   �� $��* ��� $��* �.+�]� $��0��.+��� $��Họ Tên: ��$��18(�$��80��$��10 5 5 0q��� -   $��txtName��$	��180��$��18(��� $��
Số ĐT: ��$��18(�$��80��$��10 5 5 0q��� -   $��txtDT��$	��110��$��18(��� $��Địa Chỉ: ��$��18(�$��80��$��10 5 5 0q��� -   $��	txtDiaChi��$	��180��$��18(�]� $��1��.+�� $
��0 10q� � ColumnDefinitions �� $��* ��� $��* ��� $��* �.+�]� $��0��.+��� -   $��btnAddKH��$��Thêm��$	��100��{�. $��32��$��Bottom=�]� $��1��.+��� -   $��btnUpdateKH��$��Cập Nhật��$	��100��{�.  ]� $��2��.+��� -   $��btnCancelKH��$��Hủy��$	��100��{�.  
���  ��]� $��1��.+���  �� Orientation$ Vertical=�.+��� -   $��filterCanvas��$��30��.+��� -   $��hintText�� �� Padding$ 5q�$"��Tìm kiếm nhanh theo tên:��$
��Left=�
���   �$
��Bold"�$��15(��� -	   $��keywordTextBox��$��30��
���   �$
��Bold"�$��15(�
������ $�� ��$��
3, 0, 0, 0q�����  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�&   System.Windows.Controls.DataGrid  -
   $��DataKH��   AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Width$	
 130    Header$ Mã KH��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 MaKH�  $	
 230 $ 	Họ tên�� �� $ TenKH�  $	
 190 $ Số Điện Thoại�� �� $ SoDienThoai�  $	
 200 $ Địa Chỉ�� �� $ DiaChi�  $	
 150 $ Ngày Lập Thẻ�� �� $ 
NgayLapThe� �� StringFormat$ 
dd-MM-yyyy��  $	
 150 $ Điểm Tích Lũy�� �� $ DiemThuongTichLuy�