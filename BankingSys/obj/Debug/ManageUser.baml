   M S B A M L   `   `   `  ����E  ABankingSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingSys
BankingSys  5          BankingSys.ManageUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingSys     5        N� Title$  
ManageUser��5	      .��5      � .+�5   
   �� -   5        $
��name��5      $��30(�6    $
��Left=�6.   $��50��6I   $��
170,15,0,0q�6U   $
��Wrap=�6i   $��Managing user: ��6}   $	��Top=�6�   $	��579��6�   �� 5   
   -   5        $
��Back��5      $��25,21,675,0q�6    $��26��65   $	��Top=�6A   6Y   �� 5   
   -   5        $��Deposit��5      $��31,185,619,0q�6#   $��40��69   $	��Top=�6E   6]   �� 5   
   -   5        $��Withdraw��5      $��190,185,460,0q�6$   $��40��6;   $	��Top=�6G   6_   �� 5   
   -   5         ��Name$ Amount��5      $��20(�6"    �� TextAlignment$ Center=�60   $
��Left=�6G   $��
75,134,0,0q�6b    �� TextWrapping$
 Wrap=�6v   $��Amount��6�   $	��Top=�6�   $	��236��6�   $��34��6�   6�   �� 5   
   -   5        $��Change Password��5      $��126,306,538,0q�6+   $��23��6B   $	��Top=�6N   6f   �� 5   
   -   5        $ NewPass��5      $��20(�6#   $ Center=�61   $
��Left=�6H   $��
76,257,0,0q�6c   $
 Wrap=�6w   $��New Password��6�   $	��Top=�6�   $	��236��6�   $��34��6�   6�   �� 5   
   -   5        $��Balance��5      $��30(�6#   $
��Left=�61   $��50��6L   $��
170,65,0,0q�6X   $
��Wrap=�6l   $��	Balance: ��6�   $	��Top=�6�   $	��579��6�   �� 5   
   -	   5        $��Suspend/Unsuspend��5      $��126,350,538,0q�6-   $��23��6D   $	��Top=�6P   6h   �� 5   
   -
   5        $��Delete��5      $��125,378,539,0q�6"   $��23��69   $	��Top=�6E   6]   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Transactions��5      $
��Left=�6'   $	��290��6B   $��460,111,0,0q�6O   $	��Top=�6d   $	��270��6|      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Amount��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6P   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *Amount+6P     5      $
 Date��6>   $ * 6L   	 6%   �� *Date+6L   5      5      5      