   M S B A M L   `   `   `  ����K  GMemory Test Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Memory_Test_GameMemory_Test_Game  5      #    Memory_Test_Game.WordToPicure   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Memory_Test_Game     5        N� Title$  WordToPicure��5	      .��5      � 
�������.+�5   
   �� $��Word-To-Picture��6   $
��Left=�6*   $	��100��6E   $��
600,30,0,0q�6R   $	��Top=�6f   $	��370��6~   $��48(�6�   (� 5   
   $��75��6   $��75��6   $��100,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5      �� $��2q�6   ���	#FF000000._�5      �� -   5        $��WtpImg1��5      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5      5      (� 5   
   $��75��6   $��75��6   $��190,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5      �� $��2q�6   ���	#FF000000._�5      �� -   5        $��WtpImg2��5      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5      5      (� 5   
   $��75��6   $��75��6   $��280,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5      �� $��2q�6   ���	#FF000000._�5      �� -   5        $��WtpImg3��5      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5      5      (� 5   
   $��75��6   $��75��6   $��370,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5       �� $��2q�6   ���	#FF000000._�5!      �� -   5        $��WtpImg4��5!      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5"      5#      (� 5$   
   $��75��6   $��75��6   $��460,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5%      �� $��2q�6   ���	#FF000000._�5&      �� -   5        $��WtpImg5��5&      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5'      5(      (� 5)   
   $��75��6   $��75��6   $��550,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5*      �� $��2q�6   ���	#FF000000._�5+      �� -   5        $��WtpImg6��5+      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5,      5-      (� 5.   
   $��75��6   $��75��6   $��640,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5/      �� $��2q�6   ���	#FF000000._�50      �� -   5        $��WtpImg7��50      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   51      52      (� 53   
   $��75��6   $��75��6   $��730,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��54      �� $��2q�6   ���	#FF000000._�55      �� -   5        $��WtpImg8��55      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   56      57      (� 58   
   $��75��6   $��75��6   $��820,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��59      �� $��2q�6   ���	#FF000000._�5:      �� -	   5        $��WtpImg9��5:      $
��Left=�6'   $
��Fill=�6B   $	��Top=�6Q   $��75��6i   $��75��6t   6�   5;      5<      (� 5=   
   $��75��6   $��75��6   $��910,325,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5>      �� $��2q�6   ���	#FF000000._�5?      �� -
   5        $��WtpImg10��5?      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5@      5A      (� 5D   
   $��75��6   $��75��6   $��100,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5E      �� $��2q�6   ���	#FF000000._�5F      �� -   5        $��WtpImg11��5F      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5G      5H      (� 5I   
   $��75��6   $��75��6   $��190,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5J      �� $��2q�6   ���	#FF000000._�5K      �� -   5        $��WtpImg12��5K      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5L      5M      (� 5N   
   $��75��6   $��75��6   $��280,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5O      �� $��2q�6   ���	#FF000000._�5P      �� -   5        $��WtpImg13��5P      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5Q      5R      (� 5S   
   $��75��6   $��75��6   $��370,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5T      �� $��2q�6   ���	#FF000000._�5U      �� -   5        $��WtpImg14��5U      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5V      5W      (� 5X   
   $��75��6   $��75��6   $��460,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5Y      �� $��2q�6   ���	#FF000000._�5Z      �� -   5        $��WtpImg15��5Z      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5[      5\      (� 5]   
   $��75��6   $��75��6   $��550,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5^      �� $��2q�6   ���	#FF000000._�5_      �� -   5        $��WtpImg16��5_      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5`      5a      (� 5b   
   $��75��6   $��75��6   $��640,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5c      �� $��2q�6   ���	#FF000000._�5d      �� -   5        $��WtpImg17��5d      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5e      5f      (� 5g   
   $��75��6   $��75��6   $��730,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5h      �� $��2q�6   ���	#FF000000._�5i      �� -   5        $��WtpImg18��5i      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5j      5k      (� 5l   
   $��75��6   $��75��6   $��820,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5m      �� $��2q�6   ���	#FF000000._�5n      �� -   5        $��WtpImg19��5n      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5o      5p      (� 5q   
   $��75��6   $��75��6   $��910,410,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5r      �� $��2q�6   ���	#FF000000._�5s      �� -   5        $��WtpImg20��5s      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5t      5u      (� 5x   
   $��75��6   $��75��6   $��100,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5y      �� $��2q�6   ���	#FF000000._�5z      �� -   5        $��WtpImg21��5z      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5{      5|      (� 5}   
   $��75��6   $��75��6   $��190,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5~      �� $��2q�6   ���	#FF000000._�5      �� -   5        $��WtpImg22��5      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��280,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg23��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��370,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg24��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��460,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg25��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��550,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg26��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��640,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg27��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��730,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg28��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��820,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg29��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��910,495,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg30��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��100,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -   5        $��WtpImg31��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��190,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -    5        $��WtpImg32��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��280,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -!   5        $��WtpImg33��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��370,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -"   5        $��WtpImg34��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��460,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -#   5        $��WtpImg35��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��550,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -$   5        $��WtpImg36��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��640,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -%   5        $��WtpImg37��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��730,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -&   5        $��WtpImg38��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��820,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -'   5        $��WtpImg39��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��910,580,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -(   5        $��WtpImg40��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��100,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -)   5        $��WtpImg41��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��190,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -*   5        $��WtpImg42��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��280,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -+   5        $��WtpImg43��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��370,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -,   5        $��WtpImg44��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��460,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� --   5        $��WtpImg45��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��550,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5�      �� -.   5        $��WtpImg46��5�      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5�      5�      (� 5�   
   $��75��6   $��75��6   $��640,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5�      �� $��2q�6   ���	#FF000000._�5      �� -/   5        $��WtpImg47��5      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��730,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5     �� $��2q�6   ���	#FF000000._�5     �� -0   5        $��WtpImg48��5     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��820,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5	     �� $��2q�6   ���	#FF000000._�5
     �� -1   5        $��WtpImg49��5
     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��910,665,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5     �� $��2q�6   ���	#FF000000._�5     �� -2   5        $��WtpImg50��5     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��100,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5     �� $��2q�6   ���	#FF000000._�5     �� -3   5        $��WtpImg51��5     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��190,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5     �� $��2q�6   ���	#FF000000._�5     �� -4   5        $��WtpImg52��5     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5     5     (� 5  
   $��75��6   $��75��6   $��280,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5     �� $��2q�6   ���	#FF000000._�5      �� -5   5        $��WtpImg53��5      $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5!     5"     (� 5#  
   $��75��6   $��75��6   $��370,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5$     �� $��2q�6   ���	#FF000000._�5%     �� -6   5        $��WtpImg54��5%     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5&     5'     (� 5(  
   $��75��6   $��75��6   $��460,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5)     �� $��2q�6   ���	#FF000000._�5*     �� -7   5        $��WtpImg55��5*     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5+     5,     (� 5-  
   $��75��6   $��75��6   $��550,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5.     �� $��2q�6   ���	#FF000000._�5/     �� -8   5        $��WtpImg56��5/     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   50     51     (� 52  
   $��75��6   $��75��6   $��640,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��53     �� $��2q�6   ���	#FF000000._�54     �� -9   5        $��WtpImg57��54     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   55     56     (� 57  
   $��75��6   $��75��6   $��730,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��58     �� $��2q�6   ���	#FF000000._�59     �� -:   5        $��WtpImg58��59     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5:     5;     (� 5<  
   $��75��6   $��75��6   $��820,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5=     �� $��2q�6   ���	#FF000000._�5>     �� -;   5        $��WtpImg59��5>     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5?     5@     (� 5A  
   $��75��6   $��75��6   $��910,750,0,0q�6)   $
