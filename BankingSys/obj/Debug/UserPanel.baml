   M S B A M L   `   `   `  ����E  ABankingSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingSys
BankingSys  5          BankingSys.UserPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingSys     5        N� Title$  	UserPanel��5	      .��5      � .+�5   
   �� -   5        $��balance��5      $��30(�6#   $
��Left=�61   $��59��6L   $��
52,129,0,0q�6X   $
��Wrap=�6l   $��Your Balance:��6�   $	��Top=�6�   $	��366��6�   �� 5   
   -   5        $��Deposit��5      $��52,0,598,168q�6#   $��40��69   $��Bottom=�6E   6`   �� 5   
   -   5        $��Withdraw��5      $��52,0,598,97q�6$   $��40��69   $��Bottom=�6E   6`   �� 5   
   -   5        $��
My Account��5      $��52,0,598,25q�6&   $��40��6;   $��Bottom=�6G   6b   �� 5   
   -   5        $
��name��5      $��30(�6    $
��Left=�6.   $��59��6I   $��	52,65,0,0q�6U   $
��Wrap=�6h   $��Welcome,��6|   $	��Top=�6�   $	��366��6�   �� 5   
   -   5        $��Logout��5      $��604,0,46,30q�6"   $��40��67   $��Bottom=�6C   6^   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Transactions��5      $
��Left=�6'   $	��289��6B   $��
483,23,0,0q�6O   $	��Top=�6c   $	��271��6{      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Amount��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Amount+6P     5      $
 Date��6>   $ * 6L    6%   �� *Date+6L   5      5      5      