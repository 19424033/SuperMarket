   M S B A M L   `   `   `  ����F  BSuperMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperMarketSuperMarket  5      "    SuperMarket.ThongBaoNhapHang   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %localclr-namespace:SuperMarket  5      .��5
      � $	��540��6   $��Bottom=�6     � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   ]� $��0��6   $��Center=�6!   $��Center=�6>   .+�5      �� 
���   �$��Center=�6,   $
��Bold"�6G   $��Mã Sản Phẩm: ��6Y   $
��0 10q�6n   �� 5      -   5        $��txtmasp��5      
���   �$��Center=�69   $
��Bold"�6T   $	��100��6f   $��10 10q�6r   6�   �� 5      ��6   Z� ��6+   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6*   ���	#FFED1D1D68   5      �� 5      
���   �$��Center=�6,   $
��Bold"�6G   $��Tên Sản Phẩm: ��6Y   $
��0 10q�6o   �� 5      -   5        $��txttensp��5   (   {�.  
���   �$��Center=�6L   $
��Bold"�6g   $	��150��6y   $��10 10q�6�   �� 5      -   5        $��	btnThemSP��5      $��Thêm��6&   $	��100��65   $��Right=�6A   $��20 10q�6]   6l   5      ]� 5      $��1��6   .+�5      �� -   5        $��orderListView��5       �� View 5      �� 5      .P�5      ��  �� Width$	 150��6)   $��Ngày��65    �� DisplayMemberBinding 6C   �� *	NgayLap+ �� StringFormat$ 
dd-MM-yyyy���� 5      $	 200��6)   $��Mã sản phẩm��65    6J   �� *MaSP+�� 5      $	 350��6)   $��Tên sản phẩm��65    6K   �� *TenSP+�� 5       $	 150��6)   $��Trạng Thái��65    6I   �� *	TrangThai+�� 5!      $��Người Lập��6)    6<   �� *TenNV+5"      5$      5%      5&      5'      