   M S B A M L   `   `   `  ����G  Ccompteur_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:compteur_wpfcompteur_wpf  5   	       compteur_wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:compteur_wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	   	   ��    GestionMainWindows �� Source# [  .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��50 �6   �� 5      $��1* �6   .+�5   
   �� $��+��6   $��50(�6   $��0��6+   $��0��68   
����� ���5   #   ��  �� Path$
 Incr��� 5   
   $��-��6   $��50(�6   $��2��6+   $��0��68   
��� ����5   )   �� $	 Dcr��� 5   
   $��1��6   $��3��6"   $��50(�5       �� TextAlignment$ Center=�6    $��Center=�67   ��5   3   �� $ Value���5   R   �� *Value+  GestionCouleur �� 	Converter# [ �� 5   
   $��2��6   $��3��6"   ��63   �� *MaList+��5      �� 5      .R�5      �� ��6    �� *Value+��67   �� *Value+# [ 5       5"      �� 5#   
   $	��Add��6   $��0��6   $��1��6/   ��6<   �� *Add+5$      5%      