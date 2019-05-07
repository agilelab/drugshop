using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DrugShop.Res
{
    public static class ImageExtensions
    {
        /// <summary>
        /// 转换图像为图标。
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static System.Drawing.Icon ToIcon(this System.Drawing.Image image)
        {
            System.Drawing.Size size = new System.Drawing.Size();

            size.Height = image.Height < 128 ? image.Height : 128;
            size.Width = image.Width < 128 ? image.Width : 128;

            try
            {
                using (Bitmap iconBm = new Bitmap(image, size))
                {
                    return Icon.FromHandle(iconBm.GetHicon());
                }
            }
            catch
            {
                return null;
            }
        }

        #region 等比缩放

        /// <summary>
        /// 图片等比缩放
        /// </summary>
        /// <remarks>吴剑 2012-08-08</remarks>
        /// <param name="fromFile">原图Stream对象</param>
        /// <param name="savePath">缩略图存放地址</param>
        /// <param name="targetWidth">指定的最大宽度</param>
        /// <param name="targetHeight">指定的最大高度</param>
        public static Image ZoomAuto(this System.Drawing.Image initImage, System.Double targetWidth, System.Double targetHeight)
        {
            //原图宽高均小于模版，不作处理，直接保存
            if (initImage.Width <= targetWidth && initImage.Height <= targetHeight)
            {
                return initImage;
            }
            else
            {
                //缩略图宽、高计算
                double newWidth = initImage.Width;
                double newHeight = initImage.Height;

                //宽大于高或宽等于高（横图或正方）
                if (initImage.Width > initImage.Height || initImage.Width == initImage.Height)
                {
                    //如果宽大于模版
                    if (initImage.Width > targetWidth)
                    {
                        //宽按模版，高按比例缩放
                        newWidth = targetWidth;
                        newHeight = initImage.Height * (targetWidth / initImage.Width);
                    }
                }
                //高大于宽（竖图）
                else
                {
                    //如果高大于模版
                    if (initImage.Height > targetHeight)
                    {
                        //高按模版，宽按比例缩放
                        newHeight = targetHeight;
                        newWidth = initImage.Width * (targetHeight / initImage.Height);
                    }
                }

                //生成新图
                //新建一个bmp图片
                System.Drawing.Image newImage = new System.Drawing.Bitmap((int)newWidth, (int)newHeight);
                //新建一个画板
                using (System.Drawing.Graphics newG = System.Drawing.Graphics.FromImage(newImage))
                {

                    //设置质量
                    newG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    newG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    //置背景色
                    newG.Clear(Color.White);
                    //画图
                    newG.DrawImage(initImage, new System.Drawing.Rectangle(0, 0, newImage.Width, newImage.Height), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel);
                }

                return newImage;
            }
        }

        #endregion
    }
}