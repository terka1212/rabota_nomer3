   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	   !    курсовая.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $
��1000��6   $
��1500��6*   ���#2C3E50 � 
ResizeMode$ NoResize=�6L   .��5
      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 �� Triggers P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 �� To g� Duration N� ExitActions&   System.Windows.Controls.DataGrid��%�  '��       '��     '��     '      �� 5      " ��6   .�5      ��  � ��
 �����6/   �� 5       � �� �#2980B96/   �� 5       � ��
 ���� 60   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ 5q�6+   �� 5       � ��$
 10,5q�6,   �� 5       �@�Cursor$
 Hand��6+   �� 5       � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $ border��6)   #��z��69   #��z��6c   $��1q�6�   $	 5��6�   �� 5   "   $��Center=�63   $��Center=�6P   5      
 5      P� 5   "    �@J�IsMouseOver .  5   &   �� 5   *   .��5    .   �� .��5!   2   �� $ border��6A   $1 +(Border.Background).(SolidColorBrush.Color)�6`   $ #1ABC9CX�6�   $ 0:0:0.3D�6�   5"   /   5#   +    5%   &   �� 5&   *   .��5'   .   �� .��5(   2   �� $ border��6A   $1 +(Border.Background).(SolidColorBrush.Color)�6`   $ #2980B9X�6�   $ 0:0:0.3D�6�   5)   /   5*   +   5,   #   5.      50      51      �� 52      " ��6   .�53      ��  � ��$ Segoe UI)�6/   �� 54       � ��$ 14(�6-   �� 55       � ��$ 5q�6+   �� 56       � ��$ 5q�6,   �� 57       � �� �#2980B960   �� 58       � ��
 �����6/   59      �� 5:      " ��6   .�5;      ��  � ��$ Segoe UI)�6/   �� 5<       � ��$ 14(�6-   �� 5=       � ��$ 5q�6+   �� 5>       � ��$ 5q�6,   �� 5?       � �� �#2980B960   �� 5@       � ��
 �����6/   5A      �� 5B      "  6   .�5C      ��  � ��$ Segoe UI)�6/   �� 5D       � ��$ 14(�6-   �� 5E       � ��$ 10q�6+   �� 5F       �@ RowBackground �#ECF0F162   �� 5G        �@ AlternatingRowBackground �#BDC3C76=   �� 5H       � �� �#2C3E506/   �� 5I       �@ GridLinesVisibility$
 None=�68   5J      5K       � RowDefinitions 5M   
   �� 5N      $	��784 �6   �� 5O      $	��216 �6   .+�5R   
     -   5          Name$ BookService��5R         CanUserAddRows .     AutoGenerateColumns .  $��0,50,0,0q�6[      
IsReadOnly . ���#2980B9���#ECF0F1   Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T      -   5        
IdBook��,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��5T   5      
Foreground �#E74C3C1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	id_source+6y     5U      -   5        	Title��$ Название��5U   4    6F   �� *title+6b     5V      -   5        
Author��$ 
Автор��5V   5    6D   �� *Author.name_aut+6j     5W      $ Тема��6%    63   �� *Topic.name_topic+6Z     5X      $ Язык��6%    63   �� *
C_language+6T     5Y      $
 ISBN��6%    63   �� *isbn+6N     5Z      -   5        
Publisher1��$ Издательство��5Z   9    6O   �� *	publisher+6o     5[      $! Год публикации��6%    6=   �� *publication_year+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5\         Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6)      CellTemplate 5]      �� 5^      .R�5_      ��  ��Name$ BtnMore��6;   -   5        $��Подробности��5_   %   $
��auto��6b   $��50��6o   5`      5b        5c      $
 auto 6)    5d      �� 5e      .R�5f      �� $ BtnEdit��6=   -   5        $ ��Редактировать��5f   %   $
��auto��6d   $��50��6q   5g      5i      5k      �� 5m   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	10,10,0,0q�6a   $��30��6t   $	��492��6�   .+�5n      �� $��
Поиск��6   $��16(�6%   
�������$��Center=�6F   �� 5o      -   5          ��Name$  	SearchBox��5o      $	��200��6)   $��30��65   $��10,0,0,0q�6A   $��Center=�6S   6n   �� 5p      -	   5        ! ��Name$! CategoryComboBox��5p      $	��200��6\   $��30��6h   $��10,0,0,0q�6t   $��Center=�6�   " �� DisplayMemberPath$" name_cat��6�   # �� SelectedItem# 61   �� *Category.name_cat+5q      5r      �� 5t   
   $ Vertical=�6   $��Right=�6,   $	��Top=�6H   $��	0,10,10,0q�6`   .+�5u      �� -
   5        $ ��Name$$ UserNameTextBlock��5u      $��16(�63   
�������$��Right=�6T   5v      �� 5x   
   -   5        $��BtnAdd��5x   L   $��Добавить��6   $��1��6$   $
��Left=�61   $��10,20,0,108q�6o   $	��117��6�   �� 5y   
   -   5        $��BtnAuthorization��5y   M   $��Вернуться��6   $��1��6%   $
��Left=�62   $��443,20,0,108q�6�   $	��117��6�   �� 5z   
   -   5        $��BtnUp��5z   L   $��Обновить��6   $��1��6$   $
��Left=�61   $��232,20,0,108q�6m   $	��117��6�   �� 5{   
   -   5        $��BtnDelet��5{   L   $��Удалить��6   $��1��6#   $��Right=�60   $��0,20,720,108q�6s   $	��116��6�   5}      5~      