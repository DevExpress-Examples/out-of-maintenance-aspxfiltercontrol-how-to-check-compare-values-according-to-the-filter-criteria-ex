<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128532731/11.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3939)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxFilterControl - How to check/compare values according to the filter criteria/expression
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3939/)**
<!-- run online end -->


<p>This example demonstrates how to check values via<strong> ASPxFilterControl</strong>.</p><p>1) Define a class with properties for checking; <br />
2) Define <strong>ASPxFilterControl</strong> and specify its columns for properties that should be checked;<br />
3) Specify the required filter criteria for checking;<br />
4) Create the <strong>CriteriaOperator</strong> object based on the <strong>ASPxFilterControl.AppliedFilterExpression</strong>;<br />
5) Create <strong>ExpressionEvaluator</strong> based on this <strong>CriteriaOperator</strong> object;<br />
6) Check whether or not the current instance (i.e., properties for checking) matches the specified criteria via the <strong>ExpressionEvaluator.Fit</strong> method.</p>

<br/>


