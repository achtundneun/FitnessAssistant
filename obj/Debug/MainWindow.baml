   M S B A M L   `   `   `  ����f  bFitnessAssistant_Nikitin_Liventsev2ISP11-17, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:FitnessAssistant_Nikitin_Liventsev2ISP11_17+FitnessAssistant_Nikitin_Liventsev2ISP11_17  5   	   <    6FitnessAssistant_Nikitin_Liventsev2ISP11_17.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:FitnessAssistant_Nikitin_Liventsev2ISP11_17     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��650��5
   	   $	��800��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� ���	#FF3838B6$��5��5!      $��0,0,0,40q�5"      $��2��5#      �� 5%   
   $����Данная утилита отлично справляется не только с подсчетом калорий, но и 
подборкой персональной диеты, учетом физических нагрузок, подробным 
анализом продуктов и не только.��5&      $��19(�5'      $��45��5(      $��Center=�5)      
������� �� TextAlignment$ Center=�5+      $	��800��5,      $��10,40,10,45q�5-      $��2��5.      �� 50   
   $#��Фитнес помощник��51      $��24(�52      $��5��53      $��Center=�54      
�������55      �� 57   
   $��1��58      $!��АВТОРИЗУЙТЕСЬ:��59      $��5��5:      $��Center=�5;      $��Bottom=�5<      $��16(�5=      ���	#FF3838B65>      �� 5@   
   $��
Логин��5A      $��2��5B      $��1��5C      $��Center=�5D      $��Center=�5E      $��20(�5F      ���	#FF3838B65G      �� 5I   
   $��Пароль��5J      $��3��5K      $��1��5L      $��Center=�5M      $��Center=�5N      $��20(�5O      ���	#FF3838B65P      �� 5R   
   -   5         ��Name$ Login��5U      $��Center=�5S      $��23��5T      $��1��5V       �� TextWrapping$
 Wrap=�5W      $��2��5X      $��2��5Y      $	��Top=�5Z      $	��152��5[      $��1,30,6,0q�5\      ���	#FF1545D65]      �� 5_   
   -   5        $ Password��5b      $��Center=�5`      $��23��5a      $��1��5c      $
 Wrap=�5d      $��3��5e      $��2��5f      $��Center=�5g      $	��152��5h      $��1 2 6 0q�5i      ���	#FF1545D65j      �� 5l   
   -   5         ��Name$ BtnEnter��5m      $��
Войти��5o      $��20(�5p      $	��150��5q      $��40��5r      $��4��5s      $��5��5t      $��Center=�5u      $��Center=�5v      ���	#FF3838B6
�������5x      �� 5z   
   $��5��5{      $��5��5|      $��0 0 0 10q�5}      $��Bottom=�5~      .+�5�      �� $��Нет аккаунта?��5�      $��15(�5�      
����  �$��Center=�5�      �� 5�      -   5         ��Name$ Registration��5�      $��Center=�5�      �� 5�      -   5        .�5�   )   &$Зарегистрироваться5�      5�      5�      5�      5�      