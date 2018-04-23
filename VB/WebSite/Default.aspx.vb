Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports System.ComponentModel

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim obj As New ObjectForChecking()
		obj.x = Convert.ToInt32(txt1.Text)
		obj.y = Convert.ToInt32(txt2.Text)

		fc.ApplyFilter()
		Dim criteriaOperator As CriteriaOperator = CriteriaOperator.Parse(fc.AppliedFilterExpression)
		Dim eval As New ExpressionEvaluator(TypeDescriptor.GetProperties(obj), criteriaOperator)

		lblResult.Text = "Expression Result: " & eval.Fit(obj)
	End Sub

	Public Class ObjectForChecking
		Private _X As Integer
		Public Property x() As Integer
			Get
				Return _X
			End Get
			Set(ByVal value As Integer)
				_X = value
			End Set
		End Property

		Private _Y As Integer
		Public Property y() As Integer
			Get
				Return _Y
			End Get
			Set(ByVal value As Integer)
				_Y = value
			End Set
		End Property
	End Class
End Class
