   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	       курсовая.Review_   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � Title$  Review_��5   	   $	��450��6   $	��800��6&   ���#2C3E50 � 
ResizeMode$ NoResize=�6G   .��5	      �  � 	Resources 5
   
    �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius	 �� Triggers
 P� Property P� Value N� EnterActions �� 
TargetName �� TargetProperty	 �� To g� Duration N� ExitActions&   System.Windows.Controls.DataGrid��%�  '��       '��     '      �� 5      " ��6   .�5      ��  � ��
 �����6/   �� 5       � �� �#2980B96/   �� 5       � ��
 ���� 60   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$ 14(�6-   �� 5       � ��$ 5q�6+   �� 5       � ��$
 10,5q�6,   �� 5       �@�Cursor$
 Hand��6+   �� 5       � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $ border��6)   #��z��69   #��z��6c   $��1q�6�   $ 5��6�   �� 5   "   $��Center=�63   $��Center=�6P   5      	 5      P� 5   "   
 �@J�IsMouseOver .  5   &   �� 5   *   .��5   .   �� .��5    2   �� $ border��6A   $1 +(Border.Background).(SolidColorBrush.Color)�6`   $ #1ABC9CX�6�   $ 0:0:0.3D�6�   5!   /   5"   +    5$   &   �� 5%   *   .��5&   .   �� .��5'   2   �� $ border��6A   $1 +(Border.Background).(SolidColorBrush.Color)�6`   $ #2980B9X�6�   $ 0:0:0.3D�6�   5(   /   5)   +   5+   #   5-      5/      50      �� 51      " ��6   .�52      ��  � ��$ Segoe UI)�6/   �� 53       � ��$ 14(�6-   �� 54       � ��$ 5q�6+   �� 55       � ��$ 5q�6,   �� 56       � �� �#2980B960   �� 57       � ��
 �����6/   58      �� 59      "  6   .�5:      ��  � ��$ Segoe UI)�6/   �� 5;       � ��$ 14(�6-   �� 5<       � ��$ 10q�6+   �� 5=       �@ RowBackground �#ECF0F162   �� 5>        �@ AlternatingRowBackground �#BDC3C76=   �� 5?       � �� �#2C3E506/   �� 5@       �@ GridLinesVisibility$
 None=�68   5A      5B      .+�5D   
     -   5          Name$ 
BookReview��5D         CanUserAddRows .     AutoGenerateColumns .  $��10,10,10,67q�6Z      
IsReadOnly . ���#2980B9���#ECF0F1   CanUserResizeColumns .     Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Отзыв��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *review_text+6T     5G      $ Оценка��6%   $
 auto 6P    65   �� *rating+6P     5H      $ Дата��6%   $
 auto 6S    63   �� *review_date+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5I      $
 auto 6)      CellTemplate 5J      �� 5K      .R�5L      ��  ��Name$ 	BtnDelete��67   -   5        $��Удалить��5L   %   $
��auto��6b   $��40��6o   5M      5O      5Q      �� 5S   
    �� Orientation$ 
Horizontal=�6   $��
10,0,10,10q�6.   $��Bottom=�6B   $��Right=�6]   .+�5T      �� -   5        $!��Добавить отзыв��5T      $	��136��6.   $��40��6:   6F   5U      5V      5W      