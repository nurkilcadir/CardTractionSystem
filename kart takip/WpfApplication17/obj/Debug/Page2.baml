   M S B A M L   `   `   `  ����  WpfApplication17    WpfApplication17.Page2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Page2��5      .��5
      � ��5   
   �� 5       �� ImageSource$s m\\CB0222DEV57\Users\vb53094\Desktop\ali\son\WpfApplication17\WpfApplication17\component\Content\img\resim.png��6   .+�5   
   �� $��	KartId  :��6   $
��Left=�6$   $��	10,10,0,0q�6?   $	��Top=�6R   $	��119��6j   �� 5   
   $��	ISLEMKODU��6   $
��Left=�6$   $��	10,36,0,0q�6?   $	��Top=�6R   $	��119��6j   �� 5   
   -   5         ��Name$ txtIslemKodu��5      $
��Left=�6(   $��23��6C   $��
157,39,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�    �� 	MaxLength$ 6��6�   �� 5   
   $��ISLEMACIKLAMASI��6   $
��Left=�6*   $��	10,67,0,0q�6E   $	��Top=�6X   $	��119��6p   �� 5   
   -   5        $ txtİslemAciklama��5      $
��Left=�6,   $��23��6G   $��
157,70,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ cbxId��5      $
��Left=�6"   $��
157,14,0,0q�6=   $	��Top=�6Q   $	��120��6i   �� 5   
   $��KAYITTARIHI��6   $
��Left=�6&   $��	10,98,0,0q�6A   $	��Top=�6T   $	��119��6l   �� 5   
   $��KAYITUSERCODE��6   $
��Left=�6(   $��
10,129,0,0q�6C   $	��Top=�6W   $	��119��6o   �� 5   
   $��KAYITKANALKODU��6   $
��Left=�6)   $��
10,160,0,0q�6D   $	��Top=�6X   $	��119��6p   �� 5   
   -   5        $ txtKayitUser��5      $
��Left=�6(   $��23��6C   $��157,132,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   $ 6��6�   �� 5   
   -   5        $ txtKayitKanal��5      $
��Left=�6)   $��23��6D   $��157,163,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   $ 6��6�   �� 5   
   -   5         ��Name$ 	btnKaydet��5      $��Kaydet��6$   $
��Left=�65   $��
10,196,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ 
btnListele��5      $��Listele��6%   $
��Left=�67   $��119,196,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5   
   -   5         ��Name$ 	detayList��5      $
��Left=�6?   $	��142��6Z   $��
10,248,0,0q�6g   $	��Top=�6{   $	��280��6�   ��6&   ��  �� View 5      �� 5      .P�5      �� $��Id��6&   	 �� Width$	 90��62   
 �� DisplayMemberBinding
 6=   �� *Id+�� 5      $��KartId��6&   $	 90��66   
 6A   �� *KartId+�� 5       $��	ISLEMKODU��6&   $	 90��69   
 6D   �� *	ISLEMKODU+�� 5!      $��ISLEMACIKLAMASI��6&   $	 90��6?   
 6J   �� *ISLEMACIKLAMASI+�� 5"      $��KAYITTARIHI��6&   $	 90��6;   
 6F   �� *KAYITTARIHI+�� 5#      $��KAYITUSERCODE��6&   $	 90��6=   
 6H   �� *KAYITUSERCODE+�� 5$      $��KAYITKANALKODU��6&   $	 90��6>   
 6I   �� *KAYITKANALKODU+5%      5'      (  "System.Windows.Controls.DatePicker  5(   
   -	   5          Name$ 	kayitDate��5(      $
��Left=�6(   $��157,100,0,0q�6C   $	��Top=�6X   $	��120��6p   5*      5+      