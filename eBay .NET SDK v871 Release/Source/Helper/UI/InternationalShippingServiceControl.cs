#region Copyright
//	Copyright (c) 2013 eBay, Inc.
//	
//	This program is licensed under the terms of the eBay Common Development and
//	Distribution License (CDDL) Version 1.0 (the "License") and any subsequent  
//	version thereof released by eBay.  The then-current version of the License can be 
//	found at http://www.opensource.org/licenses/cddl1.php and in the eBaySDKLicense 
//	file that is under the eBay SDK ../docs directory
#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Samples.Helper.UI
{
	/// <summary>
	/// Summary description for InternationalShippingServiceControl.
	/// </summary>
	public class InternationalShippingServiceControl : System.Windows.Forms.UserControl
	{
		IntlShippingServiceListView listView = new IntlShippingServiceListView();
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// 
		/// </summary>
		public InternationalShippingServiceControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
			this.Controls.Add(this.listView);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// InternationalShippingServiceControl
			// 
			this.Name = "InternationalShippingServiceControl";
			this.Size = new System.Drawing.Size(225, 150);

		}
		#endregion

		/// <summary>
		/// 
		/// </summary>
		public IntlShippingServiceListView EditListView
		{
			get {return this.listView;}
		}
	}
}
