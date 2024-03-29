﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UU
{
	public class EntryCustom : Entry
	{
		public static readonly BindableProperty BorderColorProperty =
			   BindableProperty.Create(
				   nameof(BorderColor),
				   typeof(Color),
				   typeof(EntryCustom),
				   Color.White);

		// Gets or sets BorderColor value
		public Color BorderColor
		{
			get { return (Color)GetValue(BorderColorProperty); }
			set { SetValue(BorderColorProperty, value); }
		}

		public static readonly BindableProperty BorderWidthProperty =
		BindableProperty.Create(
			nameof(BorderWidth),
			typeof(int),
			typeof(EntryCustom),
			Device.OnPlatform<int>(1, 2, 2));

		// Gets or sets BorderWidth value
		public int BorderWidth
		{
			get { return (int)GetValue(BorderWidthProperty); }
			set { SetValue(BorderWidthProperty, value); }
		}

		public static readonly BindableProperty CornerRadiusProperty =
		BindableProperty.Create(
			nameof(CornerRadius),
			typeof(double),
			typeof(EntryCustom),
			Device.OnPlatform<double>(6, 7, 7));

		// Gets or sets CornerRadius value
		public double CornerRadius
		{
			get { return (double)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}

		public static readonly BindableProperty IsCurvedCornersEnabledProperty =
		BindableProperty.Create(
			nameof(IsCurvedCornersEnabled),
			typeof(bool),
			typeof(EntryCustom),
			true);

		// Gets or sets IsCurvedCornersEnabled value
		public bool IsCurvedCornersEnabled
		{
			get { return (bool)GetValue(IsCurvedCornersEnabledProperty); }
			set { SetValue(IsCurvedCornersEnabledProperty, value); }
		}
	}
}

