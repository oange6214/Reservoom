   M S B A M L   `   `   `  ���� D  @Reservoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Reservoom.ViewsReservoom.Views  )    #Reservoom.Views.MakeReservationView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:Reservoom.Views     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .���   � IsSharedSizeScope$
  True�� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0�� 
  Header#��[  $��Make Reservation��� $��1��$��0,25,0,0q� �� $
��auto ��� $
��auto �.+��� $��0��$��Username���� $��1��$��0,5,0,0q����� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�� $��2��$��0,10,0,0q� �� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto � z� SharedSizeGroup$ FirstColumn���� $
��auto �$ SecondColumn��.+��� $��0��$��0��$��	Floor No.���� $��1��$��0��$��0,5,0,0q����� *FloorNumber+$ PropertyChanged=��� $��0��$��1��$��10,0,0,0q�$��	Room No. ���� $��1��$��1��$��10,5,0,0q����� *
RoomNumber+$ PropertyChanged=�� $��3��$��0,10,0,0q� �� $
��auto ��� $
��auto � �� $
��auto �$ FirstColumn���� $
��auto �$ SecondColumn��.+��� $��0��$��0��$��
Start Date��(  "System.Windows.Controls.DatePicker  $��1��$��0��$��0,5,0,0q�   SelectedDate �� *	StartDate+$ PropertyChanged=��� $��0��$��1��$��10,0,0,0q�$��	End Date ��  $��1��$��1��$��10,5,0,0q� �� *	EndDate+$ PropertyChanged=��� $��4��$��0,25,0,0q� �� Orientation$ 
Horizontal=�.+��� $��Submit������ *SubmitCommand+�� $��10,0,0,0q�$��Cancel������ *CancelCommand+