   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   A =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Vistas.ConversoresVistas.Conversores 5   	      Vistas.Ventas.Pedidos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =data,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   4convert clr-namespace:Vistas.Conversores     5   	   -   5          N� Title$  Pedidos��5   	   $	��407��6   $	��537��6&    � 	Resources 5      * $Vistas.Conversores.ConversorArticulo   ConvertArticulo  ListaItemsPedido S� 
ObjectType$   ClasesBase.TrabajarItemsPedido S� 
MethodName  ItemsDT��%�   &	        &	      &	 P       5   
   6$   S� 5	   
   "  66   $ TraerItemsPedido��6e   5
      �� 5   
   5      5      .��5      � .+�5   
   �� -   5        $��listBox2��5   /    �� Left$	 192��6   
 �� Top$ 14��6   $��280,140,19,76q�6?   ��5      ��  �� Source# [  �� View 5      �� 5       P�5!      �� 5"      $��Articulo��6)    �� Width$	 100��6;   	 �� CellTemplate	 5#      �� 5$   "   .R�5%   &   �� ��60   �� 
 �� Path$
 Art_id� �� 	Converter# [   �� ConverterParameter$
 true��5&   #   5(      �� 5)      $��Cantidad��6)   $ 60��6;   	 5*      �� 5+   "   .R�5,   &   �� ��60   �� $
 Cantidad�5-   #   5/      �� 50      $��Total��6)   $ 60��68   	 51      �� 52   "   .R�53   &   �� ��60   �� $
 Importe�54   #   56      58      5:      �� 5;   
   -   5         ��Name$ 
cboCliente��5;   q   $��23��6   $
��Left=�6   $��	81,77,0,0q�6:   $	��Top=�6M   $	��171��6e    �� DisplayMemberPath$ Cli_Apellido��6�    �� SelectedValuePath$ Cli_Id��6�   6�   �� 5=   
   -   5        $ cboArticulo��5=   r   $��23��6   $
��Left=�6   $��
81,140,0,0q�6:   $	��Top=�6N   $	��171��6f   $ Art_Descrip��6�   $ Art_Id��6�   6�   �� 5>   
   -   5        $��txtCantidad��5>   M   $��23��6   $
��Left=�6   $��
81,170,0,0q�69   $	��Top=�6`   $	��171��6x   �� 5?   
   -   5        $��
txbCliente��5?   N   $��23��6   $
��Left=�6    $��	12,79,0,0q�6;   $��Cliente��6`   $	��Top=�6o   
�������6�   �� 5@   
   -   5        $��txbArticulo��5@   O   $��23��6   $
��Left=�6    $��
12,140,0,0q�6;   $��Articulo��6b   $	��Top=�6r   
�������6�   �� 5A   
   -   5        $��txbCantidad��5A   O   $��23��6   $
��Left=�6    $��
12,170,0,0q�6;   $��Cantidad��6b   $	��Top=�6r   
�������6�   �� 5B   
   -	   5        $��
btnGuardar��5B   h   $��Confirmar Pedido��6   $��32��6,   $
��Left=�68   $��280,337,0,0q�6S   $	��Top=�6z   $	��238��6�   6�   �� 5C   
   -
   5        $��txtMesa��5C   O   $��23��6   $
��Left=�6    $��
280,23,0,0q�6;   $��Número de Mesa:��6^   $	��Top=�6u   
�������6�   �� 5D   
   -   5        $��
txtNroMesa��5D   O   $��23��6   $
��Left=�6    $��
383,23,0,0q�6;   $��	TextBlock��6a   $	��Top=�6r   $
��Bold"�6�   
�������6�   �� 5E   
   -   5        $��
btnAgregar��5E   ^   $��Agregar��6   $��23��6#   $
��Left=�6/   $��
81,235,0,0q�6J   $	��Top=�6p   $	��171��6�   6�   �� 5F   
   -   5        $��
textBlock1��5F   P   $��23��6   $
��Left=�6    $��280,116,0,0q�6;   $��Items del Pedido��6b   $	��Top=�6z   
�������6�   �� 5G   
   -   5        $��	txtPrecio��5G   O   $��23��6   $
��Left=�6    $��
81,199,0,0q�6;   $	��Top=�6�   $	��171��6�   
���������6`   ��  �� ElementName$ cboArticulo��$
 SelectedItem.Art_Precio�6�   �� 5H   
   -   5        $��
textBlock2��5H   O   $��23��6   $
��Left=�6    $��
12,199,0,0q�6;   $��Precio��6a   $	��Top=�6o   
�������6�   �� 5I   
   -   5        $��txtComensales��5I   M   $��23��6   $��Right=�6   $��	0,77,19,0q�6:   $	��Top=�6b   $��89��6z   �� 5J   
   -   5        $��txbComensales��5J   O   $��23��6   $
��Left=�6    $��
360,79,0,0q�6;   $��
Comensales��6d   $	��Top=�6v   
�������6�   �� 5K   
   -   5        $��	txbTitulo��5K   N   $��39��6   $
��Left=�6    $��	12,12,0,0q�6;   $��Nuevo Pedido��6_   $	��Top=�6s   $	��189��6�   $��26(�6�   $
��Bold"�6�   
�������6�   5L      5M      