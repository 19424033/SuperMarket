   M S B A M L   `   `   `  ���� F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket      SuperMarket.NhanVien   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +localclr-namespace:SuperMarket     .���   � RowDefinitions  �� $��* ��� $
��1.5* �.+�]� $��0��.+��  � ColumnDefinitions �� $��* ��� $��* �.+�]� $��0��.+��� 
���   �$	��540����Z� ����  �� Orientation$ 
Horizontal=�$��5q�.+��� $��18(�$��Thông Tin Nhân Viên��$
��Bold"��� -   $��
isActiveNV��$y�Hidden=�$��isActive��$��18(�$��	240 0 0 0q�$��Right=�.���� .+��  �� $
��1.3* ��� $��* �.+��� $��0��.+��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��Họ Tên: ��$��18(�$��80��$��	10 5 10 0q��� $��Right=�.+��� -   $��txtName��$	��180��$��18(��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��Ng Sinh:��$��18(�$��80��$��	10 5 10 0q��� $ 
Horizontal=�$��Right=�.+��� -   $��txtdateBirth��$	��100��$��18(��� -   $��checkGT��$	��Nam��$��Center=�$��30 5 0 0q�$��18(��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��	Q.Quán: ��$��18(�$��80��$��	10 5 10 0q��� $��Right=�.+��� -   $��txtQQ��$	��180��$��18(��� $��1��.+��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��
Số ĐT: ��$��18(�$��80��$
��10 5q��� $��Right=�.+��� -   $��txtDT��$	��110��$��18(��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��Chức vụ:��$��18(�$��80��$
��10 5q��� $��Right=�.+��� -   $
��cbCV��$	��110��$	��0 5q��� $ 
Horizontal=�$��0 5 0 0q�.+��� $
��Left=�.+��� $��
M.Khẩu: ��$��18(�$��80��$
��10 5q��� $��Right=�.+�G� -   $��txtPass��$	��110��$��18(�� $	��0 5q� �� $��* ��� $��* ��� $��* �.+�]� $��0��.+��� -	   $��btnAddNV��$��Thêm��$	��100��{�. $��32��$	��Top=�]� $��1��.+��� -
   $��btnUpdateNV��$��Cập Nhật��$	��100��{�.  ]� $��2��.+��� -   $��btnCancelNV��$��Hủy��$	��100��{�.  
���  ��]� $��1��.+��� 
���   �$	��540����Z� ���� $ 
Horizontal=�$��5q�.+��� $��18(�$��Ca Làm Việc��$
��Bold"�.���� .+��� $ 
Horizontal=�$	��0 5q�.+��� $��Từ Ngày: ��$��18(�$
��10 5q�(  "System.Windows.Controls.DatePicker  -     Name$ 	DateStart��$	��150��{�.  $��18(�$
��10 0q�$��Center=�$��Sitka Banner)����	#FFF00707$
��Bold"��  �� $��* ��� $��* ��� $��* �.+��� $��0��.+��� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN1��$��Thứ hai: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN1��{�.  $��50���� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN2��$��
Thứ ba: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN2��{�.  $��50���� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN3��$��Thứ tư: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN3��{�.  $��50���� $��1��.+��� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN4��$��Thứ năm: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN4��{�.  $��50���� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN5��$��Thứ sáu: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN5��{�.  $��50���� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�.+��� -   $��txtN6��$��Thứ bảy: ��$��18(�$	��100��$
��10 0q��� $��Right=�.+��� -   $
��cbN6��{�.  $��50���� $��2��.+��� $ 
Horizontal=�$	��0 5q�.+��� $
��Left=�$	��0 5q�.+��� -   $��txtN7��$��Chủ nhật: ��$��18(�$	��100��$
��10 0q��� $��Right=�$	��0 5q�.+��� -   $
��cbN7��{�.  $��50���� -   $��updateCaLam��$��Cập nhật��$	��100��$��5q�{�.  ]� $��1��.+��� 
���   �$
��1080����Z� ���� $ 
Horizontal=�$��5q�.+��� $��18(�$��Danh Sách Nhân Viên��$
��Bold"�.���� $ Vertical=�.+��� -   $��filterCanvas��$��30��.+��� -   $��hintText�� �� Padding$ 5q�$"��Tìm kiếm nhanh theo tên:��$
��Left=�
���   �$
��Bold"�$��15(��� -   $��keywordTextBox��$��30��
���   �$
��Bold"�$��15(�
������ $�� ��$��
3, 0, 0, 0q�����  �� ElementName$ filterCanvas�� �� Path$ ActualWidth�&   System.Windows.Controls.DataGrid  -   $��DataNV��   AutoGenerateColumns .     
IsReadOnly . 	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width$	 130    Header$ Mã NV��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� $
 MaNV�  $	 220 $ 	Họ tên�� �� $ TenNV�  $	 150 $ Số Điện Thoại�� �� $ SoDienThoai�  $	 150 $ 
Quê Quán�� �� $ QueQuan�  $	 150 $ 
Ngày Sinh�� �� $ NgaySinh� �� StringFormat$ 
dd-MM-yyyy��4  .System.Windows.Controls.DataGridCheckBoxColumn  $	 100 $ Giới Tính�� �� $ GioiTinh� �� Mode$ OneWay=�  $	 150 $ Mật Khẩu�� �� $ MatKhau