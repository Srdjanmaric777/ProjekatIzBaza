   M S B A M L   `   `   `  ����F  BTeretanaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TeretanaWPF.ViewTeretanaWPF.View  5   	        TeretanaWPF.View.Zaposleni   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TeretanaWPF.View     5   	     � Title$  	Zaposleni��5   	   $	��310��6   $	��620��6(   .��5	      � 
��� ��� � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� -   5         ��Name$ dodajButton��5      $��Dodaj��6*   $��88��6:   6F   �� 5      -   5        $ deleteButton��5      $��Izbrisi��6+   $��88��6=   6I   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   #   $��1��6      AutoGenerateColumns .  $	��265��6~   $
��Left=�6�   $	��Top=�6�   $	��500��6�      SelectionMode$ Single=�6�      
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ IDBedz��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *IdBedz+  5      $	 Ime��6%   $	 * 62   
 6<   �� *Ime+  5      $ Prezime��6%   $	 * 66   
 6@   �� *	Prezime+  5      $	 Tip��6%   $	 * 62   
 6<   �� *Tip+5      5!      5"      