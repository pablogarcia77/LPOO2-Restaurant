   M S B A M L   `   `   `  ����E  AClasesBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:ClasesBase;assembly=ClasesBase
ClasesBase  5   	   
 Vistas   Vistas.NuevoCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <svc,clr-namespace:ClasesBase;assembly=ClasesBase     5   	   -   5          � Title$  Nuevo Cliente��5   	   $	��300��6   $	��350��6,    � WindowStartupLocation$ CenterScreen=�6O    � 	Resources 5       	  Datos S� 
ObjectType    ClasesBase.TrabajarCliente S� 
MethodName �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $ ../Estilos/Estilos.xaml?�6%   6H   %?   &	        S� 5      "  6/   $ TraerCliente��6Y   6u   5      .��5      � .+�5   
   �� -   5        $��	lblCodigo��5   [   $��Codigo��6   $��28��6!   $
��Left=�6-   $��	12,12,0,0q�6H   $	��Top=�6l   �� 5   
   -   5        $��lblApellido��5   ]   $��Apellido��6   $��28��6#   $
��Left=�6/   $��	12,46,0,0q�6J   $	��Top=�6p   �� 5   
   -   5        $��	lblNombre��5   [   $��Nombre��6   $��28��6!   $
��Left=�6-   $��	12,80,0,0q�6H   $	��Top=�6l   �� 5   
   -   5        $��lblDireccion��5   _   $��	Direccion��6   $��28��6$   $
��Left=�60   $��
12,114,0,0q�6K   $	��Top=�6s   �� 5   
   -   5        $��lblTelefono��5   ^   $��Telefono��6   $��28��6#   $
��Left=�6/   $��
12,148,0,0q�6J   $	��Top=�6q   �� 5   
   -   5        $��lblEmail��5   [   $��Email��6   $��28��6    $
��Left=�6,   $��
12,182,0,0q�6G   $	��Top=�6k   �� 5   
   -   5        $��	txtCodigo��5   M   $��23��6   $
��Left=�6   $��
113,12,0,0q�69   $	��Top=�6^   $	��153��6v     EstiloError#��[ 6�    � DataContext# [  6�   .��6�   ��5      �� 5       �� Path$ Cli_id�6   	 �� UpdateSourceTrigger$	 PropertyChanged=�6(   
 �� ValidatesOnDataErrors
 .  �� ValidatesOnExceptions . 6k   .��5      5      �� 5   
   -	   5        $��txtApellido��5   M   $��23��6   $
��Left=�6   $��
113,46,0,0q�69   $	��Top=�6`   $	��153��6x   �� 5   
   -
   5        $��	txtNombre��5   M   $��23��6   $
��Left=�6   $��
113,80,0,0q�69   $	��Top=�6^   $	��153��6v   #��[ 6�   # [  6�   .��6�   ��5      �� 5      $ 
Cli_nombre�6   $	 PropertyChanged=�6,    �� ValidationRules 5      5  /System.Windows.Controls.ExceptionValidationRule  5       5  /System.Windows.Controls.DataErrorValidationRule  5!      5#      .��5$      5%      �� 5&   
   -   5        $��txtDireccion��5&   N   $��23��6   $
��Left=�6   $��113,114,0,0q�69   $	��Top=�6b   $	��153��6z   �� 5'   
   -   5        $��txtTelefono��5'   N   $��23��6   $
��Left=�6   $��113,148,0,0q�69   $	��Top=�6a   $	��153��6y   �� 5(   
   -   5        $��txtEmail��5(   N   $��23��6   $
��Left=�6   $��113,182,0,0q�69   $	��Top=�6^   $	��153��6v   �� 5)   
   -   5        $��
btnAgregar��5)   ^   $��Agregar��6   $��32��6#   $
��Left=�6/   $��
12,217,0,0q�6J   $	��Top=�6p   $	��115��6�     btn_plantilla_aceptar#��[ 6�   �� 5*   
   -   5        $��btnCancelar��5*   `   $��Cancelar��6   $��32��6$   $
��Left=�60   $��151,217,0,0q�6K   $	��Top=�6s   $	��115��6�     btn_plantilla_cancelar#��[ 6�   5+      5,      