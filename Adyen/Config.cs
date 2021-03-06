#region Licence
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2019 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using Environment = Adyen.Model.Enum.Environment;

namespace Adyen
{
    public class Config
    {
        //Merchant details
        public string Username { get; set; }
        public string Password { get; set; }
        public string MerchantAccount { get; set; }
        public Environment Environment { get; set; }
        public string Endpoint { get; set; }
        public string ApplicationName { get; set; }
        public int HttpRequestTimeout { get; set; }
        //HPP specific
        public string HppEndpoint { get; set; }
        public string SkinCode{ get; set; }
        public string HmacKey { get; set; }
        public string CheckoutEndpoint { get;set; }

        //Terminal cloud api
        public string XApiKey { get; set; }
        public string CloudApiEndPoint { get; set; }
        [Obsolete("This is deprecated property by Adyen.")]
        public bool SkipCertValidation { get; set; } = false;

    }
}