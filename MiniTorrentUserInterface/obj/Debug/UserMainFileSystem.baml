   M S B A M L   `   `   `  ����S  OMiniTorrentUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MiniTorrentUserInterfaceMiniTorrentUserInterface  5   	   1    +MiniTorrentUserInterface.UserMainFileSystem   5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:MiniTorrentUserInterface     5   	     � Title$  UserMainFileSystem��5	   	   $��577.089��6$   $��912.006��65   .��5
      � $	��500��6   $��
10,10,19,0q�6   $	��Top=�6,   
������� � ColumnDefinitions 5   
   �� 5      $
��192* �6   �� 5      $	��94* �6   �� 5      $	��68* �6   �� 5      $
��449* �6   �� 5      $	��63* �6   �� 5      $
��209* �6   .+�5   
   �� -   5         ��Name$ lblName��5      $��Enter File Name: ��6!   $
��Left=�6=   $��	0,105,0,0q�6X   $	��Top=�6k   $��Welcome to login page)�6�   $��18(�6�    J� RenderTransformOrigin$ 0.437,1.207&�6�   $��30��6�   $	��181��6�   �� 5   
   -   5         ��Name$ tbName��5      $
��Left=�6"   $��24��6=   $��	5,109,0,0q�6I    �� TextWrapping$
 Wrap=�6\   $��TextBox��6p   $	��Top=�6   $	��155��6�   $ 
0.597,1.07&�6�   $��3��6�   $��1��6�   �� 5   
   -   5         ��Name$ btSearch��5      $��Search��6#   $
��Left=�64   $��
58,108,0,0q�6O   $	��Top=�6c   $��87��6{   $��24��6�   $ -0.199,0.559&�6�   $��3��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtGrid��5   [   $	��247��6   $	��838��6    $
��Left=�6,   $��	0,199,0,0q�6G   $	��Top=�6i      	RowHeight$ 30Q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6�   
�������$��5��6�   #��� ��6�   $ 0.5,0.5&�6  z�5      V� 5      .~�5      �� �� 5      	 �� AngleY$	 -0.285Q�6$   �� 5      T� 5      
 T� Y$
 -2.245Q�6)   5      5      �� 5    
   -   5        $ 
btDownload��5       $��Download��6%   $
��Left=�68   $��
30,446,0,0q�6S   $	��Top=�6g   $	��102��6   $��24��6�   $��5��6�   $ 	1.5,1.221&�6�   �� 5!   
   -   5        $ lblHeadLine��5!      $��	Home Page��6&   $
��Left=�6:   $��52,0,0,0q�6U   $	��Top=�6g   $��63��6   $	��532��6�   $��Welcome to login page)�6�   $��Center=�6�   $��36(�6�   $��3��6�   $��1��6   �� 5"   
   -   5        $ btLogOut��5"      $��Log Out��6$   $
��Left=�66   $��	56,28,0,0q�6Q   $	��Top=�6d   $��94��6|   $��22��6�   $ -0.388,-1.16&�6�   $��5��6�   �� 5#   
   -   5        $ lblFileSearchHeadLine��5#      $��File Search Results��6/   $
��Left=�6M   $��	0,162,0,0q�6h   $	��Top=�6{   $��Welcome to login page)�6�   $��24(�6�   $
��Thin"�6�   $��Italic$�6�   $��2��6�   $	��252��6�   $��37��6	  � 5$   
   -	   5         �Name$ process��5$      $��5��6)   $
��Left=�6=   $��25��6X   $��	0,446,0,0q�6d   $	��Top=�6w   $	��705��6�   5&      5'      