   M S B A M L   `   `   `  ����D  @EnsasWare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EnsasWare	EnsasWare  5          EnsasWare.GestionFiliere   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:EnsasWare     5      a ]Telerik.Windows.Data, Version=2018.1.220.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2018.1.220.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2018.1.220.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Ctelerik1http://schemas.telerik.com/2008/xaml/presentation    5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��1080��5	      $	��460��6,   ���	#F6FFFFFF.��5
      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5
   *   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6M   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromTop+   Duration$ 0:0:0.5X�.��5   
   � -   5         �Name$ grig1��5      $
��1080��6   ��5   
   �� 5       �� ImageSource$ fil_img.png��6   .+�5   
   *  $Telerik.Windows.Controls.RadCarousel  -   5          Name$ radfil��5      $
��Left=�6.   $��	28,10,0,0q�6I   $	��Top=�6\   $	��244��6t   $	��990��6�   ���	#19FFFFFF6�   � 5   
   -   5        $ controlgrid��5      $
��Left=�6$   $	��188��6?   $��262,272,0,0q�6L   $	��Top=�6a   $	��484��6y   ���	#75E3EEF7 � ColumnDefinitions 5      �� 5      $
��224* �6#   �� 5      $
��261* �6#   .+�5      �� $��ID Filière��6   $
��Left=�6)   $��	55,23,0,0q�6D   $	��Top=�6W   $��92��6o   ���	#FFDEBDBD
���   ���6z   Z� 6�   �� 5      $
��Left=�6   $��30��61   $��
168,23,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��175��6�   $��2��6�   ��6�   Z� 6�   �� 5      $
��Left=�6   $��30��61   $��
168,62,0,0q�6=   $
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��175��6�   $��2��6�   ��6�   Z� 6�   �� 5      $��Nom Filière��6   $
��Left=�6*   $��	55,66,0,0q�6E   $	��Top=�6X   $��92��6p   
���   �6{   �� 5      -   5         ��Name$ modifierFil��5      $��Modifier��6*   $
��Left=�6=   $��34��6X   $��180,130,0,0q�6d   $	��Top=�6y   $	��110��6�   $��2��6�   �� 5      -   5        $ supprimerFil��5      $��	Supprimer��6+   $
��Left=�6?   $��34��6Z   $��86.5,130,0,0q�6f   $	��Top=�6|   $	��105��6�   $��1��6�   �� 5      -   5        $ 
ajouterFil��5      $��Ajouter��6)   $
��Left=�6;   $��34��6V   $��
41,130,0,0q�6b   $	��Top=�6v   $	��115��6�   6�   5      5       5!      5"      