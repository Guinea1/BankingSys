   M S B A M L   `   `   `  ����E  ABankingSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingSys
BankingSys  5          BankingSys.AdminPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingSys     5        N� Title$  
AdminPanel��5	      .��5      � .+�5   
   �� $��30(�6   $
��Left=�6"   $��50��6=   $��
57,135,0,0q�6I   $
��Wrap=�6]   $��Manage User��6q   $	��Top=�6�   $	��184��6�   �� 5   
   -   5         ��Name$
 User��5      $��20(�6     �� TextAlignment$ Center=�6.   $
��Left=�6E   $��
32,190,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $��Username��6�   $	��Top=�6�   $	��236��6�   $��34��6�   6�   �� 5   
   -   5        $��Manage��5      $��74,247,576,0q�6"   $��40��68   $	��Top=�6D   6\   �� 5   
   -   5        $��Logout��5      $��604,0,46,30q�6"   $��40��67   $��Bottom=�6C   6^   �� 5   
   -   5        $
��name��5      $��30(�6    $
��Left=�6.   $��50��6I   $��	34,47,0,0q�6U   $
��Wrap=�6h   $��Welcome,��6|   $	��Top=�6�   $	��688��6�   �� 5   
   -   5        $��Create Admin Account��5      $��325,165,325,0q�60   $��40��6G   $	��Top=�6S   6k   �� 5   
   -   5        $��
My Account��5      $��325,225,325,0q�6&   $��40��6=   $	��Top=�6I   6a   �� 5   
   -   5        $��
TotalMoney��5      $��30(�6&   $
��Left=�64   $��50��6O   $��
32,336,0,0q�6[   $
��Wrap=�6o   $��Total Money: ��6�   $	��Top=�6�   $	��522��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	Customers��5      $
��Left=�6$   $	��298��6?   $��
517,18,0,0q�6L   $	��Top=�6`   $	��237��6x      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *
Username+6T     5      $ Balance��6A   $ * 6R   	 6%   �� *	Balance+6R   5      5      5      