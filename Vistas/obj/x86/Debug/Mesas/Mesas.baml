   M S B A M L   `   `   `  ����A  =Vistas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Vistas.ConversoresVistas.Conversores  5   	       Vistas.Mesas   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4convert clr-namespace:Vistas.Conversores     5   	   -   5          N� Title$  Mesas��5   	   $	��516��6   $	��788��6$    � 	Resources 5         Estados � Source � XPath+   %Vistas.Conversores.ConversorDeEstados  ConvertColores  FondoEstado �� ElementName �� XPath �� 	Converter  MesasDT �� Orientation �� Path	 �� MergedDictionaries
 �� Source�� 5   
   	 5      �� 5      $
 ../Estilos/Estilos.xaml?�6%   6H   %�  &	        &	 =     &	 P     7  &	 �     � 5      $ EstadosMesa.xml?�6.   $ /estados��6G     5      6)   �� 5      .R�5      �� .+�5      �� $
��Bold"�5      ��5       �� $ listBox1��$ estado/@name��8   5      5      5      �� 5      .R�5      �� $ 
Horizontal=�6   .+�5      �� ��6    �� $ Mesa_Id�6@   �� 5      -6$   �� 5      ��6    �� $ Mesa_Estado�6D   5      5      5!      .��5$      � -   5         �Name$ Grilla��5$      .+�5%      �� -   5         ��Name$ listEstados��5%      $	��143��5&   R   
�������$��632,51,12,291q�6q   ��5%   +   ��  �� Source# [  $ estado/@name����5(      �� 5)       5+       �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName��%�  '��       7  7  �� 5,      " ��6   .�5-      ��  � �� 5.      �� 5/   "   " ��62   .R�50   &   �� $ Bd��6-   #��z��51   )   #��z��52   )   # z��53   )    . ._�55   &   �� #��z��67   # z 56   )   #��z��57   )   58   '    59   &   ]� 5:   *    5;   .   �� 5<   2    �@��IsSelectionActive .  6b   �� 5=   2    �@��
IsSelected . 6R   ./�5?   .   �� $ Bd��6K    6[   �� $ listEstados��$ SelectedValue�8    � ��5@   +   ]� 5A   *    5B   .   �� 5C   2    �@��IsSelectionActive . 6b   �� 5D   2    �@��
IsSelected . 6R   ./�5F   .   �� $ Bd��6K    6[   �� $ listEstados��$ SelectedValue�8   � ��5G   +   5I   #   5K      5L      5M      5N      �� 5O   
   -   5        $��
rectangle1��5O   P   $��48��6   $
��Left=�6    $��632,287,0,0q�6;   
��� � �$	��Top=�6q   $��50��6�   ���	#FF007D00 �� RadiusX$ 0��6�    �� RadiusY$ 0��6�   �� 5P   
   -   5        $��
rectangle2��5P   P   $��48��6   $
��Left=�6    $��632,341,0,0q�6;   
���  ��$	��Top=�6o   $��50��6�   
���  ��6�   �� 5Q   
   -   5        $��label1��5Q   \   $��Libre��6   $��28��6    $
��Left=�6,   $��687,298,0,0q�6G   $	��Top=�6j   
�������6�   �� 5R   
   -   5        $��label2��5R   ^   $��Ocupada��6   $��28��6"   $
��Left=�6.   $��688,352,0,0q�6I   $	��Top=�6l   
�������6�   �� 5S   
   -   5        $��
txbColores��5S   O   $��23��6   $
��Left=�6    $��
632,31,0,0q�6;   $��Colores de Referencia��6a   $	��Top=�6~   $	��143��6�   $
��Bold"�6�   
�������6�   �� 5T   
   -	   5        $��btnCambiarEstado��5T   f   $��Cambiar Estado��6   $��23��6*   $
��Left=�66   $��632,231,0,0q�6Q   $	��Top=�6~   $	��143��6�     btn_plantilla_aceptar#��[ 6�   �� 5U   
   -
   5        $��	txbTitulo��5U   N   $��39��6   $
��Left=�6    $��	12,12,0,0q�6;   $��Mesas��6_   $	��Top=�6l   $	��189��6�   $��26(�6�   $
��Bold"�6�   
�������6�   5V      5W      