   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	       курсовая.Review_   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � Title$  Review_��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
BookReview��5
         CanUserAddRows .     AutoGenerateColumns .  $��0,0,0,67q�6Z      
IsReadOnly . 
����������	#FFD8D2CF   CanUserResizeColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Отзыв��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *review_text+6T     5      $ Оценка��6%   $
 auto 6P   	 65   �� *rating+6P     5      $ Дата��6%   $
 auto 6S   	 63   �� *review_date+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ 	BtnDelete��67   -   5        $��Удалить��5   %   $
��auto��6b   5      5      5      �� 5   
    �� Orientation$ Vertical=�6   $��
10,0,10,10q�6,   $��Bottom=�6@   .+�5      �� -   5        $!��Добавить отзыв��5      $	��136��6.   $��40��6:   ���	#FFFBAA82���	#FFF3F3F3$��16(�6�   5      5      5      