   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      W SGraysTableReservation.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullqPclr-namespace:GraysTableReservation.Models;assembly=GraysTableReservation.ModelsGraysTableReservation.Models 5      T PGraysTableReservation.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:GraysTableReservation.Wpf.Infrastructure(GraysTableReservation.Wpf.Infrastructure 5	      @   :GraysTableReservation.Wpf.Views.AddOrUpdateReservationView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      3system&clr-namespace:System;assembly=mscorlib  5      XmPclr-namespace:GraysTableReservation.Models;assembly=GraysTableReservation.Models  5      Kinfrastructure6clr-namespace:GraysTableReservation.Wpf.Infrastructure  5	        � 	Resources  5       
  IntOneJ  DGraysTableReservation.Wpf.Infrastructure.DateTimeToTimeSpanConverter  DateTimeToTimeSpanConverterI  CGraysTableReservation.Wpf.Infrastructure.DateTimeIncrementConverter  DateTimeIncrementConverter  MetroLabelMessage �� 
TargetType  
MetroLabel �� BasedOn �� Triggers.  (GraysTableReservation.Models.MessageType   Failure �� Value �� Binding �� Property �� Value	   
Suggestion��%�  &	        &	      &	 ,     &	 ?     7  ��5   
   1��6)     5   
   65     5   
   64   �� 5   
   " ��6*   8    5      �� 5      # Z 6J    6   �� *Reservation.MessageType+.a�5      ��  � ��
 �  ��63   5      �� 5      # Z	 6J    6   �� *Reservation.MessageType+.a�5      ��  � ��
 � ���63   5      5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      $��30 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5"   
   �� -   5        $��MsgLabel��5"      #��[ 6    $��0��6s   $��Center=�6�   ��6K   �� *Reservation.Message+5#      � 5$   
   $��1��6   $��15q�6   
 5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6     � ColumnDefinitions 5,      �� 5-      $��80 �6#   �� 5.      $	��180 �6#   .+�50      �� $��0��6   $��0��6%   $��3q�65   $
��For:��6@   �� 51      $��1��6   $��0��6%   $��3q�65   $��People#:��6@   �� 52      $��2��6   $��0��6%   $��3q�65   $��From:��6@   �� 53      $��3��6   $��0��6%   $��3q�65   $	��To:��6@   �� 54      $��4��6   $��0��6%   $��3q�65   $��Table#:��6@   6Q   �� 55      $��0��6   $��1��6#   $��3q�63   $	��160��6>   $
��Left=�6�   ��6J   �� *Reservation.ReservedFor+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   �� 56      $��1��6   $��1��6#   $��3q�63   $��60��6>   $
��Left=�6�   ��6I   �� *Reservation.NumberOfPeople+$ PropertyChanged=� .  �� TargetNullValue$  ��6�   "  Xceed.Wpf.Toolkit.TimePicker  58      -   5        $��StarTimePicker��58      $��2��64   $��1��6A   $��3q�6Q   $	��110��6\   $
��Left=�5:         Value 59      �� *Reservation.FromTime+ �� StringFormat$ t��$ PropertyChanged=� .    TimeInterval 5;      �� *TimeInterval+   	StartTime 5<      �� *OpeningTime+   EndTime 5=      �� *LastReservationTime+   Minimum 5>      �� *FromTimeMin+   Maximum 5?      �� *FromTimeMax+5@        5A      $��3��6   $��1��6+   $��3q�6;   $	��110��6F   $
��Left=�5C       5B      �� *Reservation.ToTime+$ t��$ PropertyChanged=� .  5D      �� *TimeInterval+ 5E      �� *Value+ �� ElementName$ StarTimePicker�� �� 	Converter# [  �� ConverterParameter# [   5F      �� *ClosingTime+ 5G      �� *Value+$ StarTimePicker��# [ # [   5H      �� *	ToTimeMax+�� 5I      $��4��6   $��1��6!   $��3q�61   $��70��6<   $
��Left=�6�   ��6G   �� *Reservation.TableNumber+$ PropertyChanged=� .  $  ��6�   5J      �� 5K   
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�5L      �� $
��Save��6   $��5q�6$   ��6/   �� *SaveCommand+�� 5M      $��Cancel��6   $��5q�6&   ��61   �� *CancelCommand+5N      5O      5P      