   M S B A M L   `   `   `  ����I  EIranyitoMutato, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:IranyitoMutatoIranyitoMutato  5   	       IranyitoMutato.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:IranyitoMutato     5   	     � Title$%  Irányító mutató kalkulátor��5   	   $	��284��6,   $	��697��69   .��5	      � $��0,0,21,6q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   �� 5      $	��19* �6   .+�5   
   �� $$��Átadási kísérletek száma:��6   $��2��64   $
��Left=�6D   $��	10,10,0,0q�6_   $	��Top=�6r   �� 5   
   $ ��Sikeres átadások száma:��6   $��2��62   $
��Left=�6B   $��	10,40,0,0q�6]   $	��Top=�6p   �� 5   
   $��Passzolt yardok:��6   $��2��6+   $
��Left=�6;   $��	10,70,0,0q�6V   $	��Top=�6i   �� 5   
   $��Touchdown passzok:��6   $��2��6-   $
��Left=�6=   $��
10,100,0,0q�6X   $	��Top=�6l   �� 5   
   $��Eladott átadások:��6   $��2��6,   $
��Left=�6<   $��
10,130,0,0q�6W   $	��Top=�6k   �� 5   
   -   5         ��Name$ tbKísérlet��5      $
��Left=�6'   $��
184,14,0,0q�6B   $��0��6V    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $��40��6�    �� TextAlignment$ Center=�6�   $��2��6�   6�   �� 5   
   -   5        $ 	tbSikeres��5      ${�False��6%   $��2��67   $
��Left=�6G   $��
184,44,0,0q�6b   $��0��6v   $
 Wrap=�6   $	��Top=�6�   $��40��6�   $ Center=�6�   �� 5   
   -   5        $ tbyardok��5      ${�False��6$   $��2��67   $
��Left=�6G   $��
184,74,0,0q�6b   $��0��6v   $
 Wrap=�6   $	��Top=�6�   $��40��6�   $ Center=�6�   �� 5   
   -   5        $ tbTDK��5      ${�False��6"   $��2��65   $
��Left=�6E   $��184,104,0,0q�6`   $��0��6u   $
 Wrap=�6~   $	��Top=�6�   $��40��6�   $ Center=�6�   �� 5   
   -   5        $ 	tbEladott��5      ${�False��6&   $��2��69   $
��Left=�6I   $��184,134,0,0q�6d   $��0��6y   $
 Wrap=�6�   $	��Top=�6�   $��40��6�   $ Center=�6�   �� 5   
   -   5         ��Name$ lMutató��5      $��Irányító mutató:��6!   $��2��6<   $
��Left=�6L   $��
292,59,0,0q�6g   $	��Top=�6{   $
��Bold"�6�   $��20(�6�   �� 5   
   -   5         ��Name$ 	btnSzamol��5      $��Számól��6$   $��2��65   $
��Left=�6E   $��336,111,0,0q�6`   $	��Top=�6u   $��74��6�   6�   5      5      