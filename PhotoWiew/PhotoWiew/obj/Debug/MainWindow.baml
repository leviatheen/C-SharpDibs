   M S B A M L   `   `   `  ����D  @PhotoWiew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PhotoWiew	PhotoWiew  5   	       PhotoWiew.MainWindow   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PhotoWiew     5   	   -   5          �Name$  
Photo_Wiew��5   
    � Title$ 	PhotoWiew��5   	   $	��450��6   $��731.195��6(   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��250 �6   .+�5   
   � .+�5      �� $��Stretch=�6   .��5      �� -   5         ��Name$ _ImagesContainer��5      
�������$��Stretch=�6N   5      5      5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� $��0��6    �� Orientation$ Vertical=�6&   .+�5      �� -   5        $��Select file ...��5      
�������$
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��75��6�   6�   �� 5      -   5         ��Name$ O��5      
������$1��+Скопировать в мою папку��6<   $
��Left=�6^   $��	10,10,0,0q�6y   $
��10,4q�6�   $	��Top=�6�   6�   5      �� 5      $��1��6   $��Stretch=�6)   $��Stretch=�6G   .��5       �� -   5         ��Name$ CenterImage��5       $��Stretch=�6-   $��Uniform=�6K   $��	10,10,6,0q�6]   $	��Top=�6p   5!      5"      5#      5$      