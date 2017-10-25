﻿using System.ComponentModel;
using System.Windows;
using Ccr.MaterialDesign.Markup.TypeConverters;
using Ccr.PresentationCore.Helpers.DependencyHelpers;

namespace Ccr.MaterialDesign
{
	[TypeConverter(typeof(MaterialIdentityConverter))]
	public class MaterialIdentity : Freezable
	{
		public static readonly DependencyProperty SwatchClassifierProperty = DP.Register(
			new Meta<MaterialIdentity, SwatchClassifier>());

		public static readonly DependencyProperty IsAccentProperty = DP.Register(
			new Meta<MaterialIdentity, bool>());

		public static readonly DependencyProperty MaterialIndexProperty = DP.Register(
			new Meta<MaterialIdentity, double>());


		public SwatchClassifier SwatchClassifier
		{
			get => (SwatchClassifier)GetValue(SwatchClassifierProperty);
			set => SetValue(SwatchClassifierProperty, value);
		}
		public bool IsAccent
		{
			get => (bool)GetValue(IsAccentProperty);
			set => SetValue(IsAccentProperty, value);
		}
		public double MaterialIndex
		{
			get => (double)GetValue(MaterialIndexProperty);
			set => SetValue(MaterialIndexProperty, value);
		}


		internal MaterialIdentity(
			SwatchClassifier swatchClassifier,
			bool isAccent,
			double materialIndex)
		{
			SwatchClassifier = swatchClassifier;
			IsAccent = isAccent;
			MaterialIndex = materialIndex;
		}


		protected override Freezable CreateInstanceCore()
		{
			return new MaterialIdentity(
				SwatchClassifier,
				IsAccent,
				MaterialIndex);
		}
	}

}