using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.Web.BSObject
{
    public abstract class BSObject
    {
        private HtmlDocument _doc;
        public BSObject(HtmlDocument doc)
        {
            this._doc = doc;
        }

        #region 执行操作
        protected void InvokeAction(string methodName)
        {
            this._doc.InvokeScript(methodName, new object[0]);
        }
        protected void InvokeAction<T1>(string methodName, T1 arg1)
        {
            this._doc.InvokeScript(methodName, new[] { (object)arg1 });
        }
        protected void InvokeAction<T1, T2>(string methodName, T1 arg1, T2 arg2)
        {
            this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2 });
        }
        protected void InvokeAction<T1, T2, T3>(string methodName, T1 arg1, T2 arg2, T3 arg3)
        {
            this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2, (object)arg3 });
        }
        protected void InvokeAction<T1, T2, T3, T4>(string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2, (object)arg3, (object)arg4 });
        }
        #endregion

        #region 执行函数
        protected TResult InvokeFunc<TResult>(string methodName)
        {
            var result = this._doc.InvokeScript(methodName, new object[0]);
            return GetResult<TResult>(result);
        }
        protected TResult InvokeFunc<T1, TResult>(string methodName, T1 arg1)
        {
            var result = this._doc.InvokeScript(methodName, new[] { (object)arg1 });
            return GetResult<TResult>(result);
        }
        protected TResult InvokeFunc<T1, T2, TResult>(string methodName, T1 arg1, T2 arg2)
        {
            var result = this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2 });
            return GetResult<TResult>(result);
        }
        protected TResult InvokeFunc<T1, T2, T3, TResult>(string methodName, T1 arg1, T2 arg2, T3 arg3)
        {
            var result = this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2, (object)arg3 });
            return GetResult<TResult>(result);
        }
        protected TResult InvokeFunc<T1, T2, T3, T4, TResult>(string methodName, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            var result = this._doc.InvokeScript(methodName, new[] { (object)arg1, (object)arg2, (object)arg3, (object)arg4 });
            return GetResult<TResult>(result);
        }
        #endregion

        #region 获取结果
        private TResult GetResult<TResult>(object result)
        {
            return result == null ? default(TResult) : (TResult)result;
        }
        #endregion
    }
}
