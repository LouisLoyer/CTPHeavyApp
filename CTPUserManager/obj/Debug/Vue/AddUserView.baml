   M S B A M L   `   `   `  ����I  ECTPUserManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CTPUserManager.VueCTPUserManager.Vue  5   	   $    CTPUserManager.Vue.AddUserView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CTPUserManager.Vue     5   	     � Title$  AddUserView��5   	   $	��600��6   $	��400��6*   ���#5C88DA.��5	      �� ���#2e3137 �� CornerRadius$ 20��6"   $��20,20,20,10q�64   ._�5
      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��40 �6   6*    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   .+�5      �� $��Ajouter un utilisateur��6   
�������$��0��6H   $��0��6U   $��28(�6e   $��Center=�6s   6�   �� 5      $��Email:��6   
�������$��1��68   $��18(�6E   6U   �� 5      -   5         ��Name$ usrname��5      $��
95,0,15,40q�6'   $��1��6;   ���#545d6a
�������$��20(�6p   6�   �� 5      $
��MDP:��6   
�������$��2��66   $��18(�6C   6S   �� 5      -   5        $ usrpsw��5      $��
95,0,15,40q�6&   $��2��6:   ���#545d6a
�������$��20(�6o   6   �� 5       $��Prénom:��6   
�������$��3��69   $��18(�6F   6V   �� 5!      -   5        $ usrfirstname��5!      $��
95,0,15,40q�6,   $��3��6@   ���#545d6a
�������$��20(�6u   6�   �� 5#      $
��Nom:��6   
�������$��4��66   $��18(�6C   6S   �� 5$      -   5        $ usrlastname��5$      $��
95,0,15,40q�6+   $��4��6?   ���#545d6a
�������$��20(�6t   6�   �� 5&      $��	Suspendu:��6   
�������$��5��6;   $��18(�6H   6X   �� 5(      -   5         ��Name$ usrissuspended��5(      $��
95,0,15,40q�6/   $��5��6C   ���#545d6a$��20(�6f   .@�5)      ��  �� 
IsSelected . .��61   Faux67   �� 5*      .��6   Vrai6%   5+      �� 5-      $��IDRôle:��6   
�������$��6��69   $��18(�6F   6V   �� 5/      -   5        $ 	usrroleid��5/      $��
95,0,15,40q�6+   $��6��6?   ���#545d6a$��20(�6b   .@�50      ��  . .��61   164   �� 51      .��6   26"   �� 52      .��6   36"   �� 53      .��6   46"   �� 54      .��6   56"   �� 55      .��6   66"   �� 56      .��6   76"   57      �� 59      -   5        $��Ajouter��59   ,   $��7��6>   $��15,-15,15,15q�6K   ���#545d6a
�������$��25(�6�   {�. 6�   5<      5=      5>      