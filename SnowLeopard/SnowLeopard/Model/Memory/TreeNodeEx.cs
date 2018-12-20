/*----------------------------------------------------------------
// Copyright (C) 2011 
// 版权所有。 
//
// 文件名：ThreeStateTreeNode.cs
// 文件功能描述：车辆树节点
//                
// 
// 创建标识：
//
// 修改标识：
// 修改描述：
 * 20110823 属性增加DriverCode,DriverName属性
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace SnowLeopard.Model.Memory
{
    public class TreeNodeEx : TreeNode
    {
        #region 属性
        // 是否显示勾选框
        private bool _isShowCheckBox = true;
        //private ThreeStates _triState = ThreeStates.Unchecked;
        ///// <summary>
        ///// 选中状态
        ///// </summary>
        //public ThreeStates CheckState
        //{
        //    get { return _triState; }
        //    set
        //    {
        //        if (_triState != value)
        //        {
        //            SetTriState(value);
        //            _triState = value;
        //        }
        //    }
        //}
        
        /// <summary>
        /// 是否显示勾选框
        /// </summary>
        public bool IsShowCheckBox
        {
            get { return _isShowCheckBox; }
        }

        public string ShowText { get; set; }
        /// <summary>
        /// 节点编号
        /// </summary>
        public int NodeIndex { get; set; }

        public virtual bool IsFrozen
        {
            get { return false; }
        }
        #endregion

        #region 构造函数

        public TreeNodeEx() : base() { InitNodeFont(); }

        public TreeNodeEx(string text) : base(text) { this.Text = text; }
        public TreeNodeEx(bool showCheckBox) : base() 
        { 
            _isShowCheckBox = showCheckBox;
        }

        public TreeNodeEx(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context) { }

        public TreeNodeEx(string text, TreeNode[] children) : base(text, children) { this.Text = text; }

        public TreeNodeEx(string text, int imageIndex, int selectedImageIndex)
            : base(text, imageIndex, selectedImageIndex) { this.Text = text; }

        public TreeNodeEx(string text, int imageIndex, int selectedImageIndex, TreeNode[] children)
            : base(text, imageIndex, selectedImageIndex, children) { this.Text = text; }

        private void InitNodeFont()
        {
            ////this.NodeFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }
        #endregion

        #region 设置节点状态

        /// <summary>
        /// 设置节点状态
        /// </summary>
        /// <param name="state">状态</param>
        //private void SetTriState(ThreeStates state)
        //{
        //    _triState = state;
        //    if (this.TreeView != null && this.TreeView.IsHandleCreated && this.Handle != IntPtr.Zero)
        //    {
        //        InternalSetTriState(state);
        //    }
        //}
        #endregion

        #region 设置节点状态（勾选、未勾选、不确定）
        /// <summary>
        /// 设置节点状态 三态
        /// </summary>
        /// <param name="state">状态</param>
        //private void InternalSetTriState(ThreeStates state)
        //{
        //    if (this.TreeView == null)
        //        return;

        //    NativeMethods.TVITEM item = new NativeMethods.TVITEM();
        //    item.mask = (int)(NativeMethods.TreeViewMask.TVIF_HANDLE | NativeMethods.TreeViewMask.TVIF_STATE);
        //    item.hItem = this.Handle;
        //    item.stateMask = (int)NativeMethods.TreeViewStateMask.TVIS_STATEIMAGEMASK;
        //    switch (state)
        //    {
        //        case ThreeStates.Unchecked:
        //            item.state |= 0x1000;
        //            break;
        //        case ThreeStates.Checked:
        //            item.state |= 0x2000;
        //            break;
        //        case ThreeStates.Indeterminate:
        //            item.state |= 0x3000;
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException("state");
        //    }
        //    if (!_isShowCheckBox)
        //    {
        //        item.state = 0;
        //    }

        //    NativeMethods.SendMessage(
        //        new HandleRef(this.TreeView, this.TreeView.Handle),
        //        (int)NativeMethods.Messages.TVM_SETITEM,
        //        0,
        //        ref item);

        //    TreeViewAfterTriStateUpdate(this);
        //}

        /// <summary>
        /// 节点状态改变时执行 被节点类调用
        /// </summary>
        /// <param name="node">The node.</param>
        internal void TreeViewAfterTriStateUpdate(TreeNodeEx node)
        {
            //ThreeStatesEventArgs args = new ThreeStatesEventArgs(node, node.CheckState);
            //OnAfterTriStateChanged(args);
        }

        /// <summary>
        /// 抛出三态Checked改变事件
        /// </summary>
        //protected virtual void OnAfterTriStateChanged(ThreeStatesEventArgs e)
        //{
        //    if (AfterThiStateChanged != null)
        //        AfterThiStateChanged(this, e);
        //}

        /// <summary>
        /// 事件 当节点CheckedBox选中状态发生改变时 触发
        /// </summary>
        //public event EventHandler<ThreeStatesEventArgs> AfterThiStateChanged;
        #endregion

        #region 设置节点的文本

        /// <summary>
        ///  设置节点的文本
        /// </summary>
        /// <param name="showText"></param>
        public void SetNodeText(string showText)
        {
            if (this.TreeView == null)
                return;

            if (string.IsNullOrEmpty(showText.Trim()))
            {
                return;
            }
            //NativeMethods.TVITEM item = new NativeMethods.TVITEM();
            //item.mask = (int)(NativeMethods.TreeViewMask.TVIF_HANDLE | NativeMethods.TreeViewMask.TVIF_TEXT);
            //item.hItem = this.Handle;
            //item.pszText = Marshal.StringToHGlobalAnsi(showText);

            //NativeMethods.SendMessage(
            //    new HandleRef(this.TreeView, this.TreeView.Handle),
            //    (int)NativeMethods.Messages.TVM_SETITEM,
            //    0,
            //    ref item);

            TreeViewAfterTriStateUpdate(this);
        }
        #endregion

        

        /// <summary>
        /// 设置节点显示
        /// </summary>
        public virtual void SetNodeShow()
        { 
        }
    }
}
