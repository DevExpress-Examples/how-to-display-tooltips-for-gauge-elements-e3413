<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DXGauges_Show_Tooltips/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/DXGauges_Show_Tooltips/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/DXGauges_Show_Tooltips/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DXGauges_Show_Tooltips/MainPage.xaml.vb))
<!-- default file list end -->
# How to display tooltips for gauge elements


<p>This example demonstrates how to show a tooltip with the current value of a needle on a circular gauge.</p><br />



<h3>Description</h3>

<p>To display the current <a href="http://help.devexpress.com/#Silverlight/CustomDocument5619"><u>needle</u></a>&#39;s value in a tooltip, it is necessary to handle the<strong> MouseMove</strong> and <strong>MouseLeave</strong> events for the <a href="http://help.devexpress.com/#Silverlight/clsDevExpressXpfGaugesCircularGaugeControltopic"><u>CircularGaugeControl</u></a> object and obtain the current mouse position on a scale via the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesCircularGaugeControl_CalcHitInfotopic"><u>CircularGaugeControl.CalcHitInfo</u></a> method. After that, if the mouse pointer hovers over the needle, it becomes possible to invoke the tooltip that displays the current needle&#39;s value.</p><p><br />
Note that this approach is applicable to only those gauge elements whose <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesValueIndicatorBase_IsHitTestVisibletopic"><u>IsHitTestVisible</u></a> property is set to <strong>True </strong>(this is the default option). If the <strong>IsHitTestVisible </strong>property is set to <strong>False</strong>, this element is excluded from the hit-testing algorithm. To explore this behavior in action, mark and unmark the &quot;Show tooltips for a needle&quot;<a href="http://help.devexpress.com/#Silverlight/clsDevExpressXpfEditorsCheckEdittopic"><u>CheckEdit</u></a> (whose check state is bound to the needle&#39;s <strong>IsHitTestVisible </strong>property). So, the unmarked CheckEdit&#39;s state means that tooltips are not displayed for a needle. </p><p><br />
</p><br />


<br/>


