   M S B A M L   `   `   `  ����
  Vistas    Vistas.VistaCaja   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$
  Caja��5       � 	Resources 5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding �� TextAlignment��%]  '        �� 5
   
   "  6   .�5      ��  � �� 5      �� 5      "  6&   .R�5      �� $��0,0,0,1q�6!   
���   �
������ ._�5      �� $ ContentHeader��6(   #��z��6?   $ 5,5,5,0q�6`   #��z��6r   $ Center=�6�   5      5      5      �� 5       �@�OverridesDefaultStyle . 66   5      5      .��5      � -   5        $	��374��5      $	��576��6   .+�5   
   �� $��	0,0,402,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dgCaja��5   �   	   AutoGenerateColumns	 .  $	��318��6K   $
��Left=�6X   $��	12,22,0,0q�6s   $	��Top=�6�   $	��162��6�   
�������
   HorizontalGridLinesBrush
 �	#FF688CAF   VerticalGridLinesBrush �	#FF688CAF   CanUserReorderColumns .     CanUserResizeColumns .  $   HorizontalScrollBarVisibility$ Disabled=�6N     RowHeaderWidth$ 0Q�6w  ��6   ��    RowBackground 5      �� 5      ��5      �� 5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$
 Mesa��6*      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	Mesa_Id+6T     5"      $ Importe��6*   $	 100 6W    6;   �� *	Importe+6W   5$      �� 5%       �� Orientation$ 
Horizontal=�6   $��0,10,0,0q�62   .+�5&      � .+�5'      �� $��Total:��6    $��45,0,0,0q�6.   $
��Bold"�6@   
�������6g   5(      � 5)      .+�5*      �� -   5        $��Total��5*   /   $��Footer3��6    $��10,0,0,0q�6<   $
��Bold"�6N   
�������6u   5+      5,      5-      &   System.Windows.Controls.Calendar  5.   
   -   5        $��calFecha��5.   O   $	��170��6   $
��Left=�6    $��
224,22,0,0q�6;   $	��Top=�6_   $	��180��6w   5/      �� 50   
   -   5        $��	txbTitulo��50   O   $��36��6   $
��Left=�6    $��
12,-44,0,0q�6;   $��Reporte del Dia:��6`   $	��Top=�6x   $��26(�6�   $
��Bold"�6�   
�������6�   �� 51   
   -   5        $��txbFecha��51   P   $��36��6   $
��Left=�6    $��232,-44,0,0q�6;   $��	TextBlock��6`   $	��Top=�6q   $��26(�6�   $
��Bold"�6�   
�������6�   52      53      