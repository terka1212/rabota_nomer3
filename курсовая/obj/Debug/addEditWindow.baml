   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	   $    курсовая.addEditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � Title$  addEditWindow��5   	   $	��750��6   $	��500��6,   ���	#FFF9DDC0.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $
��122* �6   6,   �� 5      $	��25* �6   6+   �� 5      $
��122* �6   6,   .+�5   
   �� $��Название��6   $��0��6$   $��Center=�61   $��Center=�6N   $��20(�6i   6z   �� 5   
   $��
Автор��6   $��1��6!   $��Center=�6.   $��Center=�6K   $��20(�6f   6v   �� 5   
   $��Жанр��6   $��2��6    $��Center=�6-   $��Center=�6J   $��20(�6e   6u   �� 5   
   $��Издательство��6   $��3��6(   $��Center=�65   $��Center=�6P   $��20(�6m   �� 5   
   $!��Год публикации��6   $��Center=�6*   $��Center=�6G   $��4��6b   $��18(�6o   �� 5   
   -   5        $��NameTextBox��5   N   $��1��6a   $��0��6q   $	��170��6~   $��Center=�6�   $��Center=�6�   ��6   �� *title+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5    
   -   5         ��Name$ ComboStatusGenre��5    Y   $��1��6<   $��2��6L    �� DisplayMemberPath$ name_gen��6s   $	��130��6�   $��Center=�6�   $��Center=�6�    �� SelectedItem 6   �� *Genre.name_gen+6�   �� 5!   
   -   5        $��BtnSave��5!   F   $��Сохранить��6   $��2��6%   $��9��69   $��136,10,136,10q�6k   ���	#FFAB917A
�������$��20(�6�   ��6�   Z� 6�   �� 5"   
   -   5         ��Name$ 	Publisher��5"      $��1��6@   $	��170��6P   $��Center=�6\   $��Center=�6y   $��3��6�   ��6%   �� *	publisher+6�   �� 5#   
   -   5        $
 Year��5#      $��1��6!   $	��170��61   $��Center=�6=   $��Center=�6Z   $��4��6u   6�   �� 5$   
   -   5        $ AuthorTextBox��5$   3   $��1��6J   $��1��6Z   $	��246��6g   $��Center=�6s   $	��Top=�6�   $��0,27,0,0q�6�   ��6   �� *Author.name_aut+6�   �� 5%   
   $��Описание��6   $��Center=�6$   $��Center=�6A   $��5��6\   $��20(�6i   �� 5&   
   -   5        $ Descrip��5&   2   $��1��6D   $	��170��6T   $��Center=�6`   $��Center=�6}   $��5��6�   ��6   �� *C_description+6�   �� 5'   
   -   5         ��Name$ langug��5'      $��Язык��6$   $
��Left=�60   $��Center=�6K   $��6��6f   $��20(�6s   $��53,0,0,0q�6�   �� 5(   
   -	   5        $ lagug��5(   /   $��1��6?   $	��170��6O   $��Center=�6[   $��Center=�6x   $��6��6�   ��6   �� *
C_language+6�   5)      5*      