using ScrollViewTestXamarin;
using ScrollViewTestXamarin.iOS;
using System;
using System.Linq;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomScrollView), typeof(CustomScrollViewRenderer))]
namespace ScrollViewTestXamarin.iOS
{
	public class CustomScrollViewRenderer : ScrollViewRenderer
	{
        public CustomScrollViewRenderer()
        {
            MaximumZoomScale = 5;
            MinimumZoomScale = 1;
        }

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				ViewForZoomingInScrollView -= GetViewForZooming;
			}

			if (e.NewElement != null)
			{
				ViewForZoomingInScrollView += GetViewForZooming;
			}
		}

		private UIView GetViewForZooming(UIScrollView sv)
		{
			return Subviews.FirstOrDefault();
		}
	}
}