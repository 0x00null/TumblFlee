using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Generates, caches and retrieves thumbnails for posts
    /// </summary>
    public static class ThumbnailHelper
    {
        public static async Task<Image> GetThumbnail(Export export, ExportedPost post)
        {
            // Create a thumbnail path
            var thumbPath = Path.Combine(export.BasePath, post.Id + ".thumb");
            if (File.Exists(thumbPath))
            {
                return Image.FromFile(thumbPath);
            }

            // Create the thumbnail
            return await Task.Run(() => CreateThumbnail(export, post, thumbPath));
        }

        private static Image CreateThumbnail(Export export, ExportedPost post, String thumbPath)
        {
            // We only support photo posts for now!

            // Create an image to render to
            Bitmap thumb = new Bitmap(150, 150);
            RectangleF previewRect = new RectangleF(0, 0, 150, 150);

            using (var g = Graphics.FromImage(thumb))
            {
                // Is this a post with multiple media items?
                if (post.Photos.Count > 1)
                {
                    // We'll render the 'stack', then put a slightly smaller and offset preview image on.
                    // The 'stack' is three rectangles which go off above and to the right of the preview image.

                    // Each rect is 3px apart, meaning we need to offset the preview image by 3 * 3 pixels
                    var stackRect = new Rectangle(3, 3, 150 - 12, 150 - 12);
                    previewRect = new RectangleF(12, 12, 150 - 12, 150 - 12);

                    // Draw the stack
                    using (var stackPen = new Pen(Color.FromArgb(96, 96, 96), 1.0f))
                        using(var stackbackBrush = new SolidBrush(Color.FromArgb(16,16,16)))
                    {
                        g.FillRectangle(stackbackBrush, stackRect);
                        g.DrawRectangle(stackPen, stackRect);

                        stackRect.Offset(3, 3);
                        g.FillRectangle(stackbackBrush, stackRect);
                        g.DrawRectangle(stackPen, stackRect);

                        stackRect.Offset(3, 3);
                        g.FillRectangle(stackbackBrush, stackRect);
                        g.DrawRectangle(stackPen, stackRect);
                    }
                }

                // Now crop and scale the first image in the post to fit in the preview rect
                using (var fullImage = Image.FromFile(Path.Combine(export.BasePath, post.Photos.First().Filename)))
                {
                    RectangleF fullImageSourceRect;

                    // Which side of the original image is smallest?
                    if (fullImage.Width > fullImage.Height)
                    {
                        // Crop by height
                        fullImageSourceRect = new RectangleF((fullImage.Width - fullImage.Height) / 2, 0, fullImage.Height, fullImage.Height);
                    }
                    else
                    {
                        // Crop by width
                        fullImageSourceRect = new RectangleF(0, (fullImage.Height - fullImage.Width) / 2, fullImage.Width, fullImage.Width);
                    }

                    // Now draw the scaled version into the thumbnail
                    g.DrawImage(fullImage, previewRect, fullImageSourceRect, GraphicsUnit.Pixel);
                }

                g.Save();
            }

            // Now save the preview
            thumb.Save(thumbPath);
            return thumb;
        }
    }
}
