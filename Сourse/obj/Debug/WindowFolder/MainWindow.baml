   M S B A M L   `   `   `  ����B  >Сourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:СourseСourse  5   	       Сourse.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Сourse     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Текстиль��5   	   $	��800��6   $
��1200��6'   $	��800��64   $	��900��6D   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��240 �6   �� 5      $��* �6   .+�5   
   � .+�5      ��  �� CornerRadius$ 	0 100 0 0��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#FFCEB49B��6'   � 5      $ 	#FFC5AC93��6'    � Offset$ 1Q�69   5      ._�5      �� .+�5      ��    LogoAuzhorization#��[  6   $	��100��6G   $	��100��6T    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   Color$	 Black��6/   
   ShadowDepth$
 4Q�6=      RenderingBias$ Performance=�6M      	Direction$	 300Q�6i      
BlurRadius$ 4Q�6y      Opacity$	 0.2Q�6�   5      �� 5      -   5        $��ListMain��5        ListTape#��[ 6/   .@�5      �� .��5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��Каталог��6,    
 TbList#��[ 6;   5       5!      �� 5"      .��5#      �� $ 
Horizontal=�6)   .+�5$   "   �� $��Корзина��6,   #��[ 6;   5%      5&      �� 5'      .��5(      �� $ 
Horizontal=�6)   .+�5)   "   �� $#��Добавить данные��6,   #��[ 6C   5*      5+      �� 5,      .��5-      �� $ 
Horizontal=�6)   .+�5.   "   �� $!��Изменить товар��6,   #��[ 6B   5/      50      51      52      53      54       � 55   
   -   5        $��FrmMain��55       $��1��6   6    56      57      