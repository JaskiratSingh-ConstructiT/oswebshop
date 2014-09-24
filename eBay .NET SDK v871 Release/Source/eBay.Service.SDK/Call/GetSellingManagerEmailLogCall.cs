#region Copyright
//	Copyright (c) 2013 eBay, Inc.
//	
//	This program is licensed under the terms of the eBay Common Development and
//	Distribution License (CDDL) Version 1.0 (the "License") and any subsequent  
//	version thereof released by eBay.  The then-current version of the License can be 
//	found at http://www.opensource.org/licenses/cddl1.php and in the eBaySDKLicense 
//	file that is under the eBay SDK ../docs directory
#endregion

#region Namespaces
using System;
using System.Runtime.InteropServices;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.EPS;
using eBay.Service.Util;

#endregion

namespace eBay.Service.Call
{

	/// <summary>
	/// 
	/// </summary>
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class GetSellingManagerEmailLogCall : ApiCall
	{

		#region Constructors
		/// <summary>
		/// 
		/// </summary>
		public GetSellingManagerEmailLogCall()
		{
			ApiRequest = new GetSellingManagerEmailLogRequestType();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ApiContext">The <see cref="ApiCall.ApiContext"/> for this API Call of type <see cref="ApiContext"/>.</param>
		public GetSellingManagerEmailLogCall(ApiContext ApiContext)
		{
			ApiRequest = new GetSellingManagerEmailLogRequestType();
			this.ApiContext = ApiContext;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Retrieves a log of emails sent, or scheduled to be sent, to buyers.
		/// 
		/// The standard Trading API
		/// deprecation process is not applicable to this call.
		/// </summary>
		/// 
		/// <param name="ItemID">
		/// Unique identifier for the eBay item listing associated with the Selling
		/// Manager email log. Unless the <b>OrderID</b> or <b>OrderLineItemID</b> value is
		/// specified in the request, the <b>ItemID</b> and <b>TransactionID</b> fields must be
		/// used to identify the Selling Manager email log to retrieve. You can
		/// use <b>GetSellingManagerSoldListings</b> to retrieve the <b>ItemID</b>, <b>TransactionID</b>
		/// or <b>OrderLineItemID</b> values that correspond to the Selling Manager sale
		/// record (<b>SaleRecordID</b>). All four of these fields are returned under the
		/// <b>SellingManagerSoldTransaction</b> container of the
		/// <b>GetSellingManagerSoldListings</b> request.
		/// </param>
		///
		/// <param name="TransactionID">
		/// Unique identifier for the order line item (transaction) associated with
		/// the Selling Manager email log. Unless the <b>OrderID</b> or <b>OrderLineItemID</b>
		/// value is specified in the request, the <b>ItemID</b> and <b>TransactionID</b> fields
		/// must be used to identify the Selling Manager email log to retrieve.
		/// You can use <b>GetSellingManagerSoldListings</b> to retrieve the <b>ItemID</b>,
		/// <b>TransactionID</b> or <b>OrderLineItemID</b> values that correspond to the Selling
		/// Manager sale record (<b>SaleRecordID</b>). All four of these fields are
		/// returned under the <b>SellingManagerSoldTransaction</b> container of the
		/// <b>GetSellingManagerSoldListings</b> request.
		/// </param>
		///
		/// <param name="OrderID">
		/// A unique identifier that identifies a single line item or multiple line item
		/// (Combined Payment) order associated with the Selling Manager email log. 
		/// 
		/// For a single line item order, the <b>OrderID</b> value is identical to the
		/// <b>OrderLineItemID</b> value that is generated upon creation of the order line
		/// item. For a Combined Payment order, the <b>OrderID</b> value is created by eBay
		/// when the buyer or seller (sharing multiple, common order line items)
		/// combines multiple order line items into a Combined Payment order through
		/// the eBay site (or when the seller creates Combined Payment order through
		/// <b>AddOrder</b>). If an <b>OrderID</b> is used in the request, the <b>OrderLineItemID</b> and
		/// <b>ItemID</b>/<b>TransactionID</b> pair are not required.
		/// </param>
		///
		/// <param name="EmailDateRange">
		/// Specifies the earliest (oldest) and latest (most recent) dates to use in a
		/// date range filter based on email sent date. Each of the time ranges can be
		/// up to 90 days.
		/// </param>
		///
		/// <param name="OrderLineItemID">
		/// A unique identifier for an eBay order line item that is associated with
		/// the Selling Manager email log. This field is created as soon as there
		/// is a commitment to buy from the seller, and its value is based upon the
		/// concatenation of <b>ItemID</b> and <b>TransactionID</b>, with a hyphen in between
		/// these two IDs. You can use <b>GetSellingManagerSoldListings</b> to retrieve the
		/// <b>ItemID</b>, <b>TransactionID</b> or <b>OrderLineItemID</b> values that correspond to the
		/// Selling Manager sale record (<b>SaleRecordID</b>). All four of these fields are
		/// returned under the <b>SellingManagerSoldTransaction</b> container of the
		/// <b>GetSellingManagerSoldListings</b> request. Unless an <b>OrderID</b> or an
		/// <b>ItemID</b>/<b>TransactionID</b> pair is specified in the <b>GetSellingManagerSaleRecord</b>
		/// request, the <b>OrderLineItemID</b> is required. 
		/// 
		/// </param>
		///
		public SellingManagerEmailLogTypeCollection GetSellingManagerEmailLog(string ItemID, long TransactionID, string OrderID, TimeRangeType EmailDateRange, string OrderLineItemID)
		{
			this.ItemID = ItemID;
			this.TransactionID = TransactionID;
			this.OrderID = OrderID;
			this.EmailDateRange = EmailDateRange;
			this.OrderLineItemID = OrderLineItemID;

			Execute();
			return ApiResponse.EmailLog;
		}



		#endregion




		#region Properties
		/// <summary>
		/// The base interface object.
		/// </summary>
		/// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
		public ApiCall ApiCallBase
		{
			get { return this; }
		}

		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType"/> for this API call.
		/// </summary>
		public GetSellingManagerEmailLogRequestType ApiRequest
		{ 
			get { return (GetSellingManagerEmailLogRequestType) AbstractRequest; }
			set { AbstractRequest = value; }
		}

		/// <summary>
		/// Gets the <see cref="GetSellingManagerEmailLogResponseType"/> for this API call.
		/// </summary>
		public GetSellingManagerEmailLogResponseType ApiResponse
		{ 
			get { return (GetSellingManagerEmailLogResponseType) AbstractResponse; }
		}

		
 		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType.ItemID"/> of type <see cref="string"/>.
		/// </summary>
		public string ItemID
		{ 
			get { return ApiRequest.ItemID; }
			set { ApiRequest.ItemID = value; }
		}
		
 		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType.TransactionID"/> of type <see cref="long"/>.
		/// </summary>
		public long TransactionID
		{ 
			get { return ApiRequest.TransactionID; }
			set { ApiRequest.TransactionID = value; }
		}
		
 		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType.OrderID"/> of type <see cref="string"/>.
		/// </summary>
		public string OrderID
		{ 
			get { return ApiRequest.OrderID; }
			set { ApiRequest.OrderID = value; }
		}
		
 		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType.EmailDateRange"/> of type <see cref="TimeRangeType"/>.
		/// </summary>
		public TimeRangeType EmailDateRange
		{ 
			get { return ApiRequest.EmailDateRange; }
			set { ApiRequest.EmailDateRange = value; }
		}
		
 		/// <summary>
		/// Gets or sets the <see cref="GetSellingManagerEmailLogRequestType.OrderLineItemID"/> of type <see cref="string"/>.
		/// </summary>
		public string OrderLineItemID
		{ 
			get { return ApiRequest.OrderLineItemID; }
			set { ApiRequest.OrderLineItemID = value; }
		}
		
		
 		/// <summary>
		/// Gets the returned <see cref="GetSellingManagerEmailLogResponseType.EmailLog"/> of type <see cref="SellingManagerEmailLogTypeCollection"/>.
		/// </summary>
		public SellingManagerEmailLogTypeCollection EmailLogList
		{ 
			get { return ApiResponse.EmailLog; }
		}
		

		#endregion

		
	}
}
