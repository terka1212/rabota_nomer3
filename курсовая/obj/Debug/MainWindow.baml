   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	   !    курсовая.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��500��6   $
��1000��6)   ���	#FF585857 � 
ResizeMode$ NoResize=�6M   .��5
      �  � RowDefinitions 5   
   �� 5      $	��350 �6   �� 5      $	��100 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ BookService��5         CanUserAddRows .     AutoGenerateColumns .  $��
0,50, 0, 0q�6[      
IsReadOnly . 
����������	#FFD8D2CF   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
IdBook��,  &System.Windows.Controls.DataGridColumn	   Header$	 
Номер��5   5   
   
Foreground
 �	#FF770A0A1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	id_book+6z     5      -   5        	Title��$	 Название��5   4    6F   �� *title+6b     5      -   5        
Author��$	 
Автор��5   5    6D   �� *Author.name_aut+6j     5      $	 Жанр��6%    63   �� *Genre.name_gen+6X     5      -   5        
Publisher1��$	 Издательство��5   9    6O   �� *	publisher+6o     5      $!	 Год публикации��6%    6=   �� *publication_year+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5         Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6)      CellTemplate 5      �� 5      .R�5      ��  ��Name$ BtnMore��6;   -   5        $��Подробности��5   %   $
��auto��6b   5      5        5       $
 auto 6)    5!      �� 5"      .R�5#      �� $ BtnEdit��6=   -   5        $ ��Редактировать��5#   %   $
��auto��6d   5$      5&      5)      �� 5*   
   $��Search 🔎��6   $
��Left=�6%   $��	10,10,0,0q�6@   $	��Top=�6S   $��75��6k   $��16(�6v   $��Harlow Solid Italic)�6�   �� 5+   
   -   5         ��Name$ 	SearchBox��5+      $	��200��6%   $��19��61   $��	85,10,0,0q�6=   $	��Top=�6P   $
��Left=�6h   
������� �� SelectionBrush
 �����
���   �
�������$��Global Serif)�6�   $��16(�6  �� 5,   
   -	   5        $��BtnAdd��5,   L   $��Добавить��6   $��1��6$   $
��Left=�61   $��
10,20,0,30q�6o   $	��117��6�   ���	#FF7F6564
���������6�   Z� 6�   �� 5-   
   -
   5        $��BtnAuthorization��5-   M   $��Вернуться��6   $��1��6%   $
��Left=�62   $��437,20,0,30q�6�   $	��117��6�   ���	#FF7F6564
���������6�   Z� 6�   �� 5.   
   -   5        $��BtnUp��5.   L   $��Обновить��6   $��1��6$   $
��Left=�61   $��220,20,0,30q�6m   $	��117��6�   ���	#FF7F6564
���������6�   Z� 6�   �� 5/   
   -   5        $��BtnDelet��5/   L   $��Удалить��6   $��1��6#   $��Right=�60   $��
0,20,26,30q�6s   $	��116��6�   ���	#FF7F6564
���������6�   Z� 6�   51      52      