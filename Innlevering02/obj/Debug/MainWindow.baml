   M S B A M L   `   `   `  ����H  DInnlevering02, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Innlevering02.User_ControlsInnlevering02.User_Controls  5   	       Innlevering02.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (ignorehttp://www.ignore.com     5   	   AuserControl)clr-namespace:Innlevering02.User_Controls     5   	   $	��598��5   	   $	��800��5	   	     � Title$  MVVM Light Application��5
   	    � 
ResizeMode$ NoResize=�5   M    � DataContext 6	   �� *
EntityList+   Locator �� Source# [  .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   o�  o� 
IsMainMenu . .@�5      m� $��_File��6   .@�5      m� $��_Save��6    m� Command 6*   �� *SaveCommand+m� 5      $��_Open��6    6*   �� *LoadCommand+m� 5      $��_Close��6    6+   �� *CloseCommand+5      5      �� 5   
   $��1��6   .@�5      �� -   5         ��Name$ UnnamedEntities��5      $��Unnamed entities��6/   .��5      � -   5        $ UnnamedEntityGrid��5      	 � ColumnDefinitions	 5       �� 5!      $
��Auto �6+   6:   �� 5"      $	��55* �6+   69   �� 5#      $
��626* �6+    5&      �� 5'      $
��Auto �6(   68   �� 5(      $��* �6(   65   .+�5+      �� $��0��6   $��0��6)   .��69   Unnamed Entities6K   �� 5,      -   5        
 ��Name$
 UnnamedEntityList��5,      $��1��69   $��0��6F    �� DisplayMemberPath$
 Name��6�    �� SelectedIndex 6V   �� *UnnamedEntityIndex+��6�   �� *UnnamedEntityCollection+6�   ,   &Innlevering02.User_Controls.StatWindow  5-      $��1��6-   $��1��6:   $��2��6J   6`   5.      5/      �� 51      -   5        $ NamedEntities��51      $��Named entities��6-   .��52      � -   5        $ NamedEntityGrid��52      	 54      �� 55      $
��Auto �6+   6:   �� 56      $��* �6+   67    59      �� 5:      $
��Auto �6(   68   �� 5;      $��* �6(   65   .+�5>      �� $��0��6   $��0��6)   .��69   Named Entities6I   �� 5?      -   5        $
 	EnemyList��5?      $��1��61   $��0��6>   $
 Name��6�    6N   �� *NamedEntityIndex+��6y   �� *NamedEntityCollection+6�     5@      $��1��6-   $��1��6:   6L   5A      5B      5C      5D      5E      