   M S B A M L   `   `   `  ????F  BGraphVisual, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GraphVisual.ViewsGraphVisual.Views  5      #    GraphVisual.Views.Graph_space   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GraphVisual.Views     5      .??5	      ? .+?5   
   ?? ??6   ?? *EdgesO+??5      ?? 5      .R?5      ?? 
??????   J? 	AllowDrop$
  True??5      5      ??5      ?? 5      .R?5      ? .+?5      ?? $??3??5       J? IsHitTestVisible$
 True??5       J? Opacity$ .5Q?5      ??5      ?? *IsTree+	 ?? X1 5      ?? *	PosXFirst+	 ?? Y1 5      ?? *	PosYFirst+	 ?? X2 5       ?? *
PosXSecond+	 ?? Y2 5!      ?? *
PosYSecond+5#      5$      5&      ?? 5(   
   ??6   ?? *
ElipsesO+??5*      ?? 5+      .R?5,      ?? -   5        $
  True??5,      
?????? 5.      5/      ??53      ?? 54       ?? 
TargetType" ??6   .?55      ??  ?? Property ?@??Left	 ?? Value	 64   ?? *PosX+?? 56       ?@??Top	 63   ?? *PosY+57      ??5:      ?? 5;      .R?5<      ? -   5        $??50??5<      $??50??5=      
 J? InputBindings
 5@      d? 5A       d? Gesture$ 	LeftClicka?6+    ?? Command 6?   ?? *ClickedNodeCommand+.+?5C      A? 
???   ?$??3??5E      ??5F      ?? *
IsSelected+5G      ?? 5H      
???  ?? ?? TextAlignment$ Center=?5J   $   $??Center=?5K   $   ??5L   $   ?? *Value+5N      5O      5P      5S      5U      5V      