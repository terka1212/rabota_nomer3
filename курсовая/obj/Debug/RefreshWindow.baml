   M S B A M L   `   `   `  ����K  Gкурсовая, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:курсоваякурсовая  5   	   $    курсовая.RefreshWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:курсовая     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ RefreshWindow��5	   	   $	��400��6   $	��600��6,   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFFFD2A4��6   � 5      $ 	#FFFDA3A3��6    � Offset$ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��Издательство��6   $��0��6(   $��Center=�65   $��Center=�6R   6o   �� 5   
   $��Год издания��6   $��1��6'   $��Center=�64   $��Center=�6Q   6n   �� 5   
   $��Язык��6   $��2��6    $��Center=�6-   $��Center=�6J   6g   �� 5!   
   $��Описание��6   $��Center=�6$   $��Center=�6A   $��3��6\   $��16(�6i   �� 5"   
   -   5         ��Name$ DescriptionTextBox��5"   1   	 �� TextWrapping$
	 Wrap=�6M   $��1��6a   $	��170��6q   $��Center=�6}   $��Center=�6�   $��3��6�   $��54��6�   ��6   �� *C_description+6�   �� 5$   
   -   5        $ 	Publisher��5$      $��1��6A   $��0��6Q   $	��170��6^   $��Center=�6j   $��Center=�6�   ��6%   �� *	publisher+6�   �� 5%   
   -   5        $ year_publish��5%      $��1��6K   $	��170��6[   $��Center=�6g   $��Center=�6�   $��1��6�   ��6(   �� *publication_year+6�   �� 5&   
   -   5        $��BtnSave��5&   F   $��Сохранить��6   $��2��6%   $��4��69   $��Center=�6k   $��Center=�6�   $	��236��6�   $��48��6�   ���	#FFC76060
���   �$��Italic$�6�   $��	Condensed&�6�   ���	#FFFF99996  �� 5'   
   -   5        $ language��5'      $��1��6A   $	��170��6Q   $��Center=�6]   $��Center=�6z   $��2��6�   ��6$   �� *
C_language+6�   5*      5+      