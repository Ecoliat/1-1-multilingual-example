//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.0.90
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models
{
	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AboutText
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// About Title
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Banner background image
		///</summary>
		[ImplementPropertyType("bannerBackgroundImage")]
		public object BannerBackgroundImage
		{
			get { return this.GetPropertyValue("bannerBackgroundImage"); }
		}

		///<summary>
		/// Banner Header
		///</summary>
		[ImplementPropertyType("bannerHeader")]
		public string BannerHeader
		{
			get { return this.GetPropertyValue<string>("bannerHeader"); }
		}

		///<summary>
		/// Banner link
		///</summary>
		[ImplementPropertyType("bannerLink")]
		public object BannerLink
		{
			get { return this.GetPropertyValue("bannerLink"); }
		}

		///<summary>
		/// Banner link text
		///</summary>
		[ImplementPropertyType("bannerLinkText")]
		public string BannerLinkText
		{
			get { return this.GetPropertyValue<string>("bannerLinkText"); }
		}

		///<summary>
		/// Banner Subheader
		///</summary>
		[ImplementPropertyType("bannerSubheader")]
		public string BannerSubheader
		{
			get { return this.GetPropertyValue<string>("bannerSubheader"); }
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Dribbble link
		///</summary>
		[ImplementPropertyType("dribbbleLink")]
		public string DribbbleLink
		{
			get { return this.GetPropertyValue<string>("dribbbleLink"); }
		}

		///<summary>
		/// Facebook link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Google+ link
		///</summary>
		[ImplementPropertyType("googleLink")]
		public string GoogleLink
		{
			get { return this.GetPropertyValue<string>("googleLink"); }
		}

		///<summary>
		/// Hide banner?
		///</summary>
		[ImplementPropertyType("hideBanner")]
		public bool HideBanner
		{
			get { return this.GetPropertyValue<bool>("hideBanner"); }
		}

		///<summary>
		/// LinkedIn link
		///</summary>
		[ImplementPropertyType("linkedInLink")]
		public string LinkedInLink
		{
			get { return this.GetPropertyValue<string>("linkedInLink"); }
		}

		///<summary>
		/// Rss link
		///</summary>
		[ImplementPropertyType("rssLink")]
		public string RssLink
		{
			get { return this.GetPropertyValue<string>("rssLink"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Twitter link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}
	}
}
