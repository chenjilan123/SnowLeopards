/*----------------------------------------------------------------
// Copyright (C) 2011 
// ��Ȩ���С� 
//
// �ļ�����ThreeStateTreeNode.cs
// �ļ������������������ڵ�
//                
// 
// ������ʶ��
//
// �޸ı�ʶ��
// �޸�������
 * 20110823 ��������DriverCode,DriverName����
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
        #region ����
        // �Ƿ���ʾ��ѡ��
        private bool _isShowCheckBox = true;
        //private ThreeStates _triState = ThreeStates.Unchecked;
        ///// <summary>
        ///// ѡ��״̬
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
        /// �Ƿ���ʾ��ѡ��
        /// </summary>
        public bool IsShowCheckBox
        {
            get { return _isShowCheckBox; }
        }

        public string ShowText { get; set; }
        /// <summary>
        /// �ڵ���
        /// </summary>
        public int NodeIndex { get; set; }

        public virtual bool IsFrozen
        {
            get { return false; }
        }
        #endregion

        #region ���캯��

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
            ////this.NodeFont = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }
        #endregion

        #region ���ýڵ�״̬

        /// <summary>
        /// ���ýڵ�״̬
        /// </summary>
        /// <param name="state">״̬</param>
        //private void SetTriState(ThreeStates state)
        //{
        //    _triState = state;
        //    if (this.TreeView != null && this.TreeView.IsHandleCreated && this.Handle != IntPtr.Zero)
        //    {
        //        InternalSetTriState(state);
        //    }
        //}
        #endregion

        #region ���ýڵ�״̬����ѡ��δ��ѡ����ȷ����
        /// <summary>
        /// ���ýڵ�״̬ ��̬
        /// </summary>
        /// <param name="state">״̬</param>
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
        /// �ڵ�״̬�ı�ʱִ�� ���ڵ������
        /// </summary>
        /// <param name="node">The node.</param>
        internal void TreeViewAfterTriStateUpdate(TreeNodeEx node)
        {
            //ThreeStatesEventArgs args = new ThreeStatesEventArgs(node, node.CheckState);
            //OnAfterTriStateChanged(args);
        }

        /// <summary>
        /// �׳���̬Checked�ı��¼�
        /// </summary>
        //protected virtual void OnAfterTriStateChanged(ThreeStatesEventArgs e)
        //{
        //    if (AfterThiStateChanged != null)
        //        AfterThiStateChanged(this, e);
        //}

        /// <summary>
        /// �¼� ���ڵ�CheckedBoxѡ��״̬�����ı�ʱ ����
        /// </summary>
        //public event EventHandler<ThreeStatesEventArgs> AfterThiStateChanged;
        #endregion

        #region ���ýڵ���ı�

        /// <summary>
        ///  ���ýڵ���ı�
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
        /// ���ýڵ���ʾ
        /// </summary>
        public virtual void SetNodeShow()
        { 
        }
    }
}
