   M S B A M L   `   `   `  ����H  DWorkWithMedia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WorkWithMediaWorkWithMedia  5   	       WorkWithMedia.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WorkWithMedia     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   $	��350��65   $	��525��6E    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$
 Open��5
      6(   .��5      � .+�5   
   o� $��3��6    J� RenderTransformOrigin$ 	0.5,0.705&�6#   .@�5      m� -   5         m�Name$ FileMenuItem��5      $
��File��6-   .@�5      m� -   5        $ OpenMenuItem��5      $
��Open��61    m� Command$
 Open��6?   m� 5      -   5        $
��Exit��5      6)   5      m� 5      -   5        $ PlayerMenuItem��5      $��Player��6/   .@�5      m� -   5        $ PlayMenuItem��5      $
��Play��61   6?   m� 5      -   5        $ PauseMenuItem��5      $��Pause��62   6A   5      5      �� 5   
   .+�5      r� -   5         r�Name$ CustomPlayer��5      $��20, 20, 20, 0q�61    r� Stretch$
 Fill=�6H   5   @   �� 5      -	   5         ��Name$ 
TimeSlider��5      $��20, 0q�6)   $y�Hidden=�68   	 � Value$	 0Q�5      5      5      5      