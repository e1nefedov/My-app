   M S B A M L   `   `   `  ����I  EMy-app-company, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:My_app_company.PagesMy_app_company.Pages  5      %    My_app_company.Pages.PageUslugi   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:My_app_company.Pages     5        N� Title$  
PageUslugi��5	      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� ���#3f53b1$��40��6.   $ 
Horizontal=�6:   $	��Top=�5      .+�5      �� -   5        $��btnAdd��5      $0��*+ Добавить новую запись��5      $
��Auto��5      $��20��5      ���#3f53b1
����������#3f53b15   '   �� 5       �� CornerRadius$ 10��6   
�������$��4q�6?   
�������$��	400 0 0 0q�5      $��30��5      ._�5      �� -   5        $��	txtSearch��5      $��0q�5      
�������$��25��5       $	��230��5!      5#      5$      �� 5%      $ 
Horizontal=�6   $��30��62   ���#eaeaea5'      �� 5(      $ Vertical=�6   $	��450��61   .+�5)      &   System.Windows.Controls.DataGrid  -   5        $��	grdUslugi��5)         
IsReadOnly .    AutoGenerateColumns .     Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Услуга��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V      
FontFamily$ arial)�6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *name+6`     5-      $ Стоимость��6-   $ * 6Z   	 6@   �� *price+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5/      
   CellTemplate
 50      �� 51   "   .R�52   &   �� $ 
Horizontal=�61   .+�53   *   �� $��btnEdit��54   -      grdBtng#��[  55   -   $
��Edit��56   ,   �� 58   *   $��btnDel��59   -   -   5        #��[  5:   -   $	��Del��5;   -   5<   -   5>   '   5?   #   5A      5C      5D      5E      5F      5G      