��Left=�6>   $	��Top=�6Y   .��5B     �� $��2q�6   ���	#FF000000._�5C     �� -<   5        $��WtpImg60��5C     $
��Left=�6(   $
��Fill=�6C   $	��Top=�6R   $��75��6j   $��75��6u   6�   5D     5E     (� 5H  
   $	��400��6   $	��400��6   $��1100,170,0,0q�6+   $
��Left=�6A   $	��Top=�6\   .��5I     �� $��2q�6   ���	#FF000000._�5J     �� -=   5        $��WtpDisplayImg��5J     $
��Left=�6-   $
��Fill=�6H   $	��Top=�6W   $	��500��6o   $	��500��6|   5K     5L     �� 5N  
   ->   5         ��Name$ 	WordLabel��5N     $��Find Item: Apple��6#   $
��Left=�6>   $	��250��6Y   $��100,100,0,0q�6f   $��Center=�6{   $��Center=�6�   $	��Top=�6�   $	��705��6�   $��64(�6�   $��Britannic Bold)�6�    �� TextAlignment$ Center=�6  �� 5O  
   -?   5        $��Confirm��5O     $
��Left=�6#   $��98��6>   $��1100,665,0,0q�6J   $	��Top=�6`   $	��400��6x   $��32(�6�    � 5Q  
   -@   5          �Name$ WordToPictureFrame��5Q       � NavigationUIVisibility$ Hidden=�6,   6N   5R     5S     