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
using System.Xml;
using System.IO;
using NUnit.Framework;
using eBay.Service.Call;
using eBay.Service.Core.Soap;
using eBay.Service.Core.Sdk;
using eBay.Service.Util;
#endregion
namespace AllTestsSuite.T_120_SellingManagerTestsSuite
{
	/// <summary>
	/// Summary description for T_050_SetSellingManagerTemplateAutomationRule.
	/// </summary>
	[TestFixture]
	public class T_050_SetSellingManagerTemplateAutomationRule : SOAPTestBase
	{
		[Test]
		public void SetSellingManagerTemplateAutomationRule()
		{
			Assert.IsTrue(TestData.SaleTemplateId!=long.MinValue);
			SetSellingManagerTemplateAutomationRuleCall api = new SetSellingManagerTemplateAutomationRuleCall(apiContext);
			SellingManagerAutoRelistType automatedRelistingRule = new SellingManagerAutoRelistType();
			automatedRelistingRule.Type=SellingManagerAutoRelistTypeCodeType.RelistOnceIfNotSold;
			automatedRelistingRule.RelistCondition=SellingManagerAutoRelistOptionCodeType.RelistImmediately;
			api.AutomatedRelistingRule=automatedRelistingRule;
			api.SaleTemplateID=TestData.SaleTemplateId;
			api.Execute();
			//check whether the call is success.
			Assert.IsTrue(api.ApiResponse.Ack==AckCodeType.Success || api.ApiResponse.Ack==AckCodeType.Warning,"do not success!");
		}
	}
}
