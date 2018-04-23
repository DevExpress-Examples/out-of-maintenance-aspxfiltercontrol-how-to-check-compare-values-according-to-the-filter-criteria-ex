using System;
using DevExpress.Data.Filtering;
using DevExpress.Data.Filtering.Helpers;
using System.ComponentModel;

public partial class _Default : System.Web.UI.Page {
    protected void btn_Click(object sender, EventArgs e) {
        ObjectForChecking obj = new ObjectForChecking();
        obj.x = Convert.ToInt32(txt1.Text);
        obj.y = Convert.ToInt32(txt2.Text);

        fc.ApplyFilter();
        CriteriaOperator criteriaOperator = CriteriaOperator.Parse(fc.AppliedFilterExpression);
        ExpressionEvaluator eval = new ExpressionEvaluator(TypeDescriptor.GetProperties(obj), criteriaOperator);

        lblResult.Text = "Expression Result: " + eval.Fit(obj);
    }

    public class ObjectForChecking {
        private int _X;
        public int x {
            get { return _X; }
            set {
                _X = value;
            }
        }

        private int _Y;
        public int y {
            get { return _Y; }
            set {
                _Y = value;
            }
        }        
    }
}
