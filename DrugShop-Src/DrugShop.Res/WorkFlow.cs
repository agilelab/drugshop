using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DrugShop.WinUI;

namespace DrugShop.Res
{
    partial class WorkFlow : UserControl
    {
        public WorkFlow()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);

            InitializeComponent();
        }                

        protected override void OnPaint(PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            g.DrawImage(Properties.Resources.FLow, 0, 0, this.Width, this.Height);
        }

        private void lbDrugType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugTypeList);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugDict_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugDictList);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbProvider_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(ProvideList);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugIn);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugBackProvder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugBackProvider);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugInCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugInRpt);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugStotreAdjust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugStoreAdjust);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugStotreCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugStoreCount);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugLimit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugLimitQuery);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugLost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugLost);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugCPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugChangePrice);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugInOutCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugInOutCount);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugSale);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugSaleBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugBackCustom);
            EAS.Application.Instance.OpenModule(T);
        }

        private void lbDrugSaleCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Type T = typeof(DrugSaleQuery);
            EAS.Application.Instance.OpenModule(T);
        }
    }
}
