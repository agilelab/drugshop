using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DrugShop.Res
{
    partial class NavigationControl
    {        
        private System.ComponentModel.IContainer components;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
            this.imageTree2 = new System.Windows.Forms.ImageList(this.components);
            this.Tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageTree2
            // 
            this.imageTree2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTree2.ImageStream")));
            this.imageTree2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTree2.Images.SetKeyName(0, "folder_closed_ii.ico");
            this.imageTree2.Images.SetKeyName(1, "desktop.ico");
            this.imageTree2.Images.SetKeyName(2, "closed_floder.ico");
            this.imageTree2.Images.SetKeyName(3, "calendar.ico");
            // 
            // Tree
            // 
            this.Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree.ImageIndex = 0;
            this.Tree.ImageList = this.imageTree2;
            this.Tree.Location = new System.Drawing.Point(0, 0);
            this.Tree.Name = "Tree";
            this.Tree.SelectedImageIndex = 0;
            this.Tree.Size = new System.Drawing.Size(200, 400);
            this.Tree.TabIndex = 0;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_close2.ico");
            this.imageList1.Images.SetKeyName(1, "folder_open.ico");
            this.imageList1.Images.SetKeyName(2, "closed_floder.ico");
            this.imageList1.Images.SetKeyName(3, "folder2.ico");
            this.imageList1.Images.SetKeyName(4, "opened_folder2.ico");
            // 
            // NavigationControl
            // 
            this.Controls.Add(this.Tree);
            this.Name = "NavigationControl";
            this.Size = new System.Drawing.Size(200, 400);
            this.ResumeLayout(false);

        }
        #endregion

        private ImageList imageTree2;
        private TreeView Tree;
        private ImageList imageList1;
    }
}