   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=0.14.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    StargateArmALauncher%   StargateArmALauncher.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5          � Title$  Stargate ArmA Launcher��5   	   $	��500��6(   $	��800��65    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W    � Icon$! Resources/stargate-arma.ico��6|    � 	Resources 5         logoicon �� 	UriSource �� CreateOptions �� CacheOption  MetroTabItem �� BasedOn	 �� 
TargetType+   %MahApps.Metro.Controls.ControlsHelper
 �� Property �� Value��%�   &	        '�� w     7  �� 5   
   $5 /pack://siteoforigin:,,,/Resources/logo-icon.png?�6'   $ IgnoreImageCache=�6c   $ OnLoad=�6�   �� 5	   
   8   "	 ��68   .�5
      �� 
 �@ HeaderFontSize$ 16Q�6G   6T   5      5      (   "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��goto website��6   �� 5      $��about��6   5      .��5      � .+�5   
   �� $
��Left=�6   $	��451��60   $��	10,10,0,0q�6=   $	��Top=�6P   $	��774��6h   .@�5      �� $
��Main��6   $��Bottom=�6$   .��5      � ���	#FFE5E5E5.+�5      �� $��Main server status:��6   $
��Left=�6:   $��	10,50,0,0q�6U   $	��Top=�6h   �� 5      $��State:��6   $
��Left=�6-   $��	10,75,0,0q�6H   $	��Top=�6[   �� 5      -   5         ��Name$ label_main_serveronline��5      $��online��6=   $
��Left=�6N   $��
200,50,0,0q�6i   $	��Top=�6}   �� 5      $��all updated��6   $
��Left=�62   $��
200,75,0,0q�6M   $	��Top=�6a   �� 5      -   5         ��Name$ textbox_main_infotext��5       �� TextWrapping$
 Wrap=�6=   $��infobox��6Q   $��400,20,10,20q�6`   {�.  6v   �� 5      -   5        $��
Start Game��5      $
��Left=�6Q   $��
10,375,0,0q�6l   $	��Top=�6�   $	��100��6�   5       5!      �� 5"      $��Updater��6   .��5#      � ���	#FFE5E5E5.+�5$      �� $��launcher version��6   $
��Left=�67   $��	10,50,0,0q�6R   $	��Top=�6e   �� 5%      $��0.0.100��6   $
��Left=�6.   $��
200,50,0,0q�6I   $	��Top=�6]   �� 5&      $��latest launcher version:��6   $
��Left=�6?   $��	10,75,0,0q�6Z   $	��Top=�6m   �� 5'      $��0.0.101��6   $
��Left=�6.   $��
200,75,0,0q�6I   $	��Top=�6]   �� 5(      $��installed mod version��6   $
��Left=�6<   $��
10,120,0,0q�6W   $	��Top=�6k   �� 5)      $��0.0.100��6   $
��Left=�6.   $��200,120,0,0q�6I   $	��Top=�6^   �� 5*      $"��latest stable build version:��6   $
��Left=�6C   $��
10,145,0,0q�6^   $	��Top=�6r   �� 5+      $��0.0.101��6   $
��Left=�6.   $��200,145,0,0q�6I   $	��Top=�6^   �� 5,      $��latest dev build version:��6   $
��Left=�6@   $��
10,170,0,0q�6[   $	��Top=�6o   �� 5-      $��0.0.102��6   $
��Left=�6.   $��200,170,0,0q�6I   $	��Top=�6^   �� 5.      $
 Wrap=�6   $��	changelog��62   $��400,20,10,60q�6C   {�.  6Y   �� 5/      -   5         ��Name$ combobox_branch��5/      $
��Left=�68   $��128,223,0,0q�6S   $	��Top=�6h   $	��257��6�   �� 50      $��build��6   $
��Left=�6,   $��
73,223,0,0q�6G   $	��Top=�6[   �� 51      -   5        $ combobox_dlserver��51      $
��Left=�6:   $��129,271,0,0q�6U   $	��Top=�6j   $	��256��6�   �� 52      $��download-server��6   $
��Left=�66   $��
12,271,0,0q�6Q   $	��Top=�6e   �� 53      -   5         ��Name$ button_updater_updateMod��53      $��
Update Mod��6?   $
��Left=�6T   $��285,321,0,0q�6o   $	��Top=�6�   $	��100��6�   �� 54      -   5        $# button_updater_updateLauncher��54      $��Update Launcher��6D   $
��Left=�6^   $��
12,321,0,0q�6y   $	��Top=�6�   $	��120��6�   � 55      $
��Left=�6"   $��
12,385,0,0q�6=   $	��Top=�6Q   $	��748��6i   $��25��6u   �� 56      $(��"downloading sga_core.pbo... (2/12)��6   $
��Left=�6I   $��
10,365,0,0q�6d   $	��Top=�6x   $	��400��6�   $��11(�6�   57      58      59      5:      5;      