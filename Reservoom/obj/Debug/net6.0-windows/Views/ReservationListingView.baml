   M S B A M L   `   `   `  ����D  @Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Reservoom.ConvertersReservoom.Converters  5      P LLoadingSpinnerControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControlLoadingSpinnerControl 5      1clr-namespace:Reservoom.ViewsReservoom.Views  5      ,    &Reservoom.Views.ReservationListingView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9
converters"clr-namespace:Reservoom.Converters     5      UcustomBclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControl     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Reservoom.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5	        � 	Resources  5          BooleanToVisibilityConverter>   8Reservoom.Converters.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter��%:   &	        &	      �� 5   
   6'     5   
   69   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5       �� $��0��5!       
 Header#��[ 5"      $��View Reservations��5#      �� 5%      $��1��5&      $��10,0,0,0q�5'      $��Make Reservation��5)      ��5(      �� *MakeReservationCommand+5)      5*      � 5,   
   $��1��6   $��0,25,0,0q�6   .+�5-      *  $LoadingSpinnerControl.LoadingSpinner     Diameter$	 100Q�5.         	Thickness$ 5Q�50         Color
 �   �   	IsLoading 5/      �� *	IsLoading+51      � 53      y�6   �� *	IsLoading+ �� 	Converter# [ .+�55      �� 
���  ����57      �� *ErrorMessage+y�58      �� *HasErrorMessage+# [  �� 5:      ��6   �� *Reservations+y�6@   �� *HasErrorMessage+# [ ��5;      �� 5<       �� 
TargetType" ��6    .�5=      �� 	 �� Property	 � ��
 �� Value$
 Stretch=�6K   5>       �� View 5A      �� 5B      .P�5C      �� $��Room ID��6-    �� CellTemplate 5D   "   �� 5E   &   .R�5F   *   �� $��Center=�64   ��6Q   �� *RoomID+5G   '   5I      �� 5K      $��Username��6-    5L   "   �� 5M   &   .R�5N   *   ��  �� Padding$ 0,0,20,0q�64   ��6G   �� *
Username+5O   '   5Q      �� 5S      $��
Start Date��6-    5T   "   �� 5U   &   .R�5V   *   �� $ 0,0,20,0q�64   ��6G   �� *	StartDate+5W   '   5Y      �� 5[      $��End Date��6-    5\   "   �� 5]   &   .R�5^   *   �� $ 0,0,20,0q�64   ��6G   �� *	EndDate+5_   '   5a      5b      5d      5e      5f      5g      5h      