   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5      
 Vistas   Vistas.ModificarArticulo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5      -   5          � Title$  Modificar Articulo��5   	   $	��366��6$   $	��316��61    � WindowStartupLocation$ CenterScreen=�6=    � WindowStyle$
 None=�6b    � Left$	 300��6v    � 	Resources 5         ListaUM S� 
ObjectType"   ClasesBase.TrabajarArticulos S� 
MethodName��%P   &	        S� 5   
   "  5	      $ TraerUnidadMedida��5
      5      5      .��5      � .+�5   
   � $��	0,0,-24,0q�6   .+�5      �� -   5        $��
lblDescrip��5   d   $��Descripcion��6   $��28��6*   $
��Left=�66   $��	18,20,0,0q�6Q   $	��Top=�6v   �� 5      -   5        $��
lblFamilia��5   `   $��Familia��6   $��28��6&   $
��Left=�62   $��	18,53,0,0q�6M   $	��Top=�6r   �� 5      -   5        $��lblUM��5   i   $��Unidad de Medida��6   $��28��6/   $
��Left=�6;   $��	18,92,0,0q�6V   $	��Top=�6v   �� 5      -   5        $��	lblPrecio��5   `   $��Precio��6   $��28��6%   $
��Left=�61   $��
18,171,0,0q�6L   $	��Top=�6q   �� 5      -   5        $��lblStock��5   _   $��Stock��6   $��28��6$   $
��Left=�60   $��
16,211,0,0q�6K   $	��Top=�6o   �� 5      -   5        $��lblCategoria��5   c   $��	Categoria��6   $��28��6(   $
��Left=�64   $��
18,126,0,0q�6O   $	��Top=�6w   �� 5      -   5        $��
txtdescrip��5   Q   $��23��6   $
��Left=�6"   $��
162,24,0,0q�6=   $	��Top=�6c   $	��120��6{   �� 5      -	   5        $��	txtPrecio��5   R   $��23��6   $
��Left=�6"   $��162,177,0,0q�6=   $	��Top=�6c   $	��120��6{   �� 5      -
   5        $��	checkBox1��5   ^   $�� ��6   $��16��6"   $
��Left=�6.   $��162,211,0,0q�6I   $	��Top=�6o   �� 5      -   5        $��button1��5   d   $��	Modificar��6   $��35��6)   $
��Left=�65   $��
12,253,0,0q�6P   $	��Top=�6s   $	��123��6�   6�   �� 5      -   5        $��button2��5   d   $��Cancelar��6   $��35��6(   $
��Left=�64   $��162,253,0,0q�6O   $	��Top=�6s   $	��123��6�   6�   �� 5      -   5        $��
cmbFamilia��5   �    �� DisplayMemberPath$ Fam_Descrip��6    �� SelectedValuePath$ Fam_Id��67   $��23��6R   $
��Left=�6^   $��
162,58,0,0q�6y   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��cmbUnidadMedida��5   �   $ 
UM_Descrip��6   $ UM_Id��67   $��23��6R   $
��Left=�6^   $��
162,92,0,0q�6y   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��cmbCategoria��5   �   $ Cat_Descrip��6   $ Cat_Id��67   $��23��6R   $
��Left=�6^   $��162,131,0,0q�6y   $	��Top=�6�   $	��120��6�   5      5      5      