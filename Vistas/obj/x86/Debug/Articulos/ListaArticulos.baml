   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5   	   
 Vistas%   Vistas.Articulos.ListaArticulos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   KcoleccionArticulos,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   ScomponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase     5   	   -   5          � Title$  ListaArticulos��5   	   $	��416��6    $	��608��6-    � 	Resources 5         List_Articulos S� 
ObjectType"   ClasesBase.TrabajarArticulos S� 
MethodName  Vista_Articulos �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName   	Direction��%�   &	        &	 =     7   S� 5   
   "  5
      $ TraerArticulosObs��5      �� 5   
   -   5        8    5        5      $ Art_descrip��61   $ 	Ascending=�6L   5      5      .��5      � .+�5   
   �� -   5        $��txtDescripcion��5   M   $��23��6   $
��Left=�6   $��
233,41,0,0q�69   $	��Top=�6c   $	��187��6{   6�   �� 5   
   -   5        $��lstArticulo��5      $��61,70,122,109q�6f   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6}   ��6&   �� 	 �� Source#	 [ 
 �� View
 5      �� 5      .P�5      �� $��Articulo��6%    �� Width$	 100��67    �� DisplayMemberBinding 6C   �� *Art_descrip+�� 5      $��Familia��6%   $	 150��66    6B   �� *Familia.Fam_descrip+�� 5      $��Precio��6%   $	 100��65    6A   �� *
Art_precio+5      5!      �� 5$   
   -   5        $��btnImprimir��5$   d   $��Vista Previa��6   $��22��6(   $
��Left=�64   $��216,283,0,0q�6O   $	��Top=�6w   $	��113��6�   6�   5%      5&      