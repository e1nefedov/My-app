   M S B A M L   `   `   `  ����I  EMy-app-company, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:My_app_company.PagesMy_app_company.Pages  5      $    My_app_company.Pages.PageZakaz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:My_app_company.Pages     5        N� Title$  	PageZakaz��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� ���#3f53b1$��40��6.   $ 
Horizontal=�6:   $	��Top=�5      .+�5      �� -   5        $��btnAdd��5      $0��*+ Добавить новую запись��5      $
��Auto��5      $��20��5      ���#3f53b1
����������#3f53b15   '   �� 5       �� CornerRadius$ 10��6   
�������$��4q�6?   
�������$��	400 0 0 0q�5      $��30��5      ._�5      �� -   5        $��	txtSearch��5      $��0q�5      
�������$��25��5      $	��230��5       5"      5#      �� 5$      $ 
Horizontal=�6   $
��Auto��61   ���#eaeaea.+�5%      9� $��Сортировка��6   $
��Auto��6/   .��5&      �� $ Vertical=�6!   .+�5'      �� $ 
Horizontal=�6%   .+�5(      	� -   5        $��
SortKlient��5)   !   $��По клиентам��5*   !    
  mainRb#��[  5+   !   5,   !   	� 5-      -   5        $��
SortUslugi��5.   !   $��По услугам��5/   !   #��[  50   !   51   !   	� 52      -   5        $��SortSotr��53   !   $!��По сотрудникам��54   !   #��[  55   !   56   !   57      &   System.Windows.Controls.DataGrid  58      -   5        $��grdSortZakaz��58   #      
IsReadOnly .    AutoGenerateColumns .     Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5<   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заказа��65      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6h      
FontFamily$ arial)�6u   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6K   �� *
id_zakaz+6u     5=   "   $ Сотрудник��65   $
 Auto 6l   	 6H   �� *sotrudniki.name+6l     5>   "   $ Клиент��65   $
 Auto 6e   	 6E   �� *klient.name+6e     5?   "   $ Договор��65   $
 Auto 6m   	 6F   �� *dogovor.id_dogovor+6m     5@   "   $ Услуга��65   $
 Auto 6e   	 6E   �� *uslugi.name+6e   5B      5C      5D      5E      �� 5F      $ Vertical=�6   $	��450��61   .+�5G        -   5        $��grdZakaz��5G       .  .   5H        5I      $ Номер заказа��6-   $ * 6`   $ arial)�6j   	 6C   �� *
id_zakaz+6j     5J      $ Сотрудник��6-   $ * 6d   	 6@   �� *sotrudniki.name+6d     5K      $ Клиент��6-   $ * 6]   	 6=   �� *klient.name+6]     5L      $ Договор��6-   $ * 6]   	 6>   �� *
id_dogovor+6]     5M      $ Услуга��6-   $ * 6]   	 6=   �� *uslugi.name+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5N      
   CellTemplate
 5O      �� 5P   "   .R�5Q   &   �� $ 
Horizontal=�61   .+�5R   *   �� $��btnEdit��5S   -   -   5          grdBtng#��[ 5T   -   $
��Edit��5U   -   5V   -   �� 5X   *   $��btnDel��5Y   -   -	   5        #��[ 5Z   -   $	��Del��5[   -   5\   -   5^   '   5_   #   5a      5d      5e      5f      5g      5h      